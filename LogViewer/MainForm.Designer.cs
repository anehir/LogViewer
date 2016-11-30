namespace LogViewer
{
    partial class MainForm
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
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.filePathLinkLabel = new System.Windows.Forms.LinkLabel();
            this.gotoPageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pageCountTextBox = new System.Windows.Forms.TextBox();
            this.pageNoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.searchPatternTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageNoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // downButton
            // 
            this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downButton.Location = new System.Drawing.Point(1044, 126);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(50, 39);
            this.downButton.TabIndex = 1;
            this.downButton.Text = "Page Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.Location = new System.Drawing.Point(1044, 81);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(50, 39);
            this.upButton.TabIndex = 2;
            this.upButton.Text = "Page Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // endButton
            // 
            this.endButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endButton.Location = new System.Drawing.Point(1044, 171);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(50, 39);
            this.endButton.TabIndex = 3;
            this.endButton.Text = "End";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.Location = new System.Drawing.Point(1044, 36);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(50, 39);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Location = new System.Drawing.Point(83, 10);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(955, 20);
            this.filePathTextBox.TabIndex = 5;
            this.filePathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filePathTextBox_KeyDown);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(1044, 10);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(50, 20);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // filePathLinkLabel
            // 
            this.filePathLinkLabel.AutoSize = true;
            this.filePathLinkLabel.Location = new System.Drawing.Point(12, 13);
            this.filePathLinkLabel.Name = "filePathLinkLabel";
            this.filePathLinkLabel.Size = new System.Drawing.Size(48, 13);
            this.filePathLinkLabel.TabIndex = 8;
            this.filePathLinkLabel.TabStop = true;
            this.filePathLinkLabel.Text = "File Path";
            this.filePathLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.filePathLinkLabel_LinkClicked);
            // 
            // gotoPageButton
            // 
            this.gotoPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gotoPageButton.Location = new System.Drawing.Point(1044, 313);
            this.gotoPageButton.Name = "gotoPageButton";
            this.gotoPageButton.Size = new System.Drawing.Size(50, 39);
            this.gotoPageButton.TabIndex = 11;
            this.gotoPageButton.Text = "Go to Page";
            this.gotoPageButton.UseVisualStyleBackColor = true;
            this.gotoPageButton.Click += new System.EventHandler(this.gotoPageButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1041, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pages:";
            // 
            // pageCountTextBox
            // 
            this.pageCountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pageCountTextBox.Location = new System.Drawing.Point(1044, 261);
            this.pageCountTextBox.Name = "pageCountTextBox";
            this.pageCountTextBox.ReadOnly = true;
            this.pageCountTextBox.Size = new System.Drawing.Size(50, 20);
            this.pageCountTextBox.TabIndex = 13;
            // 
            // pageNoNumericUpDown
            // 
            this.pageNoNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pageNoNumericUpDown.Location = new System.Drawing.Point(1044, 287);
            this.pageNoNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNoNumericUpDown.Name = "pageNoNumericUpDown";
            this.pageNoNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.pageNoNumericUpDown.TabIndex = 14;
            this.pageNoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNoNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageNoNumericUpDown_KeyDown);
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPatternTextBox.Location = new System.Drawing.Point(83, 475);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(955, 20);
            this.searchPatternTextBox.TabIndex = 15;
            this.searchPatternTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchPatternTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search Text";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(1044, 475);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(50, 20);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultsDataGridView
            // 
            this.searchResultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultsDataGridView.Location = new System.Drawing.Point(83, 501);
            this.searchResultsDataGridView.Name = "searchResultsDataGridView";
            this.searchResultsDataGridView.ReadOnly = true;
            this.searchResultsDataGridView.RowHeadersVisible = false;
            this.searchResultsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResultsDataGridView.Size = new System.Drawing.Size(955, 133);
            this.searchResultsDataGridView.TabIndex = 18;
            this.searchResultsDataGridView.DoubleClick += new System.EventHandler(this.searchResultsDataGridView_DoubleClick);
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentRichTextBox.Location = new System.Drawing.Point(83, 36);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(955, 433);
            this.contentRichTextBox.TabIndex = 19;
            this.contentRichTextBox.Text = "";
            this.contentRichTextBox.WordWrap = false;
            this.contentRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contentRichTextBox_KeyDown_1);
            // 
            // searchCountLabel
            // 
            this.searchCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCountLabel.Location = new System.Drawing.Point(1045, 502);
            this.searchCountLabel.Name = "searchCountLabel";
            this.searchCountLabel.Size = new System.Drawing.Size(49, 48);
            this.searchCountLabel.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 646);
            this.Controls.Add(this.searchCountLabel);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.searchResultsDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchPatternTextBox);
            this.Controls.Add(this.pageNoNumericUpDown);
            this.Controls.Add(this.pageCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gotoPageButton);
            this.Controls.Add(this.filePathLinkLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.downButton);
            this.MinimumSize = new System.Drawing.Size(600, 684);
            this.Name = "MainForm";
            this.Text = "Log Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pageNoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.LinkLabel filePathLinkLabel;
        private System.Windows.Forms.Button gotoPageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pageCountTextBox;
        private System.Windows.Forms.NumericUpDown pageNoNumericUpDown;
        private System.Windows.Forms.TextBox searchPatternTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchResultsDataGridView;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.Label searchCountLabel;
    }
}

