using Calculadora_Financiera_UI.Métodos;
using Calculadora_Financiera_UI.UserControllers.Descuento;
using Calculadora_Financiera_UI.UserControllers.Tiempo;
using System.Windows.Forms;

namespace Calculadora_Financiera_UI
{
    public partial class Form1 : Form
    {



        private CtrNavegador navegador;
        private Panel contenedor;

        public Form1()
        {

            InitializeComponent();
            contenedor = panel342;
            navegador = new CtrNavegador(panel342);

        }

        private void Form1_Load(object sender, EventArgs e)
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
            //panelCalculadoraFinanciera.Controls.Clear();
            //CtrInteresSimple interesSimpleMenu = new CtrInteresSimple();
            navegador.NavegarA(new CtrInteresSimple());
            //InteresSimpleMenu.Show();
            //panelCalculadoraFinanciera.Controls.Add(InteresSimpleMenu);
            //panelCalculadoraFinanciera.Visible = true;
            //interesSimpleMenu.BringToFront();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formularioActual = this.FindForm();


            formularioActual.Hide();

            formularioActual.Close();
        }

        private void TiempoMenuButton_Click(object sender, EventArgs e)
        {

            panel342.Controls.Clear();
            CtrTiempoMenu InteresSimpleMenu = new CtrTiempoMenu();
            InteresSimpleMenu.Show();
            panel342.Controls.Add(InteresSimpleMenu);
            panel342.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel342.Controls.Clear();
            CtrDescuento InteresSimpleMenu = new CtrDescuento();
            InteresSimpleMenu.Show();
            panel342.Controls.Add(InteresSimpleMenu);
            panel342.Visible = true;

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
    }
}
