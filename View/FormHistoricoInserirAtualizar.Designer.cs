namespace View
{
    partial class FormHistoricoInserirAtualizar
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
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.vaga = new System.Windows.Forms.Label();
            this.funcionario = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxCarro = new System.Windows.Forms.TextBox();
            this.textBoxVaga = new System.Windows.Forms.TextBox();
            this.textBoxFuncionario = new System.Windows.Forms.TextBox();
            this.atualizar = new System.Windows.Forms.Button();
            this.inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(116, 22);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(154, 22);
            this.textBoxData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carro";
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.Location = new System.Drawing.Point(12, 62);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(45, 17);
            this.preco.TabIndex = 3;
            this.preco.Text = "Preço";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(12, 25);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(38, 17);
            this.data.TabIndex = 4;
            this.data.Text = "Data";
            // 
            // vaga
            // 
            this.vaga.AutoSize = true;
            this.vaga.Location = new System.Drawing.Point(12, 138);
            this.vaga.Name = "vaga";
            this.vaga.Size = new System.Drawing.Size(41, 17);
            this.vaga.TabIndex = 5;
            this.vaga.Text = "Vaga";
            // 
            // funcionario
            // 
            this.funcionario.AutoSize = true;
            this.funcionario.Location = new System.Drawing.Point(12, 181);
            this.funcionario.Name = "funcionario";
            this.funcionario.Size = new System.Drawing.Size(82, 17);
            this.funcionario.TabIndex = 6;
            this.funcionario.Text = "Funcionário";
            this.funcionario.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(116, 62);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(154, 22);
            this.textBoxPreco.TabIndex = 7;
            // 
            // textBoxCarro
            // 
            this.textBoxCarro.Location = new System.Drawing.Point(116, 98);
            this.textBoxCarro.Name = "textBoxCarro";
            this.textBoxCarro.Size = new System.Drawing.Size(154, 22);
            this.textBoxCarro.TabIndex = 8;
            // 
            // textBoxVaga
            // 
            this.textBoxVaga.Location = new System.Drawing.Point(116, 138);
            this.textBoxVaga.Name = "textBoxVaga";
            this.textBoxVaga.Size = new System.Drawing.Size(154, 22);
            this.textBoxVaga.TabIndex = 9;
            // 
            // textBoxFuncionario
            // 
            this.textBoxFuncionario.Location = new System.Drawing.Point(116, 181);
            this.textBoxFuncionario.Name = "textBoxFuncionario";
            this.textBoxFuncionario.Size = new System.Drawing.Size(154, 22);
            this.textBoxFuncionario.TabIndex = 10;
            // 
            // atualizar
            // 
            this.atualizar.Location = new System.Drawing.Point(35, 218);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(75, 23);
            this.atualizar.TabIndex = 11;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // inserir
            // 
            this.inserir.Location = new System.Drawing.Point(158, 218);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(75, 23);
            this.inserir.TabIndex = 12;
            this.inserir.Text = "Inserir";
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click);
            // 
            // FormHistoricoInserirAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.textBoxFuncionario);
            this.Controls.Add(this.textBoxVaga);
            this.Controls.Add(this.textBoxCarro);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.funcionario);
            this.Controls.Add(this.vaga);
            this.Controls.Add(this.data);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxData);
            this.Name = "FormHistoricoInserirAtualizar";
            this.Text = "formHistoricoInserir";
            this.Load += new System.EventHandler(this.formHistoricoInserir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label vaga;
        private System.Windows.Forms.Label funcionario;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.TextBox textBoxCarro;
        private System.Windows.Forms.TextBox textBoxVaga;
        private System.Windows.Forms.TextBox textBoxFuncionario;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button inserir;
    }
}