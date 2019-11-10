namespace View
{
    partial class FormFuncionarioInserirAtualizar
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
            this.components = new System.ComponentModel.Container();
            this.Inserir = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.id = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(51, 218);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(75, 23);
            this.Inserir.TabIndex = 2;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(156, 218);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 3;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(22, 17);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 17);
            this.id.TabIndex = 4;
            this.id.Text = "Id";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(22, 53);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(45, 17);
            this.nome.TabIndex = 5;
            this.nome.Text = "Nome";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(22, 93);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(28, 17);
            this.tel.TabIndex = 6;
            this.tel.Text = "Tel";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(145, 93);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(100, 22);
            this.textBoxTel.TabIndex = 7;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(145, 53);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 22);
            this.textBoxNome.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(145, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 9;
            // 
            // FormFuncionarioInserirAtulizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Inserir);
            this.Name = "FormFuncionarioInserirAtulizar";
            this.Text = "FormFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxId;
    }
}