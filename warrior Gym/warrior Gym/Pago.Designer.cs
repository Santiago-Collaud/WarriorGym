namespace warrior_Gym
{
    partial class Pago
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
            this.label_nombre_cliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_mesPagado = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label_Celular = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label_nombre_cliente
            // 
            this.label_nombre_cliente.AutoSize = true;
            this.label_nombre_cliente.Location = new System.Drawing.Point(19, 50);
            this.label_nombre_cliente.Name = "label_nombre_cliente";
            this.label_nombre_cliente.Size = new System.Drawing.Size(10, 16);
            this.label_nombre_cliente.TabIndex = 1;
            this.label_nombre_cliente.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto";
            // 
            // textBox_monto
            // 
            this.textBox_monto.Location = new System.Drawing.Point(67, 145);
            this.textBox_monto.Name = "textBox_monto";
            this.textBox_monto.Size = new System.Drawing.Size(87, 22);
            this.textBox_monto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mes";
            // 
            // CB_mesPagado
            // 
            this.CB_mesPagado.FormattingEnabled = true;
            this.CB_mesPagado.Items.AddRange(new object[] {
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
            this.CB_mesPagado.Location = new System.Drawing.Point(230, 148);
            this.CB_mesPagado.Name = "CB_mesPagado";
            this.CB_mesPagado.Size = new System.Drawing.Size(87, 24);
            this.CB_mesPagado.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 218);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(161, 459);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(242, 459);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label_Celular
            // 
            this.label_Celular.AutoSize = true;
            this.label_Celular.Location = new System.Drawing.Point(12, 110);
            this.label_Celular.Name = "label_Celular";
            this.label_Celular.Size = new System.Drawing.Size(10, 16);
            this.label_Celular.TabIndex = 9;
            this.label_Celular.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha de pago";
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Celular);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CB_mesPagado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_nombre_cliente);
            this.Controls.Add(this.label1);
            this.Name = "Pago";
            this.Text = "Pagar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nombre_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_mesPagado;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label_Celular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}