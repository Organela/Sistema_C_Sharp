namespace View
{
    partial class FormVagaDeletarBuscar
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
            this.Deletar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(171, 189);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(75, 23);
            this.Deletar.TabIndex = 5;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(33, 189);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(81, 112);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione o ID da vaga";
            // 
            // FormVagaDeletarBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Deletar);
            this.Name = "FormVagaDeletarBuscar";
            this.Text = "FormVagaDeletarBuscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
    }
}