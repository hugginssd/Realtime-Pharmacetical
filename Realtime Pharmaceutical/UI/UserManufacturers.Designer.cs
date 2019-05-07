namespace Realtime_Pharmaceutical.UI
{
    partial class UserManufacturers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtAddress = new Windows.Forms.HintTextBox(this.components);
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new Windows.Forms.HintTextBox(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtManufacturerLicense = new Windows.Forms.HintTextBox(this.components);
            this.TxtManufacturerName = new Windows.Forms.HintTextBox(this.components);
            this.TxtManufactureID = new Windows.Forms.HintTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAddress
            // 
            this.TxtAddress.EnterToTab = false;
            this.TxtAddress.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.ForeColor = System.Drawing.Color.Gray;
            this.TxtAddress.HintColor = System.Drawing.Color.Gray;
            this.TxtAddress.HintValue = "Address";
            this.TxtAddress.Location = new System.Drawing.Point(18, 260);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(278, 78);
            this.TxtAddress.TabIndex = 50;
            this.TxtAddress.Text = "Address";
            this.TxtAddress.TextForeColor = System.Drawing.Color.Black;
            this.TxtAddress.Value = "";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSearch.Location = new System.Drawing.Point(830, 97);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(86, 23);
            this.BtnSearch.TabIndex = 49;
            this.BtnSearch.Text = "SEARCH";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtSearch
            // 
            this.TxtSearch.EnterToTab = false;
            this.TxtSearch.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.Gray;
            this.TxtSearch.HintColor = System.Drawing.Color.Gray;
            this.TxtSearch.HintValue = "Search here....";
            this.TxtSearch.Location = new System.Drawing.Point(328, 98);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(496, 23);
            this.TxtSearch.TabIndex = 48;
            this.TxtSearch.Text = "Search here....";
            this.TxtSearch.TextForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Value = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 270);
            this.dataGridView1.TabIndex = 47;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReset.Location = new System.Drawing.Point(177, 368);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(119, 29);
            this.BtnReset.TabIndex = 46;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnCreate.FlatAppearance.BorderSize = 0;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCreate.Location = new System.Drawing.Point(18, 368);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(119, 29);
            this.BtnCreate.TabIndex = 45;
            this.BtnCreate.Text = "CREATE";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtManufacturerLicense
            // 
            this.TxtManufacturerLicense.EnterToTab = false;
            this.TxtManufacturerLicense.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtManufacturerLicense.ForeColor = System.Drawing.Color.Gray;
            this.TxtManufacturerLicense.HintColor = System.Drawing.Color.Gray;
            this.TxtManufacturerLicense.HintValue = "Manufacturer License";
            this.TxtManufacturerLicense.Location = new System.Drawing.Point(18, 207);
            this.TxtManufacturerLicense.Name = "TxtManufacturerLicense";
            this.TxtManufacturerLicense.Size = new System.Drawing.Size(278, 23);
            this.TxtManufacturerLicense.TabIndex = 43;
            this.TxtManufacturerLicense.Text = "Manufacturer License";
            this.TxtManufacturerLicense.TextForeColor = System.Drawing.Color.Black;
            this.TxtManufacturerLicense.Value = "";
            // 
            // TxtManufacturerName
            // 
            this.TxtManufacturerName.EnterToTab = false;
            this.TxtManufacturerName.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtManufacturerName.ForeColor = System.Drawing.Color.Gray;
            this.TxtManufacturerName.HintColor = System.Drawing.Color.Gray;
            this.TxtManufacturerName.HintValue = "Manufacturer Name";
            this.TxtManufacturerName.Location = new System.Drawing.Point(18, 149);
            this.TxtManufacturerName.Name = "TxtManufacturerName";
            this.TxtManufacturerName.Size = new System.Drawing.Size(278, 23);
            this.TxtManufacturerName.TabIndex = 42;
            this.TxtManufacturerName.Text = "Manufacturer Name";
            this.TxtManufacturerName.TextForeColor = System.Drawing.Color.Black;
            this.TxtManufacturerName.Value = "";
            // 
            // TxtManufactureID
            // 
            this.TxtManufactureID.Enabled = false;
            this.TxtManufactureID.EnterToTab = false;
            this.TxtManufactureID.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtManufactureID.ForeColor = System.Drawing.Color.Gray;
            this.TxtManufactureID.HintColor = System.Drawing.Color.Gray;
            this.TxtManufactureID.HintValue = "ManufactureID";
            this.TxtManufactureID.Location = new System.Drawing.Point(18, 99);
            this.TxtManufactureID.Name = "TxtManufactureID";
            this.TxtManufactureID.Size = new System.Drawing.Size(278, 23);
            this.TxtManufactureID.TabIndex = 41;
            this.TxtManufactureID.Text = "ManufactureID";
            this.TxtManufactureID.TextForeColor = System.Drawing.Color.Black;
            this.TxtManufactureID.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "New System Users";
            // 
            // UserManufacturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtManufacturerLicense);
            this.Controls.Add(this.TxtManufacturerName);
            this.Controls.Add(this.TxtManufactureID);
            this.Controls.Add(this.label1);
            this.Name = "UserManufacturers";
            this.Size = new System.Drawing.Size(932, 421);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.HintTextBox TxtAddress;
        private System.Windows.Forms.Button BtnSearch;
        private Windows.Forms.HintTextBox TxtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnCreate;
        private Windows.Forms.HintTextBox TxtManufacturerLicense;
        private Windows.Forms.HintTextBox TxtManufacturerName;
        private Windows.Forms.HintTextBox TxtManufactureID;
        private System.Windows.Forms.Label label1;
    }
}
