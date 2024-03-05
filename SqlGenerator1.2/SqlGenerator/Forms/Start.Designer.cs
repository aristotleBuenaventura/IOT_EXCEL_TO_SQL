namespace SqlGenerator.Forms
{
	partial class Start
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

		public Start()
		{
			InitializeComponent();
		}


		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtResult = new ICSharpCode.TextEditor.TextEditorControl();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.cboSheetName = new System.Windows.Forms.ComboBox();
            this.lblSheetName = new System.Windows.Forms.Label();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnParseColumns = new System.Windows.Forms.Button();
            this.lnkAdd = new System.Windows.Forms.LinkLabel();
            this.lnkRemove = new System.Windows.Forms.LinkLabel();
            this.lnkEdit = new System.Windows.Forms.LinkLabel();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.optExcel = new System.Windows.Forms.RadioButton();
            this.optText = new System.Windows.Forms.RadioButton();
            this.cboDelimiter = new System.Windows.Forms.ComboBox();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.chkFirstLineHoldsColumnNames = new System.Windows.Forms.CheckBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.cboTableNameTarget = new System.Windows.Forms.ComboBox();
            this.cboConnectionTarget = new System.Windows.Forms.ComboBox();
            this.lblTableNameTarget = new System.Windows.Forms.Label();
            this.lblConnectionTarget = new System.Windows.Forms.Label();
            this.btnGenerateInsert = new System.Windows.Forms.Button();
            this.flowColumns = new System.Windows.Forms.FlowLayoutPanel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.optSQL = new System.Windows.Forms.RadioButton();
            this.cboTableNameSource = new System.Windows.Forms.ComboBox();
            this.cboConnectionSource = new System.Windows.Forms.ComboBox();
            this.lblTableNameSource = new System.Windows.Forms.Label();
            this.lblConnectionSource = new System.Windows.Forms.Label();
            this.grpColumnMap = new System.Windows.Forms.GroupBox();
            this.chkFullDatabaseCopy = new System.Windows.Forms.CheckBox();
            this.bindingConnectionSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingConnectionTarget = new System.Windows.Forms.BindingSource(this.components);
            this.grpOutput.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpColumnMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingConnectionSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingConnectionTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtFilePath.Location = new System.Drawing.Point(80, 57);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(169, 22);
            this.txtFilePath.TabIndex = 3;
            this.txtFilePath.Text = "C:\\Temp\\MyExcelFile.xlsx";
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtResult.EnableFolding = false;
            this.txtResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtResult.IsReadOnly = false;
            this.txtResult.Location = new System.Drawing.Point(16, 550);
            this.txtResult.Name = "txtResult";
            this.txtResult.ShowLineNumbers = false;
            this.txtResult.Size = new System.Drawing.Size(1257, 210);
            this.txtResult.TabIndex = 10;
            this.txtResult.VRulerRow = 0;
            this.txtResult.Load += new System.EventHandler(this.txtResult_Load);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(37, 60);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(32, 16);
            this.lblFilePath.TabIndex = 7;
            this.lblFilePath.Text = "File:";
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSheetName
            // 
            this.cboSheetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheetName.FormattingEnabled = true;
            this.cboSheetName.Location = new System.Drawing.Point(80, 89);
            this.cboSheetName.Margin = new System.Windows.Forms.Padding(4);
            this.cboSheetName.Name = "cboSheetName";
            this.cboSheetName.Size = new System.Drawing.Size(296, 24);
            this.cboSheetName.TabIndex = 5;
            // 
            // lblSheetName
            // 
            this.lblSheetName.AutoSize = true;
            this.lblSheetName.Location = new System.Drawing.Point(21, 90);
            this.lblSheetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSheetName.Name = "lblSheetName";
            this.lblSheetName.Size = new System.Drawing.Size(45, 16);
            this.lblSheetName.TabIndex = 8;
            this.lblSheetName.Text = "Sheet:";
            this.lblSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(257, 53);
            this.btnSearchFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(104, 28);
            this.btnSearchFile.TabIndex = 4;
            this.btnSearchFile.Text = "Select a file";
            this.myToolTip.SetToolTip(this.btnSearchFile, "Select file");
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // btnCopy
            // 
            this.btnEnter.Location = new System.Drawing.Point(16, 782);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnCopy";
            this.btnEnter.Size = new System.Drawing.Size(164, 28);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "Enter to the Database";
            this.myToolTip.SetToolTip(this.btnEnter, "Copy result to Windows clipboard");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnterToTheDatabase);
            // 
            // btnParseColumns
            // 
            this.btnParseColumns.Location = new System.Drawing.Point(1187, 17);
            this.btnParseColumns.Margin = new System.Windows.Forms.Padding(4);
            this.btnParseColumns.Name = "btnParseColumns";
            this.btnParseColumns.Size = new System.Drawing.Size(64, 28);
            this.btnParseColumns.TabIndex = 11;
            this.btnParseColumns.Text = "Map";
            this.myToolTip.SetToolTip(this.btnParseColumns, "Generate SQL from specified input");
            this.btnParseColumns.UseVisualStyleBackColor = true;
            this.btnParseColumns.Click += new System.EventHandler(this.btnParseColumns_Click);
            // 
            // lnkAdd
            // 
            this.lnkAdd.AutoSize = true;
            this.lnkAdd.Location = new System.Drawing.Point(12, 27);
            this.lnkAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkAdd.Name = "lnkAdd";
            this.lnkAdd.Size = new System.Drawing.Size(32, 16);
            this.lnkAdd.TabIndex = 44;
            this.lnkAdd.TabStop = true;
            this.lnkAdd.Text = "Add";
            this.myToolTip.SetToolTip(this.lnkAdd, "Add new connection");
            this.lnkAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdd_LinkClicked);
            // 
            // lnkRemove
            // 
            this.lnkRemove.AutoSize = true;
            this.lnkRemove.Location = new System.Drawing.Point(96, 27);
            this.lnkRemove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRemove.Name = "lnkRemove";
            this.lnkRemove.Size = new System.Drawing.Size(59, 16);
            this.lnkRemove.TabIndex = 45;
            this.lnkRemove.TabStop = true;
            this.lnkRemove.Text = "Remove";
            this.myToolTip.SetToolTip(this.lnkRemove, "Remove current connection");
            this.lnkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRemove_LinkClicked);
            // 
            // lnkEdit
            // 
            this.lnkEdit.AutoSize = true;
            this.lnkEdit.Location = new System.Drawing.Point(55, 27);
            this.lnkEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkEdit.Name = "lnkEdit";
            this.lnkEdit.Size = new System.Drawing.Size(30, 16);
            this.lnkEdit.TabIndex = 46;
            this.lnkEdit.TabStop = true;
            this.lnkEdit.Text = "Edit";
            this.myToolTip.SetToolTip(this.lnkEdit, "dit current connection");
            this.lnkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEdit_LinkClicked);
            // 
            // lblResultCount
            // 
            this.lblResultCount.ForeColor = System.Drawing.Color.Navy;
            this.lblResultCount.Location = new System.Drawing.Point(188, 784);
            this.lblResultCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(88, 26);
            this.lblResultCount.TabIndex = 15;
            this.lblResultCount.Text = "(No result)";
            this.lblResultCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optExcel
            // 
            this.optExcel.AutoSize = true;
            this.optExcel.Checked = true;
            this.optExcel.Location = new System.Drawing.Point(25, 23);
            this.optExcel.Margin = new System.Windows.Forms.Padding(4);
            this.optExcel.Name = "optExcel";
            this.optExcel.Size = new System.Drawing.Size(61, 20);
            this.optExcel.TabIndex = 0;
            this.optExcel.TabStop = true;
            this.optExcel.Text = "Excel";
            this.optExcel.UseVisualStyleBackColor = true;
            this.optExcel.CheckedChanged += new System.EventHandler(this.SourceType_CheckedChanged);
            // 
            // optText
            // 
            this.optText.AutoSize = true;
            this.optText.Location = new System.Drawing.Point(557, 23);
            this.optText.Margin = new System.Windows.Forms.Padding(4);
            this.optText.Name = "optText";
            this.optText.Size = new System.Drawing.Size(54, 20);
            this.optText.TabIndex = 1;
            this.optText.Text = "Text";
            this.optText.UseVisualStyleBackColor = true;
            this.optText.Visible = false;
            this.optText.CheckedChanged += new System.EventHandler(this.SourceType_CheckedChanged);
            // 
            // cboDelimiter
            // 
            this.cboDelimiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDelimiter.FormattingEnabled = true;
            this.cboDelimiter.Items.AddRange(new object[] {
            "Semicolon",
            "Comma",
            "Tab"});
            this.cboDelimiter.Location = new System.Drawing.Point(170, 19);
            this.cboDelimiter.Margin = new System.Windows.Forms.Padding(4);
            this.cboDelimiter.Name = "cboDelimiter";
            this.cboDelimiter.Size = new System.Drawing.Size(296, 24);
            this.cboDelimiter.TabIndex = 5;
            this.cboDelimiter.Visible = false;
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.Location = new System.Drawing.Point(95, 24);
            this.lblDelimiter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(63, 16);
            this.lblDelimiter.TabIndex = 20;
            this.lblDelimiter.Text = "Delimiter:";
            this.lblDelimiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDelimiter.Visible = false;
            // 
            // chkFirstLineHoldsColumnNames
            // 
            this.chkFirstLineHoldsColumnNames.AutoSize = true;
            this.chkFirstLineHoldsColumnNames.Checked = true;
            this.chkFirstLineHoldsColumnNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFirstLineHoldsColumnNames.Location = new System.Drawing.Point(408, 57);
            this.chkFirstLineHoldsColumnNames.Margin = new System.Windows.Forms.Padding(4);
            this.chkFirstLineHoldsColumnNames.Name = "chkFirstLineHoldsColumnNames";
            this.chkFirstLineHoldsColumnNames.Size = new System.Drawing.Size(240, 20);
            this.chkFirstLineHoldsColumnNames.TabIndex = 2;
            this.chkFirstLineHoldsColumnNames.Text = "Skip first line holding column names";
            this.chkFirstLineHoldsColumnNames.UseVisualStyleBackColor = true;
            this.chkFirstLineHoldsColumnNames.CheckedChanged += new System.EventHandler(this.chkSkipFirstLine_CheckedChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.ForeColor = System.Drawing.Color.Navy;
            this.lblVersion.Location = new System.Drawing.Point(868, 795);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(409, 26);
            this.lblVersion.TabIndex = 22;
            this.lblVersion.Text = "IOT";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lnkEdit);
            this.grpOutput.Controls.Add(this.cboTableNameTarget);
            this.grpOutput.Controls.Add(this.lnkRemove);
            this.grpOutput.Controls.Add(this.lnkAdd);
            this.grpOutput.Controls.Add(this.cboConnectionTarget);
            this.grpOutput.Controls.Add(this.btnParseColumns);
            this.grpOutput.Controls.Add(this.lblTableNameTarget);
            this.grpOutput.Controls.Add(this.lblConnectionTarget);
            this.grpOutput.Location = new System.Drawing.Point(16, 144);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grpOutput.Size = new System.Drawing.Size(1261, 62);
            this.grpOutput.TabIndex = 28;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Microsoft SQL Server";
            // 
            // cboTableNameTarget
            // 
            this.cboTableNameTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTableNameTarget.DropDownWidth = 223;
            this.cboTableNameTarget.FormattingEnabled = true;
            this.cboTableNameTarget.Location = new System.Drawing.Point(868, 20);
            this.cboTableNameTarget.Margin = new System.Windows.Forms.Padding(4);
            this.cboTableNameTarget.MaxDropDownItems = 50;
            this.cboTableNameTarget.Name = "cboTableNameTarget";
            this.cboTableNameTarget.Size = new System.Drawing.Size(296, 24);
            this.cboTableNameTarget.TabIndex = 21;
            // 
            // cboConnectionTarget
            // 
            this.cboConnectionTarget.DisplayMember = "DisplayName";
            this.cboConnectionTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConnectionTarget.FormattingEnabled = true;
            this.cboConnectionTarget.Items.AddRange(new object[] {
            "Semicolon",
            "Comma",
            "Tab"});
            this.cboConnectionTarget.Location = new System.Drawing.Point(288, 23);
            this.cboConnectionTarget.Margin = new System.Windows.Forms.Padding(4);
            this.cboConnectionTarget.Name = "cboConnectionTarget";
            this.cboConnectionTarget.Size = new System.Drawing.Size(443, 24);
            this.cboConnectionTarget.TabIndex = 21;
            this.cboConnectionTarget.ValueMember = "ConnectionString";
            this.cboConnectionTarget.SelectedIndexChanged += new System.EventHandler(this.cboConnectionTarget_SelectedIndexChanged);
            // 
            // lblTableNameTarget
            // 
            this.lblTableNameTarget.AutoSize = true;
            this.lblTableNameTarget.Location = new System.Drawing.Point(773, 23);
            this.lblTableNameTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableNameTarget.Name = "lblTableNameTarget";
            this.lblTableNameTarget.Size = new System.Drawing.Size(83, 16);
            this.lblTableNameTarget.TabIndex = 23;
            this.lblTableNameTarget.Text = "TableName:";
            this.lblTableNameTarget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConnectionTarget
            // 
            this.lblConnectionTarget.AutoSize = true;
            this.lblConnectionTarget.Location = new System.Drawing.Point(167, 27);
            this.lblConnectionTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionTarget.Name = "lblConnectionTarget";
            this.lblConnectionTarget.Size = new System.Drawing.Size(111, 16);
            this.lblConnectionTarget.TabIndex = 21;
            this.lblConnectionTarget.Text = "ConnectionString:";
            this.lblConnectionTarget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGenerateInsert
            // 
            this.btnGenerateInsert.Location = new System.Drawing.Point(16, 515);
            this.btnGenerateInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateInsert.Name = "btnGenerateInsert";
            this.btnGenerateInsert.Size = new System.Drawing.Size(100, 28);
            this.btnGenerateInsert.TabIndex = 9;
            this.btnGenerateInsert.Text = "Generate SQL";
            this.btnGenerateInsert.UseVisualStyleBackColor = true;
            this.btnGenerateInsert.Click += new System.EventHandler(this.btnGenerateInsert_Click);
            // 
            // flowColumns
            // 
            this.flowColumns.AutoScroll = true;
            this.flowColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowColumns.Location = new System.Drawing.Point(4, 20);
            this.flowColumns.Margin = new System.Windows.Forms.Padding(4);
            this.flowColumns.Name = "flowColumns";
            this.flowColumns.Size = new System.Drawing.Size(1253, 269);
            this.flowColumns.TabIndex = 30;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.chkFullDatabaseCopy);
            this.grpInput.Controls.Add(this.lblFilter);
            this.grpInput.Controls.Add(this.txtFilter);
            this.grpInput.Controls.Add(this.optSQL);
            this.grpInput.Controls.Add(this.cboTableNameSource);
            this.grpInput.Controls.Add(this.optExcel);
            this.grpInput.Controls.Add(this.cboConnectionSource);
            this.grpInput.Controls.Add(this.lblTableNameSource);
            this.grpInput.Controls.Add(this.optText);
            this.grpInput.Controls.Add(this.lblConnectionSource);
            this.grpInput.Controls.Add(this.lblFilePath);
            this.grpInput.Controls.Add(this.txtFilePath);
            this.grpInput.Controls.Add(this.lblDelimiter);
            this.grpInput.Controls.Add(this.chkFirstLineHoldsColumnNames);
            this.grpInput.Controls.Add(this.lblSheetName);
            this.grpInput.Controls.Add(this.btnSearchFile);
            this.grpInput.Controls.Add(this.cboDelimiter);
            this.grpInput.Controls.Add(this.cboSheetName);
            this.grpInput.Location = new System.Drawing.Point(16, 15);
            this.grpInput.Margin = new System.Windows.Forms.Padding(4);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(4);
            this.grpInput.Size = new System.Drawing.Size(1261, 122);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Data";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(617, 25);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 16);
            this.lblFilter.TabIndex = 30;
            this.lblFilter.Text = "Filter:";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(665, 21);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(10, 22);
            this.txtFilter.TabIndex = 29;
            // 
            // optSQL
            // 
            this.optSQL.AutoSize = true;
            this.optSQL.Location = new System.Drawing.Point(487, 23);
            this.optSQL.Margin = new System.Windows.Forms.Padding(4);
            this.optSQL.Name = "optSQL";
            this.optSQL.Size = new System.Drawing.Size(54, 20);
            this.optSQL.TabIndex = 28;
            this.optSQL.Text = "SQL";
            this.optSQL.UseVisualStyleBackColor = true;
            this.optSQL.Visible = false;
            this.optSQL.CheckedChanged += new System.EventHandler(this.SourceType_CheckedChanged);
            // 
            // cboTableNameSource
            // 
            this.cboTableNameSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTableNameSource.DropDownWidth = 223;
            this.cboTableNameSource.FormattingEnabled = true;
            this.cboTableNameSource.Location = new System.Drawing.Point(794, 19);
            this.cboTableNameSource.Margin = new System.Windows.Forms.Padding(4);
            this.cboTableNameSource.MaxDropDownItems = 50;
            this.cboTableNameSource.Name = "cboTableNameSource";
            this.cboTableNameSource.Size = new System.Drawing.Size(296, 24);
            this.cboTableNameSource.TabIndex = 24;
            // 
            // cboConnectionSource
            // 
            this.cboConnectionSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConnectionSource.FormattingEnabled = true;
            this.cboConnectionSource.Items.AddRange(new object[] {
            "Semicolon",
            "Comma",
            "Tab"});
            this.cboConnectionSource.Location = new System.Drawing.Point(535, 89);
            this.cboConnectionSource.Margin = new System.Windows.Forms.Padding(4);
            this.cboConnectionSource.Name = "cboConnectionSource";
            this.cboConnectionSource.Size = new System.Drawing.Size(443, 24);
            this.cboConnectionSource.TabIndex = 25;
            this.cboConnectionSource.SelectedIndexChanged += new System.EventHandler(this.cboConnectionSource_SelectedIndexChanged);
            // 
            // lblTableNameSource
            // 
            this.lblTableNameSource.AutoSize = true;
            this.lblTableNameSource.Location = new System.Drawing.Point(699, 23);
            this.lblTableNameSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableNameSource.Name = "lblTableNameSource";
            this.lblTableNameSource.Size = new System.Drawing.Size(83, 16);
            this.lblTableNameSource.TabIndex = 27;
            this.lblTableNameSource.Text = "TableName:";
            this.lblTableNameSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConnectionSource
            // 
            this.lblConnectionSource.AutoSize = true;
            this.lblConnectionSource.Location = new System.Drawing.Point(405, 92);
            this.lblConnectionSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionSource.Name = "lblConnectionSource";
            this.lblConnectionSource.Size = new System.Drawing.Size(111, 16);
            this.lblConnectionSource.TabIndex = 26;
            this.lblConnectionSource.Text = "ConnectionString:";
            this.lblConnectionSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpColumnMap
            // 
            this.grpColumnMap.Controls.Add(this.flowColumns);
            this.grpColumnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpColumnMap.Location = new System.Drawing.Point(16, 213);
            this.grpColumnMap.Margin = new System.Windows.Forms.Padding(4);
            this.grpColumnMap.Name = "grpColumnMap";
            this.grpColumnMap.Padding = new System.Windows.Forms.Padding(4);
            this.grpColumnMap.Size = new System.Drawing.Size(1261, 293);
            this.grpColumnMap.TabIndex = 0;
            this.grpColumnMap.TabStop = false;
            this.grpColumnMap.Text = "Mapping of Columns";
            // 
            // chkFullDatabaseCopy
            // 
            this.chkFullDatabaseCopy.AutoSize = true;
            this.chkFullDatabaseCopy.Location = new System.Drawing.Point(702, 51);
            this.chkFullDatabaseCopy.Margin = new System.Windows.Forms.Padding(4);
            this.chkFullDatabaseCopy.Name = "chkFullDatabaseCopy";
            this.chkFullDatabaseCopy.Size = new System.Drawing.Size(144, 20);
            this.chkFullDatabaseCopy.TabIndex = 31;
            this.chkFullDatabaseCopy.Text = "Full database copy";
            this.chkFullDatabaseCopy.UseVisualStyleBackColor = true;
            this.chkFullDatabaseCopy.CheckedChanged += new System.EventHandler(this.chkFullDatabaseCopy_CheckedChanged);
            // 
            // bindingConnectionSource
            // 
            this.bindingConnectionSource.DataSource = typeof(SqlGenerator.Entities.ConnectionItem);
            // 
            // bindingConnectionTarget
            // 
            this.bindingConnectionTarget.DataSource = typeof(SqlGenerator.Entities.ConnectionItem);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 830);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpColumnMap);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.btnGenerateInsert);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblResultCount);
            this.Controls.Add(this.btnEnter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1110, 784);
            this.Name = "Start";
            this.Text = "IOT";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpColumnMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingConnectionSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingConnectionTarget)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtFilePath;
		private System.Windows.Forms.Label lblFilePath;
		private System.Windows.Forms.ComboBox cboSheetName;
		private System.Windows.Forms.Label lblSheetName;
		private System.Windows.Forms.ToolTip myToolTip;
		private System.Windows.Forms.Button btnSearchFile;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Label lblResultCount;
		private System.Windows.Forms.RadioButton optExcel;
		private System.Windows.Forms.RadioButton optText;
		private System.Windows.Forms.ComboBox cboDelimiter;
		private System.Windows.Forms.Label lblDelimiter;
		private System.Windows.Forms.CheckBox chkFirstLineHoldsColumnNames;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.GroupBox grpOutput;
		private System.Windows.Forms.Label lblTableNameTarget;
		private System.Windows.Forms.Label lblConnectionTarget;
		private System.Windows.Forms.Button btnParseColumns;
		private System.Windows.Forms.Button btnGenerateInsert;
		private System.Windows.Forms.FlowLayoutPanel flowColumns;
		private System.Windows.Forms.GroupBox grpInput;
		private System.Windows.Forms.GroupBox grpColumnMap;
		private System.Windows.Forms.ComboBox cboTableNameTarget;
		private System.Windows.Forms.ComboBox cboConnectionTarget;
        private System.Windows.Forms.RadioButton optSQL;
        private System.Windows.Forms.ComboBox cboTableNameSource;
        private System.Windows.Forms.ComboBox cboConnectionSource;
        private System.Windows.Forms.Label lblTableNameSource;
        private System.Windows.Forms.Label lblConnectionSource;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
		private System.Windows.Forms.BindingSource bindingConnectionSource;
		private System.Windows.Forms.LinkLabel lnkEdit;
		private System.Windows.Forms.LinkLabel lnkRemove;
		private System.Windows.Forms.LinkLabel lnkAdd;
		private System.Windows.Forms.BindingSource bindingConnectionTarget;
        private System.Windows.Forms.CheckBox chkFullDatabaseCopy;
        private ICSharpCode.TextEditor.TextEditorControl txtResult;
    }
}

