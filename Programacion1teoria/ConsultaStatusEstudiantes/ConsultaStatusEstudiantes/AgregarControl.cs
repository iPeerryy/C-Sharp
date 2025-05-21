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
    public partial class AgregarControl : UserControl
    {
        private readonly AlmacenamientoSQLServer _almacenamiento;
        public AgregarControl(AlmacenamientoSQLServer almacenamiento)
        {
            InitializeComponent();
            _almacenamiento = almacenamiento;
        }
        private void limpiarCampos()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtMatricula.Clear();
            txtParcial1.Clear();
            txtParcial2.Clear();
            txtExamenFinal.Clear();
            txtPractica1.Clear();
            txtPractica2.Clear();
            txtPractica3.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!double.TryParse(txtParcial1.Text, out double primerParcial) || primerParcial < 0 || primerParcial > 100 ||
                    !double.TryParse(txtParcial2.Text, out double segundoParcial) || segundoParcial < 0 || segundoParcial > 100 ||
                    !double.TryParse(txtExamenFinal.Text, out double examenFinal) || examenFinal < 0 || examenFinal > 100)
                {
                    MessageBox.Show("Las calificaciones de los parciales deben ser números entre 0 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!double.TryParse(txtPractica1.Text, out double practica1) || practica1 < 0 || practica1 > 100 ||
                   !double.TryParse(txtPractica2.Text, out double practica2) || practica2 < 0 || practica2 > 100 ||
                   !double.TryParse(txtPractica3.Text, out double practica3) ||  practica3 < 0|| practica3 > 100)
                {
                    MessageBox.Show("Las calificaciones de las prácticas deben ser valores numéricos y no mayores a 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Estudiante estudiante = new Estudiante
                {
                    matricula = txtMatricula.Text,
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    PrimerParcial = primerParcial,
                    SegundoParcial = segundoParcial,
                    ExamenFinal = examenFinal,
                    Practica1 = practica1,
                    Practica2 = practica2,
                    Practica3 = practica3
                };

                estudiante.PromedioPracticas = estudiante.PorcentajePracticas();
                estudiante.PromedioExamenes = estudiante.PorcentajeExamenes();
                estudiante.PromedioTotal = estudiante.CalificacionFinal();
                if (!estudiante.ValidarCalificacion(estudiante.PromedioTotal))
                {
                    MessageBox.Show("La calificación debe estar entre 50 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                estudiante.estado = estudiante.Estatus() == "Aprobado";

                _almacenamiento.Guardar(estudiante);
                MessageBox.Show("Estudiante agregado exitosamente.", "Duro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el estudiante. Verifique los datos ingresados." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarControl_Load(object sender, EventArgs e)
        {

        }
    }
}
