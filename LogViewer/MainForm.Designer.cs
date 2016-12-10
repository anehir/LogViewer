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
            this.nextPageButton = new System.Windows.Forms.Button();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.gotoPageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pageCountTextBox = new System.Windows.Forms.TextBox();
            this.pageNoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.searchPatternTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.PageNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchCountToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pageNoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewerSplitContainer)).BeginInit();
            this.viewerSplitContainer.Panel1.SuspendLayout();
            this.viewerSplitContainer.Panel2.SuspendLayout();
            this.viewerSplitContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(75, 0);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(30, 22);
            this.nextPageButton.TabIndex = 1;
            this.nextPageButton.Text = ">";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(39, 0);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(30, 22);
            this.previousPageButton.TabIndex = 2;
            this.previousPageButton.Text = "<";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.previousPageButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(111, 0);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(30, 22);
            this.endButton.TabIndex = 3;
            this.endButton.Text = ">>";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(3, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(30, 22);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "<<";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // gotoPageButton
            // 
            this.gotoPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gotoPageButton.Location = new System.Drawing.Point(1024, 0);
            this.gotoPageButton.Name = "gotoPageButton";
            this.gotoPageButton.Size = new System.Drawing.Size(79, 22);
            this.gotoPageButton.TabIndex = 6;
            this.gotoPageButton.Text = "Go to Page";
            this.gotoPageButton.UseVisualStyleBackColor = true;
            this.gotoPageButton.Click += new System.EventHandler(this.gotoPageButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(866, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pages:";
            // 
            // pageCountTextBox
            // 
            this.pageCountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pageCountTextBox.Location = new System.Drawing.Point(912, 2);
            this.pageCountTextBox.Name = "pageCountTextBox";
            this.pageCountTextBox.ReadOnly = true;
            this.pageCountTextBox.Size = new System.Drawing.Size(50, 20);
            this.pageCountTextBox.TabIndex = 13;
            this.pageCountTextBox.TabStop = false;
            // 
            // pageNoNumericUpDown
            // 
            this.pageNoNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pageNoNumericUpDown.Location = new System.Drawing.Point(968, 2);
            this.pageNoNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNoNumericUpDown.Name = "pageNoNumericUpDown";
            this.pageNoNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.pageNoNumericUpDown.TabIndex = 5;
            this.pageNoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNoNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageNoNumericUpDown_KeyDown);
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPatternTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(1044, 20);
            this.searchPatternTextBox.TabIndex = 8;
            this.searchPatternTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchPatternTextBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(1053, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(50, 20);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultsDataGridView
            // 
            this.searchResultsDataGridView.AllowUserToAddRows = false;
            this.searchResultsDataGridView.AllowUserToDeleteRows = false;
            this.searchResultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultsDataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.searchResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageNo,
            this.Sample});
            this.searchResultsDataGridView.Location = new System.Drawing.Point(3, 29);
            this.searchResultsDataGridView.Name = "searchResultsDataGridView";
            this.searchResultsDataGridView.ReadOnly = true;
            this.searchResultsDataGridView.RowHeadersVisible = false;
            this.searchResultsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResultsDataGridView.Size = new System.Drawing.Size(1100, 140);
            this.searchResultsDataGridView.TabIndex = 10;
            this.searchResultsDataGridView.DoubleClick += new System.EventHandler(this.searchResultsDataGridView_DoubleClick);
            // 
            // PageNo
            // 
            this.PageNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PageNo.DataPropertyName = "PageNo";
            this.PageNo.HeaderText = "PageNo";
            this.PageNo.Name = "PageNo";
            this.PageNo.ReadOnly = true;
            this.PageNo.Width = 71;
            // 
            // Sample
            // 
            this.Sample.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sample.DataPropertyName = "Sample";
            this.Sample.HeaderText = "Sample";
            this.Sample.Name = "Sample";
            this.Sample.ReadOnly = true;
            this.Sample.Width = 67;
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentRichTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contentRichTextBox.Location = new System.Drawing.Point(3, 28);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.ReadOnly = true;
            this.contentRichTextBox.Size = new System.Drawing.Size(1106, 390);
            this.contentRichTextBox.TabIndex = 7;
            this.contentRichTextBox.Text = "";
            this.contentRichTextBox.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchVisibleToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // searchVisibleToolStripMenuItem
            // 
            this.searchVisibleToolStripMenuItem.Checked = true;
            this.searchVisibleToolStripMenuItem.CheckOnClick = true;
            this.searchVisibleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchVisibleToolStripMenuItem.Name = "searchVisibleToolStripMenuItem";
            this.searchVisibleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchVisibleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.searchVisibleToolStripMenuItem.Text = "Search Visible";
            this.searchVisibleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.searchVisibleToolStripMenuItem_CheckedChanged);
            // 
            // viewerSplitContainer
            // 
            this.viewerSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewerSplitContainer.BackColor = System.Drawing.SystemColors.ControlText;
            this.viewerSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.viewerSplitContainer.Name = "viewerSplitContainer";
            this.viewerSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // viewerSplitContainer.Panel1
            // 
            this.viewerSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.viewerSplitContainer.Panel1.Controls.Add(this.contentRichTextBox);
            this.viewerSplitContainer.Panel1.Controls.Add(this.homeButton);
            this.viewerSplitContainer.Panel1.Controls.Add(this.previousPageButton);
            this.viewerSplitContainer.Panel1.Controls.Add(this.nextPageButton);
            this.viewerSplitContainer.Panel1.Controls.Add(this.gotoPageButton);
            this.viewerSplitContainer.Panel1.Controls.Add(this.pageNoNumericUpDown);
            this.viewerSplitContainer.Panel1.Controls.Add(this.endButton);
            this.viewerSplitContainer.Panel1.Controls.Add(this.pageCountTextBox);
            this.viewerSplitContainer.Panel1.Controls.Add(this.label1);
            // 
            // viewerSplitContainer.Panel2
            // 
            this.viewerSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.viewerSplitContainer.Panel2.Controls.Add(this.searchResultsDataGridView);
            this.viewerSplitContainer.Panel2.Controls.Add(this.searchButton);
            this.viewerSplitContainer.Panel2.Controls.Add(this.searchPatternTextBox);
            this.viewerSplitContainer.Size = new System.Drawing.Size(1106, 594);
            this.viewerSplitContainer.SplitterDistance = 418;
            this.viewerSplitContainer.TabIndex = 22;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchCountToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 621);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1106, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchCountToolStripLabel
            // 
            this.searchCountToolStripLabel.Name = "searchCountToolStripLabel";
            this.searchCountToolStripLabel.Size = new System.Drawing.Size(74, 22);
            this.searchCountToolStripLabel.Text = "searchCount";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 646);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.viewerSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 684);
            this.Name = "MainForm";
            this.Text = "Log Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pageNoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.viewerSplitContainer.Panel1.ResumeLayout(false);
            this.viewerSplitContainer.Panel1.PerformLayout();
            this.viewerSplitContainer.Panel2.ResumeLayout(false);
            this.viewerSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewerSplitContainer)).EndInit();
            this.viewerSplitContainer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button gotoPageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pageCountTextBox;
        private System.Windows.Forms.NumericUpDown pageNoNumericUpDown;
        private System.Windows.Forms.TextBox searchPatternTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchResultsDataGridView;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SplitContainer viewerSplitContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel searchCountToolStripLabel;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchVisibleToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sample;
    }
}

