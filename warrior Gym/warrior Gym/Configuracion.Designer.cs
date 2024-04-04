namespace warrior_Gym
{
    partial class Configuracion
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_BackUp = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_BackUP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Dia_BackUP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Configurar Mail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_BackUp
            // 
            this.button_BackUp.Location = new System.Drawing.Point(12, 74);
            this.button_BackUp.Name = "button_BackUp";
            this.button_BackUp.Size = new System.Drawing.Size(310, 27);
            this.button_BackUp.TabIndex = 1;
            this.button_BackUp.Text = "Crear ZIP de respaldo";
            this.button_BackUp.UseVisualStyleBackColor = true;
            this.button_BackUp.Click += new System.EventHandler(this.button_BackUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Creacion de archivo ZIP\r\n";
            // 
            // comboBox_BackUP
            // 
            this.comboBox_BackUP.FormattingEnabled = true;
            this.comboBox_BackUP.Items.AddRange(new object[] {
            "AUTOMATICA",
            "MANUAL"});
            this.comboBox_BackUP.Location = new System.Drawing.Point(182, 122);
            this.comboBox_BackUP.Name = "comboBox_BackUP";
            this.comboBox_BackUP.Size = new System.Drawing.Size(140, 24);
            this.comboBox_BackUP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fijar dia para crear el archivo\r\n\r\n";
            // 
            // comboBox_Dia_BackUP
            // 
            this.comboBox_Dia_BackUP.FormattingEnabled = true;
            this.comboBox_Dia_BackUP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_Dia_BackUP.Location = new System.Drawing.Point(235, 169);
            this.comboBox_Dia_BackUP.Name = "comboBox_Dia_BackUP";
            this.comboBox_Dia_BackUP.Size = new System.Drawing.Size(87, 24);
            this.comboBox_Dia_BackUP.TabIndex = 5;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 224);
            this.Controls.Add(this.comboBox_Dia_BackUP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_BackUP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_BackUp);
            this.Controls.Add(this.button1);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_BackUp;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_BackUP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Dia_BackUP;
    }
}