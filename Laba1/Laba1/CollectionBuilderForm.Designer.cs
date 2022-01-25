using System.ComponentModel;

namespace Laba1
{
    partial class CollectionBuilderForm
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
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAscending = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDescending = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSecondQuery = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFirstQuery = new System.Windows.Forms.Button();
            this.buttonThirdQuery = new System.Windows.Forms.Button();
            this.listBoxCollection = new System.Windows.Forms.ListBox();
            this.listBoxQuery = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(350, 40);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(291, 22);
            this.textBoxCount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(350, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inter Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(347, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Collection";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAscending
            // 
            this.buttonAscending.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAscending.Location = new System.Drawing.Point(127, 221);
            this.buttonAscending.Name = "buttonAscending";
            this.buttonAscending.Size = new System.Drawing.Size(103, 62);
            this.buttonAscending.TabIndex = 4;
            this.buttonAscending.Text = "Ascending";
            this.buttonAscending.UseVisualStyleBackColor = true;
            this.buttonAscending.Click += new System.EventHandler(this.ButtonAscending_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(127, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order By";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
     
            // 
            // buttonDescending
            // 
            this.buttonDescending.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDescending.Location = new System.Drawing.Point(127, 307);
            this.buttonDescending.Name = "buttonDescending";
            this.buttonDescending.Size = new System.Drawing.Size(103, 62);
            this.buttonDescending.TabIndex = 7;
            this.buttonDescending.Text = "Descending";
            this.buttonDescending.UseVisualStyleBackColor = true;
            this.buttonDescending.Click += new System.EventHandler(this.buttonDescending_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.Location = new System.Drawing.Point(431, 81);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(121, 62);
            this.buttonGenerate.TabIndex = 8;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(347, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Query Result";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSecondQuery
            // 
            this.buttonSecondQuery.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSecondQuery.Location = new System.Drawing.Point(698, 329);
            this.buttonSecondQuery.Name = "buttonSecondQuery";
            this.buttonSecondQuery.Size = new System.Drawing.Size(102, 62);
            this.buttonSecondQuery.TabIndex = 13;
            this.buttonSecondQuery.Text = "Second";
            this.buttonSecondQuery.UseVisualStyleBackColor = true;
            this.buttonSecondQuery.Click += new System.EventHandler(this.buttonSecondQuery_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(678, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Make Query";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFirstQuery
            // 
            this.buttonFirstQuery.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirstQuery.Location = new System.Drawing.Point(698, 247);
            this.buttonFirstQuery.Name = "buttonFirstQuery";
            this.buttonFirstQuery.Size = new System.Drawing.Size(102, 62);
            this.buttonFirstQuery.TabIndex = 11;
            this.buttonFirstQuery.Text = "First";
            this.buttonFirstQuery.UseVisualStyleBackColor = true;
            this.buttonFirstQuery.Click += new System.EventHandler(this.buttonFirstQuery_Click);
            // 
            // buttonThirdQuery
            // 
            this.buttonThirdQuery.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThirdQuery.Location = new System.Drawing.Point(698, 406);
            this.buttonThirdQuery.Name = "buttonThirdQuery";
            this.buttonThirdQuery.Size = new System.Drawing.Size(102, 62);
            this.buttonThirdQuery.TabIndex = 14;
            this.buttonThirdQuery.Text = "Third";
            this.buttonThirdQuery.UseVisualStyleBackColor = true;
            this.buttonThirdQuery.Click += new System.EventHandler(this.buttonThirdQuery_Click);
            // 
            // listBoxCollection
            // 
            this.listBoxCollection.FormattingEnabled = true;
            this.listBoxCollection.ItemHeight = 16;
            this.listBoxCollection.Location = new System.Drawing.Point(350, 189);
            this.listBoxCollection.Name = "listBoxCollection";
            this.listBoxCollection.Size = new System.Drawing.Size(291, 164);
            this.listBoxCollection.TabIndex = 17;
            // 
            // listBoxQuery
            // 
            this.listBoxQuery.FormattingEnabled = true;
            this.listBoxQuery.ItemHeight = 16;
            this.listBoxQuery.Location = new System.Drawing.Point(350, 406);
            this.listBoxQuery.Name = "listBoxQuery";
            this.listBoxQuery.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxQuery.Size = new System.Drawing.Size(291, 164);
            this.listBoxQuery.TabIndex = 18;
            // 
            // CollectionBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 594);
            this.Controls.Add(this.listBoxQuery);
            this.Controls.Add(this.listBoxCollection);
            this.Controls.Add(this.buttonThirdQuery);
            this.Controls.Add(this.buttonSecondQuery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonFirstQuery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonDescending);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAscending);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCount);
            this.Name = "CollectionBuilderForm";
            this.Text = "CollectionBuilderForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listBoxQuery;

        private System.Windows.Forms.ListBox listBoxCollection;

        private System.Windows.Forms.Button buttonThirdQuery;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSecondQuery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFirstQuery;

        private System.Windows.Forms.Button buttonGenerate;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAscending;
        private System.Windows.Forms.Button buttonDescending;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}