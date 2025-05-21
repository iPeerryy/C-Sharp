using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ConsultaStatusEstudiantes.Estudiante;

namespace ConsultaStatusEstudiantes
{
    public partial class EliminarControl : UserControl
    {
        private readonly AlmacenamientoSQLServer _almacenamiento;
        public EliminarControl(AlmacenamientoSQLServer almacenamiento)
        {
            InitializeComponent();
            _almacenamiento = almacenamiento;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    string.IsNullOrWhiteSpace(textMatricula.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Estudiante estudiante = _almacenamiento.Obtener(textMatricula.Text);
                if (estudiante == null)
                {
                    MessageBox.Show("No se encontró un estudiante con esa matrícula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _almacenamiento.Eliminar(textMatricula.Text);
                MessageBox.Show("Estudiante eliminado exitosamente.", "Duro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textMatricula.Clear();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EliminarControl_Load(object sender, EventArgs e)
        {

        }
    }
}
