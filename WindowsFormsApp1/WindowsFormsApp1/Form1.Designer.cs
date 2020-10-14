namespace WindowsFormsApp1
{
    partial class LogIn
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Użytkownik = new System.Windows.Forms.TextBox();
            this.Hasło = new System.Windows.Forms.TextBox();
            this.Logowanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Użytkownik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logowanie do systemu";
            // 
            // Użytkownik
            // 
            this.Użytkownik.Location = new System.Drawing.Point(190, 68);
            this.Użytkownik.Name = "Użytkownik";
            this.Użytkownik.Size = new System.Drawing.Size(100, 20);
            this.Użytkownik.TabIndex = 3;
            // 
            // Hasło
            // 
            this.Hasło.Location = new System.Drawing.Point(190, 121);
            this.Hasło.Name = "Hasło";
            this.Hasło.Size = new System.Drawing.Size(100, 20);
            this.Hasło.TabIndex = 4;
            this.Hasło.UseSystemPasswordChar = true;
            // 
            // Logowanie
            // 
            this.Logowanie.Location = new System.Drawing.Point(190, 169);
            this.Logowanie.Name = "Logowanie";
            this.Logowanie.Size = new System.Drawing.Size(75, 23);
            this.Logowanie.TabIndex = 5;
            this.Logowanie.Text = "Zaloguj";
            this.Logowanie.UseVisualStyleBackColor = true;
            this.Logowanie.Click += new System.EventHandler(this.Logowanie_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 216);
            this.Controls.Add(this.Logowanie);
            this.Controls.Add(this.Hasło);
            this.Controls.Add(this.Użytkownik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Użytkownik;
        private System.Windows.Forms.TextBox Hasło;
        private System.Windows.Forms.Button Logowanie;
    }
}

