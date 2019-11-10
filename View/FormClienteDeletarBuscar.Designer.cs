namespace View
{
    partial class FormClienteDeletarBuscar
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
            this.deletar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(48, 167);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(75, 23);
            this.deletar.TabIndex = 3;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(177, 167);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(87, 106);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(145, 22);
            this.textId.TabIndex = 5;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(85, 74);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(147, 17);
            this.id.TabIndex = 6;
            this.id.Text = "Selecione id desejado";
            // 
            // FormClienteDeletarBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 253);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.deletar);
            this.Name = "FormClienteDeletarBuscar";
            this.Text = "FormClienteDeletarBuscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label id;
    }
}