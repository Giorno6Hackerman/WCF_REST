namespace WcfClient
{
    partial class mainForm
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
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.offsetTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.getFilePieceButton = new System.Windows.Forms.Button();
            this.sendTextButton = new System.Windows.Forms.Button();
            this.getHashCodeButton = new System.Windows.Forms.Button();
            this.getBase64Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(43, 49);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fileNameTextBox.TabIndex = 0;
            // 
            // offsetTextBox
            // 
            this.offsetTextBox.Location = new System.Drawing.Point(195, 49);
            this.offsetTextBox.Name = "offsetTextBox";
            this.offsetTextBox.Size = new System.Drawing.Size(100, 20);
            this.offsetTextBox.TabIndex = 1;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(370, 49);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 2;
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(43, 152);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(427, 99);
            this.textTextBox.TabIndex = 3;
            // 
            // getFilePieceButton
            // 
            this.getFilePieceButton.Location = new System.Drawing.Point(563, 49);
            this.getFilePieceButton.Name = "getFilePieceButton";
            this.getFilePieceButton.Size = new System.Drawing.Size(123, 44);
            this.getFilePieceButton.TabIndex = 4;
            this.getFilePieceButton.Text = "Get piece of file";
            this.getFilePieceButton.UseVisualStyleBackColor = true;
            this.getFilePieceButton.Click += new System.EventHandler(this.getFilePieceButton_Click);
            // 
            // sendTextButton
            // 
            this.sendTextButton.Location = new System.Drawing.Point(563, 99);
            this.sendTextButton.Name = "sendTextButton";
            this.sendTextButton.Size = new System.Drawing.Size(123, 45);
            this.sendTextButton.TabIndex = 6;
            this.sendTextButton.Text = "Append text";
            this.sendTextButton.UseVisualStyleBackColor = true;
            this.sendTextButton.Click += new System.EventHandler(this.sendTextButton_Click);
            // 
            // getHashCodeButton
            // 
            this.getHashCodeButton.Location = new System.Drawing.Point(563, 150);
            this.getHashCodeButton.Name = "getHashCodeButton";
            this.getHashCodeButton.Size = new System.Drawing.Size(123, 49);
            this.getHashCodeButton.TabIndex = 7;
            this.getHashCodeButton.Text = "Get hash code";
            this.getHashCodeButton.UseVisualStyleBackColor = true;
            this.getHashCodeButton.Click += new System.EventHandler(this.getHashCodeButton_Click);
            // 
            // getBase64Button
            // 
            this.getBase64Button.Location = new System.Drawing.Point(563, 205);
            this.getBase64Button.Name = "getBase64Button";
            this.getBase64Button.Size = new System.Drawing.Size(123, 46);
            this.getBase64Button.TabIndex = 8;
            this.getBase64Button.Text = "Get Base64 code";
            this.getBase64Button.UseVisualStyleBackColor = true;
            this.getBase64Button.Click += new System.EventHandler(this.getBase64Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Text";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(43, 300);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(643, 108);
            this.resultTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Result";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 420);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getBase64Button);
            this.Controls.Add(this.getHashCodeButton);
            this.Controls.Add(this.sendTextButton);
            this.Controls.Add(this.getFilePieceButton);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.offsetTextBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Name = "mainForm";
            this.Text = "REST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox offsetTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Button getFilePieceButton;
        private System.Windows.Forms.Button sendTextButton;
        private System.Windows.Forms.Button getHashCodeButton;
        private System.Windows.Forms.Button getBase64Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label5;
    }
}

