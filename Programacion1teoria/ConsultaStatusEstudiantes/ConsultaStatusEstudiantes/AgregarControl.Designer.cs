namespace ConsultaStatusEstudiantes
{
    partial class AgregarControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            btnAddEstudiante = new Button();
            txtMatricula = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtParcial1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtParcial2 = new TextBox();
            label6 = new Label();
            txtExamenFinal = new TextBox();
            label7 = new Label();
            txtPractica1 = new TextBox();
            label8 = new Label();
            txtPractica2 = new TextBox();
            label9 = new Label();
            txtPractica3 = new TextBox();
            label10 = new Label();
            txtNombre = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 18);
            label1.Name = "label1";
            label1.Size = new Size(290, 36);
            label1.TabIndex = 0;
            label1.Text = "Agregar Estudiante";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 73);
            panel1.TabIndex = 0;
            // 
            // btnAddEstudiante
            // 
            btnAddEstudiante.Location = new Point(403, 448);
            btnAddEstudiante.Name = "btnAddEstudiante";
            btnAddEstudiante.Size = new Size(181, 73);
            btnAddEstudiante.TabIndex = 1;
            btnAddEstudiante.Text = "Añadir";
            btnAddEstudiante.UseVisualStyleBackColor = true;
            btnAddEstudiante.Click += button1_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(59, 170);
            txtMatricula.Multiline = true;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(233, 25);
            txtMatricula.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 198);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 3;
            label2.Text = "Matricula del Estudiante";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(669, 170);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(233, 25);
            txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(728, 198);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellido del Estudiante";
            // 
            // txtParcial1
            // 
            txtParcial1.Location = new Point(138, 244);
            txtParcial1.Multiline = true;
            txtParcial1.Name = "txtParcial1";
            txtParcial1.Size = new Size(71, 25);
            txtParcial1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 272);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 7;
            label4.Text = "Puntuación primer examen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 334);
            label5.Name = "label5";
            label5.Size = new Size(161, 15);
            label5.TabIndex = 9;
            label5.Text = "Puntuación segundo examen";
            // 
            // txtParcial2
            // 
            txtParcial2.Location = new Point(138, 306);
            txtParcial2.Multiline = true;
            txtParcial2.Name = "txtParcial2";
            txtParcial2.Size = new Size(71, 25);
            txtParcial2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 398);
            label6.Name = "label6";
            label6.Size = new Size(138, 15);
            label6.TabIndex = 11;
            label6.Text = "Puntuación examen final";
            // 
            // txtExamenFinal
            // 
            txtExamenFinal.Location = new Point(138, 370);
            txtExamenFinal.Multiline = true;
            txtExamenFinal.Name = "txtExamenFinal";
            txtExamenFinal.Size = new Size(71, 25);
            txtExamenFinal.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(724, 272);
            label7.Name = "label7";
            label7.Size = new Size(157, 15);
            label7.TabIndex = 13;
            label7.Text = "Puntuación primera practica";
            // 
            // txtPractica1
            // 
            txtPractica1.Location = new Point(757, 244);
            txtPractica1.Multiline = true;
            txtPractica1.Name = "txtPractica1";
            txtPractica1.Size = new Size(71, 25);
            txtPractica1.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(724, 334);
            label8.Name = "label8";
            label8.Size = new Size(161, 15);
            label8.TabIndex = 15;
            label8.Text = "Puntuación segunda practica";
            // 
            // txtPractica2
            // 
            txtPractica2.Location = new Point(757, 306);
            txtPractica2.Multiline = true;
            txtPractica2.Name = "txtPractica2";
            txtPractica2.Size = new Size(71, 25);
            txtPractica2.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(724, 398);
            label9.Name = "label9";
            label9.Size = new Size(152, 15);
            label9.TabIndex = 17;
            label9.Text = "Puntuación tercera practica";
            // 
            // txtPractica3
            // 
            txtPractica3.Location = new Point(757, 370);
            txtPractica3.Multiline = true;
            txtPractica3.Name = "txtPractica3";
            txtPractica3.Size = new Size(71, 25);
            txtPractica3.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(426, 198);
            label10.Name = "label10";
            label10.Size = new Size(128, 15);
            label10.TabIndex = 19;
            label10.Text = "Nombre del Estudiante";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(370, 170);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 25);
            txtNombre.TabIndex = 18;
            // 
            // AgregarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(txtNombre);
            Controls.Add(label9);
            Controls.Add(txtPractica3);
            Controls.Add(label8);
            Controls.Add(txtPractica2);
            Controls.Add(label7);
            Controls.Add(txtPractica1);
            Controls.Add(label6);
            Controls.Add(txtExamenFinal);
            Controls.Add(label5);
            Controls.Add(txtParcial2);
            Controls.Add(label4);
            Controls.Add(txtParcial1);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtMatricula);
            Controls.Add(btnAddEstudiante);
            Controls.Add(panel1);
            Name = "AgregarControl";
            Size = new Size(1011, 639);
            Load += AgregarControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnAddEstudiante;
        private TextBox txtMatricula;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtParcial1;
        private Label label4;
        private Label label5;
        private TextBox txtParcial2;
        private Label label6;
        private TextBox txtExamenFinal;
        private Label label7;
        private TextBox txtPractica1;
        private Label label8;
        private TextBox txtPractica2;
        private Label label9;
        private TextBox txtPractica3;
        private Label label10;
        private TextBox txtNombre;
    }
}
