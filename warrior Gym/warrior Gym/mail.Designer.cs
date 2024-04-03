namespace warrior_Gym
{
    partial class mail
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
            this.dataGridView_ClientesParaMail = new System.Windows.Forms.DataGridView();
            this.Clientes = new System.Windows.Forms.Label();
            this.button_Enviar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_asunto = new System.Windows.Forms.TextBox();
            this.button_adjuntar = new System.Windows.Forms.Button();
            this.textBox_mensaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_configMail = new System.Windows.Forms.Button();
            this.lblFiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClientesParaMail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ClientesParaMail
            // 
            this.dataGridView_ClientesParaMail.AllowUserToAddRows = false;
            this.dataGridView_ClientesParaMail.AllowUserToDeleteRows = false;
            this.dataGridView_ClientesParaMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClientesParaMail.Location = new System.Drawing.Point(12, 46);
            this.dataGridView_ClientesParaMail.Name = "dataGridView_ClientesParaMail";
            this.dataGridView_ClientesParaMail.ReadOnly = true;
            this.dataGridView_ClientesParaMail.RowHeadersWidth = 51;
            this.dataGridView_ClientesParaMail.RowTemplate.Height = 24;
            this.dataGridView_ClientesParaMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ClientesParaMail.Size = new System.Drawing.Size(776, 150);
            this.dataGridView_ClientesParaMail.TabIndex = 0;
            // 
            // Clientes
            // 
            this.Clientes.AutoSize = true;
            this.Clientes.Location = new System.Drawing.Point(12, 27);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(47, 16);
            this.Clientes.TabIndex = 1;
            this.Clientes.Text = "Clintes";
            // 
            // button_Enviar
            // 
            this.button_Enviar.Location = new System.Drawing.Point(713, 494);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(75, 23);
            this.button_Enviar.TabIndex = 2;
            this.button_Enviar.Text = "Enviar";
            this.button_Enviar.UseVisualStyleBackColor = true;
            this.button_Enviar.Click += new System.EventHandler(this.button_Enviar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(623, 494);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 3;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asunto";
            // 
            // textBox_asunto
            // 
            this.textBox_asunto.Location = new System.Drawing.Point(16, 224);
            this.textBox_asunto.Name = "textBox_asunto";
            this.textBox_asunto.Size = new System.Drawing.Size(773, 22);
            this.textBox_asunto.TabIndex = 5;
            // 
            // button_adjuntar
            // 
            this.button_adjuntar.Location = new System.Drawing.Point(18, 494);
            this.button_adjuntar.Name = "button_adjuntar";
            this.button_adjuntar.Size = new System.Drawing.Size(75, 23);
            this.button_adjuntar.TabIndex = 6;
            this.button_adjuntar.Text = "Adjuntar";
            this.button_adjuntar.UseVisualStyleBackColor = true;
            this.button_adjuntar.Click += new System.EventHandler(this.button_adjuntar_Click);
            // 
            // textBox_mensaje
            // 
            this.textBox_mensaje.Location = new System.Drawing.Point(16, 272);
            this.textBox_mensaje.Multiline = true;
            this.textBox_mensaje.Name = "textBox_mensaje";
            this.textBox_mensaje.Size = new System.Drawing.Size(773, 112);
            this.textBox_mensaje.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mensaje";
            // 
            // button_configMail
            // 
            this.button_configMail.Location = new System.Drawing.Point(623, 454);
            this.button_configMail.Name = "button_configMail";
            this.button_configMail.Size = new System.Drawing.Size(165, 23);
            this.button_configMail.TabIndex = 9;
            this.button_configMail.Text = "Configurar mail";
            this.button_configMail.UseVisualStyleBackColor = true;
            this.button_configMail.Click += new System.EventHandler(this.button_configMail_Click);
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(31, 416);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(10, 16);
            this.lblFiles.TabIndex = 10;
            this.lblFiles.Text = ".";
            // 
            // mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.button_configMail);
            this.Controls.Add(this.textBox_mensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_adjuntar);
            this.Controls.Add(this.textBox_asunto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Enviar);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.dataGridView_ClientesParaMail);
            this.Name = "mail";
            this.Text = "mail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClientesParaMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ClientesParaMail;
        private System.Windows.Forms.Label Clientes;
        private System.Windows.Forms.Button button_Enviar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_asunto;
        private System.Windows.Forms.Button button_adjuntar;
        private System.Windows.Forms.TextBox textBox_mensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_configMail;
        private System.Windows.Forms.Label lblFiles;
    }
}