namespace warrior_Gym
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarMailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estaditicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llamarAUnProgramadorEncerioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.enviarMailsToolStripMenuItem,
            this.estaditicasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.editarClienteToolStripMenuItem.Text = "Ver Clientes";
            this.editarClienteToolStripMenuItem.Click += new System.EventHandler(this.editarClienteToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPagoToolStripMenuItem,
            this.verPagosToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // registrarPagoToolStripMenuItem
            // 
            this.registrarPagoToolStripMenuItem.Name = "registrarPagoToolStripMenuItem";
            this.registrarPagoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.registrarPagoToolStripMenuItem.Text = "Registrar pago";
            this.registrarPagoToolStripMenuItem.Click += new System.EventHandler(this.registrarPagoToolStripMenuItem_Click);
            // 
            // verPagosToolStripMenuItem
            // 
            this.verPagosToolStripMenuItem.Name = "verPagosToolStripMenuItem";
            this.verPagosToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.verPagosToolStripMenuItem.Text = "Ver pagos";
            this.verPagosToolStripMenuItem.Click += new System.EventHandler(this.verPagosToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem1});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.exportarToolStripMenuItem.Text = "exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem1
            // 
            this.exportarToolStripMenuItem1.Name = "exportarToolStripMenuItem1";
            this.exportarToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.exportarToolStripMenuItem1.Text = "exportar";
            this.exportarToolStripMenuItem1.Click += new System.EventHandler(this.exportarToolStripMenuItem1_Click);
            // 
            // enviarMailsToolStripMenuItem
            // 
            this.enviarMailsToolStripMenuItem.Name = "enviarMailsToolStripMenuItem";
            this.enviarMailsToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.enviarMailsToolStripMenuItem.Text = "enviar mails";
            this.enviarMailsToolStripMenuItem.Click += new System.EventHandler(this.enviarMailsToolStripMenuItem_Click);
            // 
            // estaditicasToolStripMenuItem
            // 
            this.estaditicasToolStripMenuItem.Name = "estaditicasToolStripMenuItem";
            this.estaditicasToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.estaditicasToolStripMenuItem.Text = "Estaditicas";
            this.estaditicasToolStripMenuItem.Click += new System.EventHandler(this.estaditicasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.llamarAUnProgramadorEncerioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // llamarAUnProgramadorEncerioToolStripMenuItem
            // 
            this.llamarAUnProgramadorEncerioToolStripMenuItem.Name = "llamarAUnProgramadorEncerioToolStripMenuItem";
            this.llamarAUnProgramadorEncerioToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.llamarAUnProgramadorEncerioToolStripMenuItem.Text = "Llamar a un programador encerio";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 596);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warrior Gym - Santiago Collaud Soft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem llamarAUnProgramadorEncerioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarMailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estaditicasToolStripMenuItem;
    }
}

