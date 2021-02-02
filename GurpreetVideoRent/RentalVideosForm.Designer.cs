namespace GurpreetVideoRent
{
    partial class RentalVideosForm
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
            this.rentBtn = new System.Windows.Forms.Button();
            this.MovieBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rentBtn
            // 
            this.rentBtn.BackColor = System.Drawing.Color.Gray;
            this.rentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentBtn.ForeColor = System.Drawing.Color.White;
            this.rentBtn.Location = new System.Drawing.Point(610, 124);
            this.rentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(167, 98);
            this.rentBtn.TabIndex = 5;
            this.rentBtn.Text = "Rental Movies";
            this.rentBtn.UseVisualStyleBackColor = false;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // MovieBtn
            // 
            this.MovieBtn.BackColor = System.Drawing.Color.Gray;
            this.MovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieBtn.ForeColor = System.Drawing.Color.White;
            this.MovieBtn.Location = new System.Drawing.Point(349, 124);
            this.MovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MovieBtn.Name = "MovieBtn";
            this.MovieBtn.Size = new System.Drawing.Size(167, 98);
            this.MovieBtn.TabIndex = 4;
            this.MovieBtn.Text = "Movies";
            this.MovieBtn.UseVisualStyleBackColor = false;
            this.MovieBtn.Click += new System.EventHandler(this.MovieBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.Gray;
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.White;
            this.customerBtn.Location = new System.Drawing.Point(102, 124);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(167, 98);
            this.customerBtn.TabIndex = 3;
            this.customerBtn.Text = "Customers";
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // RentalVideosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(878, 346);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.MovieBtn);
            this.Controls.Add(this.customerBtn);
            this.Name = "RentalVideosForm";
            this.Text = "RentalVideosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.Button MovieBtn;
        private System.Windows.Forms.Button customerBtn;
    }
}