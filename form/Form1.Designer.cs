namespace form
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInfoBox = new System.Windows.Forms.GroupBox();
            this.completeButton = new System.Windows.Forms.Button();
            this.townLabel = new System.Windows.Forms.Label();
            this.birthdayGroupBox = new System.Windows.Forms.GroupBox();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.countryLabel = new System.Windows.Forms.Label();
            this.townDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.countryDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.whatRadioButton = new System.Windows.Forms.RadioButton();
            this.manRadioButton = new System.Windows.Forms.RadioButton();
            this.womanRadioButton = new System.Windows.Forms.RadioButton();
            this.UserInfoBox.SuspendLayout();
            this.birthdayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInfoBox
            // 
            this.UserInfoBox.Controls.Add(this.surnameTextBox);
            this.UserInfoBox.Controls.Add(this.completeButton);
            this.UserInfoBox.Controls.Add(this.townLabel);
            this.UserInfoBox.Controls.Add(this.birthdayGroupBox);
            this.UserInfoBox.Controls.Add(this.countryLabel);
            this.UserInfoBox.Controls.Add(this.townDomainUpDown);
            this.UserInfoBox.Controls.Add(this.countryDomainUpDown);
            this.UserInfoBox.Controls.Add(this.progressBar);
            this.UserInfoBox.Controls.Add(this.patronymicLabel);
            this.UserInfoBox.Controls.Add(this.surnameLabel);
            this.UserInfoBox.Controls.Add(this.nameLabel);
            this.UserInfoBox.Controls.Add(this.patronymicTextBox);
            this.UserInfoBox.Controls.Add(this.nameTextBox);
            this.UserInfoBox.Controls.Add(this.pictureBox1);
            this.UserInfoBox.Controls.Add(this.groupBox1);
            this.UserInfoBox.Location = new System.Drawing.Point(12, 12);
            this.UserInfoBox.Name = "UserInfoBox";
            this.UserInfoBox.Size = new System.Drawing.Size(328, 355);
            this.UserInfoBox.TabIndex = 0;
            this.UserInfoBox.TabStop = false;
            this.UserInfoBox.Text = "Пользовательская информация";
            // 
            // completeButton
            // 
            this.completeButton.Enabled = false;
            this.completeButton.Location = new System.Drawing.Point(6, 323);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(316, 26);
            this.completeButton.TabIndex = 10;
            this.completeButton.Text = "Готово";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // townLabel
            // 
            this.townLabel.AutoSize = true;
            this.townLabel.Location = new System.Drawing.Point(14, 195);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(37, 13);
            this.townLabel.TabIndex = 19;
            this.townLabel.Text = "Город";
            // 
            // birthdayGroupBox
            // 
            this.birthdayGroupBox.Controls.Add(this.birthdayPicker);
            this.birthdayGroupBox.Location = new System.Drawing.Point(8, 229);
            this.birthdayGroupBox.Name = "birthdayGroupBox";
            this.birthdayGroupBox.Size = new System.Drawing.Size(314, 37);
            this.birthdayGroupBox.TabIndex = 24;
            this.birthdayGroupBox.TabStop = false;
            this.birthdayGroupBox.Text = "Дата рождения";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayPicker.Location = new System.Drawing.Point(152, 11);
            this.birthdayPicker.MaxDate = new System.DateTime(2023, 9, 14, 0, 0, 0, 0);
            this.birthdayPicker.MinDate = new System.DateTime(1907, 3, 3, 0, 0, 0, 0);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.birthdayPicker.Size = new System.Drawing.Size(156, 20);
            this.birthdayPicker.TabIndex = 6;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(14, 169);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 18;
            this.countryLabel.Text = "Страна";
            // 
            // townDomainUpDown
            // 
            this.townDomainUpDown.Enabled = false;
            this.townDomainUpDown.Location = new System.Drawing.Point(160, 193);
            this.townDomainUpDown.Name = "townDomainUpDown";
            this.townDomainUpDown.Size = new System.Drawing.Size(156, 20);
            this.townDomainUpDown.TabIndex = 5;
            this.townDomainUpDown.Text = "...";
            this.townDomainUpDown.Wrap = true;
            // 
            // countryDomainUpDown
            // 
            this.countryDomainUpDown.Items.Add("Россия");
            this.countryDomainUpDown.Items.Add("США");
            this.countryDomainUpDown.Items.Add("Украина");
            this.countryDomainUpDown.Items.Add("Казахстан");
            this.countryDomainUpDown.Items.Add("Китай");
            this.countryDomainUpDown.Location = new System.Drawing.Point(160, 167);
            this.countryDomainUpDown.Name = "countryDomainUpDown";
            this.countryDomainUpDown.Size = new System.Drawing.Size(156, 20);
            this.countryDomainUpDown.TabIndex = 4;
            this.countryDomainUpDown.Text = "...";
            this.countryDomainUpDown.Wrap = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 303);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(314, 14);
            this.progressBar.TabIndex = 14;
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(104, 94);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(54, 13);
            this.patronymicLabel.TabIndex = 7;
            this.patronymicLabel.Text = "Отчество";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(104, 30);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(56, 13);
            this.surnameLabel.TabIndex = 6;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(104, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Имя";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(166, 91);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(150, 20);
            this.patronymicTextBox.TabIndex = 3;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(166, 27);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(150, 20);
            this.surnameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(166, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.whatRadioButton);
            this.groupBox1.Controls.Add(this.manRadioButton);
            this.groupBox1.Controls.Add(this.womanRadioButton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(8, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 37);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол";
            // 
            // whatRadioButton
            // 
            this.whatRadioButton.AutoSize = true;
            this.whatRadioButton.Location = new System.Drawing.Point(196, 12);
            this.whatRadioButton.Name = "whatRadioButton";
            this.whatRadioButton.Size = new System.Drawing.Size(114, 17);
            this.whatRadioButton.TabIndex = 6;
            this.whatRadioButton.Text = "Не определилось";
            this.whatRadioButton.UseVisualStyleBackColor = true;
            // 
            // manRadioButton
            // 
            this.manRadioButton.AutoSize = true;
            this.manRadioButton.Checked = true;
            this.manRadioButton.Location = new System.Drawing.Point(41, 12);
            this.manRadioButton.Name = "manRadioButton";
            this.manRadioButton.Size = new System.Drawing.Size(71, 17);
            this.manRadioButton.TabIndex = 4;
            this.manRadioButton.Text = "Мужской";
            this.manRadioButton.UseVisualStyleBackColor = true;
            // 
            // womanRadioButton
            // 
            this.womanRadioButton.AutoSize = true;
            this.womanRadioButton.Location = new System.Drawing.Point(118, 12);
            this.womanRadioButton.Name = "womanRadioButton";
            this.womanRadioButton.Size = new System.Drawing.Size(72, 17);
            this.womanRadioButton.TabIndex = 5;
            this.womanRadioButton.Text = "Женский";
            this.womanRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 377);
            this.Controls.Add(this.UserInfoBox);
            this.Name = "Form1";
            this.Text = "Тестирование";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UserInfoBox.ResumeLayout(false);
            this.UserInfoBox.PerformLayout();
            this.birthdayGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserInfoBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton whatRadioButton;
        private System.Windows.Forms.RadioButton womanRadioButton;
        private System.Windows.Forms.RadioButton manRadioButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown countryDomainUpDown;
        private System.Windows.Forms.DomainUpDown townDomainUpDown;
        private System.Windows.Forms.Label townLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.GroupBox birthdayGroupBox;
    }
}

