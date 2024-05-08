using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Resources;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_EDUCACION.FORMULARIOS.ESCUELA
{
    public partial class FrmPrincipalEscuela : Form
    {
        LOGICA.LHelpers h = new LOGICA.LHelpers();
        private Button btn = new Button();
        private Button btnL = new Button();
        private int Tx, Ty = 32,
                    Lx = 19,Ly, 
                    Topheight = 46, Topwidth = 165, 
                    Leftheight = 91, Leftwidth = 121, i,
                    administrativoX = 4, administrativoY = 192 ,
                    administracionX = 4, administracionY = 517,
                    academicoX = 19, academicoY = 357;

        public FrmPrincipalEscuela()
        {
            InitializeComponent();
        }

        private void CreateButtonInPanelTop()
        {
            //btn.Tag = 5;
            btn.Size = new Size(Topwidth, Topheight);
            btn.Location = new Point(919, Ty);
            btn.Text = "xd nose algo mas";
            btn.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Image = Properties.Resources.secciones;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            P_BarraArriba.Controls.Add(btn);
            btn.BringToFront();
        }

        private void MovePanelButtonsUp()
        {
            if (btnL.Created)
            {
                btnadministrativo.Visible = false;
                btnadministracion.Location = new Point(administracionX,academicoY);
                btnacademico.Location = new Point(academicoX,administrativoY);
            }
            if (btnL.Location.X == Lx && btnL.Location.Y == 357)
            {
                btnacademico.Visible = false;
                btnadministracion.Location = new Point(administracionX, administrativoY);
            }
        }

        private void MovePanelButtonsDown()
        {
            if (btnL.Created)
            {
                btnadministracion.Visible = false;
                btnadministrativo.Location = new Point(administrativoX, academicoY);
                btnacademico.Location = new Point(academicoX, administracionY);
            }
            if (btnL.Location.X == Lx && btnL.Location.Y == 357)
            {
                btnacademico.Visible = false;
                btnadministrativo.Location = new Point(administracionX, administracionY);
            }
        }


        private void CreateButtonInPanelLeft(string namebtn, Button BTN = null)
        {
            btnL.Size = new Size(Leftwidth, Leftheight);
            btnL.Location = new Point(Lx, 100);
            btnL.Text = namebtn;
            btnL.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            btnL.FlatAppearance.BorderSize = 0;
            btnL.FlatStyle = FlatStyle.Flat;
            btnL.Image = Properties.Resources.economico;
            btnL.ImageAlign = ContentAlignment.TopCenter;
            btnL.TextAlign = ContentAlignment.BottomCenter;
            P_barraIzquierda.Controls.Add(btnL);
            btnL.BringToFront();
            btnL.Visible = false;
        }

        private void FrmPrincipalEscuela_Load(object sender, EventArgs e)
        {
            CreateButtonInPanelTop();
            this.Size = new Size( Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void MoveButtonsLeft()
        {
                if (btn.Location.X == 919 && btn.Location.Y == Ty)
                {
                    for (i = 919; i >= Tx; i--)
                    {
                        btn.Location = new Point(i, Ty);
                        if (btn.Location.X == 666) break;
                    }
                }
                else if (btn.Location.X == 666 && btn.Location.Y == Ty)
                {
                    for (i = 666; i >= Tx; i--)
                    {
                        btn.Location = new Point(i, Ty);
                        if (btn.Location.X == 406) break;
                    }
                }
                else if (btn.Location.X == 406 && btn.Location.Y == Ty)
                {
                    for (i = 406; i >= Tx; i--)
                    {
                        btn.Location = new Point(i, Ty);
                        if (btn.Location.X == 94) break;
                    }
                }
            
        }

        private void MoveButtonsRight()
        {
                if (btn.Location.X == 666 && btn.Location.Y == Ty)
                {
                    for (i = 666; i >= Tx; i++)
                    {
                        btn.Location = new Point(i, Ty);
                        if (btn.Location.X == 919) break;
                    }
                }
                else if (btn.Location.X == 406 && btn.Location.Y == Ty)
                {
                    for (i = 406; i >= Tx; i++)
                    {
                        btn.Location = new Point(i, Ty);
                        if (btn.Location.X == 666) break;
                    }
                }
                else if (btn.Location.X == 94 && btn.Location.Y == Ty)
                { 
                    for (i = 94; i >= Tx; i++)
                    {
                        btn.Location = new Point(i, Ty);
                        if (btn.Location.X == 406) break;
                    }
                }
            
        }

        private void MoveButtonsUp()
        {
            if (btnL.Visible == false && btnL.Location.X == Lx & btnL.Location.Y == 100 && 
                btnadministracion.Location.X == administracionX && btnadministracion.Location.Y == academicoY) {
                btnL.Location = new Point(Lx,517);
                btnL.Visible = true;
            }
            else if (btnL.Location.X == Lx && btnL.Location.Y == 517) { 
                for (i = 517; i >= Ly; i--) { 
                    btnL.Location = new Point(Lx, i); 
                    if (btnL.Location.Y == 357) break; }
                MovePanelButtonsUp();
            } else if (btnL.Location.X == Lx && btnL.Location.Y == 357) { 
                for (i = 357; i >= Ly; i--) { 
                    btnL.Location = new Point(Lx, i); 
                    if (btnL.Location.Y == 192) break; 
                }
            }
            
            
        }

        private void MoveButtonsDown()
        {
            if (btnL.Visible == false && btnL.Location.X == Lx & btnL.Location.Y == 100 &&
                btnadministrativo.Location.X == administrativoX && btnadministrativo.Location.Y == academicoY)
            {
                btnL.Location = new Point(Lx, 192);
                btnL.Visible = true;
            }else if (btnL.Location.X == Lx && btnL.Location.Y == 192){
                for (i = 192; i >= Ly; i++) { 
                    btnL.Location = new Point(Lx, i); 
                    if (btnL.Location.Y == 357) break; 
                }
                MovePanelButtonsDown();
            }else if (btnL.Location.X == Lx && btnL.Location.Y == 357){
                for (i = 357; i >= Ly; i++){
                    btnL.Location = new Point(Lx, i);
                    if (btnL.Location.Y == 517) break;
                }
            }
            
        }

        private void btnizquierda_Click_1(object sender, EventArgs e)
        {
            MoveButtonsLeft();
        }

        private void btnderecha_Click_1(object sender, EventArgs e)
        {
            MoveButtonsRight();
        }

        private void btnarriba_Click(object sender, EventArgs e)
        {
            if (btnL.Created)
            { MovePanelButtonsUp(); MoveButtonsUp();}
        }

        private void btnabajo_Click(object sender, EventArgs e)
        {
            if (btnL.Created)
            { MovePanelButtonsDown(); MoveButtonsDown();}
        }
    }
}
