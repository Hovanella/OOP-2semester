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
            this.textBoxSecondValue = new System.Windows.Forms.TextBox();
            this.textBoxOperationSign = new System.Windows.Forms.TextBox();
            this.textBoxEquals = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxFirstValue = new System.Windows.Forms.TextBox();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSecondValue
            // 
            this.textBoxSecondValue.Location = new System.Drawing.Point(242, 108);
            this.textBoxSecondValue.Name = "textBoxSecondValue";
            this.textBoxSecondValue.Size = new System.Drawing.Size(160, 22);
            this.textBoxSecondValue.TabIndex = 1;
            // 
            // textBoxOperationSign
            // 
            this.textBoxOperationSign.BackColor = System.Drawing.Color.Pink;
            this.textBoxOperationSign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOperationSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOperationSign.Location = new System.Drawing.Point(209, 108);
            this.textBoxOperationSign.Name = "textBoxOperationSign";
            this.textBoxOperationSign.Size = new System.Drawing.Size(27, 23);
            this.textBoxOperationSign.TabIndex = 4;
            this.textBoxOperationSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEquals
            // 
            this.textBoxEquals.BackColor = System.Drawing.Color.Pink;
            this.textBoxEquals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEquals.Location = new System.Drawing.Point(408, 104);
            this.textBoxEquals.Name = "textBoxEquals";
            this.textBoxEquals.Size = new System.Drawing.Size(27, 23);
            this.textBoxEquals.TabIndex = 5;
            this.textBoxEquals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(441, 108);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(160, 22);
            this.textBoxResult.TabIndex = 6;
            // 
            // textBoxFirstValue
            // 
            this.textBoxFirstValue.Location = new System.Drawing.Point(43, 108);
            this.textBoxFirstValue.Name = "textBoxFirstValue";
            this.textBoxFirstValue.Size = new System.Drawing.Size(160, 22);
            this.textBoxFirstValue.TabIndex = 7;
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Location = new System.Drawing.Point(441, 54);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.Size = new System.Drawing.Size(160, 22);
            this.textBoxMemory.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(242, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Second Value";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Value";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(441, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Result";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(441, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Memory";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/", "^" });
            this.comboBox1.Location = new System.Drawing.Point(43, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 39);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(43, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sign Choise\r\n";
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.White;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEquals.Location = new System.Drawing.Point(242, 198);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(162, 39);
            this.buttonEquals.TabIndex = 16;
            this.buttonEquals.Text = "=\r\n";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonSave.Location = new System.Drawing.Point(441, 198);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(162, 39);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonClear.Location = new System.Drawing.Point(242, 271);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(162, 39);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // CalculatorForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(710, 451);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMemory);
            this.Controls.Add(this.textBoxFirstValue);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxEquals);
            this.Controls.Add(this.textBoxOperationSign);
            this.Controls.Add(this.textBoxSecondValue);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.Button buttonEquals;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxEquals;
        private System.Windows.Forms.TextBox textBoxOperationSign;

        private System.Windows.Forms.TextBox textBoxSecondValue;
        private System.Windows.Forms.TextBox textBoxFirstValue;

        private System.Windows.Forms.TextBox textBoxResult;

        #endregion
    }
}