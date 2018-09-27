namespace WindowsFormsApp2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Immutable = new System.Windows.Forms.Button();
            this.Oscilator = new System.Windows.Forms.Button();
            this.Glider = new System.Windows.Forms.Button();
            this.Dakota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 519);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 565);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "300";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 565);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "300";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rozmiar Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rozmiar X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Twórz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(806, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Immutable
            // 
            this.Immutable.Location = new System.Drawing.Point(442, 560);
            this.Immutable.Name = "Immutable";
            this.Immutable.Size = new System.Drawing.Size(75, 23);
            this.Immutable.TabIndex = 7;
            this.Immutable.Text = "Immutable";
            this.Immutable.UseVisualStyleBackColor = true;
            this.Immutable.Click += new System.EventHandler(this.button3_Click);
            // 
            // Oscilator
            // 
            this.Oscilator.Location = new System.Drawing.Point(523, 561);
            this.Oscilator.Name = "Oscilator";
            this.Oscilator.Size = new System.Drawing.Size(75, 23);
            this.Oscilator.TabIndex = 8;
            this.Oscilator.Text = "Oscilator";
            this.Oscilator.UseVisualStyleBackColor = true;
            this.Oscilator.Click += new System.EventHandler(this.Oscilator_Click);
            // 
            // Glider
            // 
            this.Glider.Location = new System.Drawing.Point(604, 560);
            this.Glider.Name = "Glider";
            this.Glider.Size = new System.Drawing.Size(75, 23);
            this.Glider.TabIndex = 9;
            this.Glider.Text = "Glider";
            this.Glider.UseVisualStyleBackColor = true;
            this.Glider.Click += new System.EventHandler(this.Glider_Click);
            // 
            // Dakota
            // 
            this.Dakota.Location = new System.Drawing.Point(685, 561);
            this.Dakota.Name = "Dakota";
            this.Dakota.Size = new System.Drawing.Size(75, 23);
            this.Dakota.TabIndex = 10;
            this.Dakota.Text = "Dakota";
            this.Dakota.UseVisualStyleBackColor = true;
            this.Dakota.Click += new System.EventHandler(this.Dakota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 603);
            this.Controls.Add(this.Dakota);
            this.Controls.Add(this.Glider);
            this.Controls.Add(this.Oscilator);
            this.Controls.Add(this.Immutable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Immutable;
        private System.Windows.Forms.Button Oscilator;
        private System.Windows.Forms.Button Glider;
        private System.Windows.Forms.Button Dakota;
    }
}

