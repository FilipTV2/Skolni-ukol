namespace GUI_Razeni
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.otacky = new System.Windows.Forms.Label();
            this.tachac = new System.Windows.Forms.Label();
            this.otackoMer = new System.Windows.Forms.Label();
            this.tachometr = new System.Windows.Forms.Label();
            this.akcelerator = new System.Windows.Forms.TrackBar();
            this.otackoMetrBar = new System.Windows.Forms.ProgressBar();
            this.rychloMetrBar = new System.Windows.Forms.ProgressBar();
            this.spojka = new System.Windows.Forms.CheckBox();
            this.stupenJedna = new System.Windows.Forms.Button();
            this.stupenDva = new System.Windows.Forms.Button();
            this.stupenTri = new System.Windows.Forms.Button();
            this.stupenPet = new System.Windows.Forms.Button();
            this.stupenCtyri = new System.Windows.Forms.Button();
            this.stupenSest = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.akcelerator)).BeginInit();
            this.SuspendLayout();
            // 
            // otacky
            // 
            this.otacky.AutoSize = true;
            this.otacky.Location = new System.Drawing.Point(440, 51);
            this.otacky.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otacky.Name = "otacky";
            this.otacky.Size = new System.Drawing.Size(49, 16);
            this.otacky.TabIndex = 0;
            this.otacky.Text = "Otáčky";
            // 
            // tachac
            // 
            this.tachac.AutoSize = true;
            this.tachac.Location = new System.Drawing.Point(440, 78);
            this.tachac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tachac.Name = "tachac";
            this.tachac.Size = new System.Drawing.Size(59, 16);
            this.tachac.TabIndex = 1;
            this.tachac.Text = "Rychlost";
            // 
            // otackoMer
            // 
            this.otackoMer.AutoSize = true;
            this.otackoMer.Location = new System.Drawing.Point(494, 51);
            this.otackoMer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otackoMer.Name = "otackoMer";
            this.otackoMer.Size = new System.Drawing.Size(14, 16);
            this.otackoMer.TabIndex = 2;
            this.otackoMer.Text = "0";
            // 
            // tachometr
            // 
            this.tachometr.AutoSize = true;
            this.tachometr.Location = new System.Drawing.Point(514, 80);
            this.tachometr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tachometr.Name = "tachometr";
            this.tachometr.Size = new System.Drawing.Size(14, 16);
            this.tachometr.TabIndex = 3;
            this.tachometr.Text = "0";
            // 
            // akcelerator
            // 
            this.akcelerator.Location = new System.Drawing.Point(436, 372);
            this.akcelerator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.akcelerator.Maximum = 100;
            this.akcelerator.Name = "akcelerator";
            this.akcelerator.Size = new System.Drawing.Size(632, 56);
            this.akcelerator.TabIndex = 5;
            this.akcelerator.ValueChanged += new System.EventHandler(this.akcelerator_ValueChanged);
            // 
            // otackoMetrBar
            // 
            this.otackoMetrBar.Location = new System.Drawing.Point(552, 52);
            this.otackoMetrBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.otackoMetrBar.Maximum = 6000;
            this.otackoMetrBar.Name = "otackoMetrBar";
            this.otackoMetrBar.Size = new System.Drawing.Size(515, 16);
            this.otackoMetrBar.TabIndex = 6;
            // 
            // rychloMetrBar
            // 
            this.rychloMetrBar.Location = new System.Drawing.Point(552, 78);
            this.rychloMetrBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rychloMetrBar.Maximum = 400;
            this.rychloMetrBar.Name = "rychloMetrBar";
            this.rychloMetrBar.Size = new System.Drawing.Size(515, 18);
            this.rychloMetrBar.TabIndex = 7;
            // 
            // spojka
            // 
            this.spojka.AutoSize = true;
            this.spojka.Location = new System.Drawing.Point(998, 220);
            this.spojka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spojka.Name = "spojka";
            this.spojka.Size = new System.Drawing.Size(72, 20);
            this.spojka.TabIndex = 8;
            this.spojka.Text = "Spojka";
            this.spojka.UseVisualStyleBackColor = true;
            // 
            // stupenJedna
            // 
            this.stupenJedna.Location = new System.Drawing.Point(436, 153);
            this.stupenJedna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stupenJedna.Name = "stupenJedna";
            this.stupenJedna.Size = new System.Drawing.Size(66, 66);
            this.stupenJedna.TabIndex = 9;
            this.stupenJedna.Text = "1";
            this.stupenJedna.UseVisualStyleBackColor = true;
            this.stupenJedna.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stupenJedna_MouseClick);
            // 
            // stupenDva
            // 
            this.stupenDva.Location = new System.Drawing.Point(436, 246);
            this.stupenDva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stupenDva.Name = "stupenDva";
            this.stupenDva.Size = new System.Drawing.Size(66, 66);
            this.stupenDva.TabIndex = 10;
            this.stupenDva.Text = "2";
            this.stupenDva.UseVisualStyleBackColor = true;
            this.stupenDva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stupenDva_MouseClick);
            // 
            // stupenTri
            // 
            this.stupenTri.Location = new System.Drawing.Point(534, 153);
            this.stupenTri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stupenTri.Name = "stupenTri";
            this.stupenTri.Size = new System.Drawing.Size(66, 66);
            this.stupenTri.TabIndex = 11;
            this.stupenTri.Text = "3";
            this.stupenTri.UseVisualStyleBackColor = true;
            // 
            // stupenPet
            // 
            this.stupenPet.Location = new System.Drawing.Point(633, 153);
            this.stupenPet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stupenPet.Name = "stupenPet";
            this.stupenPet.Size = new System.Drawing.Size(66, 66);
            this.stupenPet.TabIndex = 12;
            this.stupenPet.Text = "5";
            this.stupenPet.UseVisualStyleBackColor = true;
            // 
            // stupenCtyri
            // 
            this.stupenCtyri.Location = new System.Drawing.Point(534, 246);
            this.stupenCtyri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stupenCtyri.Name = "stupenCtyri";
            this.stupenCtyri.Size = new System.Drawing.Size(66, 66);
            this.stupenCtyri.TabIndex = 13;
            this.stupenCtyri.Text = "4";
            this.stupenCtyri.UseVisualStyleBackColor = true;
            // 
            // stupenSest
            // 
            this.stupenSest.Location = new System.Drawing.Point(633, 246);
            this.stupenSest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stupenSest.Name = "stupenSest";
            this.stupenSest.Size = new System.Drawing.Size(66, 66);
            this.stupenSest.TabIndex = 14;
            this.stupenSest.Text = "6";
            this.stupenSest.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1107, 481);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(308, 122);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Push to Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 545);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stupenSest);
            this.Controls.Add(this.stupenCtyri);
            this.Controls.Add(this.stupenPet);
            this.Controls.Add(this.stupenTri);
            this.Controls.Add(this.stupenDva);
            this.Controls.Add(this.stupenJedna);
            this.Controls.Add(this.spojka);
            this.Controls.Add(this.rychloMetrBar);
            this.Controls.Add(this.otackoMetrBar);
            this.Controls.Add(this.akcelerator);
            this.Controls.Add(this.tachometr);
            this.Controls.Add(this.otackoMer);
            this.Controls.Add(this.tachac);
            this.Controls.Add(this.otacky);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.akcelerator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otacky;
        private System.Windows.Forms.Label tachac;
        private System.Windows.Forms.Label otackoMer;
        private System.Windows.Forms.Label tachometr;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TrackBar akcelerator;
        private System.Windows.Forms.ProgressBar otackoMetrBar;
        private System.Windows.Forms.ProgressBar rychloMetrBar;
        private System.Windows.Forms.CheckBox spojka;
        private System.Windows.Forms.Button stupenJedna;
        private System.Windows.Forms.Button stupenDva;
        private System.Windows.Forms.Button stupenTri;
        private System.Windows.Forms.Button stupenPet;
        private System.Windows.Forms.Button stupenCtyri;
        private System.Windows.Forms.Button stupenSest;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button startButton;
    }
}

