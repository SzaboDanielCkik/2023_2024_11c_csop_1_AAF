
namespace _2024_04_09_FormAlapok
{
    partial class Form1
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
            this.lblNev = new System.Windows.Forms.Label();
            this.lblTelszam = new System.Windows.Forms.Label();
            this.lblSzulev = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.txtTelszam = new System.Windows.Forms.TextBox();
            this.BtnCsinald = new System.Windows.Forms.Button();
            this.nudSzulev = new System.Windows.Forms.NumericUpDown();
            this.rdbPiros = new System.Windows.Forms.RadioButton();
            this.rdbZold = new System.Windows.Forms.RadioButton();
            this.rdbKek = new System.Windows.Forms.RadioButton();
            this.rdbEredeti = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzulev)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNev.Location = new System.Drawing.Point(103, 24);
            this.lblNev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(56, 25);
            this.lblNev.TabIndex = 0;
            this.lblNev.Text = "Név:";
            // 
            // lblTelszam
            // 
            this.lblTelszam.AutoSize = true;
            this.lblTelszam.Location = new System.Drawing.Point(19, 66);
            this.lblTelszam.Name = "lblTelszam";
            this.lblTelszam.Size = new System.Drawing.Size(141, 25);
            this.lblTelszam.TabIndex = 1;
            this.lblTelszam.Text = "Telefonszám:";
            // 
            // lblSzulev
            // 
            this.lblSzulev.AutoSize = true;
            this.lblSzulev.Location = new System.Drawing.Point(24, 108);
            this.lblSzulev.Name = "lblSzulev";
            this.lblSzulev.Size = new System.Drawing.Size(135, 25);
            this.lblSzulev.TabIndex = 2;
            this.lblSzulev.Text = "Születési év:";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(165, 21);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(186, 31);
            this.txtNev.TabIndex = 3;
            this.txtNev.TextChanged += new System.EventHandler(this.txtNev_TextChanged);
            // 
            // txtTelszam
            // 
            this.txtTelszam.Location = new System.Drawing.Point(165, 63);
            this.txtTelszam.Name = "txtTelszam";
            this.txtTelszam.Size = new System.Drawing.Size(186, 31);
            this.txtTelszam.TabIndex = 4;
            // 
            // BtnCsinald
            // 
            this.BtnCsinald.Location = new System.Drawing.Point(165, 142);
            this.BtnCsinald.Name = "BtnCsinald";
            this.BtnCsinald.Size = new System.Drawing.Size(137, 42);
            this.BtnCsinald.TabIndex = 6;
            this.BtnCsinald.Text = "Csináld";
            this.BtnCsinald.UseVisualStyleBackColor = true;
            this.BtnCsinald.Click += new System.EventHandler(this.BtnCsinald_Click);
            // 
            // nudSzulev
            // 
            this.nudSzulev.Location = new System.Drawing.Point(165, 106);
            this.nudSzulev.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nudSzulev.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudSzulev.Name = "nudSzulev";
            this.nudSzulev.Size = new System.Drawing.Size(186, 31);
            this.nudSzulev.TabIndex = 7;
            this.nudSzulev.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // rdbPiros
            // 
            this.rdbPiros.AutoSize = true;
            this.rdbPiros.Location = new System.Drawing.Point(6, 30);
            this.rdbPiros.Name = "rdbPiros";
            this.rdbPiros.Size = new System.Drawing.Size(79, 29);
            this.rdbPiros.TabIndex = 8;
            this.rdbPiros.TabStop = true;
            this.rdbPiros.Text = "Piros";
            this.rdbPiros.UseVisualStyleBackColor = true;
            this.rdbPiros.CheckedChanged += new System.EventHandler(this.rdbPiros_CheckedChanged);
            // 
            // rdbZold
            // 
            this.rdbZold.AutoSize = true;
            this.rdbZold.Location = new System.Drawing.Point(6, 65);
            this.rdbZold.Name = "rdbZold";
            this.rdbZold.Size = new System.Drawing.Size(72, 29);
            this.rdbZold.TabIndex = 10;
            this.rdbZold.TabStop = true;
            this.rdbZold.Text = "Zöld";
            this.rdbZold.UseVisualStyleBackColor = true;
            this.rdbZold.CheckedChanged += new System.EventHandler(this.rdbZold_CheckedChanged);
            // 
            // rdbKek
            // 
            this.rdbKek.AutoSize = true;
            this.rdbKek.Location = new System.Drawing.Point(6, 100);
            this.rdbKek.Name = "rdbKek";
            this.rdbKek.Size = new System.Drawing.Size(67, 29);
            this.rdbKek.TabIndex = 11;
            this.rdbKek.TabStop = true;
            this.rdbKek.Text = "Kék";
            this.rdbKek.UseVisualStyleBackColor = true;
            this.rdbKek.CheckedChanged += new System.EventHandler(this.rdbKek_CheckedChanged);
            // 
            // rdbEredeti
            // 
            this.rdbEredeti.AutoSize = true;
            this.rdbEredeti.Location = new System.Drawing.Point(6, 135);
            this.rdbEredeti.Name = "rdbEredeti";
            this.rdbEredeti.Size = new System.Drawing.Size(98, 29);
            this.rdbEredeti.TabIndex = 12;
            this.rdbEredeti.TabStop = true;
            this.rdbEredeti.Text = "Eredeti";
            this.rdbEredeti.UseVisualStyleBackColor = true;
            this.rdbEredeti.CheckedChanged += new System.EventHandler(this.rdbEredeti_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(152, 29);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(152, 29);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPiros);
            this.groupBox1.Controls.Add(this.rdbZold);
            this.groupBox1.Controls.Add(this.rdbKek);
            this.groupBox1.Controls.Add(this.rdbEredeti);
            this.groupBox1.Location = new System.Drawing.Point(382, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 191);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ablak háttérszíne";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(611, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 95);
            this.panel1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "alma",
            "körte",
            "csersznye",
            "szilva"});
            this.comboBox1.Location = new System.Drawing.Point(611, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 33);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 29);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "123";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 239);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 29);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "12";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 275);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 29);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "171";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Összeg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(839, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudSzulev);
            this.Controls.Add(this.BtnCsinald);
            this.Controls.Add(this.txtTelszam);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.lblSzulev);
            this.Controls.Add(this.lblTelszam);
            this.Controls.Add(this.lblNev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form Alapok";
            ((System.ComponentModel.ISupportInitialize)(this.nudSzulev)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblTelszam;
        private System.Windows.Forms.Label lblSzulev;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.TextBox txtTelszam;
        private System.Windows.Forms.Button BtnCsinald;
        private System.Windows.Forms.NumericUpDown nudSzulev;
        private System.Windows.Forms.RadioButton rdbPiros;
        private System.Windows.Forms.RadioButton rdbZold;
        private System.Windows.Forms.RadioButton rdbKek;
        private System.Windows.Forms.RadioButton rdbEredeti;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
    }
}

