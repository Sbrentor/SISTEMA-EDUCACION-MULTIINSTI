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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnActCult = new Button();
            btnderecha = new Button();
            btnizquierda = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            P_Principal.SuspendLayout();
            P_BarraArriba.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // P_Principal
            // 
            P_Principal.Controls.Add(P_BarraArriba);
            P_Principal.Controls.Add(panel3);
            P_Principal.Controls.Add(panel2);
            P_Principal.Dock = DockStyle.Fill;
            P_Principal.Location = new Point(0, 0);
            P_Principal.Margin = new Padding(4);
            P_Principal.Name = "P_Principal";
            P_Principal.Size = new Size(1370, 748);
            P_Principal.TabIndex = 0;
            // 
            // P_BarraArriba
            // 
            P_BarraArriba.Controls.Add(button4);
            P_BarraArriba.Controls.Add(button3);
            P_BarraArriba.Controls.Add(button2);
            P_BarraArriba.Controls.Add(btnActCult);
            P_BarraArriba.Controls.Add(btnderecha);
            P_BarraArriba.Controls.Add(btnizquierda);
            P_BarraArriba.Location = new Point(114, 1);
            P_BarraArriba.Margin = new Padding(4);
            P_BarraArriba.Name = "P_BarraArriba";
            P_BarraArriba.Size = new Size(1497, 104);
            P_BarraArriba.TabIndex = 3;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(919, 22);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(210, 58);
            button4.TabIndex = 5;
            button4.Text = "Asistencia Profesores";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(666, 22);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(210, 58);
            button3.TabIndex = 4;
            button3.Text = "Asistencias";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(406, 22);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(210, 58);
            button2.TabIndex = 3;
            button2.Text = "Actividades \r\nExtras";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnActCult
            // 
            btnActCult.FlatAppearance.BorderSize = 0;
            btnActCult.FlatStyle = FlatStyle.Flat;
            btnActCult.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActCult.Location = new Point(94, 22);
            btnActCult.Margin = new Padding(4);
            btnActCult.Name = "btnActCult";
            btnActCult.Size = new Size(210, 58);
            btnActCult.TabIndex = 2;
            btnActCult.Text = "Actividades \r\nCulturales";
            btnActCult.TextAlign = ContentAlignment.MiddleRight;
            btnActCult.UseVisualStyleBackColor = true;
            // 
            // btnderecha
            // 
            btnderecha.FlatAppearance.BorderSize = 0;
            btnderecha.FlatStyle = FlatStyle.Flat;
            btnderecha.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnderecha.Location = new Point(1180, -9);
            btnderecha.Margin = new Padding(4);
            btnderecha.Name = "btnderecha";
            btnderecha.Size = new Size(64, 95);
            btnderecha.TabIndex = 1;
            btnderecha.Text = ">";
            btnderecha.UseVisualStyleBackColor = true;
            btnderecha.Click += btnderecha_Click;
            // 
            // btnizquierda
            // 
            btnizquierda.FlatAppearance.BorderSize = 0;
            btnizquierda.FlatStyle = FlatStyle.Flat;
            btnizquierda.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnizquierda.Location = new Point(4, -9);
            btnizquierda.Margin = new Padding(4);
            btnizquierda.Name = "btnizquierda";
            btnizquierda.Size = new Size(64, 95);
            btnizquierda.TabIndex = 0;
            btnizquierda.Text = "<";
            btnizquierda.UseVisualStyleBackColor = true;
            btnizquierda.Click += btnizquierda_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(1, 105);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(115, 638);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(114, 104);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.saeg_logo;
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipalEscuela
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 748);
            Controls.Add(P_Principal);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmPrincipalEscuela";
            ShowIcon = false;
            Text = "SISTEMA ESCOLAR";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipalEscuela_Load;
            P_Principal.ResumeLayout(false);
            P_BarraArriba.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel P_Principal;
        private Panel panel2;
        private Panel panel3;
        private Panel P_BarraArriba;
        private Button btnizquierda;
        private Button btnderecha;
        private PictureBox pictureBox1;
        private Button btnActCult;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}