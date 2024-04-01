namespace warrior_Gym
{
    partial class Mostrar_pagos
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
            this.dataGridView_mostrar_pagos = new System.Windows.Forms.DataGridView();
            this.btn_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mostrar_pagos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_mostrar_pagos
            // 
            this.dataGridView_mostrar_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mostrar_pagos.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_mostrar_pagos.Name = "dataGridView_mostrar_pagos";
            this.dataGridView_mostrar_pagos.RowHeadersWidth = 51;
            this.dataGridView_mostrar_pagos.RowTemplate.Height = 24;
            this.dataGridView_mostrar_pagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_mostrar_pagos.Size = new System.Drawing.Size(869, 426);
            this.dataGridView_mostrar_pagos.TabIndex = 0;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(806, 452);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 1;
            this.btn_imprimir.Text = "imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // Mostrar_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 487);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.dataGridView_mostrar_pagos);
            this.Name = "Mostrar_pagos";
            this.Text = "Mostrar Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mostrar_pagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_mostrar_pagos;
        private System.Windows.Forms.Button btn_imprimir;
    }
}