using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class LHelpers
    {
        MessageBoxButtons boton = MessageBoxButtons.OK;
        MessageBoxIcon icono = MessageBoxIcon.Information;
        //poner mensaje de exito para guardar, eliminar y actualizar
        public void CudFrmSuccesfuly(string msg)
        {
            MessageBoxIcon icono = MessageBoxIcon.Exclamation;
            if (msg == "c" || msg == "C") MessageBox.Show("Se han guardado exitosamente los datos", "EXITO", boton, icono);
            else if (msg == "d" || msg == "D") MessageBox.Show("Se han eliminado exitosamente los datos", "EXITO", boton, icono);
            else if (msg == "u" || msg == "U") MessageBox.Show("Se han actualizado exitosamente los datos", "EXITO", boton, icono);
            else MessageBox.Show("PON BIEN LA LETRA PARA QUE APAREZCA EL MENSAJE");
        }
        //

        public string CleanSQL(string str)
        {
            string strout = "";
            string[] forbiddenchars = { "'", "=", "<", ">", ";", "\\", "?", "!", "´", "¿", "¡", "/" };
            int i, j,coinc;

            for (i = 0; i < str.Length; i++)
            {
                coinc = 0;
                for (j = 0; j < forbiddenchars.Length; j++) coinc = str.Substring(i, 1) == forbiddenchars[j] ? coinc + 1 : coinc = 0;
                strout = coinc == 0 ? strout + str.Substring(i, 1) : strout;
            }
            return strout;
        }

        public Int32 Validar(string[] txts)
        {
            Int32 res = 0;
            foreach (string v in txts)
            {
                if (v.Length == 0)
                {
                    Warning("Es necesario poner información");
                    res++;
                    return res;
                }
            }
            return res;
        }

        public void ABRIRfrm(object formhijo, Panel P)
        {
            if (P.Controls.Count > 0) P.Controls.RemoveAt(0);
            Form frm = formhijo as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            P.Controls.Add(frm);
            P.Tag = frm;
            frm.Show();
        }

        public void ShowNumber(int num = 0, double num1 = 0, float num2 = 0, long num3 = 0, short num4 = 0)
        {
            if (num > 0) MessageBox.Show(num.ToString());
            else if (num1 > 0) MessageBox.Show(num1.ToString());
            else if (num2 > 0) MessageBox.Show(num2.ToString());
            else if (num3 > 0) MessageBox.Show(num3.ToString());
            else if (num4 > 0) MessageBox.Show(num4.ToString());
        }

        public bool Question(string msg)
        {
            bool resp = false;
            MessageBoxButtons opciones = MessageBoxButtons.YesNo;
            MessageBoxIcon iconos = MessageBoxIcon.Question;
            if (MessageBox.Show(msg, "CONFIRMAR", opciones, iconos) == DialogResult.Yes) resp = true;
            return resp;
        }

        public void Succes(string msg, string titulo = "EXITO") => MessageBox.Show(msg, titulo, boton, icono);

        public void Warning(string msg, string titulo = "ATENCION") => MessageBox.Show(msg, titulo);

        public void Info(string msg, string titulo = "INFORMACION") => MessageBox.Show(msg, titulo, boton, icono);

        public Boolean Onlystrings(KeyPressEventArgs e)
        {
            Boolean res = false;

            if (e.KeyChar == (char)32 || char.IsLetter(e.KeyChar) || e.KeyChar == (char)8) res = true; 

            return res;
        }

        public Boolean Money(KeyPressEventArgs e)
        {
            Boolean resp = false;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (Char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8) resp = true;
            return resp;
        }

        public bool OnlyNumber(KeyPressEventArgs e)
        {
            Boolean resp = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)resp = true;
            return resp;
        }
    }
}
