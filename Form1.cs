using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_datagridview_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txt_nombre.Text) && !string.IsNullOrWhiteSpace(txt_correo.Text))
            {
                dgv_datos.Rows.Add(txt_nombre.Text, txt_correo.Text);
                txt_nombre.Clear();
                txt_correo.Clear();
                txt_nombre.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_datos.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int fila;
                fila = dgv_datos.CurrentRow.Index;
                DialogResult respuesta;
                respuesta = MessageBox.Show("Este seguro que desea eliminar este registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    dgv_datos.Rows.RemoveAt(fila);
                    MessageBox.Show("Registro eliminado");

                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            dgv_datos.Rows.Add(txt_nombre.Text, txt_correo.Text);
            txt_nombre.Clear();
            txt_correo.Clear();
            txt_nombre.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
