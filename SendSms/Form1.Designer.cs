namespace SendSms
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
            System.Windows.Forms.Label LbFIO;
            System.Windows.Forms.Label LbPosition;
            System.Windows.Forms.Label LbNumber;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtAddCont = new System.Windows.Forms.Button();
            this.BtDelCont = new System.Windows.Forms.Button();
            this.BtEditCont = new System.Windows.Forms.Button();
            this.TBMessege = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtSend = new System.Windows.Forms.Button();
            this.CbOtrdel = new System.Windows.Forms.ComboBox();
            this.PAddContact = new System.Windows.Forms.Panel();
            this.TbNumber = new System.Windows.Forms.MaskedTextBox();
            this.LbID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtSave = new System.Windows.Forms.Button();
            this.TbFIO = new System.Windows.Forms.TextBox();
            this.TbPosition = new System.Windows.Forms.TextBox();
            this.LsbDB = new System.Windows.Forms.ListBox();
            this.BtSettings = new System.Windows.Forms.Button();
            this.PSettings = new System.Windows.Forms.Panel();
            this.TbAPIS = new System.Windows.Forms.TextBox();
            this.LbAPIS = new System.Windows.Forms.Label();
            this.TbAPIKey = new System.Windows.Forms.TextBox();
            this.LbAPIKey = new System.Windows.Forms.Label();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.LbTitle = new System.Windows.Forms.Label();
            LbFIO = new System.Windows.Forms.Label();
            LbPosition = new System.Windows.Forms.Label();
            LbNumber = new System.Windows.Forms.Label();
            this.PAddContact.SuspendLayout();
            this.PSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbFIO
            // 
            LbFIO.AutoSize = true;
            LbFIO.Location = new System.Drawing.Point(0, 25);
            LbFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LbFIO.Name = "LbFIO";
            LbFIO.Size = new System.Drawing.Size(46, 17);
            LbFIO.TabIndex = 11;
            LbFIO.Text = "ФИО:";
            // 
            // LbPosition
            // 
            LbPosition.AutoSize = true;
            LbPosition.Location = new System.Drawing.Point(0, 57);
            LbPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LbPosition.Name = "LbPosition";
            LbPosition.Size = new System.Drawing.Size(85, 17);
            LbPosition.TabIndex = 13;
            LbPosition.Text = "Должность:";
            // 
            // LbNumber
            // 
            LbNumber.AutoSize = true;
            LbNumber.Location = new System.Drawing.Point(0, 89);
            LbNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LbNumber.Name = "LbNumber";
            LbNumber.Size = new System.Drawing.Size(125, 17);
            LbNumber.TabIndex = 15;
            LbNumber.Text = "Номер телефона:";
            // 
            // BtAddCont
            // 
            this.BtAddCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtAddCont.Location = new System.Drawing.Point(16, 15);
            this.BtAddCont.Margin = new System.Windows.Forms.Padding(4);
            this.BtAddCont.Name = "BtAddCont";
            this.BtAddCont.Size = new System.Drawing.Size(175, 28);
            this.BtAddCont.TabIndex = 1;
            this.BtAddCont.Text = "Добавить контакт";
            this.BtAddCont.UseVisualStyleBackColor = true;
            this.BtAddCont.Click += new System.EventHandler(this.BAddCont_Click);
            // 
            // BtDelCont
            // 
            this.BtDelCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtDelCont.Location = new System.Drawing.Point(421, 15);
            this.BtDelCont.Margin = new System.Windows.Forms.Padding(4);
            this.BtDelCont.Name = "BtDelCont";
            this.BtDelCont.Size = new System.Drawing.Size(175, 28);
            this.BtDelCont.TabIndex = 2;
            this.BtDelCont.Text = "Удалить контакт";
            this.BtDelCont.UseVisualStyleBackColor = true;
            this.BtDelCont.Click += new System.EventHandler(this.BtDelCont_Click);
            // 
            // BtEditCont
            // 
            this.BtEditCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtEditCont.Location = new System.Drawing.Point(199, 15);
            this.BtEditCont.Margin = new System.Windows.Forms.Padding(4);
            this.BtEditCont.Name = "BtEditCont";
            this.BtEditCont.Size = new System.Drawing.Size(215, 28);
            this.BtEditCont.TabIndex = 3;
            this.BtEditCont.Text = "Редактировать контакт";
            this.BtEditCont.UseVisualStyleBackColor = true;
            this.BtEditCont.Click += new System.EventHandler(this.BtEditCont_Click);
            // 
            // TBMessege
            // 
            this.TBMessege.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBMessege.Location = new System.Drawing.Point(16, 328);
            this.TBMessege.Margin = new System.Windows.Forms.Padding(4);
            this.TBMessege.MaxLength = 70;
            this.TBMessege.Multiline = true;
            this.TBMessege.Name = "TBMessege";
            this.TBMessege.Size = new System.Drawing.Size(795, 78);
            this.TBMessege.TabIndex = 4;
            this.TBMessege.TextChanged += new System.EventHandler(this.TBMessege_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список контактов()";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Текст сообщения (0/70)";
            // 
            // BtSend
            // 
            this.BtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtSend.Location = new System.Drawing.Point(16, 416);
            this.BtSend.Margin = new System.Windows.Forms.Padding(4);
            this.BtSend.Name = "BtSend";
            this.BtSend.Size = new System.Drawing.Size(796, 39);
            this.BtSend.TabIndex = 7;
            this.BtSend.Text = "Отправить";
            this.BtSend.UseVisualStyleBackColor = true;
            this.BtSend.Click += new System.EventHandler(this.BtSend_Click);
            // 
            // CbOtrdel
            // 
            this.CbOtrdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbOtrdel.FormattingEnabled = true;
            this.CbOtrdel.Items.AddRange(new object[] {
            "Отдел продаж",
            "Бухгалтерия",
            "Отдел технической поддержки",
            "IT отдел",
            "Юридический отдел",
            "Отдел маркетинга",
            "Отдел кадров"});
            this.CbOtrdel.Location = new System.Drawing.Point(604, 15);
            this.CbOtrdel.Margin = new System.Windows.Forms.Padding(4);
            this.CbOtrdel.Name = "CbOtrdel";
            this.CbOtrdel.Size = new System.Drawing.Size(207, 28);
            this.CbOtrdel.TabIndex = 9;
            this.CbOtrdel.Text = "Выберите отдел";
            this.CbOtrdel.SelectedIndexChanged += new System.EventHandler(this.CbOtrdel_SelectedIndexChanged);
            // 
            // PAddContact
            // 
            this.PAddContact.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PAddContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PAddContact.Controls.Add(this.TbNumber);
            this.PAddContact.Controls.Add(this.LbID);
            this.PAddContact.Controls.Add(this.label3);
            this.PAddContact.Controls.Add(this.BtSave);
            this.PAddContact.Controls.Add(LbFIO);
            this.PAddContact.Controls.Add(this.TbFIO);
            this.PAddContact.Controls.Add(LbPosition);
            this.PAddContact.Controls.Add(this.TbPosition);
            this.PAddContact.Controls.Add(LbNumber);
            this.PAddContact.Location = new System.Drawing.Point(16, 46);
            this.PAddContact.Margin = new System.Windows.Forms.Padding(4);
            this.PAddContact.Name = "PAddContact";
            this.PAddContact.Size = new System.Drawing.Size(442, 162);
            this.PAddContact.TabIndex = 10;
            this.PAddContact.Visible = false;
            // 
            // TbNumber
            // 
            this.TbNumber.Location = new System.Drawing.Point(136, 85);
            this.TbNumber.Mask = "+0 (000) 000 00-00";
            this.TbNumber.Name = "TbNumber";
            this.TbNumber.RejectInputOnFirstFailure = true;
            this.TbNumber.Size = new System.Drawing.Size(287, 22);
            this.TbNumber.TabIndex = 20;
            // 
            // LbID
            // 
            this.LbID.AutoSize = true;
            this.LbID.Location = new System.Drawing.Point(0, 2);
            this.LbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(41, 17);
            this.LbID.TabIndex = 19;
            this.LbID.Text = "Код: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Добавление";
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(4, 117);
            this.BtSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(420, 28);
            this.BtSave.TabIndex = 17;
            this.BtSave.Text = "Сохранить";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // TbFIO
            // 
            this.TbFIO.Location = new System.Drawing.Point(136, 21);
            this.TbFIO.Margin = new System.Windows.Forms.Padding(4);
            this.TbFIO.Name = "TbFIO";
            this.TbFIO.Size = new System.Drawing.Size(287, 22);
            this.TbFIO.TabIndex = 12;
            // 
            // TbPosition
            // 
            this.TbPosition.Location = new System.Drawing.Point(136, 53);
            this.TbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.TbPosition.Name = "TbPosition";
            this.TbPosition.Size = new System.Drawing.Size(287, 22);
            this.TbPosition.TabIndex = 14;
            // 
            // LsbDB
            // 
            this.LsbDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LsbDB.FormattingEnabled = true;
            this.LsbDB.ItemHeight = 20;
            this.LsbDB.Location = new System.Drawing.Point(16, 75);
            this.LsbDB.Margin = new System.Windows.Forms.Padding(4);
            this.LsbDB.Name = "LsbDB";
            this.LsbDB.Size = new System.Drawing.Size(795, 144);
            this.LsbDB.TabIndex = 11;
            this.LsbDB.Click += new System.EventHandler(this.LsbDB_Click);
            // 
            // BtSettings
            // 
            this.BtSettings.Location = new System.Drawing.Point(712, 46);
            this.BtSettings.Margin = new System.Windows.Forms.Padding(4);
            this.BtSettings.Name = "BtSettings";
            this.BtSettings.Size = new System.Drawing.Size(100, 28);
            this.BtSettings.TabIndex = 12;
            this.BtSettings.Text = "Настройки";
            this.BtSettings.UseVisualStyleBackColor = true;
            this.BtSettings.Click += new System.EventHandler(this.BtSettings_Click);
            // 
            // PSettings
            // 
            this.PSettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PSettings.Controls.Add(this.TbAPIS);
            this.PSettings.Controls.Add(this.LbAPIS);
            this.PSettings.Controls.Add(this.TbAPIKey);
            this.PSettings.Controls.Add(this.LbAPIKey);
            this.PSettings.Location = new System.Drawing.Point(545, 75);
            this.PSettings.Margin = new System.Windows.Forms.Padding(4);
            this.PSettings.Name = "PSettings";
            this.PSettings.Size = new System.Drawing.Size(267, 162);
            this.PSettings.TabIndex = 13;
            this.PSettings.Visible = false;
            // 
            // TbAPIS
            // 
            this.TbAPIS.Location = new System.Drawing.Point(49, 37);
            this.TbAPIS.Margin = new System.Windows.Forms.Padding(4);
            this.TbAPIS.Name = "TbAPIS";
            this.TbAPIS.Size = new System.Drawing.Size(212, 22);
            this.TbAPIS.TabIndex = 3;
            this.TbAPIS.TextChanged += new System.EventHandler(this.TbAPIS_TextChanged);
            // 
            // LbAPIS
            // 
            this.LbAPIS.AutoSize = true;
            this.LbAPIS.Location = new System.Drawing.Point(5, 41);
            this.LbAPIS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbAPIS.Name = "LbAPIS";
            this.LbAPIS.Size = new System.Drawing.Size(50, 17);
            this.LbAPIS.TabIndex = 2;
            this.LbAPIS.Text = "API S: ";
            // 
            // TbAPIKey
            // 
            this.TbAPIKey.Location = new System.Drawing.Point(64, 5);
            this.TbAPIKey.Margin = new System.Windows.Forms.Padding(4);
            this.TbAPIKey.Name = "TbAPIKey";
            this.TbAPIKey.Size = new System.Drawing.Size(197, 22);
            this.TbAPIKey.TabIndex = 1;
            this.TbAPIKey.TextChanged += new System.EventHandler(this.TbAPIKey_TextChanged);
            // 
            // LbAPIKey
            // 
            this.LbAPIKey.AutoSize = true;
            this.LbAPIKey.Location = new System.Drawing.Point(5, 9);
            this.LbAPIKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbAPIKey.Name = "LbAPIKey";
            this.LbAPIKey.Size = new System.Drawing.Size(63, 17);
            this.LbAPIKey.TabIndex = 0;
            this.LbAPIKey.Text = "API key: ";
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(16, 272);
            this.TbTitle.MaxLength = 20;
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(208, 22);
            this.TbTitle.TabIndex = 14;
            this.TbTitle.Text = "CompanyName";
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LbTitle.Location = new System.Drawing.Point(24, 249);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(92, 20);
            this.LbTitle.TabIndex = 15;
            this.LbTitle.Text = "Титул смс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 480);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.TbTitle);
            this.Controls.Add(this.PAddContact);
            this.Controls.Add(this.PSettings);
            this.Controls.Add(this.BtSettings);
            this.Controls.Add(this.LsbDB);
            this.Controls.Add(this.CbOtrdel);
            this.Controls.Add(this.BtSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBMessege);
            this.Controls.Add(this.BtEditCont);
            this.Controls.Add(this.BtDelCont);
            this.Controls.Add(this.BtAddCont);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SendSMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PAddContact.ResumeLayout(false);
            this.PAddContact.PerformLayout();
            this.PSettings.ResumeLayout(false);
            this.PSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtAddCont;
        private System.Windows.Forms.Button BtDelCont;
        private System.Windows.Forms.Button BtEditCont;
        private System.Windows.Forms.TextBox TBMessege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtSend;
        private System.Windows.Forms.ComboBox CbOtrdel;
        private System.Windows.Forms.Panel PAddContact;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.TextBox TbFIO;
        private System.Windows.Forms.TextBox TbPosition;

        private System.Windows.Forms.ListBox LsbDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbID;
        private System.Windows.Forms.Button BtSettings;
        private System.Windows.Forms.Panel PSettings;
        private System.Windows.Forms.TextBox TbAPIKey;
        private System.Windows.Forms.Label LbAPIKey;
        private System.Windows.Forms.TextBox TbAPIS;
        private System.Windows.Forms.Label LbAPIS;
        private System.Windows.Forms.MaskedTextBox TbNumber;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.Label LbTitle;
    }
}

