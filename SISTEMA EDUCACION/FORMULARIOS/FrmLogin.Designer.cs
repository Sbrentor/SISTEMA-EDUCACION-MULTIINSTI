namespace SISTEMA_EDUCACION.FORMULARIOS
{
    partial class FrmLogin
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
            label1 = new Label();
            txtuser = new TextBox();
            btnentrar = new Button();
            btncancelar = new Button();
            btnver = new Button();
            txtcontra = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.Black;
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.ForeColor = Color.White;
            txtuser.Location = new Point(66, 26);
            txtuser.Margin = new Padding(4);
            txtuser.Multiline = true;
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(129, 29);
            txtuser.TabIndex = 1;
            // 
            // btnentrar
            // 
            btnentrar.FlatAppearance.BorderSize = 0;
            btnentrar.FlatStyle = FlatStyle.Flat;
            btnentrar.ForeColor = Color.FromArgb(224, 224, 224);
            btnentrar.Location = new Point(15, 127);
            btnentrar.Margin = new Padding(4);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(96, 29);
            btnentrar.TabIndex = 4;
            btnentrar.Text = "ENTRAR";
            btnentrar.UseVisualStyleBackColor = true;
            btnentrar.Click += btnentrar_Click;
            // 
            // btncancelar
            // 
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.ForeColor = Color.FromArgb(224, 224, 224);
            btncancelar.Location = new Point(153, 127);
            btncancelar.Margin = new Padding(4);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(103, 29);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnver
            // 
            btnver.FlatAppearance.BorderSize = 0;
            btnver.FlatStyle = FlatStyle.Flat;
            btnver.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnver.ForeColor = Color.White;
            btnver.Location = new Point(203, 90);
            btnver.Margin = new Padding(4);
            btnver.Name = "btnver";
            btnver.Size = new Size(32, 29);
            btnver.TabIndex = 3;
            btnver.Text = "\U0001f9d0";
            btnver.UseVisualStyleBackColor = true;
            btnver.Click += btnver_Click;
            // 
            // txtcontra
            // 
            txtcontra.BackColor = Color.Black;
            txtcontra.BorderStyle = BorderStyle.None;
            txtcontra.ForeColor = Color.White;
            txtcontra.Location = new Point(66, 90);
            txtcontra.Margin = new Padding(4);
            txtcontra.Multiline = true;
            txtcontra.Name = "txtcontra";
            txtcontra.PasswordChar = '*';
            txtcontra.Size = new Size(129, 29);
            txtcontra.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 19);
            label2.TabIndex = 5;
            label2.Text = "CONTRASEÑA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 58);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 0);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 119);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 0);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Cyan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(66, 57);
            textBox3.Margin = new Padding(4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 1);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Cyan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(66, 123);
            textBox4.Margin = new Padding(4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 1);
            textBox4.TabIndex = 10;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(260, 165);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtcontra);
            Controls.Add(label2);
            Controls.Add(btnver);
            Controls.Add(btncancelar);
            Controls.Add(btnentrar);
            Controls.Add(txtuser);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmLogin";
            Text = "SESION";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtuser;
        private Button btnentrar;
        private Button btncancelar;
        private Button btnver;
        private TextBox txtcontra;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}