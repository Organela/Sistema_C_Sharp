namespace View
{
    partial class FormVagaInserirAtualizar
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.id = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(12, 201);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(75, 23);
            this.Inserir.TabIndex = 2;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(174, 201);
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
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(282, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(12, 46);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 17);
            this.id.TabIndex = 8;
            this.id.Text = "Id";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 107);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(48, 17);
            this.status.TabIndex = 9;
            this.status.Text = "Status";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(133, 102);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 22);
            this.textBoxStatus.TabIndex = 10;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(133, 41);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 11;
            // 
            // FormVagaInserirAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.status);
            this.Controls.Add(this.id);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Inserir);
            this.Name = "FormVagaInserirAtualizar";
            this.Text = "FormVaga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxId;
    }
}