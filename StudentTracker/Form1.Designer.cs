namespace StudentTracker
{
    partial class MainForm
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
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.displayAllButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.copyrightsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDLabel.Location = new System.Drawing.Point(56, 52);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(101, 24);
            this.studentIDLabel.TabIndex = 0;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(22, 112);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(135, 24);
            this.studentNameLabel.TabIndex = 1;
            this.studentNameLabel.Text = "Student Name:";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTextBox.Location = new System.Drawing.Point(192, 47);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(179, 26);
            this.studentIDTextBox.TabIndex = 2;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTextBox.Location = new System.Drawing.Point(192, 107);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(179, 26);
            this.studentNameTextBox.TabIndex = 3;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.Location = new System.Drawing.Point(30, 175);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(156, 50);
            this.addStudentButton.TabIndex = 4;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStudentButton.Location = new System.Drawing.Point(212, 175);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(159, 50);
            this.deleteStudentButton.TabIndex = 5;
            this.deleteStudentButton.Text = "Delete Student";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllButton.Location = new System.Drawing.Point(30, 248);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(156, 50);
            this.deleteAllButton.TabIndex = 6;
            this.deleteAllButton.Text = "Delete All Records";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(212, 248);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(159, 50);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search With Student ID";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(30, 320);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(341, 38);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear Display Screen";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // displayAllButton
            // 
            this.displayAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAllButton.Location = new System.Drawing.Point(30, 377);
            this.displayAllButton.Name = "displayAllButton";
            this.displayAllButton.Size = new System.Drawing.Size(341, 38);
            this.displayAllButton.TabIndex = 9;
            this.displayAllButton.Text = "Display All Records";
            this.displayAllButton.UseVisualStyleBackColor = true;
            this.displayAllButton.Click += new System.EventHandler(this.displayAllButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(30, 468);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(341, 38);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.Enabled = false;
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.Location = new System.Drawing.Point(420, 47);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(328, 459);
            this.displayTextBox.TabIndex = 11;
            // 
            // copyrightsLabel
            // 
            this.copyrightsLabel.AutoSize = true;
            this.copyrightsLabel.Location = new System.Drawing.Point(12, 539);
            this.copyrightsLabel.Name = "copyrightsLabel";
            this.copyrightsLabel.Size = new System.Drawing.Size(277, 13);
            this.copyrightsLabel.TabIndex = 12;
            this.copyrightsLabel.Text = "Li Xu - 300735072 - COMP212 Programming 3 - Fall 2015";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.copyrightsLabel);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayAllButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centennial College Student Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button displayAllButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Label copyrightsLabel;
    }
}

