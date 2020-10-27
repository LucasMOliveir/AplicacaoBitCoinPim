using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoDeTransferencia;
using Negocios;


namespace WindowsFormsApp1
{
    public partial class TelaLoginFrm : Form
    {
        public TelaLoginFrm()
        {
            InitializeComponent();
        }

        private void lk_EsqueciMinhaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioFuncionario usuarioFuncionario = new UsuarioFuncionario();

            usuarioFuncionario.FuncionarioId = int.Parse(txtUsuario.Text);
            usuarioFuncionario.Senha = txtSenha.Text;

            LogInNegocio logInNegocio = new LogInNegocio();

            if(logInNegocio.ValidarLogIn(usuarioFuncionario) == "1")
            {
                this.Hide();
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Text = "";
                txtUsuario.Text = "";
                return;
            }
        }
    }
}