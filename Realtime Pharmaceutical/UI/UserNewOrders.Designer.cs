namespace Realtime_Pharmaceutical.UI
{
    partial class UserNewOrders
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
            this.txtDiscount = new Windows.Forms.HintTextBox(this.components);
            this.txtComment = new Windows.Forms.HintTextBox(this.components);
            this.txtAmountPaid = new Windows.Forms.HintTextBox(this.components);
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new Windows.Forms.HintTextBox(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtOrderID = new Windows.Forms.HintTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCustomerID = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.CmbUserID = new System.Windows.Forms.ComboBox();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.CmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiscount
            // 
            this.txtDiscount.EnterToTab = false;
            this.txtDiscount.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.Gray;
            this.txtDiscount.HintColor = System.Drawing.Color.Gray;
            this.txtDiscount.HintValue = "Discount";
            this.txtDiscount.Location = new System.Drawing.Point(14, 272);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(199, 23);
            this.txtDiscount.TabIndex = 52;
            this.txtDiscount.Text = "Discount";
            this.txtDiscount.TextForeColor = System.Drawing.Color.Black;
            this.txtDiscount.Value = "";
            // 
            // txtComment
            // 
            this.txtComment.EnterToTab = false;
            this.txtComment.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.ForeColor = System.Drawing.Color.Gray;
            this.txtComment.HintColor = System.Drawing.Color.Gray;
            this.txtComment.HintValue = "Comment";
            this.txtComment.Location = new System.Drawing.Point(242, 272);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(199, 73);
            this.txtComment.TabIndex = 51;
            this.txtComment.Text = "Comment";
            this.txtComment.TextForeColor = System.Drawing.Color.Black;
            this.txtComment.Value = "";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.EnterToTab = false;
            this.txtAmountPaid.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.ForeColor = System.Drawing.Color.Gray;
            this.txtAmountPaid.HintColor = System.Drawing.Color.Gray;
            this.txtAmountPaid.HintValue = "Amount Paid";
            this.txtAmountPaid.Location = new System.Drawing.Point(14, 322);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(199, 23);
            this.txtAmountPaid.TabIndex = 50;
            this.txtAmountPaid.Text = "Amount Paid";
            this.txtAmountPaid.TextForeColor = System.Drawing.Color.Black;
            this.txtAmountPaid.Value = "";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSearch.Location = new System.Drawing.Point(885, 101);
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
            this.TxtSearch.Location = new System.Drawing.Point(448, 102);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(431, 23);
            this.TxtSearch.TabIndex = 48;
            this.TxtSearch.Text = "Search here....";
            this.TxtSearch.TextForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Value = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 270);
            this.dataGridView1.TabIndex = 47;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReset.Location = new System.Drawing.Point(243, 372);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(119, 29);
            this.BtnReset.TabIndex = 46;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnCreate.FlatAppearance.BorderSize = 0;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCreate.Location = new System.Drawing.Point(14, 372);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(119, 29);
            this.BtnCreate.TabIndex = 45;
            this.BtnCreate.Text = "CREATE";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtOrderID
            // 
            this.TxtOrderID.Enabled = false;
            this.TxtOrderID.EnterToTab = false;
            this.TxtOrderID.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrderID.ForeColor = System.Drawing.Color.Gray;
            this.TxtOrderID.HintColor = System.Drawing.Color.Gray;
            this.TxtOrderID.HintValue = "OrderID";
            this.TxtOrderID.Location = new System.Drawing.Point(14, 103);
            this.TxtOrderID.Name = "TxtOrderID";
            this.TxtOrderID.Size = new System.Drawing.Size(199, 23);
            this.TxtOrderID.TabIndex = 41;
            this.TxtOrderID.Text = "OrderID";
            this.TxtOrderID.TextForeColor = System.Drawing.Color.Black;
            this.TxtOrderID.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Order Details";
            // 
            // CmbCustomerID
            // 
            this.CmbCustomerID.FormattingEnabled = true;
            this.CmbCustomerID.Location = new System.Drawing.Point(14, 157);
            this.CmbCustomerID.Name = "CmbCustomerID";
            this.CmbCustomerID.Size = new System.Drawing.Size(175, 21);
            this.CmbCustomerID.TabIndex = 54;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCustomerID.Location = new System.Drawing.Point(17, 160);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(159, 15);
            this.lblCustomerID.TabIndex = 56;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUserID.Location = new System.Drawing.Point(245, 160);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(159, 15);
            this.lblUserID.TabIndex = 58;
            this.lblUserID.Text = "UserID";
            // 
            // CmbUserID
            // 
            this.CmbUserID.FormattingEnabled = true;
            this.CmbUserID.Location = new System.Drawing.Point(242, 157);
            this.CmbUserID.Name = "CmbUserID";
            this.CmbUserID.Size = new System.Drawing.Size(175, 21);
            this.CmbUserID.TabIndex = 57;
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMode.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPaymentMode.Location = new System.Drawing.Point(16, 219);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(159, 15);
            this.lblPaymentMode.TabIndex = 60;
            this.lblPaymentMode.Text = "Payment Mode";
            // 
            // CmbPaymentMode
            // 
            this.CmbPaymentMode.FormattingEnabled = true;
            this.CmbPaymentMode.Location = new System.Drawing.Point(13, 216);
            this.CmbPaymentMode.Name = "CmbPaymentMode";
            this.CmbPaymentMode.Size = new System.Drawing.Size(175, 21);
            this.CmbPaymentMode.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(245, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Status";
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Paid",
            "Not Paid",
            "Balance"});
            this.CmbStatus.Location = new System.Drawing.Point(242, 215);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(175, 21);
            this.CmbStatus.TabIndex = 61;
            // 
            // UserNewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.lblPaymentMode);
            this.Controls.Add(this.CmbPaymentMode);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.CmbUserID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.CmbCustomerID);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtOrderID);
            this.Controls.Add(this.label1);
            this.Name = "UserNewOrders";
            this.Size = new System.Drawing.Size(1004, 436);
            this.Load += new System.EventHandler(this.UserNewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Windows.Forms.HintTextBox txtDiscount;
        private Windows.Forms.HintTextBox txtComment;
        private Windows.Forms.HintTextBox txtAmountPaid;
        private System.Windows.Forms.Button BtnSearch;
        private Windows.Forms.HintTextBox TxtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnCreate;
        private Windows.Forms.HintTextBox TxtOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.ComboBox CmbUserID;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.ComboBox CmbPaymentMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbStatus;
    }
}
