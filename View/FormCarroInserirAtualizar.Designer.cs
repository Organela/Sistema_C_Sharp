namespace View
{
    partial class FormCarroInserirAtualizar
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
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.placa = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(23, 198);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(75, 23);
            this.Inserir.TabIndex = 1;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(170, 198);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 2;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(78, 96);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(167, 22);
            this.textBoxCliente.TabIndex = 3;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(78, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(167, 22);
            this.textBoxId.TabIndex = 4;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(78, 68);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(167, 22);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(78, 40);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(167, 22);
            this.textBoxPlaca.TabIndex = 6;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(20, 15);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 17);
            this.id.TabIndex = 7;
            this.id.Text = "Id";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // placa
            // 
            this.placa.AutoSize = true;
            this.placa.Location = new System.Drawing.Point(20, 40);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(43, 17);
            this.placa.TabIndex = 8;
            this.placa.Text = "Placa";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(20, 68);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(45, 17);
            this.nome.TabIndex = 9;
            this.nome.Text = "Nome";
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Location = new System.Drawing.Point(20, 99);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(51, 17);
            this.cliente.TabIndex = 10;
            this.cliente.Text = "Cliente";
            // 
            // FormCarroInserirAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.placa);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Inserir);
            this.Name = "FormCarroInserirAtualizar";
            this.Text = "FormCarro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label placa;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label cliente;
    }
}