namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.lk_EsqueciMinhaSenha = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(254, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(254, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 1;
            // 
            // bt_entrar
            // 
            this.bt_entrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_entrar.FlatAppearance.BorderSize = 0;
            this.bt_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_entrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_entrar.Location = new System.Drawing.Point(274, 343);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(156, 34);
            this.bt_entrar.TabIndex = 3;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = false;
            // 
            // lk_EsqueciMinhaSenha
            // 
            this.lk_EsqueciMinhaSenha.AutoSize = true;
            this.lk_EsqueciMinhaSenha.BackColor = System.Drawing.Color.White;
            this.lk_EsqueciMinhaSenha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lk_EsqueciMinhaSenha.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lk_EsqueciMinhaSenha.Location = new System.Drawing.Point(251, 315);
            this.lk_EsqueciMinhaSenha.Name = "lk_EsqueciMinhaSenha";
            this.lk_EsqueciMinhaSenha.Size = new System.Drawing.Size(121, 15);
            this.lk_EsqueciMinhaSenha.TabIndex = 2;
            this.lk_EsqueciMinhaSenha.TabStop = true;
            this.lk_EsqueciMinhaSenha.Text = "Esqueci minha senha";
            this.lk_EsqueciMinhaSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_EsqueciMinhaSenha_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lk_EsqueciMinhaSenha);
            this.Controls.Add(this.bt_entrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Tela de Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.LinkLabel lk_EsqueciMinhaSenha;
    }
}

