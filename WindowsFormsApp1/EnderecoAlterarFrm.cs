using Negocios;
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

namespace WindowsFormsApp1
{
    public partial class EnderecoAlterarFrm : Form
    {
        public EnderecoAlterarFrm()
        {
            InitializeComponent();
        }

        public EnderecoAlterarFrm(Endereco endereco)
        {
            InitializeComponent();

            TxtId.Text = endereco.EnderecoId.ToString();
            TxtLogradouro.Text = endereco.Logradouro.ToString();
            TxtNumero.Text = endereco.Numero.ToString();
            TxtBairro.Text = endereco.Bairro.ToString();
            TxtCidade.Text = endereco.Cidade.ToString();
            TxtUf.Text = endereco.UF.ToString();
            TxtPais.Text = endereco.Pais.ToString();
            TxtCep.Text = endereco.Cep.ToString();
            TxtComplemento.Text = endereco.Complemento.ToString();

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();

            endereco.EnderecoId = int.Parse(TxtId.Text);
            endereco.Logradouro = TxtLogradouro.Text;
            endereco.Numero = TxtNumero.Text;
            endereco.Bairro = TxtBairro.Text;
            endereco.Cidade = TxtCidade.Text;
            endereco.UF = TxtUf.Text;
            endereco.Pais = TxtPais.Text;
            endereco.Cep = TxtCep.Text;
            endereco.Complemento = TxtComplemento.Text;

            enderecoNegocios.AlterarEndereco(endereco);
            this.Close();
        }
    }
}
