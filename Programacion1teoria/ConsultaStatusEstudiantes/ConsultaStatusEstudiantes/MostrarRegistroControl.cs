using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaStatusEstudiantes
{
    public partial class MostrarRegistroControl : UserControl
    {
        private readonly AlmacenamientoSQLServer _almacenamiento;
        public MostrarRegistroControl(AlmacenamientoSQLServer almacenamiento)
        {
            InitializeComponent();
            _almacenamiento = almacenamiento;
        }

        public void CargarDatos()
        {
            try
            {
                List<Estudiante> estudiantes = _almacenamiento.ObtenerTodos();
                tablaRegistro.DataSource = estudiantes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tablaRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
