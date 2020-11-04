namespace WindowsFormsApp1
{
    partial class EnderecoInserirFrm
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
            this.TxtCep = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtLogradouro = new System.Windows.Forms.TextBox();
            this.TxtUf = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCep
            // 
            this.TxtCep.Location = new System.Drawing.Point(260, 236);
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(225, 20);
            this.TxtCep.TabIndex = 5;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.Location = new System.Drawing.Point(428, 344);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 8;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.Location = new System.Drawing.Point(12, 78);
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.Size = new System.Drawing.Size(225, 20);
            this.TxtLogradouro.TabIndex = 0;
            // 
            // TxtUf
            // 
            this.TxtUf.Location = new System.Drawing.Point(12, 284);
            this.TxtUf.Name = "TxtUf";
            this.TxtUf.Size = new System.Drawing.Size(49, 20);
            this.TxtUf.TabIndex = 6;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(12, 236);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(225, 20);
            this.TxtCidade.TabIndex = 4;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(12, 185);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(225, 20);
            this.TxtBairro.TabIndex = 3;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(260, 78);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero.TabIndex = 1;
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(12, 136);
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(225, 20);
            this.TxtComplemento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logradouro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Número";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Complemento";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(12, 25);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(225, 20);
            this.TxtId.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID";
            // 
            // TxtPais
            // 
            this.TxtPais.Location = new System.Drawing.Point(12, 329);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(225, 20);
            this.TxtPais.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pais";
            // 
            // EnderecoInserirFrm
            // 
            this.AcceptButton = this.BtnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 379);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtPais);
            this.Controls.Add(this.TxtComplemento);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtUf);
            this.Controls.Add(this.TxtLogradouro);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtCep);
            this.Name = "EnderecoInserirFrm";
            this.Text = "Inserir Endereço";
            this.Load += new System.EventHandler(this.EnderecoInserirFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCep;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.TextBox TxtUf;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.Label label9;
    }
}