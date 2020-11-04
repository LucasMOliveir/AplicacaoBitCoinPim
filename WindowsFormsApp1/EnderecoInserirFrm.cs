using Microsoft.Win32;
using ObjetoDeTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace WindowsFormsApp1
{
    public partial class EnderecoInserirFrm : Form
    {
        public EnderecoInserirFrm()
        {
            InitializeComponent();
        }

        Endereco endereco = new Endereco();
        EnderecoNegocios enderecoNegocios = new EnderecoNegocios();

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if ((TxtLogradouro.TextLength > 0) && (TxtNumero.TextLength > 0) && (TxtBairro.TextLength > 0) && (TxtCidade.TextLength > 0) && (TxtUf.TextLength > 0 ) && (TxtPais.TextLength > 0) && (TxtComplemento.TextLength > 0) && (TxtCep.TextLength > 0))
            {
                endereco.Logradouro = TxtLogradouro.Text;
                endereco.Numero = TxtNumero.Text;
                endereco.Bairro = TxtBairro.Text;
                endereco.Cidade = TxtCidade.Text;
                endereco.UF = TxtUf.Text;
                endereco.Pais = TxtPais.Text;
                endereco.Complemento = TxtComplemento.Text;
                endereco.Cep = TxtCep.Text;

                enderecoNegocios.InserirEndereco(endereco);
                
                this.Close();

            }
            else
            {
                MessageBox.Show("Campos invalidos");
            }
        }

        private void EnderecoInserirFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
