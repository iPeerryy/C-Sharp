using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financiera_UI.UserControllers.DecuentoPorProntoPago
{
    public partial class CtrDescuentoPorProntoPago : UserControl
    {
        private List<DescuentoComercial> listaDescuentos = new List<DescuentoComercial>();

        public CtrDescuentoPorProntoPago()
        {
            InitializeComponent();
            InicializarDataGridDescuentos();
        }

        private void InicializarDataGridDescuentos()
        {
            // Configurar las columnas del DataGridView para descuentos
            dataGridDescuentos.Columns.Add("Descripcion", "Descripción del Descuento");
            dataGridDescuentos.Columns.Add("Porcentaje", "Porcentaje (%)");

            // Configurar ancho de columnas
            dataGridDescuentos.Columns[0].Width = 250;
            dataGridDescuentos.Columns[1].Width = 120;

            // Permitir edición directa en la tabla
            dataGridDescuentos.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void btnAgregarDescuento_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya texto en los campos
                if (string.IsNullOrWhiteSpace(txtDescripcionDescuento.Text))
                {
                    MessageBox.Show("Ingrese una descripción para el descuento", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que el porcentaje sea válido
                if (!double.TryParse(txtPorcentajeDescuento.Text, out double porcentaje))
                {
                    MessageBox.Show("Ingrese un porcentaje válido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Agregar a la tabla
                dataGridDescuentos.Rows.Add(txtDescripcionDescuento.Text, porcentaje.ToString());

                // Limpiar los campos
                txtDescripcionDescuento.Text = "";
                txtPorcentajeDescuento.Text = "";

                // Enfocar en la descripción para agregar otro descuento
                txtDescripcionDescuento.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar descuento: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularDescuentos_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya un monto original válido
                if (!double.TryParse(txtMontoOriginal.Text, out double montoOriginal))
                {
                    MessageBox.Show("Ingrese un monto original válido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar que haya al menos un descuento
                if (dataGridDescuentos.Rows.Count <= 1)  // Considerar fila adicional para nueva entrada
                {
                    MessageBox.Show("Agregue al menos un descuento para calcular", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Recopilar los descuentos
                listaDescuentos.Clear();
                foreach (DataGridViewRow row in dataGridDescuentos.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        string descripcion = row.Cells[0].Value.ToString();
                        if (double.TryParse(row.Cells[1].Value.ToString(), out double porcentaje))
                        {
                            listaDescuentos.Add(new DescuentoComercial(descripcion, porcentaje / 100.0));
                        }
                    }
                }

                // Calcular los descuentos sucesivos
                double montoActual = montoOriginal;
                StringBuilder detalles = new StringBuilder();
                detalles.AppendLine("CÁLCULO DE DESCUENTOS COMERCIALES MÚLTIPLES");
                detalles.AppendLine("============================================");
                detalles.AppendLine($"Monto Original: {montoOriginal:C2}");
                detalles.AppendLine();

                double totalDescontado = 0;

                foreach (var descuento in listaDescuentos)
                {
                    double montoDescontado = montoActual * descuento.Porcentaje;
                    double nuevoPrecio = montoActual - montoDescontado;

                    detalles.AppendLine($"Descuento: {descuento.Descripcion} ({descuento.Porcentaje:P2})");
                    detalles.AppendLine($"Monto antes del descuento: {montoActual:C2}");
                    detalles.AppendLine($"Monto del descuento: {montoDescontado:C2}");
                    detalles.AppendLine($"Precio después del descuento: {nuevoPrecio:C2}");
                    detalles.AppendLine("--------------------------------------------");

                    montoActual = nuevoPrecio;
                    totalDescontado += montoDescontado;
                }

                // Calcular el descuento único equivalente
                double descuentoUnicoEquivalente = totalDescontado / montoOriginal * 100;

                detalles.AppendLine();
                detalles.AppendLine("RESULTADO FINAL");
                detalles.AppendLine("==============");
                detalles.AppendLine($"Monto Original: {montoOriginal:C2}");
                detalles.AppendLine($"Monto Final a Pagar: {montoActual:C2}");
                detalles.AppendLine($"Total Descontado: {totalDescontado:C2}");
                detalles.AppendLine($"Descuento Único Equivalente: {descuentoUnicoEquivalente:F2}%");

                // Mostrar resultados
                MostrarResultadoEnForm(detalles.ToString(), "Resultado de Descuentos Comerciales");

                // Actualizar los campos de resultado en la interfaz
                txtMontoFinal.Text = montoActual.ToString("F2");
                txtTotalDescontado.Text = totalDescontado.ToString("F2");
                txtDescuentoEquivalente.Text = descuentoUnicoEquivalente.ToString("F2") + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular descuentos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos y la tabla
            txtMontoOriginal.Text = "";
            txtMontoFinal.Text = "";
            txtTotalDescontado.Text = "";
            txtDescuentoEquivalente.Text = "";
            txtDescripcionDescuento.Text = "";
            txtPorcentajeDescuento.Text = "";

            dataGridDescuentos.Rows.Clear();
            listaDescuentos.Clear();

            // Enfocar en el monto original
            txtMontoOriginal.Focus();
        }

        private void MostrarResultadoEnForm(string contenido, string titulo)
        {
            Form formResultado = new Form();
            formResultado.Text = titulo;
            formResultado.Size = new Size(500, 500);
            formResultado.StartPosition = FormStartPosition.CenterParent;

            TextBox txtResultado = new TextBox();
            txtResultado.Multiline = true;
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Font = new Font("Consolas", 10);
            txtResultado.Text = contenido;

            formResultado.Controls.Add(txtResultado);
            formResultado.ShowDialog();
        }

        // Botón para mostrar reglas sobre descuentos comerciales
        private void btnReglasDescuentos_Click(object sender, EventArgs e)
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("REGLAS DE DESCUENTOS COMERCIALES MÚLTIPLES");
            info.AppendLine("=======================================");
            info.AppendLine();
            info.AppendLine("APLICACIÓN DE DESCUENTOS SUCESIVOS:");
            info.AppendLine("------------------------------------");
            info.AppendLine("1. Los descuentos se aplican uno tras otro sobre el monto resultante.");
            info.AppendLine("2. Fórmula general para precio final con n descuentos:");
            info.AppendLine("   Precio Final = Precio Original × (1-d₁) × (1-d₂) × ... × (1-dₙ)");
            info.AppendLine("   donde dᵢ es el i-ésimo descuento en decimal");
            info.AppendLine();
            info.AppendLine("DESCUENTO ÚNICO EQUIVALENTE:");
            info.AppendLine("-----------------------------");
            info.AppendLine("El descuento único equivalente d_eq que produce el mismo precio final es:");
            info.AppendLine("   d_eq = 1 - [(1-d₁) × (1-d₂) × ... × (1-dₙ)]");
            info.AppendLine();
            info.AppendLine("EJEMPLO:");
            info.AppendLine("---------");
            info.AppendLine("Para descuentos del 10%, 5% y 3%:");
            info.AppendLine("   Precio Final = Precio Original × 0.9 × 0.95 × 0.97");
            info.AppendLine("   Precio Final = Precio Original × 0.82935");
            info.AppendLine("   Descuento Único Equivalente = 17.065%");

            MostrarResultadoEnForm(info.ToString(), "Reglas de Descuentos Comerciales");
        }
    }

    // Clase para representar un descuento comercial
    public class DescuentoComercial
    {
        public string Descripcion { get; private set; }
        public double Porcentaje { get; private set; }

        public DescuentoComercial(string descripcion, double porcentaje)
        {
            Descripcion = descripcion;
            Porcentaje = porcentaje;
        }
    }
}
