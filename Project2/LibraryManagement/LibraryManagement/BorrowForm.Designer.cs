
namespace LibraryManagement
{
    partial class BorrowForm
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
            this.borrowGroupBox = new System.Windows.Forms.GroupBox();
            this.borrowIDTextBox = new System.Windows.Forms.TextBox();
            this.borrowIDLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.borrowDateBox = new System.Windows.Forms.DateTimePicker();
            this.borrowDateLabel = new System.Windows.Forms.Label();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.bookIDLabel = new System.Windows.Forms.Label();
            this.readerIDTextBox = new System.Windows.Forms.TextBox();
            this.readerIDLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.returnGroupBox = new System.Windows.Forms.GroupBox();
            this.searchBorrowIDTextBox = new System.Windows.Forms.TextBox();
            this.searchBorrowIDLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.return_cancelButton = new System.Windows.Forms.Button();
            this.borrowGridView = new System.Windows.Forms.DataGridView();
            this.borrowGroupBox.SuspendLayout();
            this.returnGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowGroupBox
            // 
            this.borrowGroupBox.Controls.Add(this.borrowIDTextBox);
            this.borrowGroupBox.Controls.Add(this.borrowIDLabel);
            this.borrowGroupBox.Controls.Add(this.saveButton);
            this.borrowGroupBox.Controls.Add(this.cancelButton);
            this.borrowGroupBox.Controls.Add(this.borrowDateBox);
            this.borrowGroupBox.Controls.Add(this.borrowDateLabel);
            this.borrowGroupBox.Controls.Add(this.bookIDTextBox);
            this.borrowGroupBox.Controls.Add(this.bookIDLabel);
            this.borrowGroupBox.Controls.Add(this.readerIDTextBox);
            this.borrowGroupBox.Controls.Add(this.readerIDLabel);
            this.borrowGroupBox.Location = new System.Drawing.Point(15, 16);
            this.borrowGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.borrowGroupBox.Name = "borrowGroupBox";
            this.borrowGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.borrowGroupBox.Size = new System.Drawing.Size(817, 220);
            this.borrowGroupBox.TabIndex = 0;
            this.borrowGroupBox.TabStop = false;
            this.borrowGroupBox.Text = "Borrow";
            // 
            // borrowIDTextBox
            // 
            this.borrowIDTextBox.Location = new System.Drawing.Point(498, 176);
            this.borrowIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.borrowIDTextBox.Name = "borrowIDTextBox";
            this.borrowIDTextBox.Size = new System.Drawing.Size(270, 28);
            this.borrowIDTextBox.TabIndex = 10;
            // 
            // borrowIDLabel
            // 
            this.borrowIDLabel.AutoSize = true;
            this.borrowIDLabel.Location = new System.Drawing.Point(494, 137);
            this.borrowIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borrowIDLabel.Name = "borrowIDLabel";
            this.borrowIDLabel.Size = new System.Drawing.Size(97, 24);
            this.borrowIDLabel.TabIndex = 11;
            this.borrowIDLabel.Text = "Borrow ID:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(498, 58);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 40);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(663, 58);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 40);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // borrowDateBox
            // 
            this.borrowDateBox.Location = new System.Drawing.Point(23, 176);
            this.borrowDateBox.Margin = new System.Windows.Forms.Padding(4);
            this.borrowDateBox.Name = "borrowDateBox";
            this.borrowDateBox.Size = new System.Drawing.Size(409, 28);
            this.borrowDateBox.TabIndex = 6;
            this.borrowDateBox.Value = new System.DateTime(2023, 2, 28, 8, 43, 5, 0);
            // 
            // borrowDateLabel
            // 
            this.borrowDateLabel.AutoSize = true;
            this.borrowDateLabel.Location = new System.Drawing.Point(19, 137);
            this.borrowDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borrowDateLabel.Name = "borrowDateLabel";
            this.borrowDateLabel.Size = new System.Drawing.Size(116, 24);
            this.borrowDateLabel.TabIndex = 5;
            this.borrowDateLabel.Text = "Borrow date:";
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Location = new System.Drawing.Point(144, 88);
            this.bookIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(285, 28);
            this.bookIDTextBox.TabIndex = 3;
            // 
            // bookIDLabel
            // 
            this.bookIDLabel.AutoSize = true;
            this.bookIDLabel.Location = new System.Drawing.Point(19, 94);
            this.bookIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookIDLabel.Name = "bookIDLabel";
            this.bookIDLabel.Size = new System.Drawing.Size(80, 24);
            this.bookIDLabel.TabIndex = 4;
            this.bookIDLabel.Text = "Book ID:";
            // 
            // readerIDTextBox
            // 
            this.readerIDTextBox.Location = new System.Drawing.Point(144, 41);
            this.readerIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.readerIDTextBox.Name = "readerIDTextBox";
            this.readerIDTextBox.Size = new System.Drawing.Size(285, 28);
            this.readerIDTextBox.TabIndex = 1;
            // 
            // readerIDLabel
            // 
            this.readerIDLabel.AutoSize = true;
            this.readerIDLabel.Location = new System.Drawing.Point(19, 47);
            this.readerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerIDLabel.Name = "readerIDLabel";
            this.readerIDLabel.Size = new System.Drawing.Size(99, 24);
            this.readerIDLabel.TabIndex = 2;
            this.readerIDLabel.Text = "Reader ID:";
            // 
            // returnGroupBox
            // 
            this.returnGroupBox.Controls.Add(this.borrowGridView);
            this.returnGroupBox.Controls.Add(this.return_cancelButton);
            this.returnGroupBox.Controls.Add(this.returnButton);
            this.returnGroupBox.Controls.Add(this.searchButton);
            this.returnGroupBox.Controls.Add(this.searchBorrowIDTextBox);
            this.returnGroupBox.Controls.Add(this.searchBorrowIDLabel);
            this.returnGroupBox.Location = new System.Drawing.Point(15, 258);
            this.returnGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.returnGroupBox.Name = "returnGroupBox";
            this.returnGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.returnGroupBox.Size = new System.Drawing.Size(817, 241);
            this.returnGroupBox.TabIndex = 1;
            this.returnGroupBox.TabStop = false;
            this.returnGroupBox.Text = "Return";
            // 
            // searchBorrowIDTextBox
            // 
            this.searchBorrowIDTextBox.Location = new System.Drawing.Point(12, 64);
            this.searchBorrowIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBorrowIDTextBox.Name = "searchBorrowIDTextBox";
            this.searchBorrowIDTextBox.Size = new System.Drawing.Size(270, 28);
            this.searchBorrowIDTextBox.TabIndex = 12;
            // 
            // searchBorrowIDLabel
            // 
            this.searchBorrowIDLabel.AutoSize = true;
            this.searchBorrowIDLabel.Location = new System.Drawing.Point(8, 25);
            this.searchBorrowIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchBorrowIDLabel.Name = "searchBorrowIDLabel";
            this.searchBorrowIDLabel.Size = new System.Drawing.Size(97, 24);
            this.searchBorrowIDLabel.TabIndex = 13;
            this.searchBorrowIDLabel.Text = "Borrow ID:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(327, 52);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 40);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(498, 52);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(105, 40);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // return_cancelButton
            // 
            this.return_cancelButton.Location = new System.Drawing.Point(663, 52);
            this.return_cancelButton.Name = "return_cancelButton";
            this.return_cancelButton.Size = new System.Drawing.Size(105, 40);
            this.return_cancelButton.TabIndex = 15;
            this.return_cancelButton.Text = "Cancel";
            this.return_cancelButton.UseVisualStyleBackColor = true;
            this.return_cancelButton.Click += new System.EventHandler(this.return_cancelButton_Click);
            // 
            // borrowGridView
            // 
            this.borrowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowGridView.Location = new System.Drawing.Point(12, 109);
            this.borrowGridView.Name = "borrowGridView";
            this.borrowGridView.RowHeadersWidth = 51;
            this.borrowGridView.RowTemplate.Height = 24;
            this.borrowGridView.Size = new System.Drawing.Size(798, 132);
            this.borrowGridView.TabIndex = 16;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.Controls.Add(this.returnGroupBox);
            this.Controls.Add(this.borrowGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BorrowForm";
            this.Text = "Borrow Form";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            this.borrowGroupBox.ResumeLayout(false);
            this.borrowGroupBox.PerformLayout();
            this.returnGroupBox.ResumeLayout(false);
            this.returnGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox borrowGroupBox;
        private System.Windows.Forms.TextBox borrowIDTextBox;
        private System.Windows.Forms.Label borrowIDLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker borrowDateBox;
        private System.Windows.Forms.Label borrowDateLabel;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.Label bookIDLabel;
        private System.Windows.Forms.TextBox readerIDTextBox;
        private System.Windows.Forms.Label readerIDLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox returnGroupBox;
        private System.Windows.Forms.Button return_cancelButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBorrowIDTextBox;
        private System.Windows.Forms.Label searchBorrowIDLabel;
        private System.Windows.Forms.DataGridView borrowGridView;
    }
}

