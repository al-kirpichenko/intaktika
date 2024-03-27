namespace intaktika
{
    partial class EditBid
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
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDecsription = new System.Windows.Forms.Label();
            this.labelExecutor = new System.Windows.Forms.Label();
            this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOpen = new System.Windows.Forms.DateTimePicker();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelClosed = new System.Windows.Forms.Label();
            this.dateTimePickerClosed = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(150, 57);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(57, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "№ заявки";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(213, 50);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(249, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(213, 77);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(249, 21);
            this.comboBoxClient.TabIndex = 2;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(164, 85);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 3;
            this.labelClient.Text = "Клиент";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(213, 105);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(249, 157);
            this.textBoxDescription.TabIndex = 4;
            // 
            // labelDecsription
            // 
            this.labelDecsription.AutoSize = true;
            this.labelDecsription.Location = new System.Drawing.Point(150, 249);
            this.labelDecsription.Name = "labelDecsription";
            this.labelDecsription.Size = new System.Drawing.Size(57, 13);
            this.labelDecsription.TabIndex = 5;
            this.labelDecsription.Text = "Описание";
            // 
            // labelExecutor
            // 
            this.labelExecutor.AutoSize = true;
            this.labelExecutor.Location = new System.Drawing.Point(133, 276);
            this.labelExecutor.Name = "labelExecutor";
            this.labelExecutor.Size = new System.Drawing.Size(74, 13);
            this.labelExecutor.TabIndex = 7;
            this.labelExecutor.Text = "Исполнитель";
            // 
            // comboBoxExecutor
            // 
            this.comboBoxExecutor.FormattingEnabled = true;
            this.comboBoxExecutor.Location = new System.Drawing.Point(213, 268);
            this.comboBoxExecutor.Name = "comboBoxExecutor";
            this.comboBoxExecutor.Size = new System.Drawing.Size(249, 21);
            this.comboBoxExecutor.TabIndex = 6;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(166, 303);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 13);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(213, 295);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(249, 21);
            this.comboBoxStatus.TabIndex = 8;
            // 
            // dateTimePickerOpen
            // 
            this.dateTimePickerOpen.Location = new System.Drawing.Point(213, 323);
            this.dateTimePickerOpen.Name = "dateTimePickerOpen";
            this.dateTimePickerOpen.Size = new System.Drawing.Size(249, 20);
            this.dateTimePickerOpen.TabIndex = 10;
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Location = new System.Drawing.Point(123, 329);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(84, 13);
            this.labelOpen.TabIndex = 11;
            this.labelOpen.Text = "Дата открытия";
            // 
            // labelClosed
            // 
            this.labelClosed.AutoSize = true;
            this.labelClosed.Location = new System.Drawing.Point(123, 355);
            this.labelClosed.Name = "labelClosed";
            this.labelClosed.Size = new System.Drawing.Size(85, 13);
            this.labelClosed.TabIndex = 13;
            this.labelClosed.Text = "Дата закрытия";
            // 
            // dateTimePickerClosed
            // 
            this.dateTimePickerClosed.Location = new System.Drawing.Point(213, 349);
            this.dateTimePickerClosed.Name = "dateTimePickerClosed";
            this.dateTimePickerClosed.Size = new System.Drawing.Size(249, 20);
            this.dateTimePickerClosed.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(183, 389);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(205, 49);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // EditBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelClosed);
            this.Controls.Add(this.dateTimePickerClosed);
            this.Controls.Add(this.labelOpen);
            this.Controls.Add(this.dateTimePickerOpen);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelExecutor);
            this.Controls.Add(this.comboBoxExecutor);
            this.Controls.Add(this.labelDecsription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Name = "EditBid";
            this.Text = "Изменить заявку";
            this.Load += new System.EventHandler(this.EditBid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDecsription;
        private System.Windows.Forms.Label labelExecutor;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerOpen;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Label labelClosed;
        private System.Windows.Forms.DateTimePicker dateTimePickerClosed;
        private System.Windows.Forms.Button buttonSave;
    }
}