namespace AITMediaLibrary
{
    partial class MediaEditor
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
            this.mediaGridView = new System.Windows.Forms.DataGridView();
            this.directorComboBox = new System.Windows.Forms.ComboBox();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addMediaButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.genreGridView = new System.Windows.Forms.DataGridView();
            this.directorGridView = new System.Windows.Forms.DataGridView();
            this.languageGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.newGenreTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.newDirectorTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.newLanguageTextBox = new System.Windows.Forms.TextBox();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.addDirectorButton = new System.Windows.Forms.Button();
            this.addLanguageButton = new System.Windows.Forms.Button();
            this.updateMediaButton = new System.Windows.Forms.Button();
            this.selectedMediaLabel = new System.Windows.Forms.Label();
            this.deleteMediaButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.listAllBorrowedButton = new System.Windows.Forms.Button();
            this.listAllReservedButton = new System.Windows.Forms.Button();
            this.listAllMediasButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaGridView
            // 
            this.mediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaGridView.Location = new System.Drawing.Point(55, 121);
            this.mediaGridView.Margin = new System.Windows.Forms.Padding(4);
            this.mediaGridView.Name = "mediaGridView";
            this.mediaGridView.Size = new System.Drawing.Size(850, 396);
            this.mediaGridView.TabIndex = 18;
            this.mediaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaGridView_CellClick);
            // 
            // directorComboBox
            // 
            this.directorComboBox.FormattingEnabled = true;
            this.directorComboBox.Location = new System.Drawing.Point(1048, 223);
            this.directorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.directorComboBox.Name = "directorComboBox";
            this.directorComboBox.Size = new System.Drawing.Size(160, 24);
            this.directorComboBox.TabIndex = 26;
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(1048, 273);
            this.languageComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(160, 24);
            this.languageComboBox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(940, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Genre";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(1048, 168);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(160, 24);
            this.genreComboBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(55, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "List of Media";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(940, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Language";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(940, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Director";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(1048, 120);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(160, 22);
            this.titleTextBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(940, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Title";
            // 
            // addMediaButton
            // 
            this.addMediaButton.Location = new System.Drawing.Point(944, 412);
            this.addMediaButton.Margin = new System.Windows.Forms.Padding(4);
            this.addMediaButton.Name = "addMediaButton";
            this.addMediaButton.Size = new System.Drawing.Size(265, 28);
            this.addMediaButton.TabIndex = 32;
            this.addMediaButton.Text = "Add Media";
            this.addMediaButton.UseVisualStyleBackColor = true;
            this.addMediaButton.Click += new System.EventHandler(this.addMediaButton_Click_1);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(55, 525);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 28);
            this.refreshButton.TabIndex = 33;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(940, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Publish Year";
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(1048, 318);
            this.publishYearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(160, 22);
            this.publishYearTextBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(940, 371);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Budget";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(1048, 363);
            this.budgetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(160, 22);
            this.budgetTextBox.TabIndex = 37;
            // 
            // genreGridView
            // 
            this.genreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreGridView.Location = new System.Drawing.Point(55, 611);
            this.genreGridView.Margin = new System.Windows.Forms.Padding(4);
            this.genreGridView.Name = "genreGridView";
            this.genreGridView.Size = new System.Drawing.Size(343, 119);
            this.genreGridView.TabIndex = 38;
            // 
            // directorGridView
            // 
            this.directorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorGridView.Location = new System.Drawing.Point(464, 609);
            this.directorGridView.Margin = new System.Windows.Forms.Padding(4);
            this.directorGridView.Name = "directorGridView";
            this.directorGridView.Size = new System.Drawing.Size(337, 119);
            this.directorGridView.TabIndex = 39;
            // 
            // languageGridView
            // 
            this.languageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.languageGridView.Location = new System.Drawing.Point(866, 609);
            this.languageGridView.Margin = new System.Windows.Forms.Padding(4);
            this.languageGridView.Name = "languageGridView";
            this.languageGridView.Size = new System.Drawing.Size(343, 119);
            this.languageGridView.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(51, 591);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(460, 590);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Director";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(862, 588);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Language";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(55, 753);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "New Genre";
            // 
            // newGenreTextBox
            // 
            this.newGenreTextBox.Location = new System.Drawing.Point(144, 750);
            this.newGenreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newGenreTextBox.Name = "newGenreTextBox";
            this.newGenreTextBox.Size = new System.Drawing.Size(252, 22);
            this.newGenreTextBox.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(460, 753);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "New Director";
            // 
            // newDirectorTextBox
            // 
            this.newDirectorTextBox.Location = new System.Drawing.Point(561, 750);
            this.newDirectorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newDirectorTextBox.Name = "newDirectorTextBox";
            this.newDirectorTextBox.Size = new System.Drawing.Size(239, 22);
            this.newDirectorTextBox.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(866, 751);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "New Language";
            // 
            // newLanguageTextBox
            // 
            this.newLanguageTextBox.Location = new System.Drawing.Point(981, 748);
            this.newLanguageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newLanguageTextBox.Name = "newLanguageTextBox";
            this.newLanguageTextBox.Size = new System.Drawing.Size(225, 22);
            this.newLanguageTextBox.TabIndex = 49;
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(297, 782);
            this.addGenreButton.Margin = new System.Windows.Forms.Padding(4);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(100, 28);
            this.addGenreButton.TabIndex = 50;
            this.addGenreButton.Text = "Add";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // addDirectorButton
            // 
            this.addDirectorButton.Location = new System.Drawing.Point(701, 782);
            this.addDirectorButton.Margin = new System.Windows.Forms.Padding(4);
            this.addDirectorButton.Name = "addDirectorButton";
            this.addDirectorButton.Size = new System.Drawing.Size(100, 28);
            this.addDirectorButton.TabIndex = 51;
            this.addDirectorButton.Text = "Add";
            this.addDirectorButton.UseVisualStyleBackColor = true;
            this.addDirectorButton.Click += new System.EventHandler(this.addDirectorButton_Click);
            // 
            // addLanguageButton
            // 
            this.addLanguageButton.Location = new System.Drawing.Point(1109, 780);
            this.addLanguageButton.Margin = new System.Windows.Forms.Padding(4);
            this.addLanguageButton.Name = "addLanguageButton";
            this.addLanguageButton.Size = new System.Drawing.Size(100, 28);
            this.addLanguageButton.TabIndex = 52;
            this.addLanguageButton.Text = "Add";
            this.addLanguageButton.UseVisualStyleBackColor = true;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // updateMediaButton
            // 
            this.updateMediaButton.Location = new System.Drawing.Point(944, 449);
            this.updateMediaButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateMediaButton.Name = "updateMediaButton";
            this.updateMediaButton.Size = new System.Drawing.Size(264, 28);
            this.updateMediaButton.TabIndex = 53;
            this.updateMediaButton.Text = "Update Media";
            this.updateMediaButton.UseVisualStyleBackColor = true;
            this.updateMediaButton.Click += new System.EventHandler(this.updateMediaButton_Click);
            // 
            // selectedMediaLabel
            // 
            this.selectedMediaLabel.AutoSize = true;
            this.selectedMediaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMediaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedMediaLabel.Location = new System.Drawing.Point(419, 88);
            this.selectedMediaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedMediaLabel.Name = "selectedMediaLabel";
            this.selectedMediaLabel.Size = new System.Drawing.Size(124, 17);
            this.selectedMediaLabel.TabIndex = 54;
            this.selectedMediaLabel.Text = "Selected Media:";
            // 
            // deleteMediaButton
            // 
            this.deleteMediaButton.Location = new System.Drawing.Point(944, 486);
            this.deleteMediaButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteMediaButton.Name = "deleteMediaButton";
            this.deleteMediaButton.Size = new System.Drawing.Size(265, 28);
            this.deleteMediaButton.TabIndex = 55;
            this.deleteMediaButton.Text = "Delete Media";
            this.deleteMediaButton.UseVisualStyleBackColor = true;
            this.deleteMediaButton.Click += new System.EventHandler(this.deleteMediaButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(1106, 25);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(100, 28);
            this.logOutButton.TabIndex = 56;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // listAllBorrowedButton
            // 
            this.listAllBorrowedButton.Location = new System.Drawing.Point(574, 525);
            this.listAllBorrowedButton.Name = "listAllBorrowedButton";
            this.listAllBorrowedButton.Size = new System.Drawing.Size(147, 28);
            this.listAllBorrowedButton.TabIndex = 57;
            this.listAllBorrowedButton.Text = "List All Borrowed";
            this.listAllBorrowedButton.UseVisualStyleBackColor = true;
            this.listAllBorrowedButton.Click += new System.EventHandler(this.listAllBorrowedButton_Click);
            // 
            // listAllReservedButton
            // 
            this.listAllReservedButton.Location = new System.Drawing.Point(760, 525);
            this.listAllReservedButton.Name = "listAllReservedButton";
            this.listAllReservedButton.Size = new System.Drawing.Size(145, 28);
            this.listAllReservedButton.TabIndex = 58;
            this.listAllReservedButton.Text = "List All Reserved";
            this.listAllReservedButton.UseVisualStyleBackColor = true;
            this.listAllReservedButton.Click += new System.EventHandler(this.listAllReservedButton_Click);
            // 
            // listAllMediasButton
            // 
            this.listAllMediasButton.Location = new System.Drawing.Point(409, 525);
            this.listAllMediasButton.Name = "listAllMediasButton";
            this.listAllMediasButton.Size = new System.Drawing.Size(140, 28);
            this.listAllMediasButton.TabIndex = 59;
            this.listAllMediasButton.Text = "List All Medias";
            this.listAllMediasButton.UseVisualStyleBackColor = true;
            this.listAllMediasButton.Click += new System.EventHandler(this.listAllMediasButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(944, 81);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(265, 30);
            this.clearButton.TabIndex = 60;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MediaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1263, 864);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.listAllMediasButton);
            this.Controls.Add(this.listAllReservedButton);
            this.Controls.Add(this.listAllBorrowedButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.deleteMediaButton);
            this.Controls.Add(this.selectedMediaLabel);
            this.Controls.Add(this.updateMediaButton);
            this.Controls.Add(this.addLanguageButton);
            this.Controls.Add(this.addDirectorButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.newLanguageTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.newDirectorTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.newGenreTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.languageGridView);
            this.Controls.Add(this.directorGridView);
            this.Controls.Add(this.genreGridView);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.publishYearTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addMediaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.directorComboBox);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.mediaGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MediaEditor";
            this.Text = "Media Editor";
            this.Load += new System.EventHandler(this.MediaEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mediaGridView;
        private System.Windows.Forms.ComboBox directorComboBox;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addMediaButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox publishYearTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.DataGridView genreGridView;
        private System.Windows.Forms.DataGridView directorGridView;
        private System.Windows.Forms.DataGridView languageGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newGenreTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox newDirectorTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox newLanguageTextBox;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button addDirectorButton;
        private System.Windows.Forms.Button addLanguageButton;
        private System.Windows.Forms.Button updateMediaButton;
        private System.Windows.Forms.Label selectedMediaLabel;
        private System.Windows.Forms.Button deleteMediaButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button listAllBorrowedButton;
        private System.Windows.Forms.Button listAllReservedButton;
        private System.Windows.Forms.Button listAllMediasButton;
        private System.Windows.Forms.Button clearButton;
    }
}