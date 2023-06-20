
namespace Lab2
{
    partial class MainForm
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
            this.Edytuj = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.Nowy = new System.Windows.Forms.Button();
            this.Zapisz_zmiany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edytuj
            // 
            this.Edytuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Edytuj.Location = new System.Drawing.Point(234, 12);
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Size = new System.Drawing.Size(148, 52);
            this.Edytuj.TabIndex = 1;
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.UseVisualStyleBackColor = false;
            this.Edytuj.Click += new System.EventHandler(this.Edytuj_Click);
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.Color.Maroon;
            this.lista.ForeColor = System.Drawing.SystemColors.Window;
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 15;
            this.lista.Location = new System.Drawing.Point(12, 15);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(216, 394);
            this.lista.TabIndex = 2;
            // 
            // Nowy
            // 
            this.Nowy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Nowy.Location = new System.Drawing.Point(234, 70);
            this.Nowy.Name = "Nowy";
            this.Nowy.Size = new System.Drawing.Size(148, 53);
            this.Nowy.TabIndex = 3;
            this.Nowy.Text = "Nowy";
            this.Nowy.UseVisualStyleBackColor = false;
            this.Nowy.Click += new System.EventHandler(this.Nowy_Click);
            // 
            // Zapisz_zmiany
            // 
            this.Zapisz_zmiany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Zapisz_zmiany.Location = new System.Drawing.Point(234, 129);
            this.Zapisz_zmiany.Name = "Zapisz_zmiany";
            this.Zapisz_zmiany.Size = new System.Drawing.Size(148, 54);
            this.Zapisz_zmiany.TabIndex = 4;
            this.Zapisz_zmiany.Text = "Zapisz zmiany";
            this.Zapisz_zmiany.UseVisualStyleBackColor = false;
            this.Zapisz_zmiany.UseWaitCursor = true;
            this.Zapisz_zmiany.Click += new System.EventHandler(this.Zapisz_zmiany_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(394, 444);
            this.Controls.Add(this.Zapisz_zmiany);
            this.Controls.Add(this.Nowy);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.Edytuj);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.Text = "Pracownik.NET Szczerba 9702";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Edytuj;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button Nowy;
        private System.Windows.Forms.Button Zapisz_zmiany;
    }
}

