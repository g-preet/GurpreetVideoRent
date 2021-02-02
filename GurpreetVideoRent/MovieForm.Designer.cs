namespace GurpreetVideoRent
{
    partial class MovieForm
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
            this.deleteMovieBtn = new System.Windows.Forms.Button();
            this.updateMovieBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.movieListDGV = new System.Windows.Forms.DataGridView();
            this.addMovieBtn = new System.Windows.Forms.Button();
            this.movieIDTxt = new System.Windows.Forms.TextBox();
            this.rentalCostTxt = new System.Windows.Forms.TextBox();
            this.plotTxt = new System.Windows.Forms.TextBox();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Gray;
            this.backBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(1262, 344);
            this.backBtn.Margin = new System.Windows.Forms.Padding(5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(125, 35);
            this.backBtn.TabIndex = 59;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteMovieBtn
            // 
            this.deleteMovieBtn.BackColor = System.Drawing.Color.Gray;
            this.deleteMovieBtn.ForeColor = System.Drawing.Color.White;
            this.deleteMovieBtn.Location = new System.Drawing.Point(1006, 215);
            this.deleteMovieBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteMovieBtn.Name = "deleteMovieBtn";
            this.deleteMovieBtn.Size = new System.Drawing.Size(296, 112);
            this.deleteMovieBtn.TabIndex = 58;
            this.deleteMovieBtn.Text = "Delete Movie";
            this.deleteMovieBtn.UseVisualStyleBackColor = false;
            this.deleteMovieBtn.Click += new System.EventHandler(this.deleteMovieBtn_Click);
            // 
            // updateMovieBtn
            // 
            this.updateMovieBtn.BackColor = System.Drawing.Color.Gray;
            this.updateMovieBtn.ForeColor = System.Drawing.Color.White;
            this.updateMovieBtn.Location = new System.Drawing.Point(672, 215);
            this.updateMovieBtn.Margin = new System.Windows.Forms.Padding(5);
            this.updateMovieBtn.Name = "updateMovieBtn";
            this.updateMovieBtn.Size = new System.Drawing.Size(296, 112);
            this.updateMovieBtn.TabIndex = 57;
            this.updateMovieBtn.Text = "Update Movie";
            this.updateMovieBtn.UseVisualStyleBackColor = false;
            this.updateMovieBtn.Click += new System.EventHandler(this.updateMovieBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(145, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Movie List";
            // 
            // movieListDGV
            // 
            this.movieListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieListDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.movieListDGV.Location = new System.Drawing.Point(150, 400);
            this.movieListDGV.Margin = new System.Windows.Forms.Padding(5);
            this.movieListDGV.Name = "movieListDGV";
            this.movieListDGV.RowHeadersWidth = 51;
            this.movieListDGV.Size = new System.Drawing.Size(1259, 414);
            this.movieListDGV.TabIndex = 55;
            this.movieListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieListDGV_CellContentClick);
            // 
            // addMovieBtn
            // 
            this.addMovieBtn.BackColor = System.Drawing.Color.Gray;
            this.addMovieBtn.ForeColor = System.Drawing.Color.White;
            this.addMovieBtn.Location = new System.Drawing.Point(332, 215);
            this.addMovieBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addMovieBtn.Name = "addMovieBtn";
            this.addMovieBtn.Size = new System.Drawing.Size(296, 112);
            this.addMovieBtn.TabIndex = 54;
            this.addMovieBtn.Text = "Add Movie";
            this.addMovieBtn.UseVisualStyleBackColor = false;
            this.addMovieBtn.Click += new System.EventHandler(this.addMovieBtn_Click);
            // 
            // movieIDTxt
            // 
            this.movieIDTxt.Location = new System.Drawing.Point(55, 71);
            this.movieIDTxt.Margin = new System.Windows.Forms.Padding(5);
            this.movieIDTxt.Name = "movieIDTxt";
            this.movieIDTxt.Size = new System.Drawing.Size(79, 26);
            this.movieIDTxt.TabIndex = 53;
            // 
            // rentalCostTxt
            // 
            this.rentalCostTxt.Location = new System.Drawing.Point(332, 114);
            this.rentalCostTxt.Margin = new System.Windows.Forms.Padding(5);
            this.rentalCostTxt.Name = "rentalCostTxt";
            this.rentalCostTxt.Size = new System.Drawing.Size(340, 26);
            this.rentalCostTxt.TabIndex = 52;
            // 
            // plotTxt
            // 
            this.plotTxt.Location = new System.Drawing.Point(960, 114);
            this.plotTxt.Margin = new System.Windows.Forms.Padding(5);
            this.plotTxt.Name = "plotTxt";
            this.plotTxt.Size = new System.Drawing.Size(340, 26);
            this.plotTxt.TabIndex = 51;
            // 
            // genreTxt
            // 
            this.genreTxt.Location = new System.Drawing.Point(960, 71);
            this.genreTxt.Margin = new System.Windows.Forms.Padding(5);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(340, 26);
            this.genreTxt.TabIndex = 50;
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(332, 71);
            this.titleTxt.Margin = new System.Windows.Forms.Padding(5);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(340, 26);
            this.titleTxt.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(839, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Plot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(162, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Rental Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(840, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Title";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1465, 885);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.deleteMovieBtn);
            this.Controls.Add(this.updateMovieBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.movieListDGV);
            this.Controls.Add(this.addMovieBtn);
            this.Controls.Add(this.movieIDTxt);
            this.Controls.Add(this.rentalCostTxt);
            this.Controls.Add(this.plotTxt);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.movieListDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button deleteMovieBtn;
        private System.Windows.Forms.Button updateMovieBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView movieListDGV;
        private System.Windows.Forms.Button addMovieBtn;
        private System.Windows.Forms.TextBox movieIDTxt;
        private System.Windows.Forms.TextBox rentalCostTxt;
        private System.Windows.Forms.TextBox plotTxt;
        private System.Windows.Forms.TextBox genreTxt;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}