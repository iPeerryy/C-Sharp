using System.Diagnostics.Eventing.Reader;

namespace Calculator__UI
{
    public partial class Form1 : Form
    {
        string datos = "";
        double resultado = 0;
        string operacion = "";
        bool operacionPendiente = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            datos += button.Text;
            textBox1.Text = datos;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            datos += button.Text;
            textBox1.Text = datos;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            

            Button button = (Button)sender;
            operacion = button.Text;
            resultado = double.Parse(datos);
            datos = "";
            operacionPendiente = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            datos += button.Text;
            textBox1.Text = datos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            datos += button.Text;
            textBox1.Text = datos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            datos += button.Text;
            textBox1.Text = datos;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            datos += button.Text;
            textBox1.Text = datos;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            datos += button.Text;
            textBox1.Text = datos;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            datos += button.Text;
            textBox1.Text = datos;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            datos += button.Text;
            textBox1.Text = datos;
        }

        private void Evaluate()
        {
            if (operacionPendiente)
            {
                double segundoNumero = double.Parse(datos);
                switch (operacion)
                {
                    case "+":
                        resultado += segundoNumero;
                        break;
                    case "-":
                        resultado -= segundoNumero;
                        break;
                    case "*":
                        resultado *= segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero != 0)
                        {
                            resultado /= segundoNumero;
                        }
                        else
                        {
                            textBox1.Text = "Error";
                            return;
                        }
                        break;
                }
                textBox1.Text = resultado.ToString();
                datos = "";
                operacionPendiente = false;


            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
           

            Button button = (Button)sender;
            operacion = button.Text;
            resultado = double.Parse(datos);
            datos = "";
            operacionPendiente = true;

        }

        private void button16_Click(object sender, EventArgs e)
        {
           

            Button button = (Button)sender;
            operacion = button.Text;
            resultado = double.Parse(datos);
            datos = "";
            operacionPendiente = true;

        }

        private void button15_Click(object sender, EventArgs e)
        {

            Evaluate();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            datos = "";
            resultado = 0;
            operacion = "";
            operacionPendiente = false;
            textBox1.Text = "";
        }

      
        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            datos += button.Text;
            textBox1.Text = datos;
        }
        private void button10_Click(object sender, EventArgs e)
        {
           

            Button button = (Button)sender;
            operacion = button.Text;
            resultado = double.Parse(datos);
            datos = "";
            operacionPendiente = true;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            datos = "";
            resultado = 0;
            operacion = "";
            operacionPendiente = false;
            textBox1.Text = "";
        }
    }
}