using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.Identity.Client;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Xml;

namespace LOGICA
{
    public class DB : SistemaEducacionContext
    {
        LHelpers lh = new LHelpers();

        public Int32 SaveContent(string[] txt, int ntable, Boolean[] Tc = null)
        {
            Int32 res = 0;
            if (ntable == 1) {
                using (var db = new SistemaEducacionContext())
                {
                    var d = new ActividadesCulturale
                    {
                        Actividad = txt[0].ToString(),
                        Descripcion = txt[1].ToString(),
                        Fecha = Convert.ToDateTime(txt[2]),
                        Responsable = txt[3].ToString()
                    };
                    db.ActividadesCulturales.Add(d);
                    db.SaveChanges();
                }
                res++;
            }
            return res;
        }

        public Int32 UpdateContent(string[] lista, int ntable, Boolean[] Tc = null)
        {
            Int32 res = 0;
            if (ntable == 1) {
                using (var db = new SistemaEducacionContext()) {
                    var d = db.ActividadesCulturales.Single(b => b.Id == Convert.ToInt64(lista[0]));
                    d.Actividad = lista[1].ToString();
                    d.Descripcion = lista[2].ToString();
                    d.Fecha = Convert.ToDateTime(lista[3]);
                    d.Responsable = lista[4].ToString();
                    db.SaveChanges();
                    res++;

                }
            }

            return res;
        }

        public Int32 DeleteContent(string lista, int ntable)
        {
            Int32 res = 0;
            if (ntable == 1) {
                using (var db = new SistemaEducacionContext()) {
                    var d = db.ActividadesCulturales.Single(b => b.Id == Convert.ToInt64(lista));
                    db.ActividadesCulturales.Remove(d);
                    db.SaveChanges();
                    res++;

                }
            }

            return res;
        }

        public void LoadDataDGV(DataGridView DGV, int ntable)
        {
            DGV.Rows.Clear();
            if (ntable == 1)
            {
                using (var db = new SistemaEducacionContext())
                {
                    var d = db.ActividadesCulturales.ToList();
                    foreach (var data in d)
                    {
                        DGV.Rows.Add(data.Id,
                                            data.Actividad,
                                            data.Descripcion,
                                            data.Fecha,
                                            data.Responsable);
                    }
                }
            }
        }


        public void Search(ref DataGridView DGV, int ntable, string txt = "", int id = 0)
        {
            DGV.Rows.Clear();
            if (ntable == 1) {
                using (var db = new SistemaEducacionContext()) {
                    var d = db.ActividadesCulturales.Where(c => c.Id.Equals(id)).ToList();
                    foreach (var cd in d) {
                        DGV.Rows.Add(cd.Id,
                                          cd.Actividad,
                                          cd.Descripcion,
                                          cd.Fecha,
                                          cd.Responsable);
                    }
                }
            }
        }

        //public void loadclients(ComboBox cmb)
        //{
        //    using (var db = new SistemaEducacionContext()) {
        //        var d = db.Clientes.ToList();
        //        //quitar Clientes y colocar el nombre del la tabla que se necesite

        //        cmb.DataSource = d;
        //        cmb.ValueMember = "IDCLIENTE";
        //        cmb.DisplayMember = "NOMBRE";
        //        cmb.SelectedIndex = -1;
        //        //reemplaar IDCLIENTE POR EL ID O LLAVE PRIMARIA DE LA TABLA que se necesite
        //        //reemplaar NOMBRE por el campos que se quiera ver 
        //    }
        //}

        public Int32 LoginUser(string[] txt)
        {
            Int32 res = 0;
            using (var db = new SistemaEducacionContext()) {
                var u = db.Usuarios.Where(c => c.Usuario1.Contains(txt[0]) && c.Pass.Contains(txt[1])).ToList();
                res = u.Count > 0 ? 1 : 0;
            }
            return res;
        }
    } 
} 

