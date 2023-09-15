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
            this.userInfoBox = new System.Windows.Forms.GroupBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.completeButton = new System.Windows.Forms.Button();
            this.cityLabel = new System.Windows.Forms.Label();
            this.birthdayGroupBox = new System.Windows.Forms.GroupBox();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.countryLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.whatRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.insertPhotoButton = new System.Windows.Forms.Button();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.userInfoBox.SuspendLayout();
            this.birthdayGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfoBox
            // 
            this.userInfoBox.Controls.Add(this.insertPhotoButton);
            this.userInfoBox.Controls.Add(this.cityComboBox);
            this.userInfoBox.Controls.Add(this.countryComboBox);
            this.userInfoBox.Controls.Add(this.surnameTextBox);
            this.userInfoBox.Controls.Add(this.completeButton);
            this.userInfoBox.Controls.Add(this.cityLabel);
            this.userInfoBox.Controls.Add(this.birthdayGroupBox);
            this.userInfoBox.Controls.Add(this.countryLabel);
            this.userInfoBox.Controls.Add(this.patronymicLabel);
            this.userInfoBox.Controls.Add(this.surnameLabel);
            this.userInfoBox.Controls.Add(this.nameLabel);
            this.userInfoBox.Controls.Add(this.patronymicTextBox);
            this.userInfoBox.Controls.Add(this.nameTextBox);
            this.userInfoBox.Controls.Add(this.photoBox);
            this.userInfoBox.Controls.Add(this.groupBox1);
            this.userInfoBox.Location = new System.Drawing.Point(12, 12);
            this.userInfoBox.Name = "userInfoBox";
            this.userInfoBox.Size = new System.Drawing.Size(328, 378);
            this.userInfoBox.TabIndex = 0;
            this.userInfoBox.TabStop = false;
            this.userInfoBox.Text = "Пользовательская информация";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(158, 236);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(158, 21);
            this.cityComboBox.TabIndex = 26;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Россия",
            "Украина",
            "Казахстан",
            "США"});
            this.countryComboBox.Location = new System.Drawing.Point(158, 209);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(158, 21);
            this.countryComboBox.TabIndex = 25;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            this.countryComboBox.TextUpdate += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(166, 27);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(150, 20);
            this.surnameTextBox.TabIndex = 1;
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(6, 346);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(316, 26);
            this.completeButton.TabIndex = 10;
            this.completeButton.Text = "Готово";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 238);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 13);
            this.cityLabel.TabIndex = 19;
            this.cityLabel.Text = "Город";
            // 
            // birthdayGroupBox
            // 
            this.birthdayGroupBox.Controls.Add(this.birthdayPicker);
            this.birthdayGroupBox.Location = new System.Drawing.Point(6, 272);
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
            this.birthdayPicker.Value = new System.DateTime(2023, 9, 14, 0, 0, 0, 0);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(12, 212);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 18;
            this.countryLabel.Text = "Страна";
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
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(166, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.whatRadioButton);
            this.groupBox1.Controls.Add(this.maleRadioButton);
            this.groupBox1.Controls.Add(this.femaleRadioButton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(8, 158);
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
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Location = new System.Drawing.Point(41, 12);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(71, 17);
            this.maleRadioButton.TabIndex = 4;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Мужской";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(118, 12);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(72, 17);
            this.femaleRadioButton.TabIndex = 5;
            this.femaleRadioButton.Text = "Женский";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Изображения (*.PNG; *.BMP; *.JPG; *JPEG; *.GIF)|*.PNG;*.BMP;*.JPG;*JPEG;*.GIF";
            // 
            // insertPhotoButton
            // 
            this.insertPhotoButton.Location = new System.Drawing.Point(8, 124);
            this.insertPhotoButton.Name = "insertPhotoButton";
            this.insertPhotoButton.Size = new System.Drawing.Size(90, 23);
            this.insertPhotoButton.TabIndex = 27;
            this.insertPhotoButton.Text = "Вставить фото";
            this.insertPhotoButton.UseVisualStyleBackColor = true;
            this.insertPhotoButton.Click += new System.EventHandler(this.insertPhotoButton_Click);
            // 
            // photoBox
            // 
            this.photoBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photoBox.Image = global::form.Properties.Resources.anonim;
            this.photoBox.InitialImage = null;
            this.photoBox.Location = new System.Drawing.Point(8, 19);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(90, 99);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoBox.TabIndex = 0;
            this.photoBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 401);
            this.Controls.Add(this.userInfoBox);
            this.MaximumSize = new System.Drawing.Size(368, 440);
            this.MinimumSize = new System.Drawing.Size(368, 440);
            this.Name = "Form1";
            this.Text = "Анкета";
            this.userInfoBox.ResumeLayout(false);
            this.userInfoBox.PerformLayout();
            this.birthdayGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userInfoBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton whatRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.GroupBox birthdayGroupBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Button insertPhotoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

