using System.Windows.Forms;

namespace Calculadora_Financiera_UI
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
