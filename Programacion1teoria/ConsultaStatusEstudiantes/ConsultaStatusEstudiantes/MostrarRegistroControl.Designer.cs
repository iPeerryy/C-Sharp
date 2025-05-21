namespace ConsultaStatusEstudiantes
{
    partial class MostrarRegistroControl
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
            tablaRegistro = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tablaRegistro).BeginInit();
            SuspendLayout();
            // 
            // tablaRegistro
            // 
            tablaRegistro.BackgroundColor = SystemColors.Control;
            tablaRegistro.BorderStyle = BorderStyle.None;
            tablaRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaRegistro.Dock = DockStyle.Fill;
            tablaRegistro.Location = new Point(0, 0);
            tablaRegistro.Name = "tablaRegistro";
            tablaRegistro.ReadOnly = true;
            tablaRegistro.Size = new Size(1151, 655);
            tablaRegistro.TabIndex = 0;
            tablaRegistro.CellContentClick += tablaRegistro_CellContentClick;
            // 
            // MostrarRegistroControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tablaRegistro);
            Name = "MostrarRegistroControl";
            Size = new Size(1151, 655);
            ((System.ComponentModel.ISupportInitialize)tablaRegistro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tablaRegistro;
    }
}
