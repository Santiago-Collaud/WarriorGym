namespace warrior_Gym
{
    partial class EditarCliente
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.dataGridView_clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uriConverterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uriConverterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(713, 388);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dataGridView_clientes
            // 
            this.dataGridView_clientes.AllowUserToAddRows = false;
            this.dataGridView_clientes.AllowUserToDeleteRows = false;
            this.dataGridView_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clientes.Location = new System.Drawing.Point(12, 35);
            this.dataGridView_clientes.Name = "dataGridView_clientes";
            this.dataGridView_clientes.ReadOnly = true;
            this.dataGridView_clientes.RowHeadersWidth = 51;
            this.dataGridView_clientes.RowTemplate.Height = 24;
            this.dataGridView_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_clientes.Size = new System.Drawing.Size(776, 330);
            this.dataGridView_clientes.TabIndex = 2;
            this.dataGridView_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_clientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clientes";
            // 
            // uriConverterBindingSource
            // 
           
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(632, 388);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(551, 388);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_clientes);
            this.Controls.Add(this.btn_salir);
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uriConverterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dataGridView_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource uriConverterBindingSource;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}