using Calculadora_Financiera_UI.Métodos;
using Calculadora_Financiera_UI.UserControllers.Tiempo;
using System.Windows.Forms;

namespace Calculadora_Financiera_UI
{
    public partial class Form1 : Form
    {

        private Dictionary<Control, Rectangle> posicionesOriginales = new Dictionary<Control, Rectangle>();
        private float fuenteBase;
        private CtrNavegador navegador;

        public Form1()
        {
            this.MinimumSize = new Size(1000, 700);
            this.Load += Form1_Load;
            this.Resize += Form1_Resize;
            InitializeComponent();
           navegador = new CtrNavegador(panelCalculadoraFinanciera);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            fuenteBase = this.Font.Size;
            GuardarPosicionesOriginales(this.Controls);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float ratioX = (float)this.Width / this.MinimumSize.Width;
            float ratioY = (float)this.Height / this.MinimumSize.Height;
            float ratioFuente = Math.Min(ratioX, ratioY);

            EscalarControles(this.Controls, ratioX, ratioY, ratioFuente);
        }
        private void GuardarPosicionesOriginales(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                posicionesOriginales[ctrl] = ctrl.Bounds;

                if (ctrl.HasChildren)
                {
                    GuardarPosicionesOriginales(ctrl.Controls);
                }
            }
        }
        private void EscalarControles(Control.ControlCollection controles, float ratioX, float ratioY, float ratioFuente)
        {
            foreach (Control ctrl in controles)
            {
                if (posicionesOriginales.ContainsKey(ctrl))
                {
                    Rectangle original = posicionesOriginales[ctrl];

                    ctrl.Left = (int)(original.Left * ratioX);
                    ctrl.Top = (int)(original.Top * ratioY);
                    ctrl.Width = (int)(original.Width * ratioX);
                    ctrl.Height = (int)(original.Height * ratioY);

                    try
                    {
                        ctrl.Font = new Font(ctrl.Font.FontFamily, fuenteBase * ratioFuente, ctrl.Font.Style);
                    }
                    catch { /* Algunos controles no permiten cambiar fuente, lo ignoramos */ }
                }

                if (ctrl.HasChildren)
                {
                    EscalarControles(ctrl.Controls, ratioX, ratioY, ratioFuente);
                }
            }
        }
        private void panelCalculadoraFinanciera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCalculadoraFinanciera.Controls.Clear();
            CtrInteresSimple InteresSimpleMenu = new CtrInteresSimple();
            InteresSimpleMenu.Show();
            panelCalculadoraFinanciera.Controls.Add(InteresSimpleMenu);
            panelCalculadoraFinanciera.Visible = true;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formularioActual = this.FindForm();

            
            formularioActual.Hide();

            formularioActual.Close();
        }

        private void TiempoMenuButton_Click(object sender, EventArgs e)
        {

            panelCalculadoraFinanciera.Controls.Clear();
            CtrTiempoMenu InteresSimpleMenu = new CtrTiempoMenu();
            InteresSimpleMenu.Show();
            panelCalculadoraFinanciera.Controls.Add(InteresSimpleMenu);
            panelCalculadoraFinanciera.Visible = true;
        }
    }
}
