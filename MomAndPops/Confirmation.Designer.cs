using System.Windows.Forms;

namespace MomAndPops
{
    partial class Confirmation
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeliveryText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.PickUpText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(360, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mom && Pop\'s Pizzeria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.pictureBox1.Location = new System.Drawing.Point(274, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 329);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(362, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "You order has been received";
            // 
            // DeliveryText
            // 
            this.DeliveryText.AutoSize = true;
            this.DeliveryText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.DeliveryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DeliveryText.Location = new System.Drawing.Point(389, 315);
            this.DeliveryText.Name = "DeliveryText";
            this.DeliveryText.Size = new System.Drawing.Size(448, 31);
            this.DeliveryText.TabIndex = 3;
            this.DeliveryText.Text = "Your order will be at your door soon!";
            this.DeliveryText.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(330, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(624, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thank you for ordering from Mom && Pop\'s Pizzeria!";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LogoutButton.Location = new System.Drawing.Point(568, 518);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(121, 55);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // PickUpText
            // 
            this.PickUpText.AutoSize = true;
            this.PickUpText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.PickUpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PickUpText.Location = new System.Drawing.Point(389, 315);
            this.PickUpText.Name = "PickUpText";
            this.PickUpText.Size = new System.Drawing.Size(497, 31);
            this.PickUpText.TabIndex = 6;
            this.PickUpText.Text = "Your order will be ready for pickup soon!";
            this.PickUpText.Visible = false;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PickUpText);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeliveryText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Confirmation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

/*        private void Confirmation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }*/

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DeliveryText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label PickUpText;
    }
}