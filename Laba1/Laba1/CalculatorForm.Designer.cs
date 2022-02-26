namespace Laba1
{
    partial class CalculatorForm
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
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHiddenWeight = new System.Windows.Forms.TextBox();
            this.labelHiddenWeight = new System.Windows.Forms.Label();
            this.labelHiddenTime = new System.Windows.Forms.Label();
            this.textBoxHiddenTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNorma = new System.Windows.Forms.TextBox();
            this.comboBoxStyles = new System.Windows.Forms.ComboBox();
            this.textBoxDiagnoz = new System.Windows.Forms.TextBox();
            this.comboBoxTargets = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(38, 139);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(187, 22);
            this.textBoxHeight.TabIndex = 1;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.UsersInputsChanged);
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbersOnly_KeyPress);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(38, 289);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(187, 22);
            this.textBoxAge.TabIndex = 6;
            this.textBoxAge.TextChanged += new System.EventHandler(this.UsersInputsChanged);
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbersOnly_KeyPress);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxWeight.Location = new System.Drawing.Point(38, 62);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(187, 22);
            this.textBoxWeight.TabIndex = 7;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.UsersInputsChanged);
            this.textBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbersOnly_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите рост (км)";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите вес(т)\r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введите возраст(век)";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(38, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Выберите стиль";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(38, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Выберите цель\r\n";
            // 
            // textBoxHiddenWeight
            // 
            this.textBoxHiddenWeight.Location = new System.Drawing.Point(242, 347);
            this.textBoxHiddenWeight.Name = "textBoxHiddenWeight";
            this.textBoxHiddenWeight.Size = new System.Drawing.Size(159, 22);
            this.textBoxHiddenWeight.TabIndex = 21;
            this.textBoxHiddenWeight.Visible = false;
            this.textBoxHiddenWeight.TextChanged += new System.EventHandler(this.HiddenInputsChanged);
            this.textBoxHiddenWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbersOnly_KeyPress);
            // 
            // labelHiddenWeight
            // 
            this.labelHiddenWeight.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHiddenWeight.Location = new System.Drawing.Point(233, 319);
            this.labelHiddenWeight.Name = "labelHiddenWeight";
            this.labelHiddenWeight.Size = new System.Drawing.Size(197, 23);
            this.labelHiddenWeight.TabIndex = 22;
            this.labelHiddenWeight.Text = "Желаемый вес(т)\r\n";
            this.labelHiddenWeight.Visible = false;
            // 
            // labelHiddenTime
            // 
            this.labelHiddenTime.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHiddenTime.Location = new System.Drawing.Point(242, 391);
            this.labelHiddenTime.Name = "labelHiddenTime";
            this.labelHiddenTime.Size = new System.Drawing.Size(159, 23);
            this.labelHiddenTime.TabIndex = 24;
            this.labelHiddenTime.Text = " Срок(век)\r\n\r\n";
            this.labelHiddenTime.Visible = false;
            // 
            // textBoxHiddenTime
            // 
            this.textBoxHiddenTime.Location = new System.Drawing.Point(242, 417);
            this.textBoxHiddenTime.Name = "textBoxHiddenTime";
            this.textBoxHiddenTime.Size = new System.Drawing.Size(159, 22);
            this.textBoxHiddenTime.TabIndex = 23;
            this.textBoxHiddenTime.Visible = false;
            this.textBoxHiddenTime.TextChanged += new System.EventHandler(this.HiddenInputsChanged);
            this.textBoxHiddenTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbersOnly_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(493, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 30);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ваш диагноз";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(450, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Суточная норма(КлКал)";
            // 
            // textBoxNorma
            // 
            this.textBoxNorma.Location = new System.Drawing.Point(493, 360);
            this.textBoxNorma.Multiline = true;
            this.textBoxNorma.Name = "textBoxNorma";
            this.textBoxNorma.ReadOnly = true;
            this.textBoxNorma.Size = new System.Drawing.Size(160, 68);
            this.textBoxNorma.TabIndex = 27;
            // 
            // comboBoxStyles
            // 
            this.comboBoxStyles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStyles.FormattingEnabled = true;
            this.comboBoxStyles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxStyles.Items.AddRange(new object[] { "Мужской ", "Женский", "Вертолёт" });
            this.comboBoxStyles.Location = new System.Drawing.Point(38, 219);
            this.comboBoxStyles.Name = "comboBoxStyles";
            this.comboBoxStyles.Size = new System.Drawing.Size(187, 24);
            this.comboBoxStyles.TabIndex = 29;
            this.comboBoxStyles.SelectedIndexChanged += new System.EventHandler(this.UsersInputsChanged);
            this.comboBoxStyles.SelectionChangeCommitted += new System.EventHandler(this.UsersInputsChanged);
            // 
            // textBoxDiagnoz
            // 
            this.textBoxDiagnoz.Location = new System.Drawing.Point(493, 139);
            this.textBoxDiagnoz.Multiline = true;
            this.textBoxDiagnoz.Name = "textBoxDiagnoz";
            this.textBoxDiagnoz.ReadOnly = true;
            this.textBoxDiagnoz.Size = new System.Drawing.Size(160, 68);
            this.textBoxDiagnoz.TabIndex = 30;
            // 
            // comboBoxTargets
            // 
            this.comboBoxTargets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargets.FormattingEnabled = true;
            this.comboBoxTargets.Items.AddRange(new object[] { "Поддержание веса", "Увеличение веса", "Уменьшение веса" });
            this.comboBoxTargets.Location = new System.Drawing.Point(38, 392);
            this.comboBoxTargets.Name = "comboBoxTargets";
            this.comboBoxTargets.Size = new System.Drawing.Size(187, 24);
            this.comboBoxTargets.TabIndex = 31;
            this.comboBoxTargets.SelectedIndexChanged += new System.EventHandler(this.comboBoxTargets_SelectionChangeCommitted);
            this.comboBoxTargets.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTargets_SelectionChangeCommitted);
            // 
            // CalculatorForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(710, 501);
            this.Controls.Add(this.comboBoxTargets);
            this.Controls.Add(this.textBoxDiagnoz);
            this.Controls.Add(this.comboBoxStyles);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNorma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelHiddenTime);
            this.Controls.Add(this.textBoxHiddenTime);
            this.Controls.Add(this.labelHiddenWeight);
            this.Controls.Add(this.textBoxHiddenWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxHeight);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxStyles;

        private System.Windows.Forms.TextBox textBoxDiagnoz;

        private System.Windows.Forms.TextBox textBoxWeight;

        private System.Windows.Forms.TextBox textBoxAge;

        private System.Windows.Forms.TextBox textBoxHeight;

      

        private System.Windows.Forms.Label labelHiddenWeight;

        private System.Windows.Forms.TextBox textBoxHiddenWeight;

        private System.Windows.Forms.Label labelHiddenTime;

        private System.Windows.Forms.TextBox textBoxHiddenTime;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNorma;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.ComboBox comboBoxTargets;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxSecondValue;
        private System.Windows.Forms.TextBox textBoxFirstValue;

        private System.Windows.Forms.TextBox textBoxResult;

        #endregion
    }
}