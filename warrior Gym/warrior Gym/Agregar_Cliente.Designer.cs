namespace warrior_Gym
{
    partial class Agregar_Cliente
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_celular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_dias = new System.Windows.Forms.ComboBox();
            this.cB_rutina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Notas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_mail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(187, 540);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(106, 540);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // text_Nombre
            // 
            this.text_Nombre.AutoCompleteCustomSource.AddRange(new string[] {
            "nombre"});
            this.text_Nombre.Location = new System.Drawing.Point(10, 31);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(250, 22);
            this.text_Nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // text_apellido
            // 
            this.text_apellido.AutoCompleteCustomSource.AddRange(new string[] {
            "apellido"});
            this.text_apellido.Location = new System.Drawing.Point(10, 91);
            this.text_apellido.Name = "text_apellido";
            this.text_apellido.Size = new System.Drawing.Size(250, 22);
            this.text_apellido.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Celular";
            // 
            // text_celular
            // 
            this.text_celular.AutoCompleteCustomSource.AddRange(new string[] {
            "1"});
            this.text_celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_celular.Location = new System.Drawing.Point(10, 150);
            this.text_celular.Name = "text_celular";
            this.text_celular.Size = new System.Drawing.Size(250, 22);
            this.text_celular.TabIndex = 9;
            this.text_celular.TextChanged += new System.EventHandler(this.text_celular_TextChanged);
            this.text_celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_celular_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dias";
            // 
            // cBox_dias
            // 
            this.cBox_dias.AutoCompleteCustomSource.AddRange(new string[] {
            "0"});
            this.cBox_dias.FormattingEnabled = true;
            this.cBox_dias.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBox_dias.Location = new System.Drawing.Point(139, 313);
            this.cBox_dias.Name = "cBox_dias";
            this.cBox_dias.Size = new System.Drawing.Size(121, 24);
            this.cBox_dias.TabIndex = 12;
            // 
            // cB_rutina
            // 
            this.cB_rutina.AutoCompleteCustomSource.AddRange(new string[] {
            "NN"});
            this.cB_rutina.FormattingEnabled = true;
            this.cB_rutina.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Especial"});
            this.cB_rutina.Location = new System.Drawing.Point(139, 259);
            this.cB_rutina.Name = "cB_rutina";
            this.cB_rutina.Size = new System.Drawing.Size(121, 24);
            this.cB_rutina.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rutina";
            // 
            // text_Notas
            // 
            this.text_Notas.AutoCompleteCustomSource.AddRange(new string[] {
            "nota"});
            this.text_Notas.Location = new System.Drawing.Point(10, 392);
            this.text_Notas.Multiline = true;
            this.text_Notas.Name = "text_Notas";
            this.text_Notas.Size = new System.Drawing.Size(249, 115);
            this.text_Notas.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Notas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mail";
            // 
            // text_mail
            // 
            this.text_mail.AutoCompleteCustomSource.AddRange(new string[] {
            "0"});
            this.text_mail.Location = new System.Drawing.Point(10, 208);
            this.text_mail.Name = "text_mail";
            this.text_mail.Size = new System.Drawing.Size(250, 22);
            this.text_mail.TabIndex = 17;
            // 
            // Agregar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 573);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_mail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_Notas);
            this.Controls.Add(this.cB_rutina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_dias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_celular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Nombre);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Name = "Agregar_Cliente";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_celular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBox_dias;
        private System.Windows.Forms.ComboBox cB_rutina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Notas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_mail;
    }
}