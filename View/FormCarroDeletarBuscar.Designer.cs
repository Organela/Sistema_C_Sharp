namespace View
{
    partial class FormCarroDeletarBuscar
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
            this.id = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.deletar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(60, 69);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(147, 17);
            this.id.TabIndex = 0;
            this.id.Text = "Selecione id desejado";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(62, 105);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(145, 22);
            this.textId.TabIndex = 1;
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(46, 165);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(75, 23);
            this.deletar.TabIndex = 2;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(150, 165);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 3;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // FormCarroDeletarBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.id);
            this.Name = "FormCarroDeletarBuscar";
            this.Text = "FormCarroDeletarBuscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button buscar;
    }
}