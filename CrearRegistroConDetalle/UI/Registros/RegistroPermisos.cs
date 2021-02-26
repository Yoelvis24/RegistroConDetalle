using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrearRegistroConDetalle.DAL;
using CrearRegistroConDetalle.Entidades;
using CrearRegistroConDetalle.BLL;

namespace CrearRegistroConDetalle.UI.Registros
{
    public partial class RegistroPermisos : Form
    {
        public RegistroPermisos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            PermisoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
        }

        private bool Validar()
        {
            bool paso = true;

            if (DescripcionTextBox.Text == "")
            {
                PermisosErrorProvider.SetError(DescripcionTextBox, "Campo obligatorio");
                paso = false;
            }

            return paso;
        }


        private Permisos LlenaClase()
        {
            Permisos permisos = new Permisos();
            permisos.PermisoId = (int)PermisoIdNumericUpDown.Value;
            permisos.Descripcion = DescripcionTextBox.Text;

            return permisos;
        }

        private void LLenaCampos(Permisos permisos)
        {
            PermisoIdNumericUpDown.Value = permisos.PermisoId;
            DescripcionTextBox.Text = permisos.Descripcion;
        }

        private bool ExisteEnBaseDeDatos()
        {
            var permisos = new Permisos();
            permisos = PermisosBLL.Buscar((int)PermisoIdNumericUpDown.Value);

            return (permisos != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var permisos = new Permisos();
            int id = (int)PermisoIdNumericUpDown.Value;

            Limpiar();
            permisos = PermisosBLL.Buscar(id);
            if (permisos != null)
            {
                LLenaCampos(permisos);
            }
            else
            {
                MessageBox.Show("Permiso no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Permisos permisos;
            bool paso = false;

            if (!Validar())
                return;
            permisos = LlenaClase();

            //Determinar si es guardar o modificar
            if (PermisoIdNumericUpDown.Value == 0)
            {
                paso = PermisosBLL.Guardar(permisos, DescripcionTextBox.Text);
            }
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un permiso que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PermisosBLL.Modificar(permisos);
            }
            if (paso)
            {
                Limpiar();
                MessageBox.Show("El permiso ha sido guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)PermisoIdNumericUpDown.Value;
            PermisosErrorProvider.Clear();

            if (PermisosBLL.Eliminar(id))
            {
                MessageBox.Show("El permiso ha sido eliminado", "Logrado");
                Limpiar();
            }
            else
                PermisosErrorProvider.SetError(PermisoIdNumericUpDown, "Este Id no existe");
        }
    }
}
