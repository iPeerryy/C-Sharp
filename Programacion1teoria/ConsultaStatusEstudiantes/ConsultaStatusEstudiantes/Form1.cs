using Microsoft.EntityFrameworkCore;

namespace ConsultaStatusEstudiantes
{
    public partial class frm_Home : Form
    {
        private AlmacenamientoSQLServer almacenamiento;
        private DataBaseContext dbContext;
        public frm_Home()
        {
            InitializeComponent();


            var optionsBuilder = new DbContextOptionsBuilder<DataBaseContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\localDB;Initial Catalog=ProgramacionI;Integrated Security=True");

            dbContext = new DataBaseContext(optionsBuilder.Options);
            almacenamiento = new AlmacenamientoSQLServer(dbContext);
            try
            {
                almacenamiento.InicializarBaseDatos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarControladorEnPanel(UserControl controlador)
        {
            controlador.Dock = DockStyle.Fill;
            panelReemplazable.Controls.Clear();
            panelReemplazable.Controls.Add(controlador);
            controlador.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarControl controlador = new AgregarControl(almacenamiento);
            CargarControladorEnPanel(controlador);

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarControl eliminarControl = new EliminarControl(almacenamiento);
            CargarControladorEnPanel(eliminarControl);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MostrarRegistroControl mostrarRegistroControl = new MostrarRegistroControl(almacenamiento);
            CargarControladorEnPanel(mostrarRegistroControl);
            mostrarRegistroControl.CargarDatos();

        }
    }
}
