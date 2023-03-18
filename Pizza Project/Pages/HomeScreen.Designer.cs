
namespace Pizza_Project
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.customerbutton = new System.Windows.Forms.Button();
            this.managerbutton = new System.Windows.Forms.Button();
            this.workerbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerbutton
            // 
            this.customerbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customerbutton.BackgroundImage")));
            this.customerbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerbutton.Location = new System.Drawing.Point(26, 155);
            this.customerbutton.Name = "customerbutton";
            this.customerbutton.Size = new System.Drawing.Size(535, 421);
            this.customerbutton.TabIndex = 2;
            this.customerbutton.UseVisualStyleBackColor = true;
            this.customerbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // managerbutton
            // 
            this.managerbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("managerbutton.BackgroundImage")));
            this.managerbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.managerbutton.Location = new System.Drawing.Point(601, 116);
            this.managerbutton.Name = "managerbutton";
            this.managerbutton.Size = new System.Drawing.Size(442, 192);
            this.managerbutton.TabIndex = 5;
            this.managerbutton.UseVisualStyleBackColor = true;
            this.managerbutton.Click += new System.EventHandler(this.managerbutton_Click);
            // 
            // workerbutton
            // 
            this.workerbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("workerbutton.BackgroundImage")));
            this.workerbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.workerbutton.Location = new System.Drawing.Point(601, 352);
            this.workerbutton.Name = "workerbutton";
            this.workerbutton.Size = new System.Drawing.Size(442, 192);
            this.workerbutton.TabIndex = 6;
            this.workerbutton.UseVisualStyleBackColor = true;
            this.workerbutton.Click += new System.EventHandler(this.workerbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(116)))), ((int)(((byte)(188)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(465, 53);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Mom and Pop Pizza";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(1039, 1);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(41, 32);
            this.exitbutton.TabIndex = 9;
            this.exitbutton.Text = "X";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.ControlBox = false;
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.workerbutton);
            this.Controls.Add(this.managerbutton);
            this.Controls.Add(this.customerbutton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button customerbutton;
        private System.Windows.Forms.Button managerbutton;
        private System.Windows.Forms.Button workerbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button exitbutton;
    }
}

