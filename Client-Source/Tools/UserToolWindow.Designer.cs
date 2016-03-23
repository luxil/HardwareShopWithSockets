namespace Hardware_Shop_Client.Tools
{
    partial class UserToolWindow
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
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.textBox_editName = new System.Windows.Forms.TextBox();
            this.label_edit = new System.Windows.Forms.Label();
            this.label_editName = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.textBox_createName = new System.Windows.Forms.TextBox();
            this.label_create = new System.Windows.Forms.Label();
            this.label_createName = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView_results = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_editPassword = new System.Windows.Forms.TextBox();
            this.label_editPassword = new System.Windows.Forms.Label();
            this.textBox_createPassword = new System.Windows.Forms.TextBox();
            this.label_createPassword = new System.Windows.Forms.Label();
            this.textBox_editRole = new System.Windows.Forms.TextBox();
            this.label_editRole = new System.Windows.Forms.Label();
            this.textBox_createRole = new System.Windows.Forms.TextBox();
            this.label_createRole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_results)).BeginInit();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(157, 280);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 102;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(18, 280);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 101;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_editName
            // 
            this.textBox_editName.Location = new System.Drawing.Point(76, 199);
            this.textBox_editName.Name = "textBox_editName";
            this.textBox_editName.Size = new System.Drawing.Size(156, 20);
            this.textBox_editName.TabIndex = 100;
            // 
            // label_edit
            // 
            this.label_edit.AutoSize = true;
            this.label_edit.Location = new System.Drawing.Point(134, 171);
            this.label_edit.Name = "label_edit";
            this.label_edit.Size = new System.Drawing.Size(25, 13);
            this.label_edit.TabIndex = 99;
            this.label_edit.Text = "Edit";
            // 
            // label_editName
            // 
            this.label_editName.AutoSize = true;
            this.label_editName.Location = new System.Drawing.Point(15, 202);
            this.label_editName.Name = "label_editName";
            this.label_editName.Size = new System.Drawing.Size(38, 13);
            this.label_editName.TabIndex = 98;
            this.label_editName.Text = "Name:";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(18, 128);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 97;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // textBox_createName
            // 
            this.textBox_createName.Location = new System.Drawing.Point(76, 50);
            this.textBox_createName.Name = "textBox_createName";
            this.textBox_createName.Size = new System.Drawing.Size(156, 20);
            this.textBox_createName.TabIndex = 96;
            // 
            // label_create
            // 
            this.label_create.AutoSize = true;
            this.label_create.Location = new System.Drawing.Point(134, 23);
            this.label_create.Name = "label_create";
            this.label_create.Size = new System.Drawing.Size(38, 13);
            this.label_create.TabIndex = 95;
            this.label_create.Text = "Create";
            // 
            // label_createName
            // 
            this.label_createName.AutoSize = true;
            this.label_createName.Location = new System.Drawing.Point(15, 53);
            this.label_createName.Name = "label_createName";
            this.label_createName.Size = new System.Drawing.Size(38, 13);
            this.label_createName.TabIndex = 94;
            this.label_createName.Text = "Name:";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(432, 14);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 93;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(270, 16);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(156, 20);
            this.textBox_search.TabIndex = 92;
            this.textBox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_search_KeyPress);
            // 
            // dataGridView_results
            // 
            this.dataGridView_results.AllowUserToAddRows = false;
            this.dataGridView_results.AllowUserToDeleteRows = false;
            this.dataGridView_results.AllowUserToResizeColumns = false;
            this.dataGridView_results.AllowUserToResizeRows = false;
            this.dataGridView_results.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_results.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Name,
            this.Column_Items});
            this.dataGridView_results.Location = new System.Drawing.Point(270, 50);
            this.dataGridView_results.MultiSelect = false;
            this.dataGridView_results.Name = "dataGridView_results";
            this.dataGridView_results.ReadOnly = true;
            this.dataGridView_results.RowHeadersVisible = false;
            this.dataGridView_results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_results.Size = new System.Drawing.Size(237, 253);
            this.dataGridView_results.TabIndex = 91;
            this.dataGridView_results.SelectionChanged += new System.EventHandler(this.dataGridView_results_SelectionChanged);
            // 
            // Column_ID
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.Column_ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Width = 70;
            // 
            // Column_Name
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.Column_Name.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            this.Column_Name.Width = 105;
            // 
            // Column_Items
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.Column_Items.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_Items.HeaderText = "Items";
            this.Column_Items.Name = "Column_Items";
            this.Column_Items.ReadOnly = true;
            this.Column_Items.Width = 60;
            // 
            // textBox_editPassword
            // 
            this.textBox_editPassword.Location = new System.Drawing.Point(76, 225);
            this.textBox_editPassword.Name = "textBox_editPassword";
            this.textBox_editPassword.Size = new System.Drawing.Size(156, 20);
            this.textBox_editPassword.TabIndex = 104;
            // 
            // label_editPassword
            // 
            this.label_editPassword.AutoSize = true;
            this.label_editPassword.Location = new System.Drawing.Point(15, 228);
            this.label_editPassword.Name = "label_editPassword";
            this.label_editPassword.Size = new System.Drawing.Size(56, 13);
            this.label_editPassword.TabIndex = 103;
            this.label_editPassword.Text = "Password:";
            // 
            // textBox_createPassword
            // 
            this.textBox_createPassword.Location = new System.Drawing.Point(76, 76);
            this.textBox_createPassword.Name = "textBox_createPassword";
            this.textBox_createPassword.Size = new System.Drawing.Size(156, 20);
            this.textBox_createPassword.TabIndex = 106;
            // 
            // label_createPassword
            // 
            this.label_createPassword.AutoSize = true;
            this.label_createPassword.Location = new System.Drawing.Point(15, 79);
            this.label_createPassword.Name = "label_createPassword";
            this.label_createPassword.Size = new System.Drawing.Size(56, 13);
            this.label_createPassword.TabIndex = 105;
            this.label_createPassword.Text = "Password:";
            // 
            // textBox_editRole
            // 
            this.textBox_editRole.Location = new System.Drawing.Point(76, 251);
            this.textBox_editRole.Name = "textBox_editRole";
            this.textBox_editRole.Size = new System.Drawing.Size(32, 20);
            this.textBox_editRole.TabIndex = 108;
            // 
            // label_editRole
            // 
            this.label_editRole.AutoSize = true;
            this.label_editRole.Location = new System.Drawing.Point(15, 254);
            this.label_editRole.Name = "label_editRole";
            this.label_editRole.Size = new System.Drawing.Size(32, 13);
            this.label_editRole.TabIndex = 107;
            this.label_editRole.Text = "Role:";
            // 
            // textBox_createRole
            // 
            this.textBox_createRole.Location = new System.Drawing.Point(76, 102);
            this.textBox_createRole.Name = "textBox_createRole";
            this.textBox_createRole.Size = new System.Drawing.Size(32, 20);
            this.textBox_createRole.TabIndex = 110;
            // 
            // label_createRole
            // 
            this.label_createRole.AutoSize = true;
            this.label_createRole.Location = new System.Drawing.Point(15, 105);
            this.label_createRole.Name = "label_createRole";
            this.label_createRole.Size = new System.Drawing.Size(32, 13);
            this.label_createRole.TabIndex = 109;
            this.label_createRole.Text = "Role:";
            // 
            // UserToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 309);
            this.Controls.Add(this.textBox_createRole);
            this.Controls.Add(this.label_createRole);
            this.Controls.Add(this.textBox_editRole);
            this.Controls.Add(this.label_editRole);
            this.Controls.Add(this.textBox_createPassword);
            this.Controls.Add(this.label_createPassword);
            this.Controls.Add(this.textBox_editPassword);
            this.Controls.Add(this.label_editPassword);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.textBox_editName);
            this.Controls.Add(this.label_edit);
            this.Controls.Add(this.label_editName);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textBox_createName);
            this.Controls.Add(this.label_create);
            this.Controls.Add(this.label_createName);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView_results);
            this.Name = "UserToolWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware Shop - User Tool";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textBox_editName;
        private System.Windows.Forms.Label label_edit;
        private System.Windows.Forms.Label label_editName;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_createName;
        private System.Windows.Forms.Label label_create;
        private System.Windows.Forms.Label label_createName;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Items;
        private System.Windows.Forms.TextBox textBox_editPassword;
        private System.Windows.Forms.Label label_editPassword;
        private System.Windows.Forms.TextBox textBox_createPassword;
        private System.Windows.Forms.Label label_createPassword;
        private System.Windows.Forms.TextBox textBox_editRole;
        private System.Windows.Forms.Label label_editRole;
        private System.Windows.Forms.TextBox textBox_createRole;
        private System.Windows.Forms.Label label_createRole;
    }
}