﻿namespace intaktika
{
    partial class FormMain
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
            System.Windows.Forms.Button buttonAdmin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button buttonReports;
            this.buttonCreateBid = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.comboBoxPages = new System.Windows.Forms.ComboBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.pictureBoxFilters = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewBids = new System.Windows.Forms.DataGridView();
            buttonAdmin = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            buttonReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBids)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            buttonAdmin.CausesValidation = false;
            buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonAdmin.Location = new System.Drawing.Point(10, 12);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new System.Drawing.Size(142, 38);
            buttonAdmin.TabIndex = 0;
            buttonAdmin.Text = "Добавить пользователя";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonCreateBid
            // 
            this.buttonCreateBid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateBid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateBid.Location = new System.Drawing.Point(752, 12);
            this.buttonCreateBid.Name = "buttonCreateBid";
            this.buttonCreateBid.Size = new System.Drawing.Size(139, 38);
            this.buttonCreateBid.TabIndex = 1;
            this.buttonCreateBid.Text = "Создать заявку";
            this.buttonCreateBid.UseVisualStyleBackColor = false;
            this.buttonCreateBid.Click += new System.EventHandler(this.buttonCreateBid_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 104);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(274, 23);
            this.textBoxSearch.TabIndex = 2;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(12, 85);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(39, 13);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Поиск";
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.BackgroundImage")));
            this.pictureBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSearch.Location = new System.Drawing.Point(292, 104);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxSearch.TabIndex = 4;
            this.pictureBoxSearch.TabStop = false;
            // 
            // comboBoxPages
            // 
            this.comboBoxPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPages.FormattingEnabled = true;
            this.comboBoxPages.Location = new System.Drawing.Point(693, 104);
            this.comboBoxPages.Name = "comboBoxPages";
            this.comboBoxPages.Size = new System.Drawing.Size(198, 24);
            this.comboBoxPages.TabIndex = 9;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(692, 86);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(114, 13);
            this.labelPages.TabIndex = 8;
            this.labelPages.Text = "Количество записей:";
            // 
            // pictureBoxFilters
            // 
            this.pictureBoxFilters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFilters.BackgroundImage")));
            this.pictureBoxFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFilters.Location = new System.Drawing.Point(321, 104);
            this.pictureBoxFilters.Name = "pictureBoxFilters";
            this.pictureBoxFilters.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxFilters.TabIndex = 10;
            this.pictureBoxFilters.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(349, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewBids
            // 
            this.dataGridViewBids.AllowUserToAddRows = false;
            this.dataGridViewBids.AllowUserToDeleteRows = false;
            this.dataGridViewBids.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBids.Location = new System.Drawing.Point(12, 134);
            this.dataGridViewBids.Name = "dataGridViewBids";
            this.dataGridViewBids.ReadOnly = true;
            this.dataGridViewBids.Size = new System.Drawing.Size(879, 462);
            this.dataGridViewBids.TabIndex = 11;
            this.dataGridViewBids.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBids_CellContentClick);
            // 
            // button1
            // 
            button1.CausesValidation = false;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Location = new System.Drawing.Point(158, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(142, 38);
            button1.TabIndex = 13;
            button1.Text = "Добавить клиента";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReports
            // 
            buttonReports.CausesValidation = false;
            buttonReports.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonReports.Location = new System.Drawing.Point(306, 12);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new System.Drawing.Size(142, 38);
            buttonReports.TabIndex = 14;
            buttonReports.Text = "Отчеты";
            buttonReports.UseVisualStyleBackColor = true;
            buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 820);
            this.Controls.Add(buttonReports);
            this.Controls.Add(button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewBids);
            this.Controls.Add(this.pictureBoxFilters);
            this.Controls.Add(this.comboBoxPages);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(buttonAdmin);
            this.Controls.Add(this.buttonCreateBid);
            this.Name = "FormMain";
            this.Text = "ИС \"Интактика\"";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBids)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateBid;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxPages;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.PictureBox pictureBoxFilters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBids;
    }
}

