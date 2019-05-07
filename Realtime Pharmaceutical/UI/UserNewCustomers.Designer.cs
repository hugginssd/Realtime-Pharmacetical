namespace Realtime_Pharmaceutical.UI
{
    partial class UserNewCustomers
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
            this.TxtCustomerID = new Windows.Forms.HintTextBox(this.components);
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtContact = new Windows.Forms.HintTextBox(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtAddress = new Windows.Forms.HintTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCustomerName = new Windows.Forms.HintTextBox(this.components);
            this.CmbCustomerType = new System.Windows.Forms.ComboBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCustomerID
            // 
            this.TxtCustomerID.EnterToTab = false;
            this.TxtCustomerID.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerID.ForeColor = System.Drawing.Color.Gray;
            this.TxtCustomerID.HintColor = System.Drawing.Color.Gray;
            this.TxtCustomerID.HintValue = "CustomerID";
            this.TxtCustomerID.Location = new System.Drawing.Point(25, 95);
            this.TxtCustomerID.Name = "TxtCustomerID";
            this.TxtCustomerID.Size = new System.Drawing.Size(275, 23);
            this.TxtCustomerID.TabIndex = 22;
            this.TxtCustomerID.Text = "CustomerID";
            this.TxtCustomerID.TextForeColor = System.Drawing.Color.Black;
            this.TxtCustomerID.Value = "";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReset.Location = new System.Drawing.Point(197, 381);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(103, 33);
            this.BtnReset.TabIndex = 21;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCreate.Location = new System.Drawing.Point(24, 381);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(103, 33);
            this.BtnCreate.TabIndex = 20;
            this.BtnCreate.Text = "CREATE";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtContact
            // 
            this.TxtContact.EnterToTab = false;
            this.TxtContact.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContact.ForeColor = System.Drawing.Color.Gray;
            this.TxtContact.HintColor = System.Drawing.Color.Gray;
            this.TxtContact.HintValue = "Contact";
            this.TxtContact.Location = new System.Drawing.Point(24, 189);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(275, 23);
            this.TxtContact.TabIndex = 19;
            this.TxtContact.Text = "Contact";
            this.TxtContact.TextForeColor = System.Drawing.Color.Black;
            this.TxtContact.Value = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 283);
            this.dataGridView1.TabIndex = 18;
            // 
            // TxtAddress
            // 
            this.TxtAddress.EnterToTab = false;
            this.TxtAddress.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.ForeColor = System.Drawing.Color.Gray;
            this.TxtAddress.HintColor = System.Drawing.Color.Gray;
            this.TxtAddress.HintValue = "Address";
            this.TxtAddress.Location = new System.Drawing.Point(24, 264);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(276, 111);
            this.TxtAddress.TabIndex = 17;
            this.TxtAddress.Text = "Address";
            this.TxtAddress.TextForeColor = System.Drawing.Color.Black;
            this.TxtAddress.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "New Customers";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.EnterToTab = false;
            this.TxtCustomerName.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerName.ForeColor = System.Drawing.Color.Gray;
            this.TxtCustomerName.HintColor = System.Drawing.Color.Gray;
            this.TxtCustomerName.HintValue = "Customer name";
            this.TxtCustomerName.Location = new System.Drawing.Point(24, 144);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(275, 23);
            this.TxtCustomerName.TabIndex = 23;
            this.TxtCustomerName.Text = "Customer name";
            this.TxtCustomerName.TextForeColor = System.Drawing.Color.Black;
            this.TxtCustomerName.Value = "";
            // 
            // CmbCustomerType
            // 
            this.CmbCustomerType.FormattingEnabled = true;
            this.CmbCustomerType.Location = new System.Drawing.Point(24, 228);
            this.CmbCustomerType.Name = "CmbCustomerType";
            this.CmbCustomerType.Size = new System.Drawing.Size(254, 21);
            this.CmbCustomerType.TabIndex = 24;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCustomerType.Location = new System.Drawing.Point(27, 231);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(231, 15);
            this.lblCustomerType.TabIndex = 25;
            this.lblCustomerType.Text = "Customer type";
            // 
            // UserNewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.CmbCustomerType);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.TxtCustomerID);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtContact);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label1);
            this.Name = "UserNewCustomers";
            this.Size = new System.Drawing.Size(944, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.HintTextBox TxtCustomerID;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnCreate;
        private Windows.Forms.HintTextBox TxtContact;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Windows.Forms.HintTextBox TxtAddress;
        private System.Windows.Forms.Label label1;
        private Windows.Forms.HintTextBox TxtCustomerName;
        private System.Windows.Forms.ComboBox CmbCustomerType;
        private System.Windows.Forms.Label lblCustomerType;
    }
}
