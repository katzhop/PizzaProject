
namespace Pizza_Project
{
    partial class Deli_Carry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deli_Carry));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homebutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.carryoutbutton = new System.Windows.Forms.Button();
            this.deliverybutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(165, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.homebutton.TabIndex = 5;
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
            this.backbutton.Location = new System.Drawing.Point(1, 511);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(104, 94);
            this.backbutton.TabIndex = 6;
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // carryoutbutton
            // 
            this.carryoutbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carryoutbutton.BackgroundImage")));
            this.carryoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carryoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carryoutbutton.Location = new System.Drawing.Point(597, 266);
            this.carryoutbutton.Name = "carryoutbutton";
            this.carryoutbutton.Size = new System.Drawing.Size(360, 282);
            this.carryoutbutton.TabIndex = 8;
            this.carryoutbutton.UseVisualStyleBackColor = true;
            this.carryoutbutton.Click += new System.EventHandler(this.carryoutbutton_Click);
            // 
            // deliverybutton
            // 
            this.deliverybutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deliverybutton.BackgroundImage")));
            this.deliverybutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deliverybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deliverybutton.Location = new System.Drawing.Point(140, 266);
            this.deliverybutton.Name = "deliverybutton";
            this.deliverybutton.Size = new System.Drawing.Size(360, 282);
            this.deliverybutton.TabIndex = 9;
            this.deliverybutton.UseVisualStyleBackColor = true;
            this.deliverybutton.Click += new System.EventHandler(this.deliverybutton_Click);
            // 
            // Deli_Carry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.ControlBox = false;
            this.Controls.Add(this.deliverybutton);
            this.Controls.Add(this.carryoutbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Deli_Carry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deli_Carry";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button carryoutbutton;
        private System.Windows.Forms.Button deliverybutton;
    }
}