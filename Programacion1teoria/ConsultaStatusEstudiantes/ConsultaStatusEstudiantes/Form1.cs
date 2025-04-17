using Microsoft.EntityFrameworkCore;

namespace ConsultaStatusEstudiantes
{
    public partial class Form1 : Form
    {
        private AlmacenamientoSQLServer almacenamiento;
        private DataBaseContext dbContext;
        public Form1()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<DataBaseContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\localDB;Initial Catalog=ProgramacionI;Integrated Security=True");

            dbContext = new DataBaseContext(optionsBuilder.Options);
            almacenamiento = new AlmacenamientoSQLServer(dbContext);
            try
            {
                almacenamiento.InicializarBaseDatos();

             
            }catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
