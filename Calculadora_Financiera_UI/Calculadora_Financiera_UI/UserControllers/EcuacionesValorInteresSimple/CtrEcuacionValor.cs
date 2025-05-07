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
        public CtrEcuacionValor()
        {
            InitializeComponent();
            InicializarDataGrid();
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
        private double ValorEnFechaFocal(double monto, DateTime fecha, DateTime fechaFocal, double tasa)
        {
            // Cálculo correcto de tiempo en años (positivo = pasado, negativo = futuro)
            double t = (fecha - fechaFocal).TotalDays / 365.0;

            // Si t es positivo (fecha es posterior a fecha focal), dividimos
            // Si t es negativo (fecha es anterior a fecha focal), multiplicamos
            if (t > 0)
                return monto / (1 + tasa * t); // Traer valor futuro al presente
            else
                return monto * (1 + tasa * Math.Abs(t)); // Llevar valor presente al futuro
        }
        private void CalcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaFocal = dateTimePickerFechaFocal.Value;
                double tasa = double.Parse(textBoxTasa.Text) / 100.0; // Convertir % a decimal

                // Para diagnosticar: mostrar la fecha focal y la tasa
                MessageBox.Show($"Fecha focal: {fechaFocal.ToShortDateString()}, Tasa: {tasa:P2}", "Parámetros");

                double sumaIngresosNumericos = 0;
                double sumaEgresosNumericos = 0;
                string expresionIngresos = "";
                string expresionEgresos = "";

                // Cuerpo de la función
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                        continue;  // Ignorar filas incompletas

                    string montoStr = row.Cells[0].Value.ToString();
                    string fechaStr = row.Cells[1].Value.ToString();
                    string tipo = row.Cells[2].Value.ToString();

                    // Procesar la fecha (manejar formatos relativos)
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

                    // Calcular tiempo en años (positivo = pasado, negativo = futuro)
                    double t = (fecha - fechaFocal).TotalDays / 365.0;
                    double factor;

                    // Factor correcto para interés simple
                    if (t > 0)
                        factor = 1 / (1 + tasa * t); // Traer valor futuro al presente
                    else
                        factor = (1 + tasa * Math.Abs(t)); // Llevar valor presente al futuro

                    // Procesar el monto
                    if (montoStr.Contains("X", StringComparison.OrdinalIgnoreCase))
                    {
                        // Preparar la expresión algebraica
                        // Asegurarse que X/3 se interpreta correctamente
                        montoStr = montoStr.Replace("X/", "(X)/");
                        string expr = $"({montoStr}) * {factor.ToString("F6", CultureInfo.InvariantCulture)}";

                        if (tipo == "Ingreso")
                            expresionIngresos += "+" + expr;
                        else
                            expresionEgresos += "+" + expr;
                    }
                    else
                    {
                        // Valor numérico conocido
                        double monto = double.Parse(montoStr);
                        double valorEnFocal = monto * factor;

                        if (tipo == "Ingreso")
                            sumaIngresosNumericos += valorEnFocal;
                        else
                            sumaEgresosNumericos += valorEnFocal;
                    }
                }

                // Construir la ecuación de valor
                string ecuacion;

                // Si expresiones comienzan con "+", quitar el primer "+"
                if (expresionIngresos.StartsWith("+"))
                    expresionIngresos = expresionIngresos.Substring(1);

                if (expresionEgresos.StartsWith("+"))
                    expresionEgresos = expresionEgresos.Substring(1);

                // Construir cada lado de la ecuación
                string izquierda = sumaIngresosNumericos.ToString("F6", CultureInfo.InvariantCulture);
                if (!string.IsNullOrEmpty(expresionIngresos))
                    izquierda += "+" + expresionIngresos;

                string derecha = sumaEgresosNumericos.ToString("F6", CultureInfo.InvariantCulture);
                if (!string.IsNullOrEmpty(expresionEgresos))
                    derecha += "+" + expresionEgresos;

                // La ecuación final
                ecuacion = $"({izquierda})-({derecha})";

                // Para diagnóstico: mostrar la ecuación
                MessageBox.Show($"Ecuación: {ecuacion}", "Ecuación generada");

                // Resolver
                double resultado = ResolverX(ecuacion);

                // Mostrar resultado
                MessageBox.Show($"El valor de X es: {resultado:F2}", "Resultado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private double ResolverX(string expresion)
        {
            // Implementación robusta del método de bisección
            Expression e = new Expression(expresion);

            // Paso 1: Buscar múltiples raíces en rangos razonables
            List<double> posiblesRaices = new List<double>();

            // Buscar en varios rangos con distintas precisiones
            double[] rangos = { 500, 1000, 2000, 5000, 10000 };

            foreach (double rango in rangos)
            {
                double min = -rango;
                double max = rango;
                double paso = rango / 200; // 200 puntos por rango

                double valorAnterior = double.MaxValue;

                for (double x = min; x <= max; x += paso)
                {
                    e.Parameters["X"] = x;
                    double resultado;

                    try
                    {
                        resultado = Convert.ToDouble(e.Evaluate());
                    }
                    catch
                    {
                        continue; // Ignorar errores de evaluación
                    }

                    // Detectar cambio de signo (posible raíz)
                    if (valorAnterior != double.MaxValue &&
                        ((resultado > 0 && valorAnterior < 0) || (resultado < 0 && valorAnterior > 0)))
                    {
                        // Refinar con bisección
                        double raiz = EncontrarRaizBiseccion(e, x - paso, x, 0.00001);
                        if (!double.IsNaN(raiz))
                            posiblesRaices.Add(raiz);
                    }

                    valorAnterior = resultado;
                }
            }

            // Si encontramos raíces, retornar
            if (posiblesRaices.Count > 0)
            {
                // Si hay múltiples raíces, mostrar todas
                if (posiblesRaices.Count > 1)
                {
                    string mensaje = "Se encontraron múltiples posibles valores para X:\n";
                    foreach (double raiz in posiblesRaices)
                    {
                        mensaje += $"X = {raiz:F2}\n";
                    }
                    mensaje += "\nSe utilizará el primer valor encontrado.";
                    MessageBox.Show(mensaje, "Múltiples soluciones");
                }

                return posiblesRaices[0];
            }

            throw new Exception("No se encontró una solución para X. Verifica los datos ingresados y la fecha focal.");


        }
        private double EncontrarRaizBiseccion(Expression e, double min, double max, double epsilon)
        {
            // Método de bisección estándar
            int maxIteraciones = 1000;
            int iteracion = 0;

            e.Parameters["X"] = min;
            double valorMin = Convert.ToDouble(e.Evaluate());

            e.Parameters["X"] = max;
            double valorMax = Convert.ToDouble(e.Evaluate());

            // Verificar que hay un cambio de signo
            if (valorMin * valorMax >= 0)
                return double.NaN; // No hay raíz en este intervalo

            double medio = 0;

            while ((max - min) > epsilon && iteracion < maxIteraciones)
            {
                medio = (min + max) / 2;

                e.Parameters["X"] = medio;
                double valorMedio = Convert.ToDouble(e.Evaluate());

                if (Math.Abs(valorMedio) < epsilon)
                    return medio; // Encontramos la solución

                e.Parameters["X"] = min;
                valorMin = Convert.ToDouble(e.Evaluate());

                if (valorMin * valorMedio < 0)
                    max = medio;
                else
                    min = medio;

                iteracion++;
            }

            return (min + max) / 2; // Aproximación final
        }

        private void calcularTasaButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaFocal = dateTimePickerFechaFocal.Value;

                // Listas para almacenar los flujos de efectivo
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

                // Calcular la tasa
                double tasa = EncontrarTasaInteresSimple(flujos, fechaFocal);

                // Mostrar el resultado
                MessageBox.Show($"La tasa de interés simple es: {tasa:P2}", "Resultado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private double EncontrarTasaInteresSimple(List<FlujoCaja> flujos, DateTime fechaFocal)
        {
            // Método para encontrar la tasa que equilibra la ecuación de valor
            // Usando el método de bisección con verificación de múltiples soluciones

            double minTasa = -0.99; // Límite inferior (-99%)
            double maxTasa = 10.0;  // Límite superior (1000%)
            double precision = 0.0001; // Precisión del 0.01%
            int maxIteraciones = 1000;

            // Verificar si hay solución en este rango
            double valorMin = CalcularValorPresente(flujos, fechaFocal, minTasa);
            double valorMax = CalcularValorPresente(flujos, fechaFocal, maxTasa);

            // Si ambos valores tienen el mismo signo, puede no haber raíz en este intervalo
            if (valorMin * valorMax > 0)
            {
                throw new Exception($"No se encontró una solución para la tasa en el rango [{minTasa:P0}, {maxTasa:P0}].");
            }

            // Método de bisección
            int iteracion = 0;
            double tasaMedio = 0;

            // Lista para almacenar posibles soluciones
            List<double> posiblesTasas = new List<double>();

            // Primera aproximación con bisección estándar
            while ((maxTasa - minTasa) > precision && iteracion < maxIteraciones)
            {
                tasaMedio = (minTasa + maxTasa) / 2;
                double valorMedio = CalcularValorPresente(flujos, fechaFocal, tasaMedio);

                if (Math.Abs(valorMedio) < 0.01) // Encontramos una solución aceptable
                {
                    posiblesTasas.Add(tasaMedio);
                    break;
                }

                double valorMin2 = CalcularValorPresente(flujos, fechaFocal, minTasa);

                // Determinar en qué mitad está la raíz
                if (valorMin2 * valorMedio < 0)
                    maxTasa = tasaMedio;
                else
                    minTasa = tasaMedio;

                iteracion++;
            }

            // Si no encontramos solución con bisección estándar, buscar más exhaustivamente
            if (posiblesTasas.Count == 0)
            {
                // Resetear los límites para una búsqueda más amplia
                minTasa = -0.99;
                maxTasa = 10.0;

                // Dividir en más segmentos
                int numSegmentos = 1000;
                double paso = (maxTasa - minTasa) / numSegmentos;

                double tasaAnterior = minTasa;
                double valorAnterior = CalcularValorPresente(flujos, fechaFocal, tasaAnterior);

                for (int i = 1; i <= numSegmentos; i++)
                {
                    double tasaActual = minTasa + i * paso;
                    double valorActual = CalcularValorPresente(flujos, fechaFocal, tasaActual);

                    // Detectar cambio de signo (posible raíz)
                    if (valorAnterior * valorActual <= 0)
                    {
                        // Refinar con bisección en este intervalo pequeño
                        double tasaRefinada = EncontrarTasaBiseccion(flujos, fechaFocal, tasaAnterior, tasaActual, precision);
                        if (tasaRefinada != double.NaN)
                            posiblesTasas.Add(tasaRefinada);
                    }

                    tasaAnterior = tasaActual;
                    valorAnterior = valorActual;
                }
            }

            // Verificar resultados
            if (posiblesTasas.Count == 0)
            {
                // Si no encontramos solución, devolver la mejor aproximación
                double mejorTasa = (minTasa + maxTasa) / 2;
                double valorFinal = CalcularValorPresente(flujos, fechaFocal, mejorTasa);

                string mensaje = $"No se encontró una solución exacta. La mejor aproximación es: {mejorTasa:P2}\n";
                mensaje += $"Con un valor presente neto de: {valorFinal:F2}";
                MessageBox.Show(mensaje, "Aproximación");

                return mejorTasa;
            }
            else if (posiblesTasas.Count > 1)
            {
                // Si hay múltiples soluciones, mostrar todas y devolver la primera
                string mensaje = "Se encontraron múltiples tasas de interés posibles:\n";
                foreach (double tasa in posiblesTasas)
                {
                    mensaje += $"Tasa = {tasa:P2}\n";
                }
                mensaje += "\nSe utilizará la primera tasa encontrada.";
                MessageBox.Show(mensaje, "Múltiples soluciones");

                return posiblesTasas[0];
            }

            return posiblesTasas[0];
        }
        private double EncontrarTasaBiseccion(List<FlujoCaja> flujos, DateTime fechaFocal,
                                           double minTasa, double maxTasa, double precision)
        {
            int maxIteraciones = 100;
            int iteracion = 0;

            double valorMin = CalcularValorPresente(flujos, fechaFocal, minTasa);
            double valorMax = CalcularValorPresente(flujos, fechaFocal, maxTasa);

            // Verificar que hay un cambio de signo
            if (valorMin * valorMax >= 0)
                return double.NaN;

            double tasaMedio = 0;

            while ((maxTasa - minTasa) > precision && iteracion < maxIteraciones)
            {
                tasaMedio = (minTasa + maxTasa) / 2;
                double valorMedio = CalcularValorPresente(flujos, fechaFocal, tasaMedio);

                if (Math.Abs(valorMedio) < 0.001) // Solución aceptable
                    return tasaMedio;

                valorMin = CalcularValorPresente(flujos, fechaFocal, minTasa);

                if (valorMin * valorMedio < 0)
                    maxTasa = tasaMedio;
                else
                    minTasa = tasaMedio;

                iteracion++;
            }

            return (minTasa + maxTasa) / 2;
        }
        private double CalcularValorPresente(List<FlujoCaja> flujos, DateTime fechaFocal, double tasa)
        {
            double sumaValorPresente = 0;

            foreach (var flujo in flujos)
            {
                // Calcular el tiempo en años (positivo = futuro, negativo = pasado)
                double t = (flujo.Fecha - fechaFocal).TotalDays / 365.0;

                if (t == 0) // Si el flujo está en la fecha focal
                {
                    sumaValorPresente += flujo.Monto;
                }
                else if (t > 0) // Flujo posterior a la fecha focal
                {
                    // Traer valor futuro al presente (fecha focal)
                    sumaValorPresente += flujo.Monto / (1 + tasa * t);
                }
                else // Flujo anterior a la fecha focal
                {
                    // Llevar valor pasado al presente (fecha focal)
                    sumaValorPresente += flujo.Monto * (1 + tasa * Math.Abs(t));
                }
            }

            return sumaValorPresente;
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
}
    


