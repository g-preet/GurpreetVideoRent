namespace GurpreetVideoRent
{
    partial class RentalForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOutRented = new System.Windows.Forms.RadioButton();
            this.radioButtonAllRented = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.returnMovieBtn = new System.Windows.Forms.Button();
            this.issueMovieBtn = new System.Windows.Forms.Button();
            this.textBoxPlot = new System.Windows.Forms.TextBox();
            this.textBoxRentalCost = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxRentalID = new System.Windows.Forms.TextBox();
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.textCustID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPlot = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGWMovieList = new System.Windows.Forms.DataGridView();
            this.dGWCustomerList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgWMovieRentalList = new System.Windows.Forms.DataGridView();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMovieList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWMovieRentalList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.radioButtonOutRented);
            this.groupBox1.Controls.Add(this.radioButtonAllRented);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(672, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(549, 129);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rented Movies";
            // 
            // radioButtonOutRented
            // 
            this.radioButtonOutRented.AutoSize = true;
            this.radioButtonOutRented.ForeColor = System.Drawing.Color.White;
            this.radioButtonOutRented.Location = new System.Drawing.Point(274, 69);
            this.radioButtonOutRented.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButtonOutRented.Name = "radioButtonOutRented";
            this.radioButtonOutRented.Size = new System.Drawing.Size(115, 24);
            this.radioButtonOutRented.TabIndex = 1;
            this.radioButtonOutRented.TabStop = true;
            this.radioButtonOutRented.Text = "Out Rented";
            this.radioButtonOutRented.UseVisualStyleBackColor = true;
            this.radioButtonOutRented.CheckedChanged += new System.EventHandler(this.radioButtonOutRented_CheckedChanged);
            // 
            // radioButtonAllRented
            // 
            this.radioButtonAllRented.AutoSize = true;
            this.radioButtonAllRented.ForeColor = System.Drawing.Color.White;
            this.radioButtonAllRented.Location = new System.Drawing.Point(11, 69);
            this.radioButtonAllRented.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButtonAllRented.Name = "radioButtonAllRented";
            this.radioButtonAllRented.Size = new System.Drawing.Size(107, 24);
            this.radioButtonAllRented.TabIndex = 0;
            this.radioButtonAllRented.TabStop = true;
            this.radioButtonAllRented.Text = "All Rented";
            this.radioButtonAllRented.UseVisualStyleBackColor = true;
            this.radioButtonAllRented.CheckedChanged += new System.EventHandler(this.radioButtonAllRented_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1294, 594);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 35);
            this.btnBack.TabIndex = 82;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // returnMovieBtn
            // 
            this.returnMovieBtn.BackColor = System.Drawing.Color.Gray;
            this.returnMovieBtn.Location = new System.Drawing.Point(1235, 416);
            this.returnMovieBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.returnMovieBtn.Name = "returnMovieBtn";
            this.returnMovieBtn.Size = new System.Drawing.Size(184, 111);
            this.returnMovieBtn.TabIndex = 81;
            this.returnMovieBtn.Text = "Return Movie";
            this.returnMovieBtn.UseVisualStyleBackColor = false;
            this.returnMovieBtn.Click += new System.EventHandler(this.returnMovieBtn_Click);
            // 
            // issueMovieBtn
            // 
            this.issueMovieBtn.BackColor = System.Drawing.Color.Gray;
            this.issueMovieBtn.Location = new System.Drawing.Point(1231, 248);
            this.issueMovieBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.issueMovieBtn.Name = "issueMovieBtn";
            this.issueMovieBtn.Size = new System.Drawing.Size(170, 111);
            this.issueMovieBtn.TabIndex = 80;
            this.issueMovieBtn.Text = "Issue Movie";
            this.issueMovieBtn.UseVisualStyleBackColor = false;
            this.issueMovieBtn.Click += new System.EventHandler(this.issueMovieBtn_Click);
            // 
            // textBoxPlot
            // 
            this.textBoxPlot.Location = new System.Drawing.Point(808, 175);
            this.textBoxPlot.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxPlot.Name = "textBoxPlot";
            this.textBoxPlot.Size = new System.Drawing.Size(223, 26);
            this.textBoxPlot.TabIndex = 79;
            // 
            // textBoxRentalCost
            // 
            this.textBoxRentalCost.Location = new System.Drawing.Point(505, 175);
            this.textBoxRentalCost.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxRentalCost.Name = "textBoxRentalCost";
            this.textBoxRentalCost.Size = new System.Drawing.Size(180, 26);
            this.textBoxRentalCost.TabIndex = 78;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(151, 178);
            this.textBoxGenre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(188, 26);
            this.textBoxGenre.TabIndex = 76;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(866, 63);
            this.textBoxLName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(305, 26);
            this.textBoxLName.TabIndex = 75;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(431, 68);
            this.textBoxFName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(305, 26);
            this.textBoxFName.TabIndex = 74;
            // 
            // textBoxRentalID
            // 
            this.textBoxRentalID.Location = new System.Drawing.Point(1206, 172);
            this.textBoxRentalID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxRentalID.Name = "textBoxRentalID";
            this.textBoxRentalID.Size = new System.Drawing.Size(114, 26);
            this.textBoxRentalID.TabIndex = 73;
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.Location = new System.Drawing.Point(178, 270);
            this.textBoxMovieID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(114, 26);
            this.textBoxMovieID.TabIndex = 72;
            // 
            // textCustID
            // 
            this.textCustID.Location = new System.Drawing.Point(152, 72);
            this.textCustID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textCustID.Name = "textCustID";
            this.textCustID.Size = new System.Drawing.Size(114, 26);
            this.textCustID.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1068, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 70;
            this.label12.Text = "Rental ID";
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.ForeColor = System.Drawing.Color.White;
            this.lblPlot.Location = new System.Drawing.Point(731, 178);
            this.lblPlot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(38, 20);
            this.lblPlot.TabIndex = 69;
            this.lblPlot.Text = "Plot";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(379, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "Rental Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(61, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(75, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Movie ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(766, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "L Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(318, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "F Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Cust ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 662);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Movies List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 652);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Customer List";
            // 
            // dGWMovieList
            // 
            this.dGWMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWMovieList.Location = new System.Drawing.Point(851, 701);
            this.dGWMovieList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dGWMovieList.Name = "dGWMovieList";
            this.dGWMovieList.RowHeadersWidth = 51;
            this.dGWMovieList.Size = new System.Drawing.Size(568, 231);
            this.dGWMovieList.TabIndex = 59;
            this.dGWMovieList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWMovieList_CellContentClick);
            // 
            // dGWCustomerList
            // 
            this.dGWCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWCustomerList.Location = new System.Drawing.Point(26, 701);
            this.dGWCustomerList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dGWCustomerList.Name = "dGWCustomerList";
            this.dGWCustomerList.RowHeadersWidth = 51;
            this.dGWCustomerList.Size = new System.Drawing.Size(764, 231);
            this.dGWCustomerList.TabIndex = 58;
            this.dGWCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWCustomerList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 368);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Rental List";
            // 
            // dgWMovieRentalList
            // 
            this.dgWMovieRentalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWMovieRentalList.Location = new System.Drawing.Point(30, 416);
            this.dgWMovieRentalList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgWMovieRentalList.Name = "dgWMovieRentalList";
            this.dgWMovieRentalList.RowHeadersWidth = 51;
            this.dgWMovieRentalList.Size = new System.Drawing.Size(1204, 231);
            this.dgWMovieRentalList.TabIndex = 56;
            this.dgWMovieRentalList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWMovieRentalList_CellContentClick);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(386, 273);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(254, 26);
            this.textBoxTitle.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(335, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 84;
            this.label8.Text = "Title";
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1436, 1010);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.returnMovieBtn);
            this.Controls.Add(this.issueMovieBtn);
            this.Controls.Add(this.textBoxPlot);
            this.Controls.Add(this.textBoxRentalCost);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxRentalID);
            this.Controls.Add(this.textBoxMovieID);
            this.Controls.Add(this.textCustID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblPlot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGWMovieList);
            this.Controls.Add(this.dGWCustomerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgWMovieRentalList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RentalForm";
            this.Text = "RentalForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMovieList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWMovieRentalList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOutRented;
        private System.Windows.Forms.RadioButton radioButtonAllRented;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button returnMovieBtn;
        private System.Windows.Forms.Button issueMovieBtn;
        private System.Windows.Forms.TextBox textBoxPlot;
        private System.Windows.Forms.TextBox textBoxRentalCost;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxRentalID;
        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.TextBox textCustID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGWMovieList;
        private System.Windows.Forms.DataGridView dGWCustomerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgWMovieRentalList;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label8;
    }
}