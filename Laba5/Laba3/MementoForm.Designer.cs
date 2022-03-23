using System.ComponentModel;

namespace Laba2
{
    partial class MementoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.AddStateTextBox = new System.Windows.Forms.TextBox();
            this.CurrentStateTextBox = new System.Windows.Forms.TextBox();
            this.AddStateButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStateTextBox
            // 
            this.AddStateTextBox.Location = new System.Drawing.Point(140, 97);
            this.AddStateTextBox.Name = "AddStateTextBox";
            this.AddStateTextBox.Size = new System.Drawing.Size(213, 22);
            this.AddStateTextBox.TabIndex = 0;
            // 
            // CurrentStateTextBox
            // 
            this.CurrentStateTextBox.Location = new System.Drawing.Point(140, 190);
            this.CurrentStateTextBox.Name = "CurrentStateTextBox";
            this.CurrentStateTextBox.Size = new System.Drawing.Size(213, 22);
            this.CurrentStateTextBox.TabIndex = 1;
            // 
            // AddStateButton
            // 
            this.AddStateButton.Location = new System.Drawing.Point(140, 127);
            this.AddStateButton.Name = "AddStateButton";
            this.AddStateButton.Size = new System.Drawing.Size(212, 57);
            this.AddStateButton.TabIndex = 2;
            this.AddStateButton.Text = "AddState";
            this.AddStateButton.UseVisualStyleBackColor = true;
            this.AddStateButton.Click += new System.EventHandler(this.AddStateButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(50, 127);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(84, 57);
            this.UndoButton.TabIndex = 3;
            this.UndoButton.Text = "Undo\r\n\r\n";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Location = new System.Drawing.Point(358, 127);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(84, 57);
            this.RedoButton.TabIndex = 4;
            this.RedoButton.Text = "Redo";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // MementoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 334);
            this.Controls.Add(this.RedoButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.AddStateButton);
            this.Controls.Add(this.CurrentStateTextBox);
            this.Controls.Add(this.AddStateTextBox);
            this.Name = "MementoForm";
            this.Text = "MementoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MementoForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button RedoButton;

        private System.Windows.Forms.TextBox AddStateTextBox;

        private System.Windows.Forms.TextBox CurrentStateTextBox;

        private System.Windows.Forms.Button AddStateButton;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        #endregion
    }
}