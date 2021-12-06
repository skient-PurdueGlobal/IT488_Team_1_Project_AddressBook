namespace IT488_Team_1_Project_AddressBook.PLL
{
    partial class AddressBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contactViewer = new System.Windows.Forms.DataGridView();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.lastNameRadio = new System.Windows.Forms.RadioButton();
            this.firstNameRadio = new System.Windows.Forms.RadioButton();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contactViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactViewer
            // 
            this.contactViewer.AllowUserToAddRows = false;
            this.contactViewer.AllowUserToDeleteRows = false;
            this.contactViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.contactViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contactViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.contactViewer.Location = new System.Drawing.Point(0, 0);
            this.contactViewer.Margin = new System.Windows.Forms.Padding(3, 1, 2, 1);
            this.contactViewer.MultiSelect = false;
            this.contactViewer.Name = "contactViewer";
            this.contactViewer.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.contactViewer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.contactViewer.RowTemplate.Height = 49;
            this.contactViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactViewer.ShowEditingIcon = false;
            this.contactViewer.Size = new System.Drawing.Size(798, 107);
            this.contactViewer.TabIndex = 0;
            this.contactViewer.SelectionChanged += new System.EventHandler(this.contactViewer_SelectionChanged);
            // 
            // mainContainer
            // 
            this.mainContainer.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.refreshButton);
            this.mainContainer.Panel1.Controls.Add(this.editButton);
            this.mainContainer.Panel1.Controls.Add(this.deleteButton);
            this.mainContainer.Panel1.Controls.Add(this.addButton);
            this.mainContainer.Panel1.Controls.Add(this.searchGroupBox);
            this.mainContainer.Panel1.Controls.Add(this.sortGroupBox);
            this.mainContainer.Panel1MinSize = 75;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.contactViewer);
            this.mainContainer.Panel2MinSize = 5;
            this.mainContainer.Size = new System.Drawing.Size(798, 192);
            this.mainContainer.SplitterDistance = 81;
            this.mainContainer.TabIndex = 2;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(228, 41);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(126, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit Contact";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(361, 41);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(126, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Contact";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(228, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Contact";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(493, 12);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(291, 54);
            this.searchGroupBox.TabIndex = 2;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(216, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(62, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 21);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(198, 23);
            this.searchTextBox.TabIndex = 0;
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.lastNameRadio);
            this.sortGroupBox.Controls.Add(this.firstNameRadio);
            this.sortGroupBox.Location = new System.Drawing.Point(12, 12);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(210, 54);
            this.sortGroupBox.TabIndex = 0;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort Contacts By";
            // 
            // lastNameRadio
            // 
            this.lastNameRadio.AutoSize = true;
            this.lastNameRadio.Location = new System.Drawing.Point(109, 22);
            this.lastNameRadio.Name = "lastNameRadio";
            this.lastNameRadio.Size = new System.Drawing.Size(81, 19);
            this.lastNameRadio.TabIndex = 1;
            this.lastNameRadio.Text = "Last Name";
            this.lastNameRadio.UseVisualStyleBackColor = true;
            this.lastNameRadio.CheckedChanged += new System.EventHandler(this.lastNameRadio_CheckedChanged);
            // 
            // firstNameRadio
            // 
            this.firstNameRadio.AutoSize = true;
            this.firstNameRadio.Checked = true;
            this.firstNameRadio.Location = new System.Drawing.Point(9, 22);
            this.firstNameRadio.Name = "firstNameRadio";
            this.firstNameRadio.Size = new System.Drawing.Size(82, 19);
            this.firstNameRadio.TabIndex = 0;
            this.firstNameRadio.TabStop = true;
            this.firstNameRadio.Text = "First Name";
            this.firstNameRadio.UseVisualStyleBackColor = true;
            this.firstNameRadio.CheckedChanged += new System.EventHandler(this.firstNameRadio_CheckedChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(361, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(126, 23);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh...";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 192);
            this.Controls.Add(this.mainContainer);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "AddressBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT488 Project - Address Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddressBook_FormClosing);
            this.Load += new System.EventHandler(this.AddressBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactViewer)).EndInit();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView contactViewer;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.RadioButton lastNameRadio;
        private System.Windows.Forms.RadioButton firstNameRadio;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button refreshButton;
    }
}