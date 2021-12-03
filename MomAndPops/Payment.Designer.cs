
using System.Windows.Forms;

namespace MomAndPops
{
    partial class Payment
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
            this.CashButton = new System.Windows.Forms.RadioButton();
            this.CheckButton = new System.Windows.Forms.RadioButton();
            this.CardButton = new System.Windows.Forms.RadioButton();
            this.PickupButton = new System.Windows.Forms.RadioButton();
            this.DeliveryButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmitPayment = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Total = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.CardSubmit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ZipCode = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.TextBox();
            this.CVV = new System.Windows.Forms.TextBox();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CardXButton = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.CardPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(336, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mom && Pop\'s Pizzeria";
            // 
            // CashButton
            // 
            this.CashButton.AutoSize = true;
            this.CashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CashButton.Location = new System.Drawing.Point(13, 7);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(77, 29);
            this.CashButton.TabIndex = 2;
            this.CashButton.TabStop = true;
            this.CashButton.Text = "Cash";
            this.CashButton.UseVisualStyleBackColor = true;
            // 
            // CheckButton
            // 
            this.CheckButton.AutoSize = true;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CheckButton.Location = new System.Drawing.Point(109, 7);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(87, 29);
            this.CheckButton.TabIndex = 3;
            this.CheckButton.TabStop = true;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            // 
            // CardButton
            // 
            this.CardButton.AutoSize = true;
            this.CardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CardButton.Location = new System.Drawing.Point(211, 7);
            this.CardButton.Name = "CardButton";
            this.CardButton.Size = new System.Drawing.Size(73, 29);
            this.CardButton.TabIndex = 4;
            this.CardButton.TabStop = true;
            this.CardButton.Text = "Card";
            this.CardButton.UseVisualStyleBackColor = true;
            this.CardButton.CheckedChanged += new System.EventHandler(this.CardButton_CheckedChanged);
            // 
            // PickupButton
            // 
            this.PickupButton.AutoSize = true;
            this.PickupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PickupButton.Location = new System.Drawing.Point(11, 6);
            this.PickupButton.Name = "PickupButton";
            this.PickupButton.Size = new System.Drawing.Size(89, 29);
            this.PickupButton.TabIndex = 5;
            this.PickupButton.TabStop = true;
            this.PickupButton.Text = "Pickup";
            this.PickupButton.UseVisualStyleBackColor = true;
            // 
            // DeliveryButton
            // 
            this.DeliveryButton.AutoSize = true;
            this.DeliveryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeliveryButton.Location = new System.Drawing.Point(118, 6);
            this.DeliveryButton.Name = "DeliveryButton";
            this.DeliveryButton.Size = new System.Drawing.Size(100, 29);
            this.DeliveryButton.TabIndex = 6;
            this.DeliveryButton.TabStop = true;
            this.DeliveryButton.Text = "Delivery";
            this.DeliveryButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please Select Payment Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Please Select Delivery Option:";
            // 
            // SubmitPayment
            // 
            this.SubmitPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SubmitPayment.Location = new System.Drawing.Point(246, 381);
            this.SubmitPayment.Name = "SubmitPayment";
            this.SubmitPayment.Size = new System.Drawing.Size(118, 60);
            this.SubmitPayment.TabIndex = 9;
            this.SubmitPayment.Text = "Submit Payment";
            this.SubmitPayment.UseVisualStyleBackColor = true;
            this.SubmitPayment.Click += new System.EventHandler(this.SubmitPayment_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BackButton.Location = new System.Drawing.Point(393, 381);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(92, 60);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.CardButton);
            this.panel1.Controls.Add(this.CheckButton);
            this.panel1.Controls.Add(this.CashButton);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.panel1.Location = new System.Drawing.Point(218, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 46);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.DeliveryButton);
            this.panel2.Controls.Add(this.PickupButton);
            this.panel2.Location = new System.Drawing.Point(246, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 38);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.panel3.Controls.Add(this.Total);
            this.panel3.Controls.Add(this.Tax);
            this.panel3.Controls.Add(this.Subtotal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.SubtotalLabel);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.BackButton);
            this.panel3.Controls.Add(this.SubmitPayment);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(286, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 454);
            this.panel3.TabIndex = 15;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(382, 109);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(122, 37);
            this.Total.TabIndex = 21;
            this.Total.Text = "$00.00";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Tax.Location = new System.Drawing.Point(388, 69);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(97, 31);
            this.Tax.TabIndex = 20;
            this.Tax.Text = "$00.00";
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Subtotal.Location = new System.Drawing.Point(387, 38);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(97, 31);
            this.Subtotal.TabIndex = 19;
            this.Subtotal.Text = "$00.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(167, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tax:";
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SubtotalLabel.Location = new System.Drawing.Point(167, 38);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(129, 31);
            this.SubtotalLabel.TabIndex = 16;
            this.SubtotalLabel.Text = "Subtotal: ";
            // 
            // CardPanel
            // 
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.CardSubmit);
            this.CardPanel.Controls.Add(this.label11);
            this.CardPanel.Controls.Add(this.label10);
            this.CardPanel.Controls.Add(this.label9);
            this.CardPanel.Controls.Add(this.label8);
            this.CardPanel.Controls.Add(this.label7);
            this.CardPanel.Controls.Add(this.ZipCode);
            this.CardPanel.Controls.Add(this.Year);
            this.CardPanel.Controls.Add(this.Month);
            this.CardPanel.Controls.Add(this.CVV);
            this.CardPanel.Controls.Add(this.CardNumber);
            this.CardPanel.Controls.Add(this.panel6);
            this.CardPanel.Controls.Add(this.panel5);
            this.CardPanel.Enabled = false;
            this.CardPanel.Location = new System.Drawing.Point(281, 165);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(719, 421);
            this.CardPanel.TabIndex = 16;
            this.CardPanel.Visible = false;
            // 
            // CardSubmit
            // 
            this.CardSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CardSubmit.Location = new System.Drawing.Point(290, 357);
            this.CardSubmit.Name = "CardSubmit";
            this.CardSubmit.Size = new System.Drawing.Size(147, 48);
            this.CardSubmit.TabIndex = 12;
            this.CardSubmit.Text = "Submit";
            this.CardSubmit.UseVisualStyleBackColor = true;
            this.CardSubmit.Click += new System.EventHandler(this.CardSubmit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label11.Location = new System.Drawing.Point(94, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 31);
            this.label11.TabIndex = 11;
            this.label11.Text = "Zip Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label10.Location = new System.Drawing.Point(280, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 37);
            this.label10.TabIndex = 10;
            this.label10.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.Location = new System.Drawing.Point(19, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Expiration Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label8.Location = new System.Drawing.Point(45, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Card CVV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label7.Location = new System.Drawing.Point(7, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Card Number";
            // 
            // ZipCode
            // 
            this.ZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ZipCode.Location = new System.Drawing.Point(224, 295);
            this.ZipCode.MaxLength = 5;
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Size = new System.Drawing.Size(100, 38);
            this.ZipCode.TabIndex = 6;
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Year.Location = new System.Drawing.Point(306, 238);
            this.Year.MaxLength = 2;
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(50, 38);
            this.Year.TabIndex = 5;
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Month.Location = new System.Drawing.Point(224, 237);
            this.Month.MaxLength = 2;
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(50, 38);
            this.Month.TabIndex = 4;
            // 
            // CVV
            // 
            this.CVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CVV.Location = new System.Drawing.Point(224, 173);
            this.CVV.MaxLength = 3;
            this.CVV.Name = "CVV";
            this.CVV.Size = new System.Drawing.Size(100, 38);
            this.CVV.TabIndex = 3;
            // 
            // CardNumber
            // 
            this.CardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CardNumber.Location = new System.Drawing.Point(224, 104);
            this.CardNumber.MaxLength = 16;
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(284, 38);
            this.CardNumber.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.panel6.Controls.Add(this.CardXButton);
            this.panel6.Location = new System.Drawing.Point(658, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(59, 63);
            this.panel6.TabIndex = 1;
            // 
            // CardXButton
            // 
            this.CardXButton.AutoSize = true;
            this.CardXButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardXButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.CardXButton.Location = new System.Drawing.Point(-5, 0);
            this.CardXButton.Name = "CardXButton";
            this.CardXButton.Size = new System.Drawing.Size(65, 65);
            this.CardXButton.TabIndex = 0;
            this.CardXButton.Text = "X";
            this.CardXButton.Click += new System.EventHandler(this.CardXButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(-1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(663, 63);
            this.panel5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(420, 61);
            this.label6.TabIndex = 0;
            this.label6.Text = "Card Information";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.CardPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Payment";
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payment_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Payment_FormClosed);
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CashButton;
        private System.Windows.Forms.RadioButton CheckButton;
        private System.Windows.Forms.RadioButton CardButton;
        private System.Windows.Forms.RadioButton PickupButton;
        private System.Windows.Forms.RadioButton DeliveryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmitPayment;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CardSubmit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ZipCode;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox CVV;
        private System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.Label CardXButton;
    }
}