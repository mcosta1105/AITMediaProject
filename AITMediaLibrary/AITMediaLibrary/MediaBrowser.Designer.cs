namespace AITMediaLibrary
{
    partial class MediaBrowser
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
            this.userLabel = new System.Windows.Forms.Label();
            this.mediaGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.yearSearchButton = new System.Windows.Forms.Button();
            this.listAllButton = new System.Windows.Forms.Button();
            this.selectMediaLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.languageNameTextBox = new System.Windows.Forms.TextBox();
            this.languageSearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.budgetButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.availabilityLabel = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.borrowedComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Location = new System.Drawing.Point(37, 90);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(42, 17);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User:";
            // 
            // mediaGridView
            // 
            this.mediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaGridView.Location = new System.Drawing.Point(41, 124);
            this.mediaGridView.Margin = new System.Windows.Forms.Padding(4);
            this.mediaGridView.Name = "mediaGridView";
            this.mediaGridView.Size = new System.Drawing.Size(877, 292);
            this.mediaGridView.TabIndex = 1;
            this.mediaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(476, 573);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "PublishYear:";
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(574, 570);
            this.publishYearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(157, 22);
            this.publishYearTextBox.TabIndex = 3;
            this.publishYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.publishYearTextBox_KeyPress);
            // 
            // yearSearchButton
            // 
            this.yearSearchButton.Location = new System.Drawing.Point(740, 566);
            this.yearSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.yearSearchButton.Name = "yearSearchButton";
            this.yearSearchButton.Size = new System.Drawing.Size(154, 28);
            this.yearSearchButton.TabIndex = 4;
            this.yearSearchButton.Text = "Search Year";
            this.yearSearchButton.UseVisualStyleBackColor = true;
            this.yearSearchButton.Click += new System.EventHandler(this.yearSearchButton_Click);
            // 
            // listAllButton
            // 
            this.listAllButton.Location = new System.Drawing.Point(801, 84);
            this.listAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.listAllButton.Name = "listAllButton";
            this.listAllButton.Size = new System.Drawing.Size(115, 28);
            this.listAllButton.TabIndex = 5;
            this.listAllButton.Text = "List All Media";
            this.listAllButton.UseVisualStyleBackColor = true;
            this.listAllButton.Click += new System.EventHandler(this.listAllButton_Click);
            // 
            // selectMediaLable
            // 
            this.selectMediaLable.AutoSize = true;
            this.selectMediaLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectMediaLable.Location = new System.Drawing.Point(263, 90);
            this.selectMediaLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectMediaLable.Name = "selectMediaLable";
            this.selectMediaLable.Size = new System.Drawing.Size(109, 17);
            this.selectMediaLable.TabIndex = 6;
            this.selectMediaLable.Text = "Selected Media:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(447, 522);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Language Name:";
            // 
            // languageNameTextBox
            // 
            this.languageNameTextBox.Location = new System.Drawing.Point(574, 519);
            this.languageNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.languageNameTextBox.Name = "languageNameTextBox";
            this.languageNameTextBox.Size = new System.Drawing.Size(157, 22);
            this.languageNameTextBox.TabIndex = 8;
            this.languageNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.languageNameTextBox_KeyPress);
            // 
            // languageSearchButton
            // 
            this.languageSearchButton.Location = new System.Drawing.Point(740, 515);
            this.languageSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.languageSearchButton.Name = "languageSearchButton";
            this.languageSearchButton.Size = new System.Drawing.Size(156, 28);
            this.languageSearchButton.TabIndex = 9;
            this.languageSearchButton.Text = "Search Language";
            this.languageSearchButton.UseVisualStyleBackColor = true;
            this.languageSearchButton.Click += new System.EventHandler(this.languageSearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(507, 614);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Budget:";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(574, 611);
            this.budgetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(157, 22);
            this.budgetTextBox.TabIndex = 11;
            this.budgetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.budgetTextBox_KeyPress);
            // 
            // budgetButton
            // 
            this.budgetButton.Location = new System.Drawing.Point(740, 608);
            this.budgetButton.Margin = new System.Windows.Forms.Padding(4);
            this.budgetButton.Name = "budgetButton";
            this.budgetButton.Size = new System.Drawing.Size(156, 28);
            this.budgetButton.TabIndex = 12;
            this.budgetButton.Text = "Search Budget";
            this.budgetButton.UseVisualStyleBackColor = true;
            this.budgetButton.Click += new System.EventHandler(this.budgetButton_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(40, 467);
            this.reserveButton.Margin = new System.Windows.Forms.Padding(4);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(115, 28);
            this.reserveButton.TabIndex = 13;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(801, 13);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(115, 28);
            this.logOutButton.TabIndex = 14;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // availabilityLabel
            // 
            this.availabilityLabel.AutoSize = true;
            this.availabilityLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.availabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.availabilityLabel.Location = new System.Drawing.Point(37, 431);
            this.availabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.availabilityLabel.Name = "availabilityLabel";
            this.availabilityLabel.Size = new System.Drawing.Size(141, 18);
            this.availabilityLabel.TabIndex = 15;
            this.availabilityLabel.Text = "Media Availability:";
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(177, 467);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(116, 28);
            this.borrowButton.TabIndex = 16;
            this.borrowButton.Text = "Borrow";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(177, 598);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(115, 28);
            this.returnButton.TabIndex = 17;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // borrowedComboBox
            // 
            this.borrowedComboBox.FormattingEnabled = true;
            this.borrowedComboBox.Location = new System.Drawing.Point(39, 553);
            this.borrowedComboBox.Name = "borrowedComboBox";
            this.borrowedComboBox.Size = new System.Drawing.Size(254, 24);
            this.borrowedComboBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(39, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Borrowed Medias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(525, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(574, 470);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(157, 22);
            this.titleTextBox.TabIndex = 21;
            this.titleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.titleTextBox_KeyPress);
            // 
            // titleButton
            // 
            this.titleButton.Location = new System.Drawing.Point(742, 467);
            this.titleButton.Margin = new System.Windows.Forms.Padding(4);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(154, 28);
            this.titleButton.TabIndex = 22;
            this.titleButton.Text = "Search Title";
            this.titleButton.UseVisualStyleBackColor = true;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(430, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 229);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // MediaBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(961, 705);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.borrowedComboBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.availabilityLabel);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.budgetButton);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.languageSearchButton);
            this.Controls.Add(this.languageNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectMediaLable);
            this.Controls.Add(this.listAllButton);
            this.Controls.Add(this.yearSearchButton);
            this.Controls.Add(this.publishYearTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mediaGridView);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MediaBrowser";
            this.Text = "Media Browser";
            this.Load += new System.EventHandler(this.MediaBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.DataGridView mediaGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox publishYearTextBox;
        private System.Windows.Forms.Button yearSearchButton;
        private System.Windows.Forms.Button listAllButton;
        private System.Windows.Forms.Label selectMediaLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox languageNameTextBox;
        private System.Windows.Forms.Button languageSearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Button budgetButton;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label availabilityLabel;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ComboBox borrowedComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}