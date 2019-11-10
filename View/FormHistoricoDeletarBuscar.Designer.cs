namespace View
{
    partial class FormHistoricoDeletarBuscar
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
            this.Deletar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(49, 309);
            this.Deletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(75, 23);
            this.Deletar.TabIndex = 4;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(253, 309);
            this.Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escolher data para Buscar ou Deletar";
            // 
            // TextBoxData
            // 
            this.TextBoxData.Location = new System.Drawing.Point(273, 196);
            this.TextBoxData.Name = "TextBoxData";
            this.TextBoxData.Size = new System.Drawing.Size(100, 22);
            this.TextBoxData.TabIndex = 8;
            // 
            // FormHistoricoDeletarBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 399);
            this.Controls.Add(this.TextBoxData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Deletar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHistoricoDeletarBuscar";
            this.Text = "FormHistorico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxData;
    }
}