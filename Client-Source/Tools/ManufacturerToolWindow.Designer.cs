namespace Hardware_Shop_Client.Tools
{
    partial class ManufacturerToolWindow
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
            this.textBox_edit = new System.Windows.Forms.TextBox();
            this.label_edit = new System.Windows.Forms.Label();
            this.label_editName = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.textBox_create = new System.Windows.Forms.TextBox();
            this.label_create = new System.Windows.Forms.Label();
            this.label_createName = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView_results = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_results)).BeginInit();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(137, 210);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 102;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(18, 210);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 101;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_edit
            // 
            this.textBox_edit.Location = new System.Drawing.Point(56, 173);
            this.textBox_edit.Name = "textBox_edit";
            this.textBox_edit.Size = new System.Drawing.Size(156, 20);
            this.textBox_edit.TabIndex = 100;
            // 
            // label_edit
            // 
            this.label_edit.AutoSize = true;
            this.label_edit.Location = new System.Drawing.Point(113, 144);
            this.label_edit.Name = "label_edit";
            this.label_edit.Size = new System.Drawing.Size(25, 13);
            this.label_edit.TabIndex = 99;
            this.label_edit.Text = "Edit";
            // 
            // label_editName
            // 
            this.label_editName.AutoSize = true;
            this.label_editName.Location = new System.Drawing.Point(15, 176);
            this.label_editName.Name = "label_editName";
            this.label_editName.Size = new System.Drawing.Size(38, 13);
            this.label_editName.TabIndex = 98;
            this.label_editName.Text = "Name:";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(18, 87);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 97;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // textBox_create
            // 
            this.textBox_create.Location = new System.Drawing.Point(56, 50);
            this.textBox_create.Name = "textBox_create";
            this.textBox_create.Size = new System.Drawing.Size(156, 20);
            this.textBox_create.TabIndex = 96;
            // 
            // label_create
            // 
            this.label_create.AutoSize = true;
            this.label_create.Location = new System.Drawing.Point(109, 23);
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
            this.button_search.Location = new System.Drawing.Point(405, 14);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 93;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(243, 16);
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
            this.dataGridView_results.Location = new System.Drawing.Point(243, 50);
            this.dataGridView_results.MultiSelect = false;
            this.dataGridView_results.Name = "dataGridView_results";
            this.dataGridView_results.ReadOnly = true;
            this.dataGridView_results.RowHeadersVisible = false;
            this.dataGridView_results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_results.Size = new System.Drawing.Size(237, 199);
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
            // ManufacturerToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 262);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.textBox_edit);
            this.Controls.Add(this.label_edit);
            this.Controls.Add(this.label_editName);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textBox_create);
            this.Controls.Add(this.label_create);
            this.Controls.Add(this.label_createName);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView_results);
            this.Name = "ManufacturerToolWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware Shop - Manufacturer Tool";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textBox_edit;
        private System.Windows.Forms.Label label_edit;
        private System.Windows.Forms.Label label_editName;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_create;
        private System.Windows.Forms.Label label_create;
        private System.Windows.Forms.Label label_createName;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Items;
    }
}