
namespace MomAndPops
{
    partial class Cart
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
            this.groupBoxCart = new System.Windows.Forms.GroupBox();
            this.listViewCart = new System.Windows.Forms.ListView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBoxCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCart
            // 
            this.groupBoxCart.AccessibleName = "Cart";
            this.groupBoxCart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxCart.BackColor = System.Drawing.Color.White;
            this.groupBoxCart.BackgroundImage = global::MomAndPops.Properties.Resources.testSlip;
            this.groupBoxCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxCart.Controls.Add(this.vScrollBar1);
            this.groupBoxCart.Controls.Add(this.listViewCart);
            this.groupBoxCart.Font = new System.Drawing.Font("Lucida Bright", 46F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.groupBoxCart.Location = new System.Drawing.Point(195, 12);
            this.groupBoxCart.Name = "groupBoxCart";
            this.groupBoxCart.Size = new System.Drawing.Size(843, 657);
            this.groupBoxCart.TabIndex = 0;
            this.groupBoxCart.TabStop = false;
            this.groupBoxCart.Text = "Cart";
            // 
            // listViewCart
            // 
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(59, 57);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(751, 414);
            this.listViewCart.TabIndex = 0;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(793, 57);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 414);
            this.vScrollBar1.TabIndex = 1;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBoxCart);
            this.Name = "Cart";
            this.Text = "Form1";
            this.groupBoxCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCart;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListView listViewCart;
    }
}