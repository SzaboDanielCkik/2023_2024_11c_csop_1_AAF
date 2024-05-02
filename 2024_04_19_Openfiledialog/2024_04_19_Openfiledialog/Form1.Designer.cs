
namespace _2024_04_19_Openfiledialog
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
            this.lblFajl = new System.Windows.Forms.ListBox();
            this.btnFajlbe = new System.Windows.Forms.Button();
            this.txtUtvonal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFajl
            // 
            this.lblFajl.FormattingEnabled = true;
            this.lblFajl.ItemHeight = 25;
            this.lblFajl.Location = new System.Drawing.Point(26, 25);
            this.lblFajl.Margin = new System.Windows.Forms.Padding(6);
            this.lblFajl.Name = "lblFajl";
            this.lblFajl.Size = new System.Drawing.Size(409, 254);
            this.lblFajl.TabIndex = 0;
            // 
            // btnFajlbe
            // 
            this.btnFajlbe.Location = new System.Drawing.Point(452, 99);
            this.btnFajlbe.Margin = new System.Windows.Forms.Padding(6);
            this.btnFajlbe.Name = "btnFajlbe";
            this.btnFajlbe.Size = new System.Drawing.Size(196, 44);
            this.btnFajlbe.TabIndex = 1;
            this.btnFajlbe.Text = "Fájlbeolvasás";
            this.btnFajlbe.UseVisualStyleBackColor = true;
            this.btnFajlbe.Click += new System.EventHandler(this.btnFajlbe_Click);
            // 
            // txtUtvonal
            // 
            this.txtUtvonal.Location = new System.Drawing.Point(452, 55);
            this.txtUtvonal.Margin = new System.Windows.Forms.Padding(6);
            this.txtUtvonal.Name = "txtUtvonal";
            this.txtUtvonal.Size = new System.Drawing.Size(196, 32);
            this.txtUtvonal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fájl elérési útvonala:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fájlbaíratás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUtvonal);
            this.Controls.Add(this.btnFajlbe);
            this.Controls.Add(this.lblFajl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Fájlbeolvasások";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblFajl;
        private System.Windows.Forms.Button btnFajlbe;
        private System.Windows.Forms.TextBox txtUtvonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

