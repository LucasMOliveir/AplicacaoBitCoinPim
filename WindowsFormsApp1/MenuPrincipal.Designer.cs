namespace WindowsFormsApp1
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCadastroEndereço = new System.Windows.Forms.Button();
            this.BtnInclusaoEAprovacao = new System.Windows.Forms.Button();
            this.BtnGerenciarPedidosERequisicoes = new System.Windows.Forms.Button();
            this.BtnCadastroDeUsuarios = new System.Windows.Forms.Button();
            this.BtnCadastroDeFuncionario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnCadastroEndereço);
            this.panel1.Controls.Add(this.BtnInclusaoEAprovacao);
            this.panel1.Controls.Add(this.BtnGerenciarPedidosERequisicoes);
            this.panel1.Controls.Add(this.BtnCadastroDeUsuarios);
            this.panel1.Controls.Add(this.BtnCadastroDeFuncionario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 79);
            this.panel1.TabIndex = 1;
            // 
            // BtnCadastroEndereço
            // 
            this.BtnCadastroEndereço.BackColor = System.Drawing.Color.Transparent;
            this.BtnCadastroEndereço.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroEndereço.Location = new System.Drawing.Point(848, 0);
            this.BtnCadastroEndereço.Name = "BtnCadastroEndereço";
            this.BtnCadastroEndereço.Size = new System.Drawing.Size(190, 79);
            this.BtnCadastroEndereço.TabIndex = 1;
            this.BtnCadastroEndereço.Text = "Cadastrar Endereço";
            this.BtnCadastroEndereço.UseVisualStyleBackColor = false;
            this.BtnCadastroEndereço.Click += new System.EventHandler(this.BtnCadastroEndereço_Click);
            // 
            // BtnInclusaoEAprovacao
            // 
            this.BtnInclusaoEAprovacao.BackColor = System.Drawing.Color.Transparent;
            this.BtnInclusaoEAprovacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInclusaoEAprovacao.Location = new System.Drawing.Point(636, 0);
            this.BtnInclusaoEAprovacao.Name = "BtnInclusaoEAprovacao";
            this.BtnInclusaoEAprovacao.Size = new System.Drawing.Size(213, 79);
            this.BtnInclusaoEAprovacao.TabIndex = 0;
            this.BtnInclusaoEAprovacao.Text = "Inclusão e aprovação de pedidos";
            this.BtnInclusaoEAprovacao.UseVisualStyleBackColor = false;
            // 
            // BtnGerenciarPedidosERequisicoes
            // 
            this.BtnGerenciarPedidosERequisicoes.BackColor = System.Drawing.Color.Transparent;
            this.BtnGerenciarPedidosERequisicoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerenciarPedidosERequisicoes.Location = new System.Drawing.Point(424, 0);
            this.BtnGerenciarPedidosERequisicoes.Name = "BtnGerenciarPedidosERequisicoes";
            this.BtnGerenciarPedidosERequisicoes.Size = new System.Drawing.Size(213, 79);
            this.BtnGerenciarPedidosERequisicoes.TabIndex = 0;
            this.BtnGerenciarPedidosERequisicoes.Text = "Gerenciar pedidos e requisições";
            this.BtnGerenciarPedidosERequisicoes.UseVisualStyleBackColor = false;
            // 
            // BtnCadastroDeUsuarios
            // 
            this.BtnCadastroDeUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BtnCadastroDeUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroDeUsuarios.Image = global::WindowsFormsApp1.Properties.Resources.User_Clients_icon1;
            this.BtnCadastroDeUsuarios.Location = new System.Drawing.Point(212, 0);
            this.BtnCadastroDeUsuarios.Name = "BtnCadastroDeUsuarios";
            this.BtnCadastroDeUsuarios.Size = new System.Drawing.Size(213, 79);
            this.BtnCadastroDeUsuarios.TabIndex = 0;
            this.BtnCadastroDeUsuarios.Text = "Cadastro de Usuários";
            this.BtnCadastroDeUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCadastroDeUsuarios.UseVisualStyleBackColor = false;
            this.BtnCadastroDeUsuarios.Click += new System.EventHandler(this.BtnCadastroDeUsuarios_Click);
            // 
            // BtnCadastroDeFuncionario
            // 
            this.BtnCadastroDeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.BtnCadastroDeFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroDeFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadastroDeFuncionario.Image")));
            this.BtnCadastroDeFuncionario.Location = new System.Drawing.Point(0, 0);
            this.BtnCadastroDeFuncionario.Name = "BtnCadastroDeFuncionario";
            this.BtnCadastroDeFuncionario.Size = new System.Drawing.Size(213, 79);
            this.BtnCadastroDeFuncionario.TabIndex = 0;
            this.BtnCadastroDeFuncionario.Text = "Cadastro de Funcionario";
            this.BtnCadastroDeFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCadastroDeFuncionario.UseVisualStyleBackColor = false;
            this.BtnCadastroDeFuncionario.Click += new System.EventHandler(this.BtnCadastroDeFuncionario_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 891);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGerenciarPedidosERequisicoes;
        private System.Windows.Forms.Button BtnCadastroDeUsuarios;
        private System.Windows.Forms.Button BtnCadastroDeFuncionario;
        private System.Windows.Forms.Button BtnInclusaoEAprovacao;
        private System.Windows.Forms.Button BtnCadastroEndereço;
    }
}