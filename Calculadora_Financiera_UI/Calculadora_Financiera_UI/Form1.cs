
using Calculadora_Financiera_UI.UserControllers.DecuentoPorProntoPago;
using Calculadora_Financiera_UI.UserControllers.Descuento;
using Calculadora_Financiera_UI.UserControllers.EcuacionesValorInteresSimple;
using Calculadora_Financiera_UI.UserControllers.InteresCompuesto;
using Calculadora_Financiera_UI.UserControllers.Tasa_Equivalente;
using Calculadora_Financiera_UI.UserControllers.Tiempo;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_Financiera_UI
{
    public partial class Form1 : Form
    {




        private Panel contenedor;

        public Form1()
        {

            InitializeComponent();
            contenedor = panelReemplazable;


        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void CargarControladorEnPanel(UserControl controlador)
        {
            controlador.Dock = DockStyle.Fill;
            panelReemplazable.Controls.Clear();
            panelReemplazable.Controls.Add(controlador);
            controlador.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CtrInteresSimple ctrInteresSimple = new CtrInteresSimple();
            CargarControladorEnPanel(ctrInteresSimple);

        }


        private void TiempoMenuButton_Click(object sender, EventArgs e)
        {


            CtrTiempoMenu tiempoMenu = new CtrTiempoMenu();
            CargarControladorEnPanel(tiempoMenu);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            CtrDescuento descuentoMenu = new CtrDescuento();
            CargarControladorEnPanel(descuentoMenu);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EcuacionValor_Click(object sender, EventArgs e)
        {
            CtrEcuacionValor ctrEcuacionValor = new CtrEcuacionValor();
            CargarControladorEnPanel(ctrEcuacionValor);
        }

        private void panelReemplazable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CtrDescuentoPorProntoPago descuentoPorProntoPago = new CtrDescuentoPorProntoPago();
            CargarControladorEnPanel(descuentoPorProntoPago);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CtrInteresCompuesto ctrInteresCompuesto = new CtrInteresCompuesto();
            CargarControladorEnPanel(ctrInteresCompuesto);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CtrTasaEquivalente ctrTasaEquivalente = new CtrTasaEquivalente();
            CargarControladorEnPanel(ctrTasaEquivalente);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder info = new StringBuilder();

            // Título principal
            info.AppendLine("FÓRMULAS FINANCIERAS");
            info.AppendLine("===================");
            info.AppendLine();

            // Interés Simple
            info.AppendLine("INTERÉS SIMPLE:");
            info.AppendLine("-------------");
            info.AppendLine("- Capital final: F = P(1 + i·n)");
            info.AppendLine("- Interés generado: I = P·i·n");
            info.AppendLine("- Capital inicial: P = F/(1 + i·n)");
            info.AppendLine("- Tasa de interés: i = I/(P·n)");
            info.AppendLine("- Tiempo: n = I/(P·i)");
            info.AppendLine();

            // Interés Compuesto
            info.AppendLine("INTERÉS COMPUESTO:");
            info.AppendLine("-----------------");
            info.AppendLine("- Capital final: F = P(1 + i)^n");
            info.AppendLine("- Capital inicial: P = F/(1 + i)^n");
            info.AppendLine("- Tasa de interés: i = (F/P)^(1/n) - 1");
            info.AppendLine("- Tiempo: n = ln(F/P)/ln(1 + i)");
            info.AppendLine("- Interés generado: I = F - P");
            info.AppendLine();

            // Descuento Simple
            info.AppendLine("DESCUENTO SIMPLE:");
            info.AppendLine("----------------");
            info.AppendLine("- Valor nominal: VN = VA/(1 - d·t)");
            info.AppendLine("- Valor actual: VA = VN(1 - d·t)");
            info.AppendLine("- Descuento: D = VN - VA = VN·d·t");
            info.AppendLine("- Tasa de descuento: d = D/(VN·t)");
            info.AppendLine("- Tiempo: t = D/(VN·d)");
            info.AppendLine();

            // Descuento Por Pronto Pago
            info.AppendLine("DESCUENTO POR PRONTO PAGO:");
            info.AppendLine("--------------------------");
            info.AppendLine("- Valor con descuento: VD = VN(1 - d%)");
            info.AppendLine("- Descuento: D = VN·d%");
            info.AppendLine("- Tasa de descuento efectiva: def = d%/(1 - d%)");
            info.AppendLine();

            // Descuentos Comerciales Múltiples
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
            info.AppendLine();

            // Tasa Equivalente
            info.AppendLine("TASA EQUIVALENTE:");
            info.AppendLine("----------------");
            info.AppendLine("- Tasa equivalente: ieq = (1 + i)^(m/n) - 1");
            info.AppendLine("- Tasa efectiva anual: TEA = (1 + i/m)^m - 1");
            info.AppendLine("- Tasa nominal: j = m·i");
            info.AppendLine("- Conversión entre tasas: i2 = (1 + i1)^(t1/t2) - 1");
            info.AppendLine();

            // Ecuaciones Valor Interés Simple
            info.AppendLine("ECUACIONES DE VALOR (INTERÉS SIMPLE):");
            info.AppendLine("-----------------------------------");
            info.AppendLine("- Equivalencia entre capitales: F1/(1 + i·t1) = F2/(1 + i·t2)");
            info.AppendLine("- Ecuación de valor: VA1 + VA2 + ... + VAn = VA'1 + VA'2 + ... + VA'm");
            info.AppendLine("- Donde VA = VF/(1 + i·t)");
            info.AppendLine();

            // Tiempo
            info.AppendLine("TIEMPO:");
            info.AppendLine("------");
            info.AppendLine("- Tiempo en interés simple: t = (F - P)/(P·i)");
            info.AppendLine("- Tiempo en interés compuesto: t = ln(F/P)/ln(1 + i)");
            info.AppendLine("- Tiempo para duplicar capital (Regla del 72) ≈ 72/i% (donde i% es la tasa en porcentaje)");
            info.AppendLine();

            // Anualidades
            info.AppendLine("ANUALIDADES:");
            info.AppendLine("-----------");
            info.AppendLine("- Valor presente de anualidad ordinaria: P = R·[(1 - (1 + i)^(-n))/i]");
            info.AppendLine("- Valor futuro de anualidad ordinaria: F = R·[((1 + i)^n - 1)/i]");
            info.AppendLine("- Pago periódico (cuota): R = P·[i/(1 - (1 + i)^(-n))]");
            info.AppendLine("- Pago periódico (para valor futuro): R = F·[i/((1 + i)^n - 1)]");

            // Mostrar todas las fórmulas en un formulario o ventana
            MostrarResultadoEnForm(info.ToString(), "Fórmulas Financieras");
        }
        private void MostrarResultadoEnForm(string contenido, string titulo)
        {
            // Opción 1: Mostrar en MessageBox (limitado en tamaño)
            // MessageBox.Show(contenido, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Opción 2: Crear un formulario con un RichTextBox para mostrar el contenido
            Form formResultado = new Form();
            formResultado.Text = titulo;
            formResultado.Size = new Size(800, 600);
            formResultado.StartPosition = FormStartPosition.CenterScreen;

            RichTextBox rtbResultado = new RichTextBox();
            rtbResultado.Dock = DockStyle.Fill;
            rtbResultado.ReadOnly = true;
            rtbResultado.Font = new Font("Consolas", 10);
            rtbResultado.Text = contenido;

            // Para permitir que el usuario pueda copiar el contenido
            ToolStrip toolStrip = new ToolStrip();
            ToolStripButton btnCopiar = new ToolStripButton("Copiar");
            btnCopiar.Click += (sender, e) => Clipboard.SetText(rtbResultado.Text);
            toolStrip.Items.Add(btnCopiar);

            ToolStripButton btnCerrar = new ToolStripButton("Cerrar");
            btnCerrar.Click += (sender, e) => formResultado.Close();
            toolStrip.Items.Add(btnCerrar);

            formResultado.Controls.Add(rtbResultado);
            formResultado.Controls.Add(toolStrip);
            toolStrip.Dock = DockStyle.Top;

            // Mostrar el formulario como diálogo modal
            formResultado.ShowDialog();
        }
    }
}
