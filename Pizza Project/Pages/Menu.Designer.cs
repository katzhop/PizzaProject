
namespace Pizza_Project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.homebutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.pizzabutton = new System.Windows.Forms.Button();
            this.checkoutbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drinkbutton = new System.Windows.Forms.Button();
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
            this.homebutton.TabIndex = 0;
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
            this.backbutton.Size = new System.Drawing.Size(104, 94);
            this.backbutton.TabIndex = 1;
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // pizzabutton
            // 
            this.pizzabutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pizzabutton.BackgroundImage")));
            this.pizzabutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzabutton.Location = new System.Drawing.Point(145, 171);
            this.pizzabutton.Name = "pizzabutton";
            this.pizzabutton.Size = new System.Drawing.Size(351, 333);
            this.pizzabutton.TabIndex = 2;
            this.pizzabutton.UseVisualStyleBackColor = true;
            this.pizzabutton.Click += new System.EventHandler(this.pizzabutton_Click);
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.checkoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkoutbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbutton.Location = new System.Drawing.Point(739, 569);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Size = new System.Drawing.Size(336, 80);
            this.checkoutbutton.TabIndex = 6;
            this.checkoutbutton.Text = "Checkout";
            this.checkoutbutton.UseVisualStyleBackColor = false;
            this.checkoutbutton.Click += new System.EventHandler(this.checkoutbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(116)))), ((int)(((byte)(188)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(130, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(293, 67);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Menu";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkbutton
            // 
            this.drinkbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drinkbutton.BackgroundImage")));
            this.drinkbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drinkbutton.Location = new System.Drawing.Point(617, 171);
            this.drinkbutton.Name = "drinkbutton";
            this.drinkbutton.Size = new System.Drawing.Size(365, 333);
            this.drinkbutton.TabIndex = 8;
            this.drinkbutton.UseVisualStyleBackColor = true;
            this.drinkbutton.Click += new System.EventHandler(this.drinkbutton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.ControlBox = false;
            this.Controls.Add(this.drinkbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkoutbutton);
            this.Controls.Add(this.pizzabutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.homebutton);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button pizzabutton;
        private System.Windows.Forms.Button checkoutbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button drinkbutton;
    }
}