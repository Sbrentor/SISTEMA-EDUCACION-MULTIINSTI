namespace SISTEMA_EDUCACION.FORMULARIOS.ESCUELA
{
    partial class FrmPrincipalEscuela
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            P_Principal = new Panel();
            P_BarraArriba = new Panel();
            btnderecha = new Button();
            btnizquierda = new Button();
            P_barraIzquierda = new Panel();
            btnabajo = new Button();
            btnarriba = new Button();
            btnadministracion = new Button();
            btnacademico = new Button();
            btnadministrativo = new Button();
            P_logo = new Panel();
            PBlogo = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            P_Principal.SuspendLayout();
            P_BarraArriba.SuspendLayout();
            P_barraIzquierda.SuspendLayout();
            P_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBlogo).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // P_Principal
            // 
            P_Principal.Controls.Add(P_BarraArriba);
            P_Principal.Controls.Add(P_barraIzquierda);
            P_Principal.Controls.Add(panel3);
            P_Principal.Dock = DockStyle.Fill;
            P_Principal.Location = new Point(0, 0);
            P_Principal.Name = "P_Principal";
            P_Principal.Size = new Size(1350, 729);
            P_Principal.TabIndex = 2;
            // 
            // P_BarraArriba
            // 
            P_BarraArriba.Controls.Add(btnderecha);
            P_BarraArriba.Controls.Add(btnizquierda);
            P_BarraArriba.Dock = DockStyle.Top;
            P_BarraArriba.Location = new Point(157, 0);
            P_BarraArriba.Margin = new Padding(4);
            P_BarraArriba.Name = "P_BarraArriba";
            P_BarraArriba.Size = new Size(1193, 104);
            P_BarraArriba.TabIndex = 9;
            // 
            // btnderecha
            // 
            btnderecha.FlatAppearance.BorderSize = 0;
            btnderecha.FlatStyle = FlatStyle.Flat;
            btnderecha.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnderecha.Image = Properties.Resources.derecha;
            btnderecha.Location = new Point(1136, 36);
            btnderecha.Margin = new Padding(4);
            btnderecha.Name = "btnderecha";
            btnderecha.Size = new Size(64, 39);
            btnderecha.TabIndex = 1;
            btnderecha.UseVisualStyleBackColor = true;
            btnderecha.Click += btnderecha_Click_1;
            // 
            // btnizquierda
            // 
            btnizquierda.FlatAppearance.BorderSize = 0;
            btnizquierda.FlatStyle = FlatStyle.Flat;
            btnizquierda.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnizquierda.Image = Properties.Resources.izquierda;
            btnizquierda.Location = new Point(4, 36);
            btnizquierda.Margin = new Padding(4);
            btnizquierda.Name = "btnizquierda";
            btnizquierda.Size = new Size(64, 39);
            btnizquierda.TabIndex = 0;
            btnizquierda.UseVisualStyleBackColor = true;
            btnizquierda.Click += btnizquierda_Click_1;
            // 
            // P_barraIzquierda
            // 
            P_barraIzquierda.Controls.Add(btnabajo);
            P_barraIzquierda.Controls.Add(btnarriba);
            P_barraIzquierda.Controls.Add(btnadministracion);
            P_barraIzquierda.Controls.Add(btnacademico);
            P_barraIzquierda.Controls.Add(btnadministrativo);
            P_barraIzquierda.Controls.Add(P_logo);
            P_barraIzquierda.Dock = DockStyle.Left;
            P_barraIzquierda.Location = new Point(0, 0);
            P_barraIzquierda.Margin = new Padding(4);
            P_barraIzquierda.Name = "P_barraIzquierda";
            P_barraIzquierda.Size = new Size(157, 729);
            P_barraIzquierda.TabIndex = 8;
            // 
            // btnabajo
            // 
            btnabajo.FlatAppearance.BorderSize = 0;
            btnabajo.FlatStyle = FlatStyle.Flat;
            btnabajo.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnabajo.Image = Properties.Resources.abajo;
            btnabajo.Location = new Point(46, 630);
            btnabajo.Margin = new Padding(4);
            btnabajo.Name = "btnabajo";
            btnabajo.Size = new Size(64, 74);
            btnabajo.TabIndex = 14;
            btnabajo.UseVisualStyleBackColor = true;
            btnabajo.Click += btnabajo_Click;
            // 
            // btnarriba
            // 
            btnarriba.FlatAppearance.BorderSize = 0;
            btnarriba.FlatStyle = FlatStyle.Flat;
            btnarriba.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnarriba.Image = Properties.Resources.arriba;
            btnarriba.Location = new Point(57, 82);
            btnarriba.Margin = new Padding(4);
            btnarriba.Name = "btnarriba";
            btnarriba.Size = new Size(42, 74);
            btnarriba.TabIndex = 13;
            btnarriba.UseVisualStyleBackColor = true;
            btnarriba.Click += btnarriba_Click;
            // 
            // btnadministracion
            // 
            btnadministracion.BackColor = Color.Transparent;
            btnadministracion.FlatAppearance.BorderSize = 0;
            btnadministracion.FlatStyle = FlatStyle.Flat;
            btnadministracion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadministracion.Image = Properties.Resources.administracion;
            btnadministracion.ImageAlign = ContentAlignment.TopCenter;
            btnadministracion.Location = new Point(4, 517);
            btnadministracion.Name = "btnadministracion";
            btnadministracion.Size = new Size(151, 91);
            btnadministracion.TabIndex = 12;
            btnadministracion.Text = "ADMINISTRACION";
            btnadministracion.TextAlign = ContentAlignment.BottomCenter;
            btnadministracion.UseVisualStyleBackColor = false;
            // 
            // btnacademico
            // 
            btnacademico.BackColor = Color.Transparent;
            btnacademico.FlatAppearance.BorderSize = 0;
            btnacademico.FlatStyle = FlatStyle.Flat;
            btnacademico.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnacademico.Image = Properties.Resources.academico;
            btnacademico.ImageAlign = ContentAlignment.TopCenter;
            btnacademico.Location = new Point(19, 357);
            btnacademico.Name = "btnacademico";
            btnacademico.Size = new Size(121, 91);
            btnacademico.TabIndex = 11;
            btnacademico.Text = "ACADEMICO";
            btnacademico.TextAlign = ContentAlignment.BottomCenter;
            btnacademico.UseVisualStyleBackColor = false;
            // 
            // btnadministrativo
            // 
            btnadministrativo.BackColor = Color.Transparent;
            btnadministrativo.FlatAppearance.BorderSize = 0;
            btnadministrativo.FlatStyle = FlatStyle.Flat;
            btnadministrativo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadministrativo.Image = Properties.Resources.administrativo;
            btnadministrativo.ImageAlign = ContentAlignment.TopCenter;
            btnadministrativo.Location = new Point(4, 192);
            btnadministrativo.Name = "btnadministrativo";
            btnadministrativo.Size = new Size(149, 91);
            btnadministrativo.TabIndex = 10;
            btnadministrativo.Text = "ADMINISTRATIVO";
            btnadministrativo.TextAlign = ContentAlignment.BottomCenter;
            btnadministrativo.UseVisualStyleBackColor = false;
            // 
            // P_logo
            // 
            P_logo.Controls.Add(PBlogo);
            P_logo.Location = new Point(32, 5);
            P_logo.Margin = new Padding(4);
            P_logo.Name = "P_logo";
            P_logo.Size = new Size(84, 70);
            P_logo.TabIndex = 4;
            // 
            // PBlogo
            // 
            PBlogo.Dock = DockStyle.Fill;
            PBlogo.Image = Properties.Resources.saeg_logo;
            PBlogo.Location = new Point(0, 0);
            PBlogo.Name = "PBlogo";
            PBlogo.Size = new Size(84, 70);
            PBlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PBlogo.TabIndex = 2;
            PBlogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(-537, 111);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(115, 638);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(2, 3);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(109, 99);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.saeg_logo;
            pictureBox1.Location = new Point(7, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipalEscuela
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(P_Principal);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmPrincipalEscuela";
            ShowIcon = false;
            Text = "SISTEMA ESCOLAR";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipalEscuela_Load;
            P_Principal.ResumeLayout(false);
            P_BarraArriba.ResumeLayout(false);
            P_barraIzquierda.ResumeLayout(false);
            P_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBlogo).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel P_Principal;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel P_BarraArriba;
        private Button btnderecha;
        private Button btnizquierda;
        private Panel P_barraIzquierda;
        private Panel P_logo;
        private PictureBox PBlogo;
        private Button btnadministrativo;
        private Button btnadministracion;
        private Button btnacademico;
        private Button btnarriba;
        private Button btnabajo;
    }
}