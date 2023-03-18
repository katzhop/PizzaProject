
namespace Pizza_Project
{
    partial class Quantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quantity));
            this.homebutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.minusbutton = new System.Windows.Forms.Button();
            this.plusbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.continuebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homebutton
            // 
            this.homebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homebutton.BackgroundImage")));
            this.homebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebutton.FlatAppearance.BorderSize = 0;
            this.homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebutton.ForeColor = System.Drawing.Color.Transparent;
            this.homebutton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.homebutton.Location = new System.Drawing.Point(1, 3);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(104, 90);
            this.homebutton.TabIndex = 11;
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton.BackgroundImage")));
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.ForeColor = System.Drawing.Color.Transparent;
            this.backbutton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.backbutton.Location = new System.Drawing.Point(1, 510);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(104, 93);
            this.backbutton.TabIndex = 12;
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // minusbutton
            // 
            this.minusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusbutton.Location = new System.Drawing.Point(188, 332);
            this.minusbutton.Name = "minusbutton";
            this.minusbutton.Size = new System.Drawing.Size(139, 151);
            this.minusbutton.TabIndex = 18;
            this.minusbutton.Text = "-";
            this.minusbutton.UseVisualStyleBackColor = true;
            this.minusbutton.Click += new System.EventHandler(this.minusbutton_Click);
            // 
            // plusbutton
            // 
            this.plusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusbutton.Location = new System.Drawing.Point(761, 332);
            this.plusbutton.Name = "plusbutton";
            this.plusbutton.Size = new System.Drawing.Size(139, 151);
            this.plusbutton.TabIndex = 17;
            this.plusbutton.Text = "+";
            this.plusbutton.UseVisualStyleBackColor = true;
            this.plusbutton.Click += new System.EventHandler(this.plusbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(386, 260);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(327, 291);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(345, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 102);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // continuebutton
            // 
            this.continuebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.continuebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.continuebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.continuebutton.FlatAppearance.BorderSize = 5;
            this.continuebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuebutton.Location = new System.Drawing.Point(810, 570);
            this.continuebutton.Name = "continuebutton";
            this.continuebutton.Size = new System.Drawing.Size(265, 75);
            this.continuebutton.TabIndex = 20;
            this.continuebutton.Text = "Continue";
            this.continuebutton.UseVisualStyleBackColor = false;
            this.continuebutton.Click += new System.EventHandler(this.continuebutton_Click);
            // 
            // Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.ControlBox = false;
            this.Controls.Add(this.continuebutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minusbutton);
            this.Controls.Add(this.plusbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.homebutton);
            this.Name = "Quantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantity";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button minusbutton;
        private System.Windows.Forms.Button plusbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button continuebutton;
    }
}