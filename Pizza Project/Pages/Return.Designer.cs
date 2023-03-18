
namespace Pizza_Project
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.returningbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(216, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // newbutton
            // 
            this.newbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newbutton.BackgroundImage")));
            this.newbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newbutton.Location = new System.Drawing.Point(581, 256);
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(360, 282);
            this.newbutton.TabIndex = 2;
            this.newbutton.UseVisualStyleBackColor = true;
            this.newbutton.Click += new System.EventHandler(this.newbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton.BackgroundImage")));
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.ForeColor = System.Drawing.Color.Transparent;
            this.backbutton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.backbutton.Location = new System.Drawing.Point(2, 511);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(104, 94);
            this.backbutton.TabIndex = 3;
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // homebutton
            // 
            this.homebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homebutton.BackgroundImage")));
            this.homebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebutton.FlatAppearance.BorderSize = 0;
            this.homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebutton.ForeColor = System.Drawing.Color.Transparent;
            this.homebutton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.homebutton.Location = new System.Drawing.Point(1, 2);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(104, 90);
            this.homebutton.TabIndex = 4;
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // returningbutton
            // 
            this.returningbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returningbutton.BackgroundImage")));
            this.returningbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returningbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returningbutton.Location = new System.Drawing.Point(158, 256);
            this.returningbutton.Name = "returningbutton";
            this.returningbutton.Size = new System.Drawing.Size(360, 282);
            this.returningbutton.TabIndex = 5;
            this.returningbutton.UseVisualStyleBackColor = true;
            this.returningbutton.Click += new System.EventHandler(this.returningbutton_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.ControlBox = false;
            this.Controls.Add(this.returningbutton);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.newbutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button newbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Button returningbutton;
    }
}