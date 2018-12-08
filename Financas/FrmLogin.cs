using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "daniel" && txtSenha.Text == "123")
            {
                //this.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Close();
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario e/ou senha inválidos!");
                
            }
        }
    }
}
