
namespace _2024_04_16_Listbox
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
            this.txtNev = new System.Windows.Forms.TextBox();
            this.btnFelvetel = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(12, 9);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(57, 26);
            this.lblNev.TabIndex = 0;
            this.lblNev.Text = "Név:";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(75, 9);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(253, 32);
            this.txtNev.TabIndex = 1;
            // 
            // btnFelvetel
            // 
            this.btnFelvetel.Location = new System.Drawing.Point(75, 47);
            this.btnFelvetel.Name = "btnFelvetel";
            this.btnFelvetel.Size = new System.Drawing.Size(187, 40);
            this.btnFelvetel.TabIndex = 2;
            this.btnFelvetel.Text = "Felvétel a listába";
            this.btnFelvetel.UseVisualStyleBackColor = true;
            this.btnFelvetel.Click += new System.EventHandler(this.btnFelvetel_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 25;
            this.lbLista.Location = new System.Drawing.Point(334, 9);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(291, 354);
            this.lbLista.TabIndex = 3;
            this.lbLista.SelectedIndexChanged += new System.EventHandler(this.lbLista_SelectedIndexChanged);
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(75, 93);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(187, 40);
            this.btnModosit.TabIndex = 4;
            this.btnModosit.Text = "Módosítás";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(75, 140);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(187, 43);
            this.btnTorles.TabIndex = 5;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 387);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnFelvetel);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.lblNev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Megrendelés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Button btnFelvetel;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnTorles;
    }
}

