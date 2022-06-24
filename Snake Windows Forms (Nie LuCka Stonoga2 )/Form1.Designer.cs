namespace WindowsFormsApp1
{
    partial class Start
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
            this.wDol = new System.Windows.Forms.Button();
            this.doGory = new System.Windows.Forms.Button();
            this.wprawo = new System.Windows.Forms.Button();
            this.wLewo = new System.Windows.Forms.Button();
            this.letsStart = new System.Windows.Forms.Button();
            this.TytulGry = new System.Windows.Forms.Label();
            this.Tytul2 = new System.Windows.Forms.Label();
            this.TytulGry4 = new System.Windows.Forms.Label();
            this.TytulGry3 = new System.Windows.Forms.Label();
            this.Przegrales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wDol
            // 
            this.wDol.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wDol.Location = new System.Drawing.Point(187, 409);
            this.wDol.Name = "wDol";
            this.wDol.Size = new System.Drawing.Size(44, 44);
            this.wDol.TabIndex = 0;
            this.wDol.Text = "^";
            this.wDol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wDol.UseVisualStyleBackColor = true;
            this.wDol.Visible = false;
            this.wDol.Click += new System.EventHandler(this.goDown_Click);
            // 
            // doGory
            // 
            this.doGory.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doGory.Location = new System.Drawing.Point(187, 491);
            this.doGory.Name = "doGory";
            this.doGory.Size = new System.Drawing.Size(44, 44);
            this.doGory.TabIndex = 2;
            this.doGory.Text = "v";
            this.doGory.UseVisualStyleBackColor = true;
            this.doGory.Visible = false;
            this.doGory.Click += new System.EventHandler(this.goUp_Click);
            // 
            // wprawo
            // 
            this.wprawo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wprawo.Location = new System.Drawing.Point(227, 450);
            this.wprawo.Name = "wprawo";
            this.wprawo.Size = new System.Drawing.Size(44, 44);
            this.wprawo.TabIndex = 3;
            this.wprawo.Text = ">";
            this.wprawo.UseVisualStyleBackColor = true;
            this.wprawo.Visible = false;
            this.wprawo.Click += new System.EventHandler(this.goRight_Click);
            // 
            // wLewo
            // 
            this.wLewo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wLewo.Location = new System.Drawing.Point(146, 450);
            this.wLewo.Name = "wLewo";
            this.wLewo.Size = new System.Drawing.Size(44, 44);
            this.wLewo.TabIndex = 4;
            this.wLewo.Text = "<";
            this.wLewo.UseVisualStyleBackColor = true;
            this.wLewo.Visible = false;
            this.wLewo.Click += new System.EventHandler(this.goLeft_Click);
            // 
            // letsStart
            // 
            this.letsStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.letsStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letsStart.Location = new System.Drawing.Point(116, 438);
            this.letsStart.Name = "letsStart";
            this.letsStart.Size = new System.Drawing.Size(193, 70);
            this.letsStart.TabIndex = 6;
            this.letsStart.Text = "Start";
            this.letsStart.UseVisualStyleBackColor = false;
            this.letsStart.Click += new System.EventHandler(this.letsStart_Click);
            // 
            // TytulGry
            // 
            this.TytulGry.AutoSize = true;
            this.TytulGry.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.TytulGry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TytulGry.Location = new System.Drawing.Point(25, 225);
            this.TytulGry.Name = "TytulGry";
            this.TytulGry.Size = new System.Drawing.Size(377, 52);
            this.TytulGry.TabIndex = 8;
            this.TytulGry.Text = "NIELUcKA STONOGA";
            // 
            // Tytul2
            // 
            this.Tytul2.AutoSize = true;
            this.Tytul2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tytul2.Font = new System.Drawing.Font("Mistral", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tytul2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Tytul2.Location = new System.Drawing.Point(101, 86);
            this.Tytul2.Name = "Tytul2";
            this.Tytul2.Size = new System.Drawing.Size(243, 325);
            this.Tytul2.TabIndex = 10;
            this.Tytul2.Text = "2";
            // 
            // TytulGry4
            // 
            this.TytulGry4.AutoSize = true;
            this.TytulGry4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.TytulGry4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TytulGry4.Location = new System.Drawing.Point(162, 20);
            this.TytulGry4.Name = "TytulGry4";
            this.TytulGry4.Size = new System.Drawing.Size(136, 18);
            this.TytulGry4.TabIndex = 11;
            this.TytulGry4.Text = "NIELUcKA STONOGA";
            this.TytulGry4.Visible = false;
            // 
            // TytulGry3
            // 
            this.TytulGry3.AutoSize = true;
            this.TytulGry3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TytulGry3.Font = new System.Drawing.Font("Mistral", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytulGry3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TytulGry3.Location = new System.Drawing.Point(190, -22);
            this.TytulGry3.Name = "TytulGry3";
            this.TytulGry3.Size = new System.Drawing.Size(79, 103);
            this.TytulGry3.TabIndex = 12;
            this.TytulGry3.Text = "2";
            this.TytulGry3.Visible = false;
            // 
            // Przegrales
            // 
            this.Przegrales.AutoSize = true;
            this.Przegrales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Przegrales.Font = new System.Drawing.Font("Mistral", 66F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przegrales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(87)))), ((int)(((byte)(79)))));
            this.Przegrales.Location = new System.Drawing.Point(12, 200);
            this.Przegrales.Name = "Przegrales";
            this.Przegrales.Size = new System.Drawing.Size(418, 105);
            this.Przegrales.TabIndex = 13;
            this.Przegrales.Text = "PRZEGRAŁEŚ";
            this.Przegrales.Visible = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.Przegrales);
            this.Controls.Add(this.TytulGry4);
            this.Controls.Add(this.TytulGry);
            this.Controls.Add(this.Tytul2);
            this.Controls.Add(this.letsStart);
            this.Controls.Add(this.wDol);
            this.Controls.Add(this.wLewo);
            this.Controls.Add(this.wprawo);
            this.Controls.Add(this.doGory);
            this.Controls.Add(this.TytulGry3);
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "Start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wDol;
        private System.Windows.Forms.Button doGory;
        private System.Windows.Forms.Button wprawo;
        private System.Windows.Forms.Button wLewo;
        private System.Windows.Forms.Button letsStart;
        private System.Windows.Forms.Label TytulGry;
        private System.Windows.Forms.Label Tytul2;
        private System.Windows.Forms.Label TytulGry4;
        private System.Windows.Forms.Label TytulGry3;
        private System.Windows.Forms.Label Przegrales;
    }
}

