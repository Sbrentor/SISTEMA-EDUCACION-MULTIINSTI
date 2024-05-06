using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_EDUCACION.FORMULARIOS.ESCUELA
{
    public partial class FrmPrincipalEscuela : Form
    {
        private Button btn = new Button();
        public FrmPrincipalEscuela()
        {
            InitializeComponent();
        }

        private void FrmPrincipalEscuela_Load(object sender, EventArgs e)
        {
            CreateButtonInPanel();
        }

        private void MoveButtons() {
            
        }

        private void CreateButtonInPanel()
        {
            btn.Tag = 5;
            btn.Size = new Size(210, 58);
            btn.Location = new Point(919, 22);
            btn.Text = "informacion";
            btn.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Image = Properties.Resources.secciones;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            P_BarraArriba.Controls.Add(btn);
            btn.BringToFront();
        }

        private void btnizquierda_Click(object sender, EventArgs e)
        {
            
        }

        private void btnderecha_Click(object sender, EventArgs e)
        {
            
        }
    }
}
