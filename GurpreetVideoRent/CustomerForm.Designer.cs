namespace GurpreetVideoRent
{
    partial class CustomerForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.updateCustomerBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.customerListDGV = new System.Windows.Forms.DataGridView();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.custIDTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Gray;
            this.backBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(1276, 354);
            this.backBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(125, 35);
            this.backBtn.TabIndex = 44;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.BackColor = System.Drawing.Color.Gray;
            this.deleteCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.deleteCustomerBtn.Location = new System.Drawing.Point(1020, 225);
            this.deleteCustomerBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(296, 112);
            this.deleteCustomerBtn.TabIndex = 43;
            this.deleteCustomerBtn.Text = "Delete Customer";
            this.deleteCustomerBtn.UseVisualStyleBackColor = false;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.BackColor = System.Drawing.Color.Gray;
            this.updateCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.updateCustomerBtn.Location = new System.Drawing.Point(686, 225);
            this.updateCustomerBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(296, 112);
            this.updateCustomerBtn.TabIndex = 42;
            this.updateCustomerBtn.Text = "Update Customer";
            this.updateCustomerBtn.UseVisualStyleBackColor = false;
            this.updateCustomerBtn.Click += new System.EventHandler(this.updateCustomerBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(159, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Customers List";
            // 
            // customerListDGV
            // 
            this.customerListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerListDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customerListDGV.Location = new System.Drawing.Point(164, 410);
            this.customerListDGV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.customerListDGV.Name = "customerListDGV";
            this.customerListDGV.RowHeadersWidth = 51;
            this.customerListDGV.Size = new System.Drawing.Size(1259, 414);
            this.customerListDGV.TabIndex = 40;
            this.customerListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerListDGV_CellContentClick);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.BackColor = System.Drawing.Color.Gray;
            this.addCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.addCustomerBtn.Location = new System.Drawing.Point(346, 225);
            this.addCustomerBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(296, 112);
            this.addCustomerBtn.TabIndex = 39;
            this.addCustomerBtn.Text = "Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = false;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // custIDTxt
            // 
            this.custIDTxt.Location = new System.Drawing.Point(69, 81);
            this.custIDTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.custIDTxt.Name = "custIDTxt";
            this.custIDTxt.Size = new System.Drawing.Size(79, 26);
            this.custIDTxt.TabIndex = 38;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(346, 124);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(340, 26);
            this.addressTxt.TabIndex = 37;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Location = new System.Drawing.Point(974, 124);
            this.phoneNumberTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(340, 26);
            this.phoneNumberTxt.TabIndex = 36;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(974, 81);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(340, 26);
            this.lastNameTxt.TabIndex = 35;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(346, 81);
            this.firstNameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(340, 26);
            this.firstNameTxt.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(853, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(176, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(818, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "First Name";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1490, 905);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.deleteCustomerBtn);
            this.Controls.Add(this.updateCustomerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerListDGV);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.custIDTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.phoneNumberTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerListDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button updateCustomerBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView customerListDGV;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.TextBox custIDTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}