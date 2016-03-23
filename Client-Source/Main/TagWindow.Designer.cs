namespace Hardware_Shop_Client
{
    partial class TagWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_tags = new System.Windows.Forms.DataGridView();
            this.Column_searchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_searchTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_normalTags = new System.Windows.Forms.DataGridView();
            this.Column_tagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tagViews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_addTag = new System.Windows.Forms.Button();
            this.dataGridView_masterTags = new System.Windows.Forms.DataGridView();
            this.button_addMasterTag = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_removeTag = new System.Windows.Forms.Button();
            this.button_removeMasterTag = new System.Windows.Forms.Button();
            this.button_createTag = new System.Windows.Forms.Button();
            this.textBox_newTag = new System.Windows.Forms.TextBox();
            this.Column_masterTagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_masterTagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_masterTagViews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_normalTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_masterTags)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_tags
            // 
            this.dataGridView_tags.AllowUserToAddRows = false;
            this.dataGridView_tags.AllowUserToDeleteRows = false;
            this.dataGridView_tags.AllowUserToResizeColumns = false;
            this.dataGridView_tags.AllowUserToResizeRows = false;
            this.dataGridView_tags.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_tags.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_tags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_tags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_searchID,
            this.Column_searchTag});
            this.dataGridView_tags.Location = new System.Drawing.Point(12, 38);
            this.dataGridView_tags.MultiSelect = false;
            this.dataGridView_tags.Name = "dataGridView_tags";
            this.dataGridView_tags.ReadOnly = true;
            this.dataGridView_tags.RowHeadersVisible = false;
            this.dataGridView_tags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_tags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_tags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tags.Size = new System.Drawing.Size(237, 432);
            this.dataGridView_tags.TabIndex = 57;
            this.dataGridView_tags.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_tags_CellMouseDoubleClick);
            // 
            // Column_searchID
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.Column_searchID.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_searchID.HeaderText = "ID";
            this.Column_searchID.Name = "Column_searchID";
            this.Column_searchID.ReadOnly = true;
            this.Column_searchID.Width = 70;
            // 
            // Column_searchTag
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.Column_searchTag.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_searchTag.HeaderText = "Tag";
            this.Column_searchTag.Name = "Column_searchTag";
            this.Column_searchTag.ReadOnly = true;
            this.Column_searchTag.Width = 167;
            // 
            // dataGridView_normalTags
            // 
            this.dataGridView_normalTags.AllowUserToAddRows = false;
            this.dataGridView_normalTags.AllowUserToDeleteRows = false;
            this.dataGridView_normalTags.AllowUserToResizeColumns = false;
            this.dataGridView_normalTags.AllowUserToResizeRows = false;
            this.dataGridView_normalTags.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_normalTags.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_normalTags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_normalTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_normalTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_tagID,
            this.Column_tagName,
            this.Column_tagViews});
            this.dataGridView_normalTags.Location = new System.Drawing.Point(290, 38);
            this.dataGridView_normalTags.MultiSelect = false;
            this.dataGridView_normalTags.Name = "dataGridView_normalTags";
            this.dataGridView_normalTags.ReadOnly = true;
            this.dataGridView_normalTags.RowHeadersVisible = false;
            this.dataGridView_normalTags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_normalTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_normalTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_normalTags.Size = new System.Drawing.Size(237, 266);
            this.dataGridView_normalTags.TabIndex = 58;
            this.dataGridView_normalTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_normalTags_KeyDown);
            // 
            // Column_tagID
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.Column_tagID.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_tagID.HeaderText = "ID";
            this.Column_tagID.Name = "Column_tagID";
            this.Column_tagID.ReadOnly = true;
            this.Column_tagID.Width = 70;
            // 
            // Column_tagName
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            this.Column_tagName.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column_tagName.HeaderText = "Tag";
            this.Column_tagName.Name = "Column_tagName";
            this.Column_tagName.ReadOnly = true;
            this.Column_tagName.Width = 117;
            // 
            // Column_tagViews
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            this.Column_tagViews.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column_tagViews.HeaderText = "Views";
            this.Column_tagViews.Name = "Column_tagViews";
            this.Column_tagViews.ReadOnly = true;
            this.Column_tagViews.Width = 50;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(12, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(156, 20);
            this.textBox_search.TabIndex = 59;
            this.textBox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_search_KeyPress);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(371, 476);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 61;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(452, 476);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 62;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_addTag
            // 
            this.button_addTag.Location = new System.Drawing.Point(256, 162);
            this.button_addTag.Name = "button_addTag";
            this.button_addTag.Size = new System.Drawing.Size(28, 23);
            this.button_addTag.TabIndex = 63;
            this.button_addTag.Text = ">>";
            this.button_addTag.UseVisualStyleBackColor = true;
            this.button_addTag.Click += new System.EventHandler(this.button_addTag_Click);
            // 
            // dataGridView_masterTags
            // 
            this.dataGridView_masterTags.AllowUserToAddRows = false;
            this.dataGridView_masterTags.AllowUserToDeleteRows = false;
            this.dataGridView_masterTags.AllowUserToResizeColumns = false;
            this.dataGridView_masterTags.AllowUserToResizeRows = false;
            this.dataGridView_masterTags.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_masterTags.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_masterTags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_masterTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_masterTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_masterTagID,
            this.Column_masterTagName,
            this.Column_masterTagViews});
            this.dataGridView_masterTags.Location = new System.Drawing.Point(290, 339);
            this.dataGridView_masterTags.MultiSelect = false;
            this.dataGridView_masterTags.Name = "dataGridView_masterTags";
            this.dataGridView_masterTags.ReadOnly = true;
            this.dataGridView_masterTags.RowHeadersVisible = false;
            this.dataGridView_masterTags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_masterTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_masterTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_masterTags.Size = new System.Drawing.Size(237, 131);
            this.dataGridView_masterTags.TabIndex = 64;
            this.dataGridView_masterTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_masterTags_KeyDown);
            // 
            // button_addMasterTag
            // 
            this.button_addMasterTag.Location = new System.Drawing.Point(350, 310);
            this.button_addMasterTag.Name = "button_addMasterTag";
            this.button_addMasterTag.Size = new System.Drawing.Size(43, 23);
            this.button_addMasterTag.TabIndex = 65;
            this.button_addMasterTag.Text = "Down";
            this.button_addMasterTag.UseVisualStyleBackColor = true;
            this.button_addMasterTag.Click += new System.EventHandler(this.button_addMasterTag_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(174, 9);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 66;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_removeTag
            // 
            this.button_removeTag.Location = new System.Drawing.Point(256, 191);
            this.button_removeTag.Name = "button_removeTag";
            this.button_removeTag.Size = new System.Drawing.Size(28, 23);
            this.button_removeTag.TabIndex = 67;
            this.button_removeTag.Text = "<<";
            this.button_removeTag.UseVisualStyleBackColor = true;
            this.button_removeTag.Click += new System.EventHandler(this.button_removeTag_Click);
            // 
            // button_removeMasterTag
            // 
            this.button_removeMasterTag.Location = new System.Drawing.Point(419, 310);
            this.button_removeMasterTag.Name = "button_removeMasterTag";
            this.button_removeMasterTag.Size = new System.Drawing.Size(57, 23);
            this.button_removeMasterTag.TabIndex = 68;
            this.button_removeMasterTag.Text = "Up";
            this.button_removeMasterTag.UseVisualStyleBackColor = true;
            this.button_removeMasterTag.Click += new System.EventHandler(this.button_removeMasterTag_Click);
            // 
            // button_createTag
            // 
            this.button_createTag.Location = new System.Drawing.Point(174, 476);
            this.button_createTag.Name = "button_createTag";
            this.button_createTag.Size = new System.Drawing.Size(75, 23);
            this.button_createTag.TabIndex = 70;
            this.button_createTag.Text = "Create";
            this.button_createTag.UseVisualStyleBackColor = true;
            this.button_createTag.Click += new System.EventHandler(this.button_createTag_Click);
            // 
            // textBox_newTag
            // 
            this.textBox_newTag.Location = new System.Drawing.Point(12, 479);
            this.textBox_newTag.Name = "textBox_newTag";
            this.textBox_newTag.Size = new System.Drawing.Size(156, 20);
            this.textBox_newTag.TabIndex = 69;
            // 
            // Column_masterTagID
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            this.Column_masterTagID.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column_masterTagID.HeaderText = "ID";
            this.Column_masterTagID.Name = "Column_masterTagID";
            this.Column_masterTagID.ReadOnly = true;
            this.Column_masterTagID.Width = 70;
            // 
            // Column_masterTagName
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            this.Column_masterTagName.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column_masterTagName.HeaderText = "Master Tag";
            this.Column_masterTagName.Name = "Column_masterTagName";
            this.Column_masterTagName.ReadOnly = true;
            this.Column_masterTagName.Width = 117;
            // 
            // Column_masterTagViews
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Control;
            this.Column_masterTagViews.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column_masterTagViews.HeaderText = "Views";
            this.Column_masterTagViews.Name = "Column_masterTagViews";
            this.Column_masterTagViews.ReadOnly = true;
            this.Column_masterTagViews.Width = 50;
            // 
            // TagWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 509);
            this.Controls.Add(this.button_createTag);
            this.Controls.Add(this.textBox_newTag);
            this.Controls.Add(this.button_removeMasterTag);
            this.Controls.Add(this.button_removeTag);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_addMasterTag);
            this.Controls.Add(this.dataGridView_masterTags);
            this.Controls.Add(this.button_addTag);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView_normalTags);
            this.Controls.Add(this.dataGridView_tags);
            this.Name = "TagWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware Shop - Tag Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_normalTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_masterTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_tags;
        private System.Windows.Forms.DataGridView dataGridView_normalTags;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_addTag;
        private System.Windows.Forms.DataGridView dataGridView_masterTags;
        private System.Windows.Forms.Button button_addMasterTag;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_searchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_searchTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tagID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tagViews;
        private System.Windows.Forms.Button button_removeTag;
        private System.Windows.Forms.Button button_removeMasterTag;
        private System.Windows.Forms.Button button_createTag;
        private System.Windows.Forms.TextBox textBox_newTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_masterTagID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_masterTagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_masterTagViews;
    }
}