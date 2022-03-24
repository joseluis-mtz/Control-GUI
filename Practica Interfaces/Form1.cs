using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            personalizarDisenio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void personalizarDisenio()
        {
            pnlMenuClientes.Visible = false;
            pnlMenuUsuarios.Visible = false;
            pnlMenuCatalogos.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (pnlMenuClientes.Visible == true)
            {
                pnlMenuClientes.Visible = false;
            }

            if (pnlMenuUsuarios.Visible == true)
            {
                pnlMenuUsuarios.Visible = false;
            }

            if (pnlMenuCatalogos.Visible == true)
            {
                pnlMenuCatalogos.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlMenuClientes);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlMenuUsuarios);
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlMenuCatalogos);
        }
        private Form formularioActivo = null;
        private void abrirFormulario(Form formHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formHijo);
            pnlContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnClienteCrear_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmClientesCrear());
        }
    }
}
