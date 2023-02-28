
namespace LIbraryManagement
{
    partial class ReaderForm
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
            this.readerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.readerIDTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.readerIDLabel = new System.Windows.Forms.Label();
            this.Function = new System.Windows.Forms.GroupBox();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.readerListGroupBox = new System.Windows.Forms.GroupBox();
            this.readerListGridView = new System.Windows.Forms.DataGridView();
            this.readerInfoGroupBox.SuspendLayout();
            this.Function.SuspendLayout();
            this.readerListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // readerInfoGroupBox
            // 
            this.readerInfoGroupBox.Controls.Add(this.dobBox);
            this.readerInfoGroupBox.Controls.Add(this.nameTextBox);
            this.readerInfoGroupBox.Controls.Add(this.readerIDTextBox);
            this.readerInfoGroupBox.Controls.Add(this.nameLabel);
            this.readerInfoGroupBox.Controls.Add(this.dobLabel);
            this.readerInfoGroupBox.Controls.Add(this.readerIDLabel);
            this.readerInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readerInfoGroupBox.Location = new System.Drawing.Point(15, 16);
            this.readerInfoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.readerInfoGroupBox.Name = "readerInfoGroupBox";
            this.readerInfoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.readerInfoGroupBox.Size = new System.Drawing.Size(970, 159);
            this.readerInfoGroupBox.TabIndex = 0;
            this.readerInfoGroupBox.TabStop = false;
            this.readerInfoGroupBox.Text = "Reader Infomation";
            // 
            // dobBox
            // 
            this.dobBox.Location = new System.Drawing.Point(488, 94);
            this.dobBox.Margin = new System.Windows.Forms.Padding(4);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(409, 28);
            this.dobBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(144, 92);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(286, 28);
            this.nameTextBox.TabIndex = 1;
            // 
            // readerIDTextBox
            // 
            this.readerIDTextBox.Location = new System.Drawing.Point(145, 41);
            this.readerIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.readerIDTextBox.Name = "readerIDTextBox";
            this.readerIDTextBox.Size = new System.Drawing.Size(285, 28);
            this.readerIDTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(19, 98);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 24);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(484, 47);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(115, 24);
            this.dobLabel.TabIndex = 1;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // readerIDLabel
            // 
            this.readerIDLabel.AutoSize = true;
            this.readerIDLabel.Location = new System.Drawing.Point(20, 47);
            this.readerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerIDLabel.Name = "readerIDLabel";
            this.readerIDLabel.Size = new System.Drawing.Size(99, 24);
            this.readerIDLabel.TabIndex = 0;
            this.readerIDLabel.Text = "Reader ID:";
            // 
            // Function
            // 
            this.Function.Controls.Add(this.searchNameTextBox);
            this.Function.Controls.Add(this.searchNameLabel);
            this.Function.Controls.Add(this.cancelButton);
            this.Function.Controls.Add(this.saveButton);
            this.Function.Controls.Add(this.deleteButton);
            this.Function.Controls.Add(this.editButton);
            this.Function.Controls.Add(this.addButton);
            this.Function.Controls.Add(this.searchButton);
            this.Function.Location = new System.Drawing.Point(15, 183);
            this.Function.Margin = new System.Windows.Forms.Padding(4);
            this.Function.Name = "Function";
            this.Function.Padding = new System.Windows.Forms.Padding(4);
            this.Function.Size = new System.Drawing.Size(970, 156);
            this.Function.TabIndex = 6;
            this.Function.TabStop = false;
            this.Function.Text = "Function";
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(94, 99);
            this.searchNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(285, 28);
            this.searchNameTextBox.TabIndex = 7;
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Location = new System.Drawing.Point(20, 103);
            this.searchNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(66, 24);
            this.searchNameLabel.TabIndex = 6;
            this.searchNameLabel.Text = "Name:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(743, 28);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 40);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(599, 28);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 40);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(453, 28);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 40);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(309, 28);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(105, 40);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(167, 28);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 40);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(407, 99);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 40);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // readerListGroupBox
            // 
            this.readerListGroupBox.Controls.Add(this.readerListGridView);
            this.readerListGroupBox.Location = new System.Drawing.Point(12, 346);
            this.readerListGroupBox.Name = "readerListGroupBox";
            this.readerListGroupBox.Size = new System.Drawing.Size(973, 421);
            this.readerListGroupBox.TabIndex = 7;
            this.readerListGroupBox.TabStop = false;
            this.readerListGroupBox.Text = "Reader List";
            // 
            // readerListGridView
            // 
            this.readerListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerListGridView.Location = new System.Drawing.Point(6, 27);
            this.readerListGridView.Name = "readerListGridView";
            this.readerListGridView.RowHeadersWidth = 51;
            this.readerListGridView.RowTemplate.Height = 24;
            this.readerListGridView.Size = new System.Drawing.Size(961, 388);
            this.readerListGridView.TabIndex = 9;
            this.readerListGridView.Click += new System.EventHandler(this.readerListGridView_Click);
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 779);
            this.Controls.Add(this.readerListGroupBox);
            this.Controls.Add(this.Function);
            this.Controls.Add(this.readerInfoGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReaderForm";
            this.Text = "Reader Form";
            this.Load += new System.EventHandler(this.ReaderForm_Load);
            this.readerInfoGroupBox.ResumeLayout(false);
            this.readerInfoGroupBox.PerformLayout();
            this.Function.ResumeLayout(false);
            this.Function.PerformLayout();
            this.readerListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readerListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox readerInfoGroupBox;
        private System.Windows.Forms.Label readerIDLabel;
        private System.Windows.Forms.DateTimePicker dobBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox readerIDTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.GroupBox Function;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox readerListGroupBox;
        private System.Windows.Forms.DataGridView readerListGridView;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Label searchNameLabel;
    }
}

