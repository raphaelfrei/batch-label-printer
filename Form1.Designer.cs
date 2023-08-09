namespace PRT_ETQ_QR_CODE {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbPrint = new System.Windows.Forms.ProgressBar();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblTXTFile = new System.Windows.Forms.Label();
            this.lbDTFile = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.tbDTFile = new System.Windows.Forms.TextBox();
            this.lbBG = new System.Windows.Forms.Label();
            this.lbRowsF = new System.Windows.Forms.Label();
            this.dgvText = new System.Windows.Forms.DataGridView();
            this.RowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextRPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPrintOPT = new System.Windows.Forms.Label();
            this.cbFirstLine = new System.Windows.Forms.CheckBox();
            this.cbIgnoreEmpty = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbPrinters = new System.Windows.Forms.ComboBox();
            this.lbPRT = new System.Windows.Forms.Label();
            this.lbLines = new System.Windows.Forms.Label();
            this.tbLineTot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvText)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPrint
            // 
            this.pbPrint.Location = new System.Drawing.Point(12, 627);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(776, 23);
            this.pbPrint.Step = 1;
            this.pbPrint.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(776, 66);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Print TXT File from Data File";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(12, 124);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(695, 23);
            this.tbFile.TabIndex = 2;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(713, 124);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "&Open File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblTXTFile
            // 
            this.lblTXTFile.AutoSize = true;
            this.lblTXTFile.Location = new System.Drawing.Point(12, 106);
            this.lblTXTFile.Name = "lblTXTFile";
            this.lblTXTFile.Size = new System.Drawing.Size(47, 15);
            this.lblTXTFile.TabIndex = 4;
            this.lblTXTFile.Text = "TXT File";
            // 
            // lbDTFile
            // 
            this.lbDTFile.AutoSize = true;
            this.lbDTFile.Location = new System.Drawing.Point(12, 150);
            this.lbDTFile.Name = "lbDTFile";
            this.lbDTFile.Size = new System.Drawing.Size(56, 15);
            this.lbDTFile.TabIndex = 7;
            this.lbDTFile.Text = "DATA File";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(713, 168);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 23);
            this.btnData.TabIndex = 6;
            this.btnData.Text = "Open &File";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // tbDTFile
            // 
            this.tbDTFile.Location = new System.Drawing.Point(12, 168);
            this.tbDTFile.Name = "tbDTFile";
            this.tbDTFile.ReadOnly = true;
            this.tbDTFile.Size = new System.Drawing.Size(695, 23);
            this.tbDTFile.TabIndex = 5;
            // 
            // lbBG
            // 
            this.lbBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBG.Location = new System.Drawing.Point(12, 194);
            this.lbBG.Name = "lbBG";
            this.lbBG.Size = new System.Drawing.Size(776, 395);
            this.lbBG.TabIndex = 8;
            // 
            // lbRowsF
            // 
            this.lbRowsF.AutoSize = true;
            this.lbRowsF.Location = new System.Drawing.Point(19, 201);
            this.lbRowsF.Name = "lbRowsF";
            this.lbRowsF.Size = new System.Drawing.Size(80, 15);
            this.lbRowsF.TabIndex = 9;
            this.lbRowsF.Text = "ROWS Found:";
            // 
            // dgvText
            // 
            this.dgvText.AllowUserToAddRows = false;
            this.dgvText.AllowUserToDeleteRows = false;
            this.dgvText.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvText.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowID,
            this.TextEx,
            this.TextRPL});
            this.dgvText.Location = new System.Drawing.Point(22, 222);
            this.dgvText.MultiSelect = false;
            this.dgvText.Name = "dgvText";
            this.dgvText.RowTemplate.Height = 25;
            this.dgvText.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvText.Size = new System.Drawing.Size(755, 302);
            this.dgvText.TabIndex = 10;
            // 
            // RowID
            // 
            this.RowID.HeaderText = "Row ID";
            this.RowID.Name = "RowID";
            this.RowID.ReadOnly = true;
            // 
            // TextEx
            // 
            this.TextEx.HeaderText = "Text Example";
            this.TextEx.Name = "TextEx";
            this.TextEx.ReadOnly = true;
            // 
            // TextRPL
            // 
            this.TextRPL.HeaderText = "Text To Replace";
            this.TextRPL.Name = "TextRPL";
            // 
            // lbPrintOPT
            // 
            this.lbPrintOPT.AutoSize = true;
            this.lbPrintOPT.Location = new System.Drawing.Point(19, 527);
            this.lbPrintOPT.Name = "lbPrintOPT";
            this.lbPrintOPT.Size = new System.Drawing.Size(87, 15);
            this.lbPrintOPT.TabIndex = 11;
            this.lbPrintOPT.Text = "PRINT Options:";
            // 
            // cbFirstLine
            // 
            this.cbFirstLine.AutoSize = true;
            this.cbFirstLine.Location = new System.Drawing.Point(23, 545);
            this.cbFirstLine.Name = "cbFirstLine";
            this.cbFirstLine.Size = new System.Drawing.Size(110, 19);
            this.cbFirstLine.TabIndex = 12;
            this.cbFirstLine.Text = "Ignore First Line";
            this.cbFirstLine.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreEmpty
            // 
            this.cbIgnoreEmpty.AutoSize = true;
            this.cbIgnoreEmpty.Location = new System.Drawing.Point(23, 566);
            this.cbIgnoreEmpty.Name = "cbIgnoreEmpty";
            this.cbIgnoreEmpty.Size = new System.Drawing.Size(169, 19);
            this.cbIgnoreEmpty.TabIndex = 13;
            this.cbIgnoreEmpty.Text = "Ignore If Any Data Is Empty";
            this.cbIgnoreEmpty.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 598);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(776, 23);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "&Print All";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbPrinters
            // 
            this.cbPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinters.FormattingEnabled = true;
            this.cbPrinters.Location = new System.Drawing.Point(625, 545);
            this.cbPrinters.Name = "cbPrinters";
            this.cbPrinters.Size = new System.Drawing.Size(152, 23);
            this.cbPrinters.TabIndex = 15;
            // 
            // lbPRT
            // 
            this.lbPRT.AutoSize = true;
            this.lbPRT.Location = new System.Drawing.Point(625, 527);
            this.lbPRT.Name = "lbPRT";
            this.lbPRT.Size = new System.Drawing.Size(89, 15);
            this.lbPRT.TabIndex = 16;
            this.lbPRT.Text = "Select PRINTER:";
            // 
            // lbLines
            // 
            this.lbLines.AutoSize = true;
            this.lbLines.Location = new System.Drawing.Point(643, 201);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(81, 15);
            this.lbLines.TabIndex = 17;
            this.lbLines.Text = "LINES In Total:";
            // 
            // tbLineTot
            // 
            this.tbLineTot.Location = new System.Drawing.Point(728, 197);
            this.tbLineTot.Name = "tbLineTot";
            this.tbLineTot.ReadOnly = true;
            this.tbLineTot.Size = new System.Drawing.Size(49, 23);
            this.tbLineTot.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "PRT-ETQ_QR-CODE.exe [v1.00]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLineTot);
            this.Controls.Add(this.lbLines);
            this.Controls.Add(this.lbPRT);
            this.Controls.Add(this.cbPrinters);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbIgnoreEmpty);
            this.Controls.Add(this.cbFirstLine);
            this.Controls.Add(this.lbPrintOPT);
            this.Controls.Add(this.dgvText);
            this.Controls.Add(this.lbRowsF);
            this.Controls.Add(this.lbBG);
            this.Controls.Add(this.lbDTFile);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.tbDTFile);
            this.Controls.Add(this.lblTXTFile);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Print TXT File from Data File - © Raphael Frei 2023";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar pbPrint;
        private Label lbTitle;
        private TextBox tbFile;
        private Button btnFile;
        private Label lblTXTFile;
        private Label lbDTFile;
        private Button btnData;
        private TextBox tbDTFile;
        private Label lbBG;
        private Label lbRowsF;
        private DataGridView dgvText;
        private Label lbPrintOPT;
        private CheckBox cbFirstLine;
        private CheckBox cbIgnoreEmpty;
        private Button btnPrint;
        private ComboBox cbPrinters;
        private Label lbPRT;
        private Label lbLines;
        private TextBox tbLineTot;
        private DataGridViewTextBoxColumn RowID;
        private DataGridViewTextBoxColumn TextEx;
        private DataGridViewTextBoxColumn TextRPL;
        private Label label1;
    }
}