namespace View
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.deletarBuscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirAtualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarBuscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirAtualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarBuscarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirAtualizarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarBuscarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirAtualizarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarBuscarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirAtualizarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.carroToolStripMenuItem,
            this.vagaToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.historicoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarBuscarToolStripMenuItem,
            this.inserirAtualizarToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // carroToolStripMenuItem
            // 
            this.carroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarBuscarToolStripMenuItem1,
            this.inserirAtualizarToolStripMenuItem1,
            this.listarToolStripMenuItem1});
            this.carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            this.carroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.carroToolStripMenuItem.Text = "Carro";
            this.carroToolStripMenuItem.Click += new System.EventHandler(this.carroToolStripMenuItem_Click);
            // 
            // vagaToolStripMenuItem
            // 
            this.vagaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarBuscarToolStripMenuItem2,
            this.inserirAtualizarToolStripMenuItem2,
            this.listarToolStripMenuItem2});
            this.vagaToolStripMenuItem.Name = "vagaToolStripMenuItem";
            this.vagaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vagaToolStripMenuItem.Text = "Vaga";
            this.vagaToolStripMenuItem.Click += new System.EventHandler(this.vagaToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarBuscarToolStripMenuItem3,
            this.inserirAtualizarToolStripMenuItem3,
            this.listarToolStripMenuItem3});
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarBuscarToolStripMenuItem4,
            this.inserirAtualizarToolStripMenuItem4,
            this.listarToolStripMenuItem4});
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historicoToolStripMenuItem.Text = "Historico";
            this.historicoToolStripMenuItem.Click += new System.EventHandler(this.historicoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 162);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 213);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(349, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusStrip1.Location = new System.Drawing.Point(325, 49);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 18);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(24, 183);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // deletarBuscarToolStripMenuItem
            // 
            this.deletarBuscarToolStripMenuItem.Name = "deletarBuscarToolStripMenuItem";
            this.deletarBuscarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deletarBuscarToolStripMenuItem.Text = "Deletar_Buscar";
            // 
            // inserirAtualizarToolStripMenuItem
            // 
            this.inserirAtualizarToolStripMenuItem.Name = "inserirAtualizarToolStripMenuItem";
            this.inserirAtualizarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.inserirAtualizarToolStripMenuItem.Text = "Inserir_Atualizar";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // deletarBuscarToolStripMenuItem1
            // 
            this.deletarBuscarToolStripMenuItem1.Name = "deletarBuscarToolStripMenuItem1";
            this.deletarBuscarToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.deletarBuscarToolStripMenuItem1.Text = "Deletar_Buscar";
            // 
            // inserirAtualizarToolStripMenuItem1
            // 
            this.inserirAtualizarToolStripMenuItem1.Name = "inserirAtualizarToolStripMenuItem1";
            this.inserirAtualizarToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.inserirAtualizarToolStripMenuItem1.Text = "Inserir_Atualizar";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            // 
            // deletarBuscarToolStripMenuItem2
            // 
            this.deletarBuscarToolStripMenuItem2.Name = "deletarBuscarToolStripMenuItem2";
            this.deletarBuscarToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.deletarBuscarToolStripMenuItem2.Text = "Deletar_Buscar";
            // 
            // inserirAtualizarToolStripMenuItem2
            // 
            this.inserirAtualizarToolStripMenuItem2.Name = "inserirAtualizarToolStripMenuItem2";
            this.inserirAtualizarToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.inserirAtualizarToolStripMenuItem2.Text = "Inserir_Atualizar";
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.listarToolStripMenuItem2.Text = "Listar";
            // 
            // deletarBuscarToolStripMenuItem3
            // 
            this.deletarBuscarToolStripMenuItem3.Name = "deletarBuscarToolStripMenuItem3";
            this.deletarBuscarToolStripMenuItem3.Size = new System.Drawing.Size(157, 22);
            this.deletarBuscarToolStripMenuItem3.Text = "Deletar_Buscar";
            // 
            // inserirAtualizarToolStripMenuItem3
            // 
            this.inserirAtualizarToolStripMenuItem3.Name = "inserirAtualizarToolStripMenuItem3";
            this.inserirAtualizarToolStripMenuItem3.Size = new System.Drawing.Size(157, 22);
            this.inserirAtualizarToolStripMenuItem3.Text = "Inserir_Atualizar";
            // 
            // listarToolStripMenuItem3
            // 
            this.listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            this.listarToolStripMenuItem3.Size = new System.Drawing.Size(157, 22);
            this.listarToolStripMenuItem3.Text = "Listar";
            // 
            // deletarBuscarToolStripMenuItem4
            // 
            this.deletarBuscarToolStripMenuItem4.Name = "deletarBuscarToolStripMenuItem4";
            this.deletarBuscarToolStripMenuItem4.Size = new System.Drawing.Size(157, 22);
            this.deletarBuscarToolStripMenuItem4.Text = "Deletar_Buscar";
            // 
            // inserirAtualizarToolStripMenuItem4
            // 
            this.inserirAtualizarToolStripMenuItem4.Name = "inserirAtualizarToolStripMenuItem4";
            this.inserirAtualizarToolStripMenuItem4.Size = new System.Drawing.Size(157, 22);
            this.inserirAtualizarToolStripMenuItem4.Text = "Inserir_Atualizar";
            // 
            // listarToolStripMenuItem4
            // 
            this.listarToolStripMenuItem4.Name = "listarToolStripMenuItem4";
            this.listarToolStripMenuItem4.Size = new System.Drawing.Size(157, 22);
            this.listarToolStripMenuItem4.Text = "Listar";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 232);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletarBuscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirAtualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarBuscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserirAtualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletarBuscarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem inserirAtualizarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deletarBuscarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem inserirAtualizarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deletarBuscarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem inserirAtualizarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem4;
    }
}