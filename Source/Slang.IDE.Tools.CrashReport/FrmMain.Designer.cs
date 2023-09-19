namespace Slang.IDE.Tools.CrashReport
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            LblTitle = new Label();
            TxtException = new TextBox();
            TxtExtraInfo = new TextBox();
            LblException = new Label();
            LblExtraInfo = new Label();
            BtnSendReport = new Button();
            BtnCancel = new Button();
            LblParagraph = new Label();
            PctLogo = new PictureBox();
            PctInfo = new PictureBox();
            CrashReportToolTip = new ToolTip(components);
            BtnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)PctLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PctInfo).BeginInit();
            SuspendLayout();
            // 
            // LblTitle
            // 
            LblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Pixel);
            LblTitle.Location = new Point(263, 9);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(131, 91);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Crash \r\nReport";
            LblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtException
            // 
            TxtException.BorderStyle = BorderStyle.FixedSingle;
            TxtException.Enabled = false;
            TxtException.Location = new Point(12, 172);
            TxtException.Multiline = true;
            TxtException.Name = "TxtException";
            TxtException.ReadOnly = true;
            TxtException.Size = new Size(382, 140);
            TxtException.TabIndex = 0;
            // 
            // TxtExtraInfo
            // 
            TxtExtraInfo.BorderStyle = BorderStyle.FixedSingle;
            TxtExtraInfo.Location = new Point(12, 333);
            TxtExtraInfo.Multiline = true;
            TxtExtraInfo.Name = "TxtExtraInfo";
            TxtExtraInfo.Size = new Size(382, 90);
            TxtExtraInfo.TabIndex = 1;
            // 
            // LblException
            // 
            LblException.AutoSize = true;
            LblException.Location = new Point(12, 154);
            LblException.Name = "LblException";
            LblException.Size = new Size(62, 15);
            LblException.TabIndex = 3;
            LblException.Text = "Exception:";
            // 
            // LblExtraInfo
            // 
            LblExtraInfo.AutoSize = true;
            LblExtraInfo.Location = new Point(12, 315);
            LblExtraInfo.Name = "LblExtraInfo";
            LblExtraInfo.Size = new Size(60, 15);
            LblExtraInfo.TabIndex = 4;
            LblExtraInfo.Text = "Extra Info:";
            // 
            // BtnSendReport
            // 
            BtnSendReport.Location = new Point(319, 429);
            BtnSendReport.Name = "BtnSendReport";
            BtnSendReport.Size = new Size(75, 49);
            BtnSendReport.TabIndex = 2;
            BtnSendReport.Text = "Send Report";
            BtnSendReport.UseVisualStyleBackColor = true;
            BtnSendReport.Click += BtnSendReport_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(238, 429);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 49);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // LblParagraph
            // 
            LblParagraph.Location = new Point(12, 100);
            LblParagraph.Name = "LblParagraph";
            LblParagraph.Size = new Size(382, 54);
            LblParagraph.TabIndex = 7;
            LblParagraph.Text = "We apologise about your experience. It seems there was an unhandled error. Please provide us the error and extra information about error in order to investigate it further. \r\n";
            // 
            // PctLogo
            // 
            PctLogo.Image = Properties.Resources.pngwing_com;
            PctLogo.Location = new Point(12, 12);
            PctLogo.Name = "PctLogo";
            PctLogo.Size = new Size(87, 85);
            PctLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PctLogo.TabIndex = 8;
            PctLogo.TabStop = false;
            // 
            // PctInfo
            // 
            PctInfo.Image = Properties.Resources.InfoTipInline_11_11;
            PctInfo.Location = new Point(74, 317);
            PctInfo.Name = "PctInfo";
            PctInfo.Size = new Size(11, 11);
            PctInfo.SizeMode = PictureBoxSizeMode.AutoSize;
            PctInfo.TabIndex = 9;
            PctInfo.TabStop = false;
            CrashReportToolTip.SetToolTip(PctInfo, "It is not necessary to fill this box up but we glad to hear some extra information about error.");
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(12, 427);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 49);
            BtnSave.TabIndex = 4;
            BtnSave.Text = "Save Report";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // FrmMain
            // 
            AcceptButton = BtnSendReport;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(406, 488);
            Controls.Add(BtnSave);
            Controls.Add(PctInfo);
            Controls.Add(PctLogo);
            Controls.Add(LblParagraph);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSendReport);
            Controls.Add(LblExtraInfo);
            Controls.Add(LblException);
            Controls.Add(TxtExtraInfo);
            Controls.Add(TxtException);
            Controls.Add(LblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crash Report";
            FormClosing += FrmMain_FormClosing;
            ((System.ComponentModel.ISupportInitialize)PctLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PctInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitle;
        private TextBox TxtException;
        private TextBox TxtExtraInfo;
        private Label LblException;
        private Label LblExtraInfo;
        private Button BtnSendReport;
        private Button BtnCancel;
        private Label LblParagraph;
        private PictureBox PctLogo;
        private PictureBox PctInfo;
        private ToolTip CrashReportToolTip;
        private Button BtnSave;
    }
}