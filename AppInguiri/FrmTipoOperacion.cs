using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Comun;

namespace AppInguiri
{
    public partial class FrmTipoOperacion : Form
    {
        #region Variables Privadas
        private TipoOperacionNegocio objPresenNeg = new TipoOperacionNegocio();
        private List<TipoOperacion> listPresenta = new List<TipoOperacion>();
        private bool estado = true;
        private static FrmTipoOperacion frmInstance = null;
        #endregion

        #region Principal Load
        //Singleton
        public static FrmTipoOperacion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmTipoOperacion();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public FrmTipoOperacion()
        {
            InitializeComponent();
        }

        private void FrmPresentacion_Load(object sender, EventArgs e)
        {
            CargarPresentacion();
        }
        #endregion

        #region Eventos
        private void FrmPresentacion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    BtnAgregar_Click(sender, e);
                    break;
                case Keys.F2:
                    BtnModificar_Click(sender, e);
                    break;
                case Keys.F3:
                    BtnRefrescar_Click(sender, e);
                    break;
                case Keys.F4:
                    BtnBuscar_Click(sender, e);
                    break;
                case Keys.F5:
                    BtnEliminar_Click(sender, e);
                    break;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            CargarPresentacion();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChkTodos_CheckedChanged(object sender, EventArgs e)
        {
            estado = ChkTodos.Checked;

            if (ChkTodos.Checked)
            {
                BtnEliminar.Image = Properties.Resources.X;
                BtnEliminar.Text = "&Eliminar  [F5]";
            }
            else
            {
                BtnEliminar.Image = Properties.Resources.xActivar;
                BtnEliminar.Text = "&Activar  [F5]";
            }

            CargarPresentacion();

        }

        #endregion

        #region Metodo Privados
        private void CargarPresentacion()
        {
            listPresenta.Clear();
            listPresenta = objPresenNeg.ListarTipoOperacion(estado);

            if (listPresenta.Count() > 0)
            {
                DgvPresentacion.AutoGenerateColumns = false;
                DgvPresentacion.DataSource = listPresenta;
                LblTotal.Text = "Se Encontraron " + DgvPresentacion.Rows.Count + " Registros";
            }
            else
            {
                DgvPresentacion.DataSource = null;
            }
        }
        private void Eliminar()
        {
            int respuesta = 0;

            if (DgvPresentacion.RowCount > 0)
            {
                string msg = "";
                if (estado) { estado = false; msg = "Eliminar"; }
                else { estado = true; msg = "Activar"; }

                DialogResult res;
                res = MessageBox.Show("¿Desea " + msg + " el registro?", "InguiriSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    int idPresSele = Convert.ToInt32(DgvPresentacion.CurrentRow.Cells[0].Value);

                    TipoOperacion objPre = new TipoOperacion()
                    {
                        nIdTipoOperacion = idPresSele,
                        bEstado = estado,
                        sUsuario = Funciones.UsuarioActual()
                    };

                    respuesta = objPresenNeg.EliminarActivarPresentacion(objPre);

                    if (respuesta == 1)
                    {
                        if (estado)
                        {
                            estado = false;
                            MessageBox.Show("Se Activó Correctamente", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            estado = true;
                            MessageBox.Show("Se Eliminó Correctamente", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        CargarPresentacion();
                    }
                }
                else
                {
                    if (estado) { estado = false; }
                    else { estado = true; }
                }
            }
            else
            {
                if (estado)
                {
                    MessageBox.Show("No se registran Presentación para eliminar", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    MessageBox.Show("No se registran Presentación para Activar", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Buscar()
        {
            if (DgvPresentacion.Rows.Count == 0) return;

            string presentacionporBuscar = Interaction.InputBox("", "Buscar Presentación...");

            if (!presentacionporBuscar.Equals(""))
            {
                List<TipoOperacion> dt = new List<TipoOperacion>();

                foreach (TipoOperacion col in listPresenta)
                {
                    if (col.sDescripcion.Contains(presentacionporBuscar.ToUpper()))
                    {
                        dt.Add(col);
                    }

                }
                if (dt.Count > 0)
                {
                    DgvPresentacion.DataSource = dt;
                }
                else
                {
                    DgvPresentacion.DataSource = null;
                }
            }
            else
            {
                DgvPresentacion.DataSource = listPresenta;
            }
        }

        private void Modificar()
        {
            if (DgvPresentacion.Rows.Count == 0) return;

            TipoOperacion obj =(TipoOperacion)DgvPresentacion.CurrentRow.DataBoundItem;
            
            FrmTipoOperacionActualiza frmPresent = new FrmTipoOperacionActualiza(obj);
            //frmPresent.MdiParent = this.MdiParent;
            frmPresent.frmTipoOperacion = this;
            frmPresent.tipo = 3;
            frmPresent.Text = "Actualizar Presentación De Productos";

            if (frmPresent.ShowDialog() == DialogResult.OK)
            {
                CargarPresentacion();
            }

        }
        //validar que solo se acepten letras en la descripcion
        private void Agregar()
        {
            FrmTipoOperacionActualiza frmPresent = new FrmTipoOperacionActualiza();
            //frmPresent.MdiParent = this.MdiParent;
            frmPresent.frmTipoOperacion = this;
            frmPresent.tipo = 2;
            frmPresent.Text = "Registar Presentación De Productos";

            if (frmPresent.ShowDialog() == DialogResult.OK)
            {
                CargarPresentacion();
            }
        }
        #endregion
    }
}
