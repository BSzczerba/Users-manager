
namespace Lab2
{
    partial class EditEmployeeWindow
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
            this.zapisz = new System.Windows.Forms.Button();
            this.textBox_Imie = new System.Windows.Forms.TextBox();
            this.textBox_Miasto = new System.Windows.Forms.TextBox();
            this.textBox_Nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_Pensja = new System.Windows.Forms.TextBox();
            this.textBox_Pesel = new System.Windows.Forms.TextBox();
            this.textBox_Stanowisko = new System.Windows.Forms.TextBox();
            this.textBox_Ulica = new System.Windows.Forms.TextBox();
            this.label_Imie = new System.Windows.Forms.Label();
            this.label_Miasto = new System.Windows.Forms.Label();
            this.label_Nazwisko = new System.Windows.Forms.Label();
            this.label_Pensja = new System.Windows.Forms.Label();
            this.label_Pesel = new System.Windows.Forms.Label();
            this.label_Stanowsiko = new System.Windows.Forms.Label();
            this.label_Ulica = new System.Windows.Forms.Label();
            this.Anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zapisz
            // 
            this.zapisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.zapisz.Location = new System.Drawing.Point(158, 362);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(79, 38);
            this.zapisz.TabIndex = 0;
            this.zapisz.Text = "Zapisz";
            this.zapisz.UseVisualStyleBackColor = false;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // textBox_Imie
            // 
            this.textBox_Imie.Location = new System.Drawing.Point(158, 56);
            this.textBox_Imie.Name = "textBox_Imie";
            this.textBox_Imie.Size = new System.Drawing.Size(167, 23);
            this.textBox_Imie.TabIndex = 1;
            // 
            // textBox_Miasto
            // 
            this.textBox_Miasto.Location = new System.Drawing.Point(158, 97);
            this.textBox_Miasto.Name = "textBox_Miasto";
            this.textBox_Miasto.Size = new System.Drawing.Size(167, 23);
            this.textBox_Miasto.TabIndex = 2;
            // 
            // textBox_Nazwisko
            // 
            this.textBox_Nazwisko.Location = new System.Drawing.Point(158, 143);
            this.textBox_Nazwisko.Name = "textBox_Nazwisko";
            this.textBox_Nazwisko.Size = new System.Drawing.Size(167, 23);
            this.textBox_Nazwisko.TabIndex = 3;
            // 
            // textBox_Pensja
            // 
            this.textBox_Pensja.Location = new System.Drawing.Point(158, 191);
            this.textBox_Pensja.Name = "textBox_Pensja";
            this.textBox_Pensja.Size = new System.Drawing.Size(167, 23);
            this.textBox_Pensja.TabIndex = 4;
            // 
            // textBox_Pesel
            // 
            this.textBox_Pesel.Location = new System.Drawing.Point(158, 232);
            this.textBox_Pesel.Name = "textBox_Pesel";
            this.textBox_Pesel.Size = new System.Drawing.Size(167, 23);
            this.textBox_Pesel.TabIndex = 5;
            // 
            // textBox_Stanowisko
            // 
            this.textBox_Stanowisko.Location = new System.Drawing.Point(158, 271);
            this.textBox_Stanowisko.Name = "textBox_Stanowisko";
            this.textBox_Stanowisko.Size = new System.Drawing.Size(167, 23);
            this.textBox_Stanowisko.TabIndex = 6;
            // 
            // textBox_Ulica
            // 
            this.textBox_Ulica.BackColor = System.Drawing.Color.White;
            this.textBox_Ulica.Location = new System.Drawing.Point(158, 313);
            this.textBox_Ulica.Name = "textBox_Ulica";
            this.textBox_Ulica.Size = new System.Drawing.Size(167, 23);
            this.textBox_Ulica.TabIndex = 7;
            // 
            // label_Imie
            // 
            this.label_Imie.AutoSize = true;
            this.label_Imie.Location = new System.Drawing.Point(41, 63);
            this.label_Imie.Name = "label_Imie";
            this.label_Imie.Size = new System.Drawing.Size(33, 15);
            this.label_Imie.TabIndex = 8;
            this.label_Imie.Text = "Imie:";
            // 
            // label_Miasto
            // 
            this.label_Miasto.AutoSize = true;
            this.label_Miasto.Location = new System.Drawing.Point(41, 104);
            this.label_Miasto.Name = "label_Miasto";
            this.label_Miasto.Size = new System.Drawing.Size(46, 15);
            this.label_Miasto.TabIndex = 9;
            this.label_Miasto.Text = "Miasto:";
            // 
            // label_Nazwisko
            // 
            this.label_Nazwisko.AutoSize = true;
            this.label_Nazwisko.Location = new System.Drawing.Point(41, 150);
            this.label_Nazwisko.Name = "label_Nazwisko";
            this.label_Nazwisko.Size = new System.Drawing.Size(60, 15);
            this.label_Nazwisko.TabIndex = 10;
            this.label_Nazwisko.Text = "Nazwisko:";
            // 
            // label_Pensja
            // 
            this.label_Pensja.AutoSize = true;
            this.label_Pensja.Location = new System.Drawing.Point(41, 198);
            this.label_Pensja.Name = "label_Pensja";
            this.label_Pensja.Size = new System.Drawing.Size(44, 15);
            this.label_Pensja.TabIndex = 11;
            this.label_Pensja.Text = "Pensja:";
            // 
            // label_Pesel
            // 
            this.label_Pesel.AutoSize = true;
            this.label_Pesel.Location = new System.Drawing.Point(41, 239);
            this.label_Pesel.Name = "label_Pesel";
            this.label_Pesel.Size = new System.Drawing.Size(37, 15);
            this.label_Pesel.TabIndex = 12;
            this.label_Pesel.Text = "Pesel:";
            // 
            // label_Stanowsiko
            // 
            this.label_Stanowsiko.AutoSize = true;
            this.label_Stanowsiko.Location = new System.Drawing.Point(41, 278);
            this.label_Stanowsiko.Name = "label_Stanowsiko";
            this.label_Stanowsiko.Size = new System.Drawing.Size(70, 15);
            this.label_Stanowsiko.TabIndex = 13;
            this.label_Stanowsiko.Text = "Stanowisko:";
            // 
            // label_Ulica
            // 
            this.label_Ulica.AutoSize = true;
            this.label_Ulica.Location = new System.Drawing.Point(41, 320);
            this.label_Ulica.Name = "label_Ulica";
            this.label_Ulica.Size = new System.Drawing.Size(36, 15);
            this.label_Ulica.TabIndex = 14;
            this.label_Ulica.Text = "Ulica:";
            // 
            // Anuluj
            // 
            this.Anuluj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Anuluj.Location = new System.Drawing.Point(243, 362);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(82, 38);
            this.Anuluj.TabIndex = 15;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = false;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // EditEmployeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(371, 435);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.label_Ulica);
            this.Controls.Add(this.label_Stanowsiko);
            this.Controls.Add(this.label_Pesel);
            this.Controls.Add(this.label_Pensja);
            this.Controls.Add(this.label_Nazwisko);
            this.Controls.Add(this.label_Miasto);
            this.Controls.Add(this.label_Imie);
            this.Controls.Add(this.textBox_Ulica);
            this.Controls.Add(this.textBox_Stanowisko);
            this.Controls.Add(this.textBox_Pesel);
            this.Controls.Add(this.textBox_Pensja);
            this.Controls.Add(this.textBox_Nazwisko);
            this.Controls.Add(this.textBox_Miasto);
            this.Controls.Add(this.textBox_Imie);
            this.Controls.Add(this.zapisz);
            this.Name = "EditEmployeeWindow";
            this.Text = "EditEmployeeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.TextBox textBox_Imie;
        private System.Windows.Forms.TextBox textBox_Miasto;
        private System.Windows.Forms.TextBox textBox_Nazwisko;
        private System.Windows.Forms.TextBox textBox_Pensja;
        private System.Windows.Forms.TextBox textBox_Pesel;
        private System.Windows.Forms.TextBox textBox_Stanowisko;
        private System.Windows.Forms.TextBox textBox_Ulica;
        private System.Windows.Forms.Label label_Imie;
        private System.Windows.Forms.Label label_Miasto;
        private System.Windows.Forms.Label label_Nazwisko;
        private System.Windows.Forms.Label label_Pensja;
        private System.Windows.Forms.Label label_Pesel;
        private System.Windows.Forms.Label label_Stanowsiko;
        private System.Windows.Forms.Label label_Ulica;
        private System.Windows.Forms.Button Anuluj;
    }
}