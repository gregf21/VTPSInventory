namespace VTPSInventory
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
            this.itemTextbox = new System.Windows.Forms.TextBox();
            this.itemSearchLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemLocationLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemTextbox
            // 
            this.itemTextbox.Location = new System.Drawing.Point(19, 49);
            this.itemTextbox.Name = "itemTextbox";
            this.itemTextbox.Size = new System.Drawing.Size(201, 26);
            this.itemTextbox.TabIndex = 0;
            // 
            // itemSearchLabel
            // 
            this.itemSearchLabel.AutoSize = true;
            this.itemSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSearchLabel.Location = new System.Drawing.Point(12, 9);
            this.itemSearchLabel.Name = "itemSearchLabel";
            this.itemSearchLabel.Size = new System.Drawing.Size(208, 37);
            this.itemSearchLabel.TabIndex = 1;
            this.itemSearchLabel.Text = "Item to Find:";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.Location = new System.Drawing.Point(12, 128);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(191, 37);
            this.itemNameLabel.TabIndex = 2;
            this.itemNameLabel.Text = "Item Name: ";
            // 
            // itemLocationLabel
            // 
            this.itemLocationLabel.AutoSize = true;
            this.itemLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLocationLabel.Location = new System.Drawing.Point(12, 165);
            this.itemLocationLabel.Name = "itemLocationLabel";
            this.itemLocationLabel.Size = new System.Drawing.Size(227, 37);
            this.itemLocationLabel.TabIndex = 3;
            this.itemLocationLabel.Text = "Item Location: ";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(19, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(201, 44);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 232);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.itemLocationLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.itemSearchLabel);
            this.Controls.Add(this.itemTextbox);
            this.Name = "Form1";
            this.Text = "Inventory Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemTextbox;
        private System.Windows.Forms.Label itemSearchLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label itemLocationLabel;
        private System.Windows.Forms.Button searchButton;
    }
}

