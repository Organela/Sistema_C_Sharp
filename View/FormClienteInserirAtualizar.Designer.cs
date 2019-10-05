namespace View
{
    partial class FormClienteInserirAtualizar
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxtTel = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.Inserir = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(92, 29);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 0;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(92, 74);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxtTel
            // 
            this.textBoxtTel.Location = new System.Drawing.Point(92, 123);
            this.textBoxtTel.Name = "textBoxtTel";
            this.textBoxtTel.Size = new System.Drawing.Size(100, 22);
            this.textBoxtTel.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(21, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 17);
            this.id.TabIndex = 3;
            this.id.Text = "Id";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(21, 79);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(45, 17);
            this.nome.TabIndex = 4;
            this.nome.Text = "Nome";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(21, 123);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(28, 17);
            this.tel.TabIndex = 5;
            this.tel.Text = "Tel";
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(24, 197);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(75, 23);
            this.Inserir.TabIndex = 6;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(140, 197);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 7;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            // 
            // FormClienteInserirAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBoxtTel);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxId);
            this.Name = "FormClienteInserirAtualizar";
            this.Text = "FormInserirAtualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxtTel;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Atualizar;
    }
}