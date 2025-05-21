
using Calculadora_Financiera_UI.UserControllers.DecuentoPorProntoPago;
using Calculadora_Financiera_UI.UserControllers.Descuento;
using Calculadora_Financiera_UI.UserControllers.EcuacionesValorInteresSimple;
using Calculadora_Financiera_UI.UserControllers.InteresCompuesto;
using Calculadora_Financiera_UI.UserControllers.Tasa_Equivalente;
using Calculadora_Financiera_UI.UserControllers.Tiempo;
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
    }
}
