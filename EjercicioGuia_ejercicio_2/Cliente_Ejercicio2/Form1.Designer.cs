namespace Cliente_Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cel = new System.Windows.Forms.RadioButton();
            this.Far = new System.Windows.Forms.RadioButton();
            this.Temperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Desconectar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.Cel);
            this.groupBox1.Controls.Add(this.Far);
            this.groupBox1.Controls.Add(this.Temperatura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(342, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversor Temperatura";
            // 
            // Cel
            // 
            this.Cel.AutoSize = true;
            this.Cel.Location = new System.Drawing.Point(18, 115);
            this.Cel.Name = "Cel";
            this.Cel.Size = new System.Drawing.Size(91, 29);
            this.Cel.TabIndex = 4;
            this.Cel.TabStop = true;
            this.Cel.Text = "Celsius";
            this.Cel.UseVisualStyleBackColor = true;
            // 
            // Far
            // 
            this.Far.AutoSize = true;
            this.Far.Location = new System.Drawing.Point(18, 164);
            this.Far.Name = "Far";
            this.Far.Size = new System.Drawing.Size(108, 29);
            this.Far.TabIndex = 5;
            this.Far.TabStop = true;
            this.Far.Text = "Farenheit";
            this.Far.UseVisualStyleBackColor = true;
            // 
            // Temperatura
            // 
            this.Temperatura.Location = new System.Drawing.Point(18, 67);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(150, 31);
            this.Temperatura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura (Boton : Tempeatura en la cual estoy)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 599);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private TextBox Temperatura;
        private Label label1;
        private Button button3;
        private RadioButton Cel;
        private RadioButton Far;
    }
}