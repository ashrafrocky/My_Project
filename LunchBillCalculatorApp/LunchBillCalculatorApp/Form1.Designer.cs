namespace LunchBillCalculatorApp
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
            this.riceTextBox = new System.Windows.Forms.TextBox();
            this.fishTextBox = new System.Windows.Forms.TextBox();
            this.meatTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.netBillButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.GroupBox();
            this.vatLabel = new System.Windows.Forms.Label();
            this.l.SuspendLayout();
            this.SuspendLayout();
            // 
            // riceTextBox
            // 
            this.riceTextBox.Location = new System.Drawing.Point(198, 39);
            this.riceTextBox.Name = "riceTextBox";
            this.riceTextBox.Size = new System.Drawing.Size(115, 20);
            this.riceTextBox.TabIndex = 0;
            // 
            // fishTextBox
            // 
            this.fishTextBox.Location = new System.Drawing.Point(198, 65);
            this.fishTextBox.Name = "fishTextBox";
            this.fishTextBox.Size = new System.Drawing.Size(115, 20);
            this.fishTextBox.TabIndex = 1;
            // 
            // meatTextBox
            // 
            this.meatTextBox.Location = new System.Drawing.Point(198, 91);
            this.meatTextBox.Name = "meatTextBox";
            this.meatTextBox.Size = new System.Drawing.Size(115, 20);
            this.meatTextBox.TabIndex = 2;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(198, 144);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(115, 20);
            this.totalTextBox.TabIndex = 6;
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(198, 170);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(115, 20);
            this.discountTextBox.TabIndex = 4;
            // 
            // netBillButton
            // 
            this.netBillButton.Location = new System.Drawing.Point(198, 225);
            this.netBillButton.Name = "netBillButton";
            this.netBillButton.Size = new System.Drawing.Size(115, 23);
            this.netBillButton.TabIndex = 5;
            this.netBillButton.Text = "Show Net Bill";
            this.netBillButton.UseVisualStyleBackColor = true;
            this.netBillButton.Click += new System.EventHandler(this.netBillButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(27, 143);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(72, 20);
            this.totalButton.TabIndex = 3;
            this.totalButton.Text = "Show Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rice (Unit price: 20 tk)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fish (Unit price: 80 tk)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Meat (Unit price: 100 tk)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Gross";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Unit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "tk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "VAT (5%)";
            // 
            // l
            // 
            this.l.Controls.Add(this.vatLabel);
            this.l.Controls.Add(this.meatTextBox);
            this.l.Controls.Add(this.label10);
            this.l.Controls.Add(this.riceTextBox);
            this.l.Controls.Add(this.label11);
            this.l.Controls.Add(this.fishTextBox);
            this.l.Controls.Add(this.label5);
            this.l.Controls.Add(this.totalTextBox);
            this.l.Controls.Add(this.label9);
            this.l.Controls.Add(this.discountTextBox);
            this.l.Controls.Add(this.label4);
            this.l.Controls.Add(this.netBillButton);
            this.l.Controls.Add(this.label8);
            this.l.Controls.Add(this.totalButton);
            this.l.Controls.Add(this.label3);
            this.l.Controls.Add(this.label1);
            this.l.Controls.Add(this.label7);
            this.l.Controls.Add(this.label2);
            this.l.Controls.Add(this.label6);
            this.l.Location = new System.Drawing.Point(17, 18);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(369, 268);
            this.l.TabIndex = 4;
            this.l.TabStop = false;
            this.l.Text = "Bill For Lunch";
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.Location = new System.Drawing.Point(201, 200);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(58, 13);
            this.vatLabel.TabIndex = 4;
            this.vatLabel.Text = "                 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 306);
            this.Controls.Add(this.l);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Bill Calculator";
            this.l.ResumeLayout(false);
            this.l.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox riceTextBox;
        private System.Windows.Forms.TextBox fishTextBox;
        private System.Windows.Forms.TextBox meatTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Button netBillButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox l;
        private System.Windows.Forms.Label vatLabel;
    }
}

