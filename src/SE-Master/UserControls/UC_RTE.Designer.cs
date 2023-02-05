namespace SE_Master.UserControls
{
    partial class UC_RTE
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearRTEConsole = new System.Windows.Forms.Button();
            this.RTEConsoleTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendCFGorTestscript = new System.Windows.Forms.Button();
            this.btnSendCVAR = new System.Windows.Forms.Button();
            this.TxtInputCVARs = new System.Windows.Forms.TextBox();
            this.btnDownloadCVARs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "RTETitle";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Azonix", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(704, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "SE | RTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClearRTEConsole);
            this.panel1.Controls.Add(this.RTEConsoleTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 557);
            this.panel1.TabIndex = 3;
            // 
            // btnClearRTEConsole
            // 
            this.btnClearRTEConsole.AccessibleName = "btnClearRTEConsole";
            this.btnClearRTEConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnClearRTEConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRTEConsole.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearRTEConsole.ForeColor = System.Drawing.Color.White;
            this.btnClearRTEConsole.Location = new System.Drawing.Point(585, 6);
            this.btnClearRTEConsole.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearRTEConsole.Name = "btnClearRTEConsole";
            this.btnClearRTEConsole.Size = new System.Drawing.Size(83, 30);
            this.btnClearRTEConsole.TabIndex = 19;
            this.btnClearRTEConsole.Text = "CLEAR";
            this.btnClearRTEConsole.UseVisualStyleBackColor = true;
            this.btnClearRTEConsole.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // RTEConsoleTxtBox
            // 
            this.RTEConsoleTxtBox.AccessibleName = "RTEConsoleBox";
            this.RTEConsoleTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.RTEConsoleTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTEConsoleTxtBox.Location = new System.Drawing.Point(10, 40);
            this.RTEConsoleTxtBox.MaxLength = 5000;
            this.RTEConsoleTxtBox.Multiline = true;
            this.RTEConsoleTxtBox.Name = "RTEConsoleTxtBox";
            this.RTEConsoleTxtBox.PlaceholderText = "> Console Logs";
            this.RTEConsoleTxtBox.ReadOnly = true;
            this.RTEConsoleTxtBox.Size = new System.Drawing.Size(658, 507);
            this.RTEConsoleTxtBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AccessibleName = "TxtConsoleLogTitle";
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SE | CONSOLE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSendCFGorTestscript
            // 
            this.btnSendCFGorTestscript.AccessibleName = "btnSendCFGorTestscript";
            this.btnSendCFGorTestscript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnSendCFGorTestscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCFGorTestscript.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendCFGorTestscript.ForeColor = System.Drawing.Color.White;
            this.btnSendCFGorTestscript.Location = new System.Drawing.Point(704, 315);
            this.btnSendCFGorTestscript.Margin = new System.Windows.Forms.Padding(0);
            this.btnSendCFGorTestscript.Name = "btnSendCFGorTestscript";
            this.btnSendCFGorTestscript.Size = new System.Drawing.Size(261, 30);
            this.btnSendCFGorTestscript.TabIndex = 4;
            this.btnSendCFGorTestscript.Text = "SEND CFG/TESTSCRIPT";
            this.btnSendCFGorTestscript.UseVisualStyleBackColor = true;
            this.btnSendCFGorTestscript.Click += new System.EventHandler(this.Button10_Click);
            // 
            // btnSendCVAR
            // 
            this.btnSendCVAR.AccessibleName = "btnSendCVAR";
            this.btnSendCVAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnSendCVAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCVAR.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendCVAR.ForeColor = System.Drawing.Color.White;
            this.btnSendCVAR.Location = new System.Drawing.Point(704, 275);
            this.btnSendCVAR.Margin = new System.Windows.Forms.Padding(0);
            this.btnSendCVAR.Name = "btnSendCVAR";
            this.btnSendCVAR.Size = new System.Drawing.Size(261, 30);
            this.btnSendCVAR.TabIndex = 4;
            this.btnSendCVAR.Text = "SEND CVAR";
            this.btnSendCVAR.UseVisualStyleBackColor = true;
            // 
            // TxtInputCVARs
            // 
            this.TxtInputCVARs.AccessibleName = "TxtInputCVARs";
            this.TxtInputCVARs.AllowDrop = true;
            this.TxtInputCVARs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.TxtInputCVARs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInputCVARs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtInputCVARs.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtInputCVARs.ForeColor = System.Drawing.Color.White;
            this.TxtInputCVARs.Location = new System.Drawing.Point(704, 231);
            this.TxtInputCVARs.MaxLength = 200;
            this.TxtInputCVARs.Name = "TxtInputCVARs";
            this.TxtInputCVARs.PlaceholderText = "Input CVARs";
            this.TxtInputCVARs.Size = new System.Drawing.Size(261, 31);
            this.TxtInputCVARs.TabIndex = 18;
            // 
            // btnDownloadCVARs
            // 
            this.btnDownloadCVARs.AccessibleName = "btnDownloadCVARs";
            this.btnDownloadCVARs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnDownloadCVARs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadCVARs.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDownloadCVARs.ForeColor = System.Drawing.Color.White;
            this.btnDownloadCVARs.Location = new System.Drawing.Point(704, 537);
            this.btnDownloadCVARs.Margin = new System.Windows.Forms.Padding(0);
            this.btnDownloadCVARs.Name = "btnDownloadCVARs";
            this.btnDownloadCVARs.Size = new System.Drawing.Size(261, 30);
            this.btnDownloadCVARs.TabIndex = 4;
            this.btnDownloadCVARs.Text = "DOWNLOAD CVAR LIST";
            this.btnDownloadCVARs.UseVisualStyleBackColor = true;
            this.btnDownloadCVARs.Click += new System.EventHandler(this.DownloadCVARS_click);
            // 
            // UC_RTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.TxtInputCVARs);
            this.Controls.Add(this.btnSendCVAR);
            this.Controls.Add(this.btnDownloadCVARs);
            this.Controls.Add(this.btnSendCFGorTestscript);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_RTE";
            this.Size = new System.Drawing.Size(978, 577);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnSendCFGorTestscript;
        private Button btnSendCVAR;
        private TextBox TxtInputCVARs;
        private TextBox RTEConsoleTxtBox;
        private Label label2;
        private Button btnClearRTEConsole;
        private Button btnDownloadCVARs;
    }
}
