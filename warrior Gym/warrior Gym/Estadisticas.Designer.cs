namespace warrior_Gym
{
    partial class Estadisticas
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Estado = new System.Windows.Forms.ComboBox();
            this.dataGridView_Estado = new System.Windows.Forms.DataGridView();
            this.dataGridView_Meses = new System.Windows.Forms.DataGridView();
            this.comboBox_Mes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Buscar_estado = new System.Windows.Forms.Button();
            this.button_Buscar_mes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_pagos_mes = new System.Windows.Forms.Label();
            this.button_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Meses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado del cliente";
            // 
            // comboBox_Estado
            // 
            this.comboBox_Estado.FormattingEnabled = true;
            this.comboBox_Estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.comboBox_Estado.Location = new System.Drawing.Point(132, 12);
            this.comboBox_Estado.Name = "comboBox_Estado";
            this.comboBox_Estado.Size = new System.Drawing.Size(151, 24);
            this.comboBox_Estado.TabIndex = 1;
            // 
            // dataGridView_Estado
            // 
            this.dataGridView_Estado.AllowUserToAddRows = false;
            this.dataGridView_Estado.AllowUserToDeleteRows = false;
            this.dataGridView_Estado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Estado.Location = new System.Drawing.Point(15, 42);
            this.dataGridView_Estado.Name = "dataGridView_Estado";
            this.dataGridView_Estado.ReadOnly = true;
            this.dataGridView_Estado.RowHeadersWidth = 51;
            this.dataGridView_Estado.RowTemplate.Height = 24;
            this.dataGridView_Estado.Size = new System.Drawing.Size(1134, 150);
            this.dataGridView_Estado.TabIndex = 2;
            // 
            // dataGridView_Meses
            // 
            this.dataGridView_Meses.AllowUserToAddRows = false;
            this.dataGridView_Meses.AllowUserToDeleteRows = false;
            this.dataGridView_Meses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Meses.Location = new System.Drawing.Point(12, 233);
            this.dataGridView_Meses.Name = "dataGridView_Meses";
            this.dataGridView_Meses.ReadOnly = true;
            this.dataGridView_Meses.RowHeadersWidth = 51;
            this.dataGridView_Meses.RowTemplate.Height = 24;
            this.dataGridView_Meses.Size = new System.Drawing.Size(1134, 175);
            this.dataGridView_Meses.TabIndex = 5;
            // 
            // comboBox_Mes
            // 
            this.comboBox_Mes.FormattingEnabled = true;
            this.comboBox_Mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Noviembre",
            "Diciembre"});
            this.comboBox_Mes.Location = new System.Drawing.Point(48, 203);
            this.comboBox_Mes.Name = "comboBox_Mes";
            this.comboBox_Mes.Size = new System.Drawing.Size(151, 24);
            this.comboBox_Mes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mes";
            // 
            // button_Buscar_estado
            // 
            this.button_Buscar_estado.Location = new System.Drawing.Point(289, 15);
            this.button_Buscar_estado.Name = "button_Buscar_estado";
            this.button_Buscar_estado.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar_estado.TabIndex = 6;
            this.button_Buscar_estado.Text = "Ver";
            this.button_Buscar_estado.UseVisualStyleBackColor = true;
            this.button_Buscar_estado.Click += new System.EventHandler(this.button_Buscar_estado_Click);
            // 
            // button_Buscar_mes
            // 
            this.button_Buscar_mes.Location = new System.Drawing.Point(208, 206);
            this.button_Buscar_mes.Name = "button_Buscar_mes";
            this.button_Buscar_mes.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar_mes.TabIndex = 7;
            this.button_Buscar_mes.Text = "Ver";
            this.button_Buscar_mes.UseVisualStyleBackColor = true;
            this.button_Buscar_mes.Click += new System.EventHandler(this.button_Buscar_mes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pagos del mes:";
            // 
            // label_pagos_mes
            // 
            this.label_pagos_mes.AutoSize = true;
            this.label_pagos_mes.Location = new System.Drawing.Point(119, 432);
            this.label_pagos_mes.Name = "label_pagos_mes";
            this.label_pagos_mes.Size = new System.Drawing.Size(10, 16);
            this.label_pagos_mes.TabIndex = 9;
            this.label_pagos_mes.Text = ".";
            // 
            // button_imprimir
            // 
            this.button_imprimir.Location = new System.Drawing.Point(1071, 425);
            this.button_imprimir.Name = "button_imprimir";
            this.button_imprimir.Size = new System.Drawing.Size(75, 23);
            this.button_imprimir.TabIndex = 10;
            this.button_imprimir.Text = "Imprimir";
            this.button_imprimir.UseVisualStyleBackColor = true;
            this.button_imprimir.Click += new System.EventHandler(this.button_imprimir_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 509);
            this.Controls.Add(this.button_imprimir);
            this.Controls.Add(this.label_pagos_mes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Buscar_mes);
            this.Controls.Add(this.button_Buscar_estado);
            this.Controls.Add(this.dataGridView_Meses);
            this.Controls.Add(this.comboBox_Mes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Estado);
            this.Controls.Add(this.comboBox_Estado);
            this.Controls.Add(this.label1);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Meses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Estado;
        private System.Windows.Forms.DataGridView dataGridView_Estado;
        private System.Windows.Forms.DataGridView dataGridView_Meses;
        private System.Windows.Forms.ComboBox comboBox_Mes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Buscar_estado;
        private System.Windows.Forms.Button button_Buscar_mes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_pagos_mes;
        private System.Windows.Forms.Button button_imprimir;
    }
}