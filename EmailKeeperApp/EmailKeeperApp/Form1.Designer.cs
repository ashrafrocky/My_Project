namespace EmailKeeperApp
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
            this.emailToAddLabel = new System.Windows.Forms.Label();
            this.emailToSearchLabel = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addListBox = new System.Windows.Forms.ListBox();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailToAddLabel
            // 
            this.emailToAddLabel.AutoSize = true;
            this.emailToAddLabel.Location = new System.Drawing.Point(29, 27);
            this.emailToAddLabel.Name = "emailToAddLabel";
            this.emailToAddLabel.Size = new System.Drawing.Size(65, 13);
            this.emailToAddLabel.TabIndex = 0;
            this.emailToAddLabel.Text = "Email to add";
            // 
            // emailToSearchLabel
            // 
            this.emailToSearchLabel.AutoSize = true;
            this.emailToSearchLabel.Location = new System.Drawing.Point(366, 30);
            this.emailToSearchLabel.Name = "emailToSearchLabel";
            this.emailToSearchLabel.Size = new System.Drawing.Size(79, 13);
            this.emailToSearchLabel.TabIndex = 0;
            this.emailToSearchLabel.Text = "Email to search";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(115, 27);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(181, 20);
            this.addTextBox.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(451, 27);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(173, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // addListBox
            // 
            this.addListBox.FormattingEnabled = true;
            this.addListBox.Location = new System.Drawing.Point(115, 117);
            this.addListBox.Name = "addListBox";
            this.addListBox.Size = new System.Drawing.Size(181, 134);
            this.addListBox.TabIndex = 2;
            this.addListBox.SelectedIndexChanged += new System.EventHandler(this.addListBox_SelectedIndexChanged);
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.Location = new System.Drawing.Point(451, 117);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(173, 134);
            this.searchListBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(221, 67);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(549, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 278);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchListBox);
            this.Controls.Add(this.addListBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.emailToSearchLabel);
            this.Controls.Add(this.emailToAddLabel);
            this.Name = "Form1";
            this.Text = "Email Keeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailToAddLabel;
        private System.Windows.Forms.Label emailToSearchLabel;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox addListBox;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
    }
}

