using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearRegistroConDetalle
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void rUsuariosButton_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroUsuarios registrarUsuario = new UI.Registros.RegistroUsuarios();
            registrarUsuario.Show();
        }

        private void rRolesButton_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroRoles registrarRoles = new UI.Registros.RegistroRoles();
            registrarRoles.Show();
        }
    }
}
