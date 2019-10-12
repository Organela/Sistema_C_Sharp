namespace View
{
    partial class FormLogin
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
            this.Login = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.NaoSouRobo = new System.Windows.Forms.CheckBox();
            this.textLogin = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(12, 37);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(43, 17);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(6, 105);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(49, 17);
            this.Senha.TabIndex = 2;
            this.Senha.Text = "Senha";
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(61, 105);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(169, 22);
            this.textSenha.TabIndex = 4;
            this.textSenha.UseSystemPasswordChar = true;
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(15, 145);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 43);
            this.Entrar.TabIndex = 5;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(9, 196);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(97, 39);
            this.Cadastrar.TabIndex = 6;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            // 
            // NaoSouRobo
            // 
            this.NaoSouRobo.AutoSize = true;
            this.NaoSouRobo.Location = new System.Drawing.Point(14, 55);
            this.NaoSouRobo.Name = "NaoSouRobo";
            this.NaoSouRobo.Size = new System.Drawing.Size(144, 21);
            this.NaoSouRobo.TabIndex = 7;
            this.NaoSouRobo.Text = "Não sou um Robô";
            this.NaoSouRobo.UseVisualStyleBackColor = true;
            // 
            // textLogin
            // 
            this.textLogin.FormattingEnabled = true;
            this.textLogin.Location = new System.Drawing.Point(61, 34);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(169, 24);
            this.textLogin.TabIndex = 8;
            this.textLogin.SelectedIndexChanged += new System.EventHandler(this.textLogin_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(61, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Salvar Login";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NaoSouRobo);
            this.groupBox1.Location = new System.Drawing.Point(112, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teste de Robô";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Login);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.CheckBox NaoSouRobo;
        private System.Windows.Forms.ComboBox textLogin;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

