namespace SE_Master.UserControls
{
    partial class UC_ZIP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ZipTreeView = new System.Windows.Forms.TreeView();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.FileLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsEdited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBoxSelectZip = new System.Windows.Forms.TextBox();
            this.btnZipOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ZIPProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btnZipHelp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmZipChanges = new System.Windows.Forms.Button();
            this.btnExtractZip = new System.Windows.Forms.Button();
            this.btnCreateZip = new System.Windows.Forms.Button();
            this.btnCloseZip = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "ZIPTitle";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Azonix", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(720, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "SE | ZIP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.TxtBoxSelectZip);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 557);
            this.panel1.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.guna2Panel1.Controls.Add(this.ZipTreeView);
            this.guna2Panel1.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel1.Location = new System.Drawing.Point(10, 51);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(664, 496);
            this.guna2Panel1.TabIndex = 4;
            // 
            // ZipTreeView
            // 
            this.ZipTreeView.AccessibleName = "ZipTreeView";
            this.ZipTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ZipTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ZipTreeView.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZipTreeView.ForeColor = System.Drawing.Color.White;
            this.ZipTreeView.Location = new System.Drawing.Point(0, 18);
            this.ZipTreeView.Name = "ZipTreeView";
            this.ZipTreeView.PathSeparator = "/";
            this.ZipTreeView.Size = new System.Drawing.Size(532, 478);
            this.ZipTreeView.TabIndex = 5;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AccessibleName = "DataGridZip";
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.ColumnHeadersHeight = 17;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileLocation,
            this.Size1,
            this.IsEdited});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 25;
            this.guna2DataGridView1.Size = new System.Drawing.Size(664, 496);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 17;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FileLocation
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileLocation.DefaultCellStyle = dataGridViewCellStyle10;
            this.FileLocation.FillWeight = 19.49976F;
            this.FileLocation.HeaderText = "File Name/Location";
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.ReadOnly = true;
            // 
            // Size1
            // 
            this.Size1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size1.DefaultCellStyle = dataGridViewCellStyle11;
            this.Size1.FillWeight = 60.93674F;
            this.Size1.HeaderText = "Size";
            this.Size1.Name = "Size1";
            this.Size1.ReadOnly = true;
            this.Size1.Width = 70;
            // 
            // IsEdited
            // 
            this.IsEdited.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsEdited.DefaultCellStyle = dataGridViewCellStyle12;
            this.IsEdited.FillWeight = 82.92422F;
            this.IsEdited.HeaderText = "Edited";
            this.IsEdited.Name = "IsEdited";
            this.IsEdited.ReadOnly = true;
            this.IsEdited.Width = 62;
            // 
            // TxtBoxSelectZip
            // 
            this.TxtBoxSelectZip.AccessibleName = "TxtBoxSelectZip";
            this.TxtBoxSelectZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.TxtBoxSelectZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxSelectZip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxSelectZip.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxSelectZip.ForeColor = System.Drawing.Color.White;
            this.TxtBoxSelectZip.Location = new System.Drawing.Point(10, 10);
            this.TxtBoxSelectZip.Name = "TxtBoxSelectZip";
            this.TxtBoxSelectZip.PlaceholderText = " Select a 360.zip file...";
            this.TxtBoxSelectZip.ReadOnly = true;
            this.TxtBoxSelectZip.Size = new System.Drawing.Size(664, 27);
            this.TxtBoxSelectZip.TabIndex = 3;
            // 
            // btnZipOpen
            // 
            this.btnZipOpen.AccessibleName = "btnZipOpen";
            this.btnZipOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnZipOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZipOpen.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZipOpen.ForeColor = System.Drawing.Color.White;
            this.btnZipOpen.Location = new System.Drawing.Point(720, 208);
            this.btnZipOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnZipOpen.Name = "btnZipOpen";
            this.btnZipOpen.Size = new System.Drawing.Size(236, 30);
            this.btnZipOpen.TabIndex = 3;
            this.btnZipOpen.Text = "OPEN ZIP";
            this.btnZipOpen.UseVisualStyleBackColor = true;
            this.btnZipOpen.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ZIPProgressBar);
            this.panel2.Controls.Add(this.btnZipHelp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnConfirmZipChanges);
            this.panel2.Controls.Add(this.btnExtractZip);
            this.panel2.Controls.Add(this.btnCreateZip);
            this.panel2.Controls.Add(this.btnCloseZip);
            this.panel2.Location = new System.Drawing.Point(720, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 557);
            this.panel2.TabIndex = 4;
            // 
            // ZIPProgressBar
            // 
            this.ZIPProgressBar.AccessibleName = "ZIPProgressBar";
            this.ZIPProgressBar.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.ZIPProgressBar.BorderThickness = 1;
            this.ZIPProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ZIPProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ZIPProgressBar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZIPProgressBar.ForeColor = System.Drawing.Color.White;
            this.ZIPProgressBar.Location = new System.Drawing.Point(0, 527);
            this.ZIPProgressBar.Name = "ZIPProgressBar";
            this.ZIPProgressBar.Size = new System.Drawing.Size(236, 30);
            this.ZIPProgressBar.TabIndex = 6;
            this.ZIPProgressBar.Text = "Zip Progress";
            this.ZIPProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ZIPProgressBar.UseWaitCursor = true;
            // 
            // btnZipHelp
            // 
            this.btnZipHelp.AccessibleName = "btnZipHelp";
            this.btnZipHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnZipHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnZipHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZipHelp.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZipHelp.ForeColor = System.Drawing.Color.White;
            this.btnZipHelp.Location = new System.Drawing.Point(68, 108);
            this.btnZipHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnZipHelp.Name = "btnZipHelp";
            this.btnZipHelp.Size = new System.Drawing.Size(100, 30);
            this.btnZipHelp.TabIndex = 3;
            this.btnZipHelp.Text = "HELP!!!";
            this.btnZipHelp.UseVisualStyleBackColor = true;
            this.btnZipHelp.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "TxtProgress";
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Azonix", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "PROGRESS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmZipChanges
            // 
            this.btnConfirmZipChanges.AccessibleName = "btnConfirmZipChanges";
            this.btnConfirmZipChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnConfirmZipChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmZipChanges.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmZipChanges.ForeColor = System.Drawing.Color.White;
            this.btnConfirmZipChanges.Location = new System.Drawing.Point(0, 408);
            this.btnConfirmZipChanges.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmZipChanges.Name = "btnConfirmZipChanges";
            this.btnConfirmZipChanges.Size = new System.Drawing.Size(236, 30);
            this.btnConfirmZipChanges.TabIndex = 3;
            this.btnConfirmZipChanges.Text = "CONFIRM CHANGES";
            this.btnConfirmZipChanges.UseVisualStyleBackColor = true;
            // 
            // btnExtractZip
            // 
            this.btnExtractZip.AccessibleName = "btnExtractZip";
            this.btnExtractZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnExtractZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractZip.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExtractZip.ForeColor = System.Drawing.Color.White;
            this.btnExtractZip.Location = new System.Drawing.Point(0, 318);
            this.btnExtractZip.Margin = new System.Windows.Forms.Padding(0);
            this.btnExtractZip.Name = "btnExtractZip";
            this.btnExtractZip.Size = new System.Drawing.Size(236, 30);
            this.btnExtractZip.TabIndex = 3;
            this.btnExtractZip.Text = "EXTRACT ALL FILES";
            this.btnExtractZip.UseVisualStyleBackColor = true;
            // 
            // btnCreateZip
            // 
            this.btnCreateZip.AccessibleName = "btnCreateZip";
            this.btnCreateZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnCreateZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateZip.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateZip.ForeColor = System.Drawing.Color.White;
            this.btnCreateZip.Location = new System.Drawing.Point(0, 278);
            this.btnCreateZip.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateZip.Name = "btnCreateZip";
            this.btnCreateZip.Size = new System.Drawing.Size(236, 30);
            this.btnCreateZip.TabIndex = 3;
            this.btnCreateZip.Text = "CREATE ZIP";
            this.btnCreateZip.UseVisualStyleBackColor = true;
            // 
            // btnCloseZip
            // 
            this.btnCloseZip.AccessibleName = "btnCloseZip";
            this.btnCloseZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnCloseZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseZip.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseZip.ForeColor = System.Drawing.Color.White;
            this.btnCloseZip.Location = new System.Drawing.Point(0, 238);
            this.btnCloseZip.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseZip.Name = "btnCloseZip";
            this.btnCloseZip.Size = new System.Drawing.Size(236, 30);
            this.btnCloseZip.TabIndex = 5;
            this.btnCloseZip.Text = "CLOSE ZIP";
            this.btnCloseZip.UseVisualStyleBackColor = true;
            this.btnCloseZip.Click += new System.EventHandler(this.button2_Click);
            // 
            // UC_ZIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.btnZipOpen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_ZIP";
            this.Size = new System.Drawing.Size(978, 577);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnZipOpen;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2ProgressBar ZIPProgressBar;
        private Button btnZipHelp;
        private Label label2;
        private Button btnExtractZip;
        private Button btnCreateZip;
        private Button btnCloseZip;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private TextBox TxtBoxSelectZip;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private TreeView ZipTreeView;
        private Button btnConfirmZipChanges;
        private DataGridViewTextBoxColumn FileLocation;
        private DataGridViewTextBoxColumn Size1;
        private DataGridViewTextBoxColumn IsEdited;
    }
}
