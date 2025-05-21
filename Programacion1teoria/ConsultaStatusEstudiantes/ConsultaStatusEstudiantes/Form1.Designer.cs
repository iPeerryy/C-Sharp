namespace ConsultaStatusEstudiantes
{
    partial class frm_Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            btn_eliminar = new Button();
            btn_agregar = new Button();
            panel3 = new Panel();
            panelReemplazable = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 69);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 19);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 19);
            label1.Name = "label1";
            label1.Size = new Size(253, 22);
            label1.TabIndex = 0;
            label1.Text = "Consultora  De Estudiantes";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_eliminar);
            panel2.Controls.Add(btn_agregar);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = SystemColors.Control;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 549);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13.25F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = Properties.Resources.Webp_net_resizeimage__12_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 138);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 0, 0);
            button1.Size = new Size(267, 45);
            button1.TabIndex = 2;
            button1.Text = "Mostrar Registro";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = SystemColors.ScrollBar;
            btn_eliminar.Dock = DockStyle.Top;
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Microsoft Sans Serif", 13.25F);
            btn_eliminar.ForeColor = SystemColors.ControlText;
            btn_eliminar.Image = (Image)resources.GetObject("btn_eliminar.Image");
            btn_eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eliminar.Location = new Point(0, 93);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Padding = new Padding(5, 0, 0, 0);
            btn_eliminar.Size = new Size(267, 45);
            btn_eliminar.TabIndex = 1;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.ScrollBar;
            btn_agregar.Dock = DockStyle.Top;
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Font = new Font("Microsoft Sans Serif", 13.25F);
            btn_agregar.ForeColor = SystemColors.ControlText;
            btn_agregar.Image = (Image)resources.GetObject("btn_agregar.Image");
            btn_agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar.Location = new Point(0, 48);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Padding = new Padding(5, 0, 0, 0);
            btn_agregar.Size = new Size(267, 45);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 48);
            panel3.TabIndex = 0;
            // 
            // panelReemplazable
            // 
            panelReemplazable.Dock = DockStyle.Fill;
            panelReemplazable.Location = new Point(267, 69);
            panelReemplazable.Name = "panelReemplazable";
            panelReemplazable.Size = new Size(883, 549);
            panelReemplazable.TabIndex = 2;
            // 
            // frm_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 618);
            Controls.Add(panelReemplazable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_Home";
            Text = "Consulta De Estudiantes";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btn_agregar;
        private Panel panel3;
        private Button btn_eliminar;
        private Panel panelReemplazable;
        private Button button1;
    }
}
