namespace Laba2
{
    partial class Form1
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
            System.Windows.Forms.RadioButton radioButtonFormatHTML;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.labelPublishingHouse = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonFormatPDF = new System.Windows.Forms.RadioButton();
            this.radioButtonFormatEPUB = new System.Windows.Forms.RadioButton();
            this.radioButtonFormatTXT = new System.Windows.Forms.RadioButton();
            this.radioButtonFormatFB2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUDC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumberOfPages = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxBase = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxAuthors = new System.Windows.Forms.TextBox();
            this.textBoxPublishingHouse = new System.Windows.Forms.TextBox();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.buttonSaveInFile = new System.Windows.Forms.Button();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датеЗагрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельИнструментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSortByYearr = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearchByName = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearBase = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            radioButtonFormatHTML = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonFormatHTML
            // 
            radioButtonFormatHTML.Location = new System.Drawing.Point(26, 525);
            radioButtonFormatHTML.Name = "radioButtonFormatHTML";
            radioButtonFormatHTML.Size = new System.Drawing.Size(115, 22);
            radioButtonFormatHTML.TabIndex = 8;
            radioButtonFormatHTML.TabStop = true;
            radioButtonFormatHTML.Text = "HTML";
            radioButtonFormatHTML.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список Авторов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPublishingHouse
            // 
            this.labelPublishingHouse.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPublishingHouse.Location = new System.Drawing.Point(733, 50);
            this.labelPublishingHouse.Name = "labelPublishingHouse";
            this.labelPublishingHouse.Size = new System.Drawing.Size(268, 29);
            this.labelPublishingHouse.TabIndex = 5;
            this.labelPublishingHouse.Text = "Издательство";
            this.labelPublishingHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(394, 407);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(217, 70);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить в Базу";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioButtonFormatPDF
            // 
            this.radioButtonFormatPDF.Location = new System.Drawing.Point(26, 563);
            this.radioButtonFormatPDF.Name = "radioButtonFormatPDF";
            this.radioButtonFormatPDF.Size = new System.Drawing.Size(115, 22);
            this.radioButtonFormatPDF.TabIndex = 9;
            this.radioButtonFormatPDF.TabStop = true;
            this.radioButtonFormatPDF.Text = "PDF";
            this.radioButtonFormatPDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormatEPUB
            // 
            this.radioButtonFormatEPUB.Location = new System.Drawing.Point(26, 602);
            this.radioButtonFormatEPUB.Name = "radioButtonFormatEPUB";
            this.radioButtonFormatEPUB.Size = new System.Drawing.Size(115, 22);
            this.radioButtonFormatEPUB.TabIndex = 10;
            this.radioButtonFormatEPUB.TabStop = true;
            this.radioButtonFormatEPUB.Text = "EPUB";
            this.radioButtonFormatEPUB.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormatTXT
            // 
            this.radioButtonFormatTXT.Location = new System.Drawing.Point(26, 640);
            this.radioButtonFormatTXT.Name = "radioButtonFormatTXT";
            this.radioButtonFormatTXT.Size = new System.Drawing.Size(115, 22);
            this.radioButtonFormatTXT.TabIndex = 11;
            this.radioButtonFormatTXT.TabStop = true;
            this.radioButtonFormatTXT.Text = "TXT";
            this.radioButtonFormatTXT.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormatFB2
            // 
            this.radioButtonFormatFB2.Location = new System.Drawing.Point(26, 674);
            this.radioButtonFormatFB2.Name = "radioButtonFormatFB2";
            this.radioButtonFormatFB2.Size = new System.Drawing.Size(115, 22);
            this.radioButtonFormatFB2.TabIndex = 12;
            this.radioButtonFormatFB2.TabStop = true;
            this.radioButtonFormatFB2.Text = "FB2";
            this.radioButtonFormatFB2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "File Format\r\n";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(301, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "База";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(174, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите размер файла (мб)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(174, 525);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(215, 22);
            this.textBoxSize.TabIndex = 16;
            this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigitsOnly_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(174, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Введите имя файла\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(174, 578);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(215, 22);
            this.textBoxName.TabIndex = 18;
            // 
            // textBoxUDC
            // 
            this.textBoxUDC.Location = new System.Drawing.Point(174, 638);
            this.textBoxUDC.Name = "textBoxUDC";
            this.textBoxUDC.Size = new System.Drawing.Size(215, 22);
            this.textBoxUDC.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(174, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Введите УДК файла\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNumberOfPages
            // 
            this.textBoxNumberOfPages.Location = new System.Drawing.Point(174, 690);
            this.textBoxNumberOfPages.Name = "textBoxNumberOfPages";
            this.textBoxNumberOfPages.Size = new System.Drawing.Size(215, 22);
            this.textBoxNumberOfPages.TabIndex = 22;
            this.textBoxNumberOfPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigitsOnly_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(174, 668);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Введите кол-во страниц (мб)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(427, 602);
            this.dateTimePickerYear.MaxDate = new System.DateTime(2022, 2, 13, 0, 0, 0, 0);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.ShowUpDown = true;
            this.dateTimePickerYear.Size = new System.Drawing.Size(172, 22);
            this.dateTimePickerYear.TabIndex = 25;
            this.dateTimePickerYear.Value = new System.DateTime(2022, 2, 13, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(427, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "Введите год издания\r\n\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxBase
            // 
            this.listBoxBase.FormattingEnabled = true;
            this.listBoxBase.HorizontalScrollbar = true;
            this.listBoxBase.ItemHeight = 16;
            this.listBoxBase.Location = new System.Drawing.Point(301, 80);
            this.listBoxBase.Name = "listBoxBase";
            this.listBoxBase.Size = new System.Drawing.Size(397, 308);
            this.listBoxBase.TabIndex = 28;
            this.listBoxBase.SelectedIndexChanged += new System.EventHandler(this.listBoxBase_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(716, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 63);
            this.button2.TabIndex = 29;
            this.button2.Text = "Издательство";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(716, 649);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 63);
            this.button3.TabIndex = 30;
            this.button3.Text = "Авторы\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxAuthors
            // 
            this.textBoxAuthors.Location = new System.Drawing.Point(0, 81);
            this.textBoxAuthors.Multiline = true;
            this.textBoxAuthors.Name = "textBoxAuthors";
            this.textBoxAuthors.Size = new System.Drawing.Size(281, 308);
            this.textBoxAuthors.TabIndex = 31;
            // 
            // textBoxPublishingHouse
            // 
            this.textBoxPublishingHouse.Location = new System.Drawing.Point(716, 80);
            this.textBoxPublishingHouse.Multiline = true;
            this.textBoxPublishingHouse.Name = "textBoxPublishingHouse";
            this.textBoxPublishingHouse.Size = new System.Drawing.Size(281, 308);
            this.textBoxPublishingHouse.TabIndex = 32;
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadFromFile.Location = new System.Drawing.Point(156, 407);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(217, 70);
            this.buttonLoadFromFile.TabIndex = 33;
            this.buttonLoadFromFile.Text = "Загрузить из файла";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // buttonSaveInFile
            // 
            this.buttonSaveInFile.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveInFile.Location = new System.Drawing.Point(634, 407);
            this.buttonSaveInFile.Name = "buttonSaveInFile";
            this.buttonSaveInFile.Size = new System.Drawing.Size(217, 70);
            this.buttonSaveInFile.TabIndex = 34;
            this.buttonSaveInFile.Text = "Сохранить в файл";
            this.buttonSaveInFile.UseVisualStyleBackColor = true;
            this.buttonSaveInFile.Click += new System.EventHandler(this.buttonSaveInFile_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.поНазваниюToolStripMenuItem, this.датеЗагрузкиToolStripMenuItem });
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.поНазваниюToolStripMenuItem.Text = "По названию";
            this.поНазваниюToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // датеЗагрузкиToolStripMenuItem
            // 
            this.датеЗагрузкиToolStripMenuItem.Name = "датеЗагрузкиToolStripMenuItem";
            this.датеЗагрузкиToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.датеЗагрузкиToolStripMenuItem.Text = "Дате загрузки";
            this.датеЗагрузкиToolStripMenuItem.Click += new System.EventHandler(this.датеЗагрузкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // панельИнструментовToolStripMenuItem
            // 
            this.панельИнструментовToolStripMenuItem.Name = "панельИнструментовToolStripMenuItem";
            this.панельИнструментовToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.панельИнструментовToolStripMenuItem.Text = "Панель инструментов";
            this.панельИнструментовToolStripMenuItem.Click += new System.EventHandler(this.панельИнструментовToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.поискToolStripMenuItem, this.сортировкаToolStripMenuItem, this.оПрограммеToolStripMenuItem, this.панельИнструментовToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 28);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "toolStripSearch\r\n";
            this.toolStripButton1.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // toolStripSortByYearr
            // 
            this.toolStripSortByYearr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSortByYearr.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSortByYearr.Image")));
            this.toolStripSortByYearr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSortByYearr.Name = "toolStripSortByYearr";
            this.toolStripSortByYearr.Size = new System.Drawing.Size(23, 22);
            this.toolStripSortByYearr.Text = "toolStripButton2";
            this.toolStripSortByYearr.Click += new System.EventHandler(this.датеЗагрузкиToolStripMenuItem_Click);
            // 
            // toolStripButtonSearchByName
            // 
            this.toolStripButtonSearchByName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearchByName.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearchByName.Image")));
            this.toolStripButtonSearchByName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearchByName.Name = "toolStripButtonSearchByName";
            this.toolStripButtonSearchByName.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSearchByName.Text = "toolStripButton3";
            this.toolStripButtonSearchByName.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // toolStripButtonClearBase
            // 
            this.toolStripButtonClearBase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClearBase.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearBase.Image")));
            this.toolStripButtonClearBase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearBase.Name = "toolStripButtonClearBase";
            this.toolStripButtonClearBase.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClearBase.Text = "toolStripButton2";
            this.toolStripButtonClearBase.Click += new System.EventHandler(this.toolStripButtonClearBase_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripButton1, this.toolStripSortByYearr, this.toolStripButtonSearchByName, this.toolStripButtonClearBase });
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(999, 25);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripStatusLabel1 });
            this.statusStrip1.Location = new System.Drawing.Point(0, 843);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(999, 25);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 868);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonSaveInFile);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.textBoxPublishingHouse);
            this.Controls.Add(this.textBoxAuthors);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxBase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.textBoxNumberOfPages);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxUDC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonFormatFB2);
            this.Controls.Add(this.radioButtonFormatTXT);
            this.Controls.Add(this.radioButtonFormatEPUB);
            this.Controls.Add(this.radioButtonFormatPDF);
            this.Controls.Add(radioButtonFormatHTML);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPublishingHouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.ToolStripButton toolStripButtonClearBase;

        private System.Windows.Forms.ToolStripButton toolStripSortByYearr;

        private System.Windows.Forms.ToolStripButton toolStripButtonSearchByName;

        private System.Windows.Forms.ToolStripMenuItem панельИнструментовToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton toolStripButton3;

        private System.Windows.Forms.ToolStripButton toolStripButton2;

        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.ToolStripMenuItem датеЗагрузкиToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Button buttonSaveInFile;

        private System.Windows.Forms.TextBox textBoxAuthors;

        private System.Windows.Forms.TextBox textBoxPublishingHouse;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.ListBox listBoxBase;

        private System.Windows.Forms.DateTimePicker dateTimePickerYear;

        private System.Windows.Forms.TextBox textBoxNumberOfPages;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox textBoxUDC;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox textBoxName;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSize;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.RadioButton radioButtonFormatFB2;

        private System.Windows.Forms.RadioButton radioButtonFormatPDF;
        private System.Windows.Forms.RadioButton radioButtonFormatEPUB;
        private System.Windows.Forms.RadioButton radioButtonFormatTXT;

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.Label labelPublishingHouse;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}