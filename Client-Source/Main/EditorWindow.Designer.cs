namespace Hardware_Shop_Client
{
    partial class EditorWindow
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
            this.comboBox_user = new System.Windows.Forms.ComboBox();
            this.label_editor = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.comboBox_subcategory = new System.Windows.Forms.ComboBox();
            this.label_subcategory = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_category = new System.Windows.Forms.Label();
            this.comboBox_manufacturer = new System.Windows.Forms.ComboBox();
            this.label_manufacture = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.date_creationDate = new System.Windows.Forms.DateTimePicker();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label_url = new System.Windows.Forms.Label();
            this.label_edit = new System.Windows.Forms.Label();
            this.dataGridView_normalTags = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Views = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_editTags = new System.Windows.Forms.Button();
            this.dataGridView_content = new System.Windows.Forms.DataGridView();
            this.Column_Value1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Value2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_masterTags = new System.Windows.Forms.DataGridView();
            this.Column_MasterTagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MasterTagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MasterViews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_url = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_normalTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_content)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_masterTags)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_user
            // 
            this.comboBox_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_user.FormattingEnabled = true;
            this.comboBox_user.Location = new System.Drawing.Point(67, 12);
            this.comboBox_user.Name = "comboBox_user";
            this.comboBox_user.Size = new System.Drawing.Size(170, 21);
            this.comboBox_user.TabIndex = 13;
            // 
            // label_editor
            // 
            this.label_editor.AutoSize = true;
            this.label_editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_editor.Location = new System.Drawing.Point(10, 15);
            this.label_editor.Name = "label_editor";
            this.label_editor.Size = new System.Drawing.Size(37, 13);
            this.label_editor.TabIndex = 12;
            this.label_editor.Text = "Editor:";
            // 
            // comboBox_status
            // 
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(67, 44);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(170, 21);
            this.comboBox_status.TabIndex = 15;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(10, 47);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(40, 13);
            this.label_status.TabIndex = 14;
            this.label_status.Text = "Status:";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(575, 9);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 33;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(656, 9);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(75, 23);
            this.button_new.TabIndex = 34;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(737, 9);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 35;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(818, 9);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 36;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // comboBox_subcategory
            // 
            this.comboBox_subcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subcategory.FormattingEnabled = true;
            this.comboBox_subcategory.Location = new System.Drawing.Point(387, 44);
            this.comboBox_subcategory.Name = "comboBox_subcategory";
            this.comboBox_subcategory.Size = new System.Drawing.Size(170, 21);
            this.comboBox_subcategory.TabIndex = 40;
            // 
            // label_subcategory
            // 
            this.label_subcategory.AutoSize = true;
            this.label_subcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subcategory.Location = new System.Drawing.Point(303, 47);
            this.label_subcategory.Name = "label_subcategory";
            this.label_subcategory.Size = new System.Drawing.Size(74, 13);
            this.label_subcategory.TabIndex = 39;
            this.label_subcategory.Text = "Sub-Category:";
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(387, 12);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(170, 21);
            this.comboBox_category.TabIndex = 38;
            this.comboBox_category.SelectionChangeCommitted += new System.EventHandler(this.comboBox_category_SelectionChangeCommitted);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(303, 15);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(52, 13);
            this.label_category.TabIndex = 37;
            this.label_category.Text = "Category:";
            // 
            // comboBox_manufacturer
            // 
            this.comboBox_manufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_manufacturer.FormattingEnabled = true;
            this.comboBox_manufacturer.Location = new System.Drawing.Point(387, 76);
            this.comboBox_manufacturer.Name = "comboBox_manufacturer";
            this.comboBox_manufacturer.Size = new System.Drawing.Size(170, 21);
            this.comboBox_manufacturer.TabIndex = 42;
            // 
            // label_manufacture
            // 
            this.label_manufacture.AutoSize = true;
            this.label_manufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manufacture.Location = new System.Drawing.Point(303, 79);
            this.label_manufacture.Name = "label_manufacture";
            this.label_manufacture.Size = new System.Drawing.Size(70, 13);
            this.label_manufacture.TabIndex = 41;
            this.label_manufacture.Text = "Manufacture:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(406, 563);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 13);
            this.label_id.TabIndex = 43;
            this.label_id.Text = "ID:";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(10, 77);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(33, 13);
            this.label_date.TabIndex = 46;
            this.label_date.Text = "Date:";
            // 
            // date_creationDate
            // 
            this.date_creationDate.Location = new System.Drawing.Point(92, 73);
            this.date_creationDate.Name = "date_creationDate";
            this.date_creationDate.Size = new System.Drawing.Size(145, 20);
            this.date_creationDate.TabIndex = 45;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(10, 134);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(30, 13);
            this.label_title.TabIndex = 49;
            this.label_title.Text = "Title:";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(67, 131);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(490, 20);
            this.textBox_title.TabIndex = 50;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(67, 162);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(490, 20);
            this.textBox_name.TabIndex = 52;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(10, 165);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 51;
            this.label_name.Text = "Name:";
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(67, 192);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.ReadOnly = true;
            this.textBox_url.Size = new System.Drawing.Size(409, 20);
            this.textBox_url.TabIndex = 54;
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_url.Location = new System.Drawing.Point(10, 195);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(32, 13);
            this.label_url.TabIndex = 53;
            this.label_url.Text = "URL:";
            // 
            // label_edit
            // 
            this.label_edit.AutoSize = true;
            this.label_edit.Location = new System.Drawing.Point(12, 563);
            this.label_edit.Name = "label_edit";
            this.label_edit.Size = new System.Drawing.Size(54, 13);
            this.label_edit.TabIndex = 55;
            this.label_edit.Text = "Last Edit: ";
            // 
            // dataGridView_normalTags
            // 
            this.dataGridView_normalTags.AllowUserToAddRows = false;
            this.dataGridView_normalTags.AllowUserToDeleteRows = false;
            this.dataGridView_normalTags.AllowUserToResizeColumns = false;
            this.dataGridView_normalTags.AllowUserToResizeRows = false;
            this.dataGridView_normalTags.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_normalTags.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_normalTags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_normalTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_normalTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_TagName,
            this.Column_Views});
            this.dataGridView_normalTags.Enabled = false;
            this.dataGridView_normalTags.Location = new System.Drawing.Point(575, 101);
            this.dataGridView_normalTags.Name = "dataGridView_normalTags";
            this.dataGridView_normalTags.ReadOnly = true;
            this.dataGridView_normalTags.RowHeadersVisible = false;
            this.dataGridView_normalTags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_normalTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_normalTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_normalTags.Size = new System.Drawing.Size(318, 320);
            this.dataGridView_normalTags.TabIndex = 56;
            // 
            // Column_ID
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.Column_ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Width = 82;
            // 
            // Column_TagName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.Column_TagName.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_TagName.HeaderText = "Tag";
            this.Column_TagName.Name = "Column_TagName";
            this.Column_TagName.ReadOnly = true;
            this.Column_TagName.Width = 180;
            // 
            // Column_Views
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.Column_Views.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_Views.HeaderText = "Views";
            this.Column_Views.Name = "Column_Views";
            this.Column_Views.ReadOnly = true;
            this.Column_Views.Width = 55;
            // 
            // button_editTags
            // 
            this.button_editTags.Location = new System.Drawing.Point(575, 67);
            this.button_editTags.Name = "button_editTags";
            this.button_editTags.Size = new System.Drawing.Size(75, 23);
            this.button_editTags.TabIndex = 57;
            this.button_editTags.Text = "Edit Tags";
            this.button_editTags.UseVisualStyleBackColor = true;
            this.button_editTags.Click += new System.EventHandler(this.button_editTags_Click);
            // 
            // dataGridView_content
            // 
            this.dataGridView_content.AllowUserToAddRows = false;
            this.dataGridView_content.AllowUserToDeleteRows = false;
            this.dataGridView_content.AllowUserToResizeColumns = false;
            this.dataGridView_content.AllowUserToResizeRows = false;
            this.dataGridView_content.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_content.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_content.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_content.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Value1,
            this.Column_Value2});
            this.dataGridView_content.Location = new System.Drawing.Point(12, 233);
            this.dataGridView_content.Name = "dataGridView_content";
            this.dataGridView_content.RowHeadersVisible = false;
            this.dataGridView_content.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_content.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_content.Size = new System.Drawing.Size(545, 323);
            this.dataGridView_content.TabIndex = 58;
            // 
            // Column_Value1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            this.Column_Value1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column_Value1.HeaderText = "Value1";
            this.Column_Value1.Name = "Column_Value1";
            this.Column_Value1.ReadOnly = true;
            this.Column_Value1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Value1.Width = 90;
            // 
            // Column_Value2
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            this.Column_Value2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column_Value2.HeaderText = "Value2";
            this.Column_Value2.Name = "Column_Value2";
            this.Column_Value2.Width = 455;
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
            this.Column_MasterTagID,
            this.Column_MasterTagName,
            this.Column_MasterViews});
            this.dataGridView_masterTags.Enabled = false;
            this.dataGridView_masterTags.Location = new System.Drawing.Point(575, 430);
            this.dataGridView_masterTags.Name = "dataGridView_masterTags";
            this.dataGridView_masterTags.ReadOnly = true;
            this.dataGridView_masterTags.RowHeadersVisible = false;
            this.dataGridView_masterTags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_masterTags.RowTemplate.ReadOnly = true;
            this.dataGridView_masterTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_masterTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_masterTags.Size = new System.Drawing.Size(318, 126);
            this.dataGridView_masterTags.TabIndex = 59;
            // 
            // Column_MasterTagID
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            this.Column_MasterTagID.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column_MasterTagID.HeaderText = "ID";
            this.Column_MasterTagID.Name = "Column_MasterTagID";
            this.Column_MasterTagID.ReadOnly = true;
            this.Column_MasterTagID.Width = 82;
            // 
            // Column_MasterTagName
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            this.Column_MasterTagName.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column_MasterTagName.HeaderText = "Tag";
            this.Column_MasterTagName.Name = "Column_MasterTagName";
            this.Column_MasterTagName.ReadOnly = true;
            this.Column_MasterTagName.Width = 180;
            // 
            // Column_MasterViews
            // 
            this.Column_MasterViews.HeaderText = "Views";
            this.Column_MasterViews.Name = "Column_MasterViews";
            this.Column_MasterViews.ReadOnly = true;
            this.Column_MasterViews.Width = 55;
            // 
            // button_url
            // 
            this.button_url.Location = new System.Drawing.Point(482, 190);
            this.button_url.Name = "button_url";
            this.button_url.Size = new System.Drawing.Size(75, 23);
            this.button_url.TabIndex = 60;
            this.button_url.Text = "Edit URL";
            this.button_url.UseVisualStyleBackColor = true;
            this.button_url.Click += new System.EventHandler(this.button_url_Click);
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 582);
            this.Controls.Add(this.button_url);
            this.Controls.Add(this.dataGridView_masterTags);
            this.Controls.Add(this.dataGridView_content);
            this.Controls.Add(this.button_editTags);
            this.Controls.Add(this.dataGridView_normalTags);
            this.Controls.Add(this.label_edit);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.date_creationDate);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.comboBox_manufacturer);
            this.Controls.Add(this.label_manufacture);
            this.Controls.Add(this.comboBox_subcategory);
            this.Controls.Add(this.label_subcategory);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.comboBox_user);
            this.Controls.Add(this.label_editor);
            this.Name = "EditorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware Shop - Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_normalTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_content)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_masterTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_user;
        private System.Windows.Forms.Label label_editor;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ComboBox comboBox_subcategory;
        private System.Windows.Forms.Label label_subcategory;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ComboBox comboBox_manufacturer;
        private System.Windows.Forms.Label label_manufacture;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DateTimePicker date_creationDate;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Label label_edit;
        private System.Windows.Forms.DataGridView dataGridView_normalTags;
        private System.Windows.Forms.Button button_editTags;
        private System.Windows.Forms.DataGridView dataGridView_content;
        private System.Windows.Forms.DataGridView dataGridView_masterTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Views;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Value1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Value2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MasterTagID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MasterTagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MasterViews;
        private System.Windows.Forms.Button button_url;
        public System.Windows.Forms.TextBox textBox_url;
    }
}