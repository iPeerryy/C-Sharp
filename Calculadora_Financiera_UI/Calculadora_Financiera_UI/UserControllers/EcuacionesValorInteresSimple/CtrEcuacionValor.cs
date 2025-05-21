using NCalc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financiera_UI.UserControllers.EcuacionesValorInteresSimple
{
    public partial class CtrEcuacionValor : UserControl
    {
        public enum MetodoInteres
        {
            IoTe, // Interés ordinario, tiempo exacto (365 días)
            IoTa, // Interés ordinario, tiempo aproximado (meses/12)
            IeTe, // Interés exacto (360 días), tiempo exacto (días/360)
            IeTa  // Interés exacto (360 días), tiempo aproximado (meses/12)
        }

        // Propiedad para almacenar el método seleccionado
        private MetodoInteres metodoSeleccionado = MetodoInteres.IoTe;

        // Agregar la declaración del ComboBox
        private ComboBox comboMetodo;

        public CtrEcuacionValor()
        {
            InitializeComponent();
            InicializarDataGrid();
            InicializarComboBoxMetodo();

            if (Controls.Find("dtpFechaFocal", true).Length > 0)
            {
                Control fechaFocal = Controls.Find("dtpFechaFocal", true)[0];
                fechaFocal.Visible = false;

                // También ocultar la etiqueta asociada si existe
                foreach (Control c in Controls)
                {
                    if (c is Label && ((Label)c).Text.Contains("Fecha Focal"))
                    {
                        c.Visible = false;
                        break;
                    }
                }
            }
        }
        private void InicializarComboBoxMetodo()
        {
            // Verifica que el combo no sea null
            if (comboMetodoInteres == null)
                return;

            // Desconecta temporalmente el evento para evitar errores mientras se llena
            comboMetodoInteres.SelectedIndexChanged -= ComboMetodoInteres_SelectedIndexChanged;

            // Limpiar items anteriores
            comboMetodoInteres.Items.Clear();

            // Agregar opciones
            comboMetodoInteres.Items.Add("Io Te – Interés ordinario, tiempo exacto");
            comboMetodoInteres.Items.Add("Io Ta – Interés ordinario, tiempo aproximado");
            comboMetodoInteres.Items.Add("Ie Te – Interés exacto, tiempo exacto");
            comboMetodoInteres.Items.Add("Ie Ta – Interés exacto, tiempo aproximado");

            // Asignar índice solo si hay elementos
            if (comboMetodoInteres.Items.Count > 0)
                comboMetodoInteres.SelectedIndex = 0;

            // Reconectar el evento
            comboMetodoInteres.SelectedIndexChanged += ComboMetodoInteres_SelectedIndexChanged;
        }
        // Evento para cambiar el método seleccionado
        private void ComboMetodoInteres_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.SelectedIndex >= 0 && combo.SelectedIndex < Enum.GetNames(typeof(MetodoInteres)).Length)
            {
                metodoSeleccionado = (MetodoInteres)combo.SelectedIndex;
            }
        }

        private void InicializarDataGrid()
        {
            dataGridView1.Columns.Add("Monto", "Monto");
            dataGridView1.Columns.Add("Fecha", "Fecha");
            var combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Tipo";
            combo.Items.Add("Ingreso");
            combo.Items.Add("Egreso");
            dataGridView1.Columns.Add(combo);
        }

        // Método para calcular el valor en fecha focal con interés simple
        private void CalcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaFocal = dateTimePickerFechaFocal.Value;
                double tasa = double.Parse(textBoxTasa.Text) / 100.0; // Convertir % a decimal

                // Capturar el método seleccionado actual en una variable local para asegurar consistencia
                MetodoInteres metodoActual = metodoSeleccionado;

                // Remover o comentar mensajes de depuración excesivos
                // MessageBox.Show($"Fecha focal: {fechaFocal.ToShortDateString()}, Tasa: {tasa:P2}\nMétodo: {metodoActual}", "Parámetros");

                // Organizar los flujos de caja para la ecuación de valor
                List<FlujoCaja2> flujos = new List<FlujoCaja2>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                        continue;  // Ignorar filas incompletas

                    string montoStr = row.Cells[0].Value.ToString();
                    string fechaStr = row.Cells[1].Value.ToString();
                    string tipo = row.Cells[2].Value.ToString();

                    // Procesar la fecha
                    DateTime fecha;
                    if (fechaStr.ToLower() == "hoy")
                        fecha = DateTime.Today;
                    else if (fechaStr.Contains("+"))
                    {
                        string[] partes = fechaStr.Split('+');
                        int meses = int.Parse(partes[1].Split(' ')[0]);
                        fecha = DateTime.Today.AddMonths(meses);
                    }
                    else
                        fecha = Convert.ToDateTime(fechaStr);

                    // Calcular tiempo según el método seleccionado - usar la variable local metodoActual
                    double t = CalcularTiempo(fecha, fechaFocal, metodoActual);

                    // Determinar el signo del flujo (+ingreso, -egreso)
                    int signo = (tipo == "Ingreso") ? 1 : -1;

                    // Crear objeto FlujoCaja y agregarlo a la lista - usar la variable local metodoActual
                    flujos.Add(new FlujoCaja2(montoStr, t, signo, tasa, metodoActual));
                }

                // Resolver la ecuación de valor
                double resultado = EncontrarValorX(flujos);

                // Mostrar resultado
                MessageBox.Show($"El valor de X es: {resultado:F2}", "Resultado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double CalcularTiempo(DateTime fecha, DateTime fechaFocal, MetodoInteres metodo)
        {
            double tiempo = 0;
            TimeSpan diferencia = fecha - fechaFocal;

            // Quitar o comentar el mensaje de depuración
            // MessageBox.Show($"Calculando tiempo con método: {metodo}\nFecha: {fecha.ToShortDateString()}\nFecha Focal: {fechaFocal.ToShortDateString()}", "Cálculo de Tiempo");

            switch (metodo)
            {
                case MetodoInteres.IoTe:
                    // Interés ordinario (365 días), tiempo exacto (días/365)
                    tiempo = diferencia.TotalDays / 365.0;
                    break;
                case MetodoInteres.IoTa:
                    // Interés ordinario (365 días), tiempo aproximado (meses/12)
                    int mesesIoTa = ((fecha.Year - fechaFocal.Year) * 12) + (fecha.Month - fechaFocal.Month);
                    // Si el día del mes en la fecha es mayor que en la fecha focal, añadir una fracción
                    if (fecha.Day > fechaFocal.Day)
                    {
                        // Calcular días exactos del mes final
                        int diasEnMes = DateTime.DaysInMonth(fecha.Year, fecha.Month);
                        tiempo = mesesIoTa / 12.0 + ((double)(fecha.Day - fechaFocal.Day) / (diasEnMes * 12.0));
                    }
                    else if (fecha.Day < fechaFocal.Day)
                    {
                        // Restar una fracción si hay menos días
                        int diasEnMes = DateTime.DaysInMonth(fechaFocal.Year, fechaFocal.Month);
                        tiempo = mesesIoTa / 12.0 - ((double)(fechaFocal.Day - fecha.Day) / (diasEnMes * 12.0));
                    }
                    else
                    {
                        tiempo = mesesIoTa / 12.0;
                    }
                    break;
                case MetodoInteres.IeTe:
                    // Interés exacto (360 días), tiempo exacto (días/360)
                    tiempo = diferencia.TotalDays / 360.0;
                    break;
                case MetodoInteres.IeTa:
                    // Interés exacto (360 días), tiempo aproximado (meses/12)
                    int mesesIeTa = ((fecha.Year - fechaFocal.Year) * 12) + (fecha.Month - fechaFocal.Month);
                    // El mismo ajuste para los días que en IoTa
                    if (fecha.Day > fechaFocal.Day)
                    {
                        int diasEnMes = 30; // En interés exacto, cada mes tiene 30 días
                        tiempo = mesesIeTa / 12.0 + ((double)(fecha.Day - fechaFocal.Day) / (diasEnMes * 12.0));
                    }
                    else if (fecha.Day < fechaFocal.Day)
                    {
                        int diasEnMes = 30; // En interés exacto, cada mes tiene 30 días
                        tiempo = mesesIeTa / 12.0 - ((double)(fechaFocal.Day - fecha.Day) / (diasEnMes * 12.0));
                    }
                    else
                    {
                        tiempo = mesesIeTa / 12.0;
                    }
                    break;
            }

            // Quitar o comentar el mensaje de depuración
            // MessageBox.Show($"Tiempo calculado: {tiempo}", "Resultado Tiempo");
            return tiempo;
        }

        public class FlujoCaja2
        {
            public string MontoExpresion { get; private set; }
            public double Tiempo { get; private set; }
            public int Signo { get; private set; }
            public double Tasa { get; private set; }
            public bool ContieneIncognita { get; private set; }
            public double ValorNumerico { get; private set; }
            public MetodoInteres Metodo { get; private set; }

            public FlujoCaja2(string monto, double tiempo, int signo, double tasa, MetodoInteres metodo)
            {
                MontoExpresion = monto;
                Tiempo = tiempo;
                Signo = signo;
                Tasa = tasa;
                Metodo = metodo;

                // Determinar si el flujo contiene la incógnita X
                ContieneIncognita = monto.Contains("X", StringComparison.OrdinalIgnoreCase);

                if (!ContieneIncognita)
                {
                    ValorNumerico = double.Parse(monto);
                }
            }

            public double ValorEquivalente(double valorX)
            {
                double factor;
                double monto;

                // Calcular el monto según la expresión
                if (ContieneIncognita)
                {
                    // Evaluar la expresión con X 
                    string expresion = MontoExpresion.Replace("X", valorX.ToString(CultureInfo.InvariantCulture));

                    // Usando System.Data.DataTable para evaluar expresiones
                    DataTable dt = new DataTable();
                    var resultado = dt.Compute(expresion, "");
                    monto = Convert.ToDouble(resultado);
                }
                else
                {
                    monto = ValorNumerico;
                }

                // Quitar o comentar el mensaje de depuración
                // MessageBox.Show($"Calculando factor para método: {Metodo}\nTiempo: {Tiempo}\nTasa: {Tasa}", "Cálculo de Factor");

                // Aplicar el método de interés seleccionado para el cálculo del factor
                switch (Metodo)
                {
                    case MetodoInteres.IoTe: // Interés ordinario (365 días), tiempo exacto (días/365)
                        if (Tiempo > 0)
                            factor = 1 / (1 + Tasa * Tiempo); // Traer valor futuro al presente
                        else
                            factor = (1 + Tasa * Math.Abs(Tiempo)); // Llevar valor presente al futuro
                        break;

                    case MetodoInteres.IoTa: // Interés ordinario (365 días), tiempo aproximado (meses/12)
                        if (Tiempo > 0)
                            factor = 1 / (1 + Tasa * Tiempo); // Traer valor futuro al presente
                        else
                            factor = (1 + Tasa * Math.Abs(Tiempo)); // Llevar valor presente al futuro
                        break;

                    case MetodoInteres.IeTe: // Interés exacto (360 días), tiempo exacto (días/360)
                        // Ajustar tasa para año comercial
                        double tasaIeTe = Tasa * 365.0 / 360.0;
                        if (Tiempo > 0)
                            factor = 1 / (1 + tasaIeTe * Tiempo); // Traer valor futuro al presente
                        else
                            factor = (1 + tasaIeTe * Math.Abs(Tiempo)); // Llevar valor presente al futuro
                        break;

                    case MetodoInteres.IeTa: // Interés exacto (360 días), tiempo aproximado (meses/12)
                        // Ajustar tasa para año comercial
                        double tasaIeTa = Tasa * 365.0 / 360.0;
                        if (Tiempo > 0)
                            factor = 1 / (1 + tasaIeTa * Tiempo); // Traer valor futuro al presente
                        else
                            factor = (1 + tasaIeTa * Math.Abs(Tiempo)); // Llevar valor presente al futuro
                        break;

                    default:
                        // Por defecto, usar método IoTe
                        if (Tiempo > 0)
                            factor = 1 / (1 + Tasa * Tiempo);
                        else
                            factor = (1 + Tasa * Math.Abs(Tiempo));
                        break;
                }

                // Quitar o comentar el mensaje de depuración
                // MessageBox.Show($"Factor calculado: {factor}", "Resultado Factor");
                return Signo * monto * factor;
            }
        }

        private double EncontrarValorX(List<FlujoCaja2> flujos)
        {
            bool tieneIncognita = flujos.Any(f => f.ContieneIncognita);
            if (!tieneIncognita)
                throw new Exception("No hay valores con incógnita X para resolver.");

            // Enfoque de prueba y error con interpolación lineal
            // 1. Probar con dos valores iniciales para X
            double x1 = 1000; // Primer punto de prueba
            double x2 = 2000; // Segundo punto de prueba

            double y1 = SumarFlujos(flujos, x1);
            double y2 = SumarFlujos(flujos, x2);

            // Máximo de iteraciones para evitar bucles infinitos
            int maxIteraciones = 20;
            int i = 0;

            // Tolerancia para considerar un resultado aceptable
            double tolerancia = 0.001;

            while (i < maxIteraciones)
            {
                // Si encontramos una solución dentro de la tolerancia, la devolvemos
                if (Math.Abs(y1) < tolerancia)
                    return x1;
                if (Math.Abs(y2) < tolerancia)
                    return x2;

                // Interpolación lineal para encontrar próximo valor de X a probar
                // Fórmula de Schaum: x3 = x1 - y1 * (x2 - x1) / (y2 - y1)
                if (Math.Abs(y2 - y1) < 0.000001) // Evitar división por cero
                    throw new Exception("No se pudo encontrar convergencia. Intente con otros valores iniciales.");

                double x3 = x1 - y1 * (x2 - x1) / (y2 - y1);
                double y3 = SumarFlujos(flujos, x3);

                // Para diagnóstico
                System.Diagnostics.Debug.WriteLine($"Iteración {i}: x3={x3}, y3={y3}");

                // Si el resultado está dentro de la tolerancia, lo devolvemos
                if (Math.Abs(y3) < tolerancia)
                    return x3;

                // Preparar próxima iteración, usando los dos valores que den resultados con signos opuestos
                if (y1 * y3 < 0)
                {
                    x2 = x3;
                    y2 = y3;
                }
                else
                {
                    x1 = x3;
                    y1 = y3;
                }

                i++;
            }

            // Si no hubo convergencia, intentar con método de bisección como respaldo
            return EncontrarRaizBiseccion(flujos, Math.Min(x1, x2), Math.Max(x1, x2), tolerancia);
        }

        private double SumarFlujos(List<FlujoCaja2> flujos, double valorX)
        {
            double suma = 0;
            foreach (var flujo in flujos)
            {
                suma += flujo.ValorEquivalente(valorX);
            }
            return suma;
        }

        private double EncontrarRaizBiseccion(List<FlujoCaja2> flujos, double min, double max, double epsilon)
        {
            int maxIteraciones = 50;
            int iteracion = 0;

            double valorMin = SumarFlujos(flujos, min);
            double valorMax = SumarFlujos(flujos, max);

            // Verificar que hay un cambio de signo
            if (valorMin * valorMax >= 0)
            {
                // Expandir el intervalo de búsqueda si no hay cambio de signo
                double nuevoMin = min - (max - min) * 2;
                double nuevoMax = max + (max - min) * 2;
                return EncontrarRaizBiseccion(flujos, nuevoMin, nuevoMax, epsilon);
            }

            double medio = 0;
            double valorMedio = 0;

            while ((max - min) > epsilon && iteracion < maxIteraciones)
            {
                medio = (min + max) / 2;
                valorMedio = SumarFlujos(flujos, medio);

                if (Math.Abs(valorMedio) < epsilon)
                    return medio; // Solución encontrada

                valorMin = SumarFlujos(flujos, min);

                if (valorMin * valorMedio < 0)
                    max = medio;
                else
                    min = medio;

                iteracion++;
            }

            return medio; // Aproximación final
        }

        private void calcularTasaButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Lista para almacenar los flujos de efectivo
                List<FlujoCaja> flujos = new List<FlujoCaja>();

                // Recopilar todos los flujos de efectivo
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                        continue;  // Ignorar filas incompletas

                    // Procesar el monto
                    string montoStr = row.Cells[0].Value.ToString();
                    double monto;
                    if (!double.TryParse(montoStr, out monto))
                    {
                        throw new Exception($"El monto '{montoStr}' no es válido. Para calcular la tasa, todos los valores deben ser numéricos.");
                    }

                    // Procesar la fecha
                    string fechaStr = row.Cells[1].Value.ToString();
                    DateTime fecha;

                    if (fechaStr.ToLower() == "hoy")
                        fecha = DateTime.Today;
                    else if (fechaStr.Contains("+"))
                    {
                        string[] partes = fechaStr.Split('+');
                        int meses = int.Parse(partes[1].Split(' ')[0]);
                        fecha = DateTime.Today.AddMonths(meses);
                    }
                    else
                        fecha = Convert.ToDateTime(fechaStr);

                    // Procesar el tipo (ingreso o egreso)
                    string tipo = row.Cells[2].Value.ToString();
                    double signo = (tipo == "Ingreso") ? 1 : -1;

                    // Añadir a la lista de flujos
                    flujos.Add(new FlujoCaja(monto * signo, fecha));
                }

                // Verificar que tenemos suficientes flujos
                if (flujos.Count < 2)
                {
                    throw new Exception("Se necesitan al menos dos flujos de efectivo para calcular la tasa.");
                }

                // Obtener la fecha focal (último movimiento)
                DateTime fechaFocal = flujos.Max(f => f.Fecha);

                // Calcular la tasa según el método de la serie Schaum
                double tasa = CalcularTasaInteresSimplesSchaum(flujos, fechaFocal);

                // Mostrar el resultado
                MessageBox.Show($"La tasa de interés simple es: {tasa:P2}\n" +
                               $"Fecha focal utilizada: {fechaFocal.ToShortDateString()} (fecha del último movimiento)",
                               "Resultado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double CalcularTasaInteresSimplesSchaum(List<FlujoCaja> flujos, DateTime fechaFocal)
        {
            // Implementación según metodología de la Serie Schaum (Frank Ayres)
            // Con fecha focal siempre en el último movimiento

            // Paso 1: Calcular los coeficientes de la ecuación de valor
            double sumaMontos = 0;                         // Término independiente
            double sumaMontosMultiplicadosPorTiempo = 0;   // Coeficiente de i

            foreach (var flujo in flujos)
            {
                // Tiempo en años desde la fecha del flujo hasta la fecha focal
                double t = (fechaFocal - flujo.Fecha).TotalDays / 365.0;

                if (t == 0)
                {
                    // El flujo está en la fecha focal
                    sumaMontos += flujo.Monto;
                }
                else
                {
                    // Flujo anterior a la fecha focal
                    sumaMontos += flujo.Monto;
                    sumaMontosMultiplicadosPorTiempo += flujo.Monto * t;
                }
            }

            // Paso 2: Resolver la ecuación de valor para la tasa
            // La ecuación es: sumaMontos + sumaMontosMultiplicadosPorTiempo * i = 0

            // Si no hay término con la variable i, no se puede calcular la tasa
            if (Math.Abs(sumaMontosMultiplicadosPorTiempo) < 0.000001)
            {
                if (Math.Abs(sumaMontos) < 0.000001)
                    throw new Exception("Todos los flujos suman cero. No se puede determinar una tasa única.");
                else
                    throw new Exception("No es posible calcular la tasa. Los flujos no generan interés en el tiempo.");
            }

            // Despejamos i: i = -sumaMontos / sumaMontosMultiplicadosPorTiempo
            double tasa = -sumaMontos / sumaMontosMultiplicadosPorTiempo;

            // Verificar que la tasa tenga sentido financiero
            if (tasa < -0.99)
            {
                throw new Exception("La tasa calculada es menor que -99%, lo que no tiene sentido financiero.");
            }

            return tasa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaFocal = dateTimePickerFechaFocal.Value;
                double tasa = double.Parse(textBoxTasa.Text) / 100.0; // Convertir % a decimal
                MetodoInteres metodoActual = metodoSeleccionado;

                // Lista para almacenar los flujos de efectivo
                List<FlujoCaja> flujos = new List<FlujoCaja>();

                // Recopilar todos los flujos de efectivo y ordenarlos cronológicamente
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                        continue;  // Ignorar filas incompletas

                    // Procesar el monto
                    string montoStr = row.Cells[0].Value.ToString();
                    double monto;
                    if (!double.TryParse(montoStr, out monto))
                    {
                        throw new Exception($"El monto '{montoStr}' no es válido. Todos los valores deben ser numéricos.");
                    }

                    // Procesar la fecha
                    string fechaStr = row.Cells[1].Value.ToString();
                    DateTime fecha;

                    if (fechaStr.ToLower() == "hoy")
                        fecha = DateTime.Today;
                    else if (fechaStr.Contains("+"))
                    {
                        string[] partes = fechaStr.Split('+');
                        int meses = int.Parse(partes[1].Split(' ')[0]);
                        fecha = DateTime.Today.AddMonths(meses);
                    }
                    else
                        fecha = Convert.ToDateTime(fechaStr);

                    // Procesar el tipo (ingreso o egreso)
                    string tipo = row.Cells[2].Value.ToString();
                    double signo = (tipo == "Ingreso") ? 1 : -1;

                    // Añadir a la lista de flujos
                    flujos.Add(new FlujoCaja(monto * signo, fecha));
                }

                // Verificar que tenemos suficientes flujos
                if (flujos.Count < 2)
                {
                    throw new Exception("Se necesitan al menos dos flujos de efectivo para aplicar la regla de saldos.");
                }

                // Ordenar los flujos cronológicamente
                flujos = flujos.OrderBy(f => f.Fecha).ToList();

                // Aplicar la regla de saldos
                StringBuilder resultado = new StringBuilder();
                resultado.AppendLine("REGLA DE SALDOS:");
                resultado.AppendLine("----------------");
                resultado.AppendLine("Fecha\t\tMonto\t\tSaldo\t\tInterés\t\tNuevo Saldo");

                double saldo = 0;
                DateTime fechaAnterior = flujos[0].Fecha;

                foreach (var flujo in flujos)
                {
                    // Calcular tiempo entre fechas según el método seleccionado
                    double tiempo = CalcularTiempo(fechaAnterior, flujo.Fecha, metodoActual);

                    // Calcular interés generado durante el período
                    double interes = saldo * tasa * Math.Abs(tiempo);

                    // Actualizar saldo con intereses
                    double nuevoSaldo = saldo + interes;

                    // Registrar el estado antes de aplicar el nuevo flujo
                    resultado.AppendLine($"{fechaAnterior.ToShortDateString()}\t{0:C2}\t\t{saldo:C2}\t{interes:C2}\t{nuevoSaldo:C2}");

                    // Aplicar el nuevo flujo
                    saldo = nuevoSaldo + flujo.Monto;

                    // Registrar el estado después de aplicar el flujo
                    resultado.AppendLine($"{flujo.Fecha.ToShortDateString()}\t{flujo.Monto:C2}\t{saldo:C2}\t{0:C2}\t{saldo:C2}");

                    // Actualizar fecha anterior para la próxima iteración
                    fechaAnterior = flujo.Fecha;
                }

                // Calcular el interés hasta la fecha focal si es posterior al último flujo
                if (fechaFocal > fechaAnterior)
                {
                    double tiempoFinal = CalcularTiempo(fechaAnterior, fechaFocal, metodoActual);
                    double interesFinal = saldo * tasa * Math.Abs(tiempoFinal);
                    double saldoFinal = saldo + interesFinal;

                    resultado.AppendLine($"{fechaFocal.ToShortDateString()}\t{0:C2}\t\t{saldo:C2}\t{interesFinal:C2}\t{saldoFinal:C2}");
                }

                // Mostrar resultado con un visor de texto más amplio
                Form resultadoForm = new Form();
                resultadoForm.Text = "Resultado - Regla de Saldos";
                resultadoForm.Size = new Size(600, 400);

                TextBox txtResultado = new TextBox();
                txtResultado.Multiline = true;
                txtResultado.ScrollBars = ScrollBars.Both;
                txtResultado.Dock = DockStyle.Fill;
                txtResultado.Font = new Font("Consolas", 10);
                txtResultado.Text = resultado.ToString();

                resultadoForm.Controls.Add(txtResultado);
                resultadoForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double tasa = double.Parse(textBoxTasa.Text) / 100.0; // Convertir % a decimal

                // Lista para almacenar los dos flujos de efectivo
                List<FlujoCaja> flujos = new List<FlujoCaja>();

                // Variables para el cálculo
                double montoInicial = 0;
                double montoFinal = 0;
                DateTime fechaInicial = DateTime.MinValue;
                DateTime fechaFinal = DateTime.MinValue;

                // Recopilar los flujos de efectivo
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                        continue;  // Ignorar filas incompletas

                    // Procesar el monto
                    string montoStr = row.Cells[0].Value.ToString();
                    double monto;
                    if (!double.TryParse(montoStr, out monto))
                    {
                        throw new Exception($"El monto '{montoStr}' no es válido. Para calcular el tiempo, todos los valores deben ser numéricos.");
                    }

                    // Procesar la fecha
                    string fechaStr = row.Cells[1].Value.ToString();
                    DateTime fecha;

                    if (fechaStr.ToLower() == "hoy")
                        fecha = DateTime.Today;
                    else if (fechaStr.Contains("+"))
                    {
                        string[] partes = fechaStr.Split('+');
                        int meses = int.Parse(partes[1].Split(' ')[0]);
                        fecha = DateTime.Today.AddMonths(meses);
                    }
                    else if (fechaStr.ToLower() == "?") // Fecha a determinar
                    {
                        // Esta es la fecha que queremos encontrar
                        fechaFinal = DateTime.MaxValue; // Valor temporal para indicar que es la incógnita
                        montoFinal = monto;
                        continue;
                    }
                    else
                        fecha = Convert.ToDateTime(fechaStr);

                    // Procesar el tipo (ingreso o egreso)
                    string tipo = row.Cells[2].Value.ToString();
                    double signo = (tipo == "Ingreso") ? 1 : -1;

                    // Añadir a la lista de flujos
                    flujos.Add(new FlujoCaja(monto * signo, fecha));

                    // Si es la fecha inicial (asumimos que la primera fecha no es la incógnita)
                    if (fechaInicial == DateTime.MinValue)
                    {
                        fechaInicial = fecha;
                        montoInicial = monto * signo;
                    }
                }

                // Verificar que tenemos al menos un flujo conocido y uno con fecha desconocida
                if (fechaInicial == DateTime.MinValue || montoFinal == 0)
                {
                    throw new Exception("Se necesita al menos un flujo con fecha conocida y otro con fecha desconocida (indicada con '?').");
                }

                // Calcular el tiempo según la fórmula de interés simple
                // F = P(1 + rt) => t = (F/P - 1)/r

                double factor = Math.Abs(montoFinal / montoInicial);
                double tiempo;

                if (montoInicial * montoFinal > 0) // Mismo signo
                {
                    tiempo = (factor - 1) / tasa;
                }
                else // Signos diferentes
                {
                    throw new Exception("Los montos tienen signos diferentes. Este caso requiere un análisis más complejo.");
                }

                // Calcular la fecha desconocida
                DateTime fechaResultado;

                switch (metodoSeleccionado)
                {
                    case MetodoInteres.IoTe: // Interés ordinario, tiempo exacto (365 días)
                        fechaResultado = fechaInicial.AddDays(tiempo * 365);
                        break;

                    case MetodoInteres.IoTa: // Interés ordinario, tiempo aproximado (meses/12)
                        int meses = (int)(tiempo * 12);
                        int diasAdicionales = (int)((tiempo * 12 - meses) * 30);
                        fechaResultado = fechaInicial.AddMonths(meses).AddDays(diasAdicionales);
                        break;

                    case MetodoInteres.IeTe: // Interés exacto, tiempo exacto (360 días)
                        fechaResultado = fechaInicial.AddDays(tiempo * 360);
                        break;

                    case MetodoInteres.IeTa: // Interés exacto, tiempo aproximado (meses/12)
                        int mesesIeTa = (int)(tiempo * 12);
                        int diasAdicionalesIeTa = (int)((tiempo * 12 - mesesIeTa) * 30);
                        fechaResultado = fechaInicial.AddMonths(mesesIeTa).AddDays(diasAdicionalesIeTa);
                        break;

                    default:
                        fechaResultado = fechaInicial.AddDays(tiempo * 365);
                        break;
                }

                // Mostrar el resultado
                MessageBox.Show($"Fecha inicial: {fechaInicial.ToShortDateString()}\n" +
                               $"Monto inicial: {montoInicial:C2}\n" +
                               $"Monto final: {montoFinal:C2}\n" +
                               $"Tiempo calculado: {tiempo:F4} años\n" +
                               $"Fecha calculada: {fechaResultado.ToShortDateString()}\n",
                               "Resultado - Cálculo de Tiempo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

// Clase auxiliar para representar un flujo de caja
public class FlujoCaja
{
    public double Monto { get; private set; }
    public DateTime Fecha { get; private set; }

    public FlujoCaja(double monto, DateTime fecha)
    {
        Monto = monto;
        Fecha = fecha;
    }
}