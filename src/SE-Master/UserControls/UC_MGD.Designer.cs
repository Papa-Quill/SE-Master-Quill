namespace SE_Master.UserControls
{
    partial class UC_MGD
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
            this.label1 = new System.Windows.Forms.Label();
            this.DropDownMGD = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearMGDLogs = new System.Windows.Forms.Button();
            this.MGDLogsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectFilesFolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "MGDTitle";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Azonix", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(702, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "SE | MGD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DropDownMGD
            // 
            this.DropDownMGD.AccessibleName = "DropDownMGD";
            this.DropDownMGD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.DropDownMGD.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.DropDownMGD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownMGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownMGD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.DropDownMGD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(246)))));
            this.DropDownMGD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(246)))));
            this.DropDownMGD.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DropDownMGD.ForeColor = System.Drawing.Color.White;
            this.DropDownMGD.ItemHeight = 30;
            this.DropDownMGD.Items.AddRange(new object[] {
            "Select an Option",
            "Placeholder1",
            "Placeholder2"});
            this.DropDownMGD.Location = new System.Drawing.Point(702, 97);
            this.DropDownMGD.Name = "DropDownMGD";
            this.DropDownMGD.Size = new System.Drawing.Size(266, 36);
            this.DropDownMGD.StartIndex = 0;
            this.DropDownMGD.TabIndex = 2;
            this.DropDownMGD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DropDownMGD.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "MGDLogsTitle";
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClearMGDLogs);
            this.panel1.Controls.Add(this.MGDLogsBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 557);
            this.panel1.TabIndex = 4;
            // 
            // btnClearMGDLogs
            // 
            this.btnClearMGDLogs.AccessibleName = "btnClearMGDLogs";
            this.btnClearMGDLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnClearMGDLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMGDLogs.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearMGDLogs.ForeColor = System.Drawing.Color.White;
            this.btnClearMGDLogs.Location = new System.Drawing.Point(583, 6);
            this.btnClearMGDLogs.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearMGDLogs.Name = "btnClearMGDLogs";
            this.btnClearMGDLogs.Size = new System.Drawing.Size(83, 30);
            this.btnClearMGDLogs.TabIndex = 19;
            this.btnClearMGDLogs.Text = "CLEAR";
            this.btnClearMGDLogs.UseVisualStyleBackColor = true;
            this.btnClearMGDLogs.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // MGDLogsBox
            // 
            this.MGDLogsBox.AccessibleName = "MGDLogsBox";
            this.MGDLogsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.MGDLogsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MGDLogsBox.ForeColor = System.Drawing.Color.White;
            this.MGDLogsBox.Location = new System.Drawing.Point(10, 40);
            this.MGDLogsBox.MaxLength = 5000;
            this.MGDLogsBox.Multiline = true;
            this.MGDLogsBox.Name = "MGDLogsBox";
            this.MGDLogsBox.PlaceholderText = "> MGD Logs";
            this.MGDLogsBox.ReadOnly = true;
            this.MGDLogsBox.Size = new System.Drawing.Size(656, 507);
            this.MGDLogsBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SE | MGD LOGS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SelectFilesFolder
            // 
            this.SelectFilesFolder.AccessibleName = "SelectFilesFolder";
            this.SelectFilesFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.SelectFilesFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFilesFolder.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectFilesFolder.ForeColor = System.Drawing.Color.White;
            this.SelectFilesFolder.Location = new System.Drawing.Point(702, 146);
            this.SelectFilesFolder.Margin = new System.Windows.Forms.Padding(0);
            this.SelectFilesFolder.Name = "SelectFilesFolder";
            this.SelectFilesFolder.Size = new System.Drawing.Size(266, 30);
            this.SelectFilesFolder.TabIndex = 5;
            this.SelectFilesFolder.Text = "Select Files/Folders";
            this.SelectFilesFolder.UseVisualStyleBackColor = true;
            this.SelectFilesFolder.Click += new System.EventHandler(this.SelectFilesFolder_Click);
            // 
            // UC_MGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.SelectFilesFolder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DropDownMGD);
            this.Controls.Add(this.label1);
            this.Name = "UC_MGD";
            this.Size = new System.Drawing.Size(978, 577);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox DropDownMGD;
        private Panel panel1;
        private Button btnClearMGDLogs;
        private TextBox MGDLogsBox;
        private Label label2;
        private Button SelectFilesFolder;
    }
}
