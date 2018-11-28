using CouponReader.Common.Controls;

namespace CouponReader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scanButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.txtInputCode = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.headerGroupBox = new System.Windows.Forms.GroupBox();
            this.historyButton = new System.Windows.Forms.Button();
            this.elementHost = new System.Windows.Forms.Integration.ElementHost();
            this.couponDetails = new CouponReader.Common.Controls.CouponDetailsControl();
            this.couponsHistory = new System.Windows.Forms.Integration.ElementHost();
            this.couponsHistoryControl = new CouponReader.Common.Controls.CouponsHistoryControl();
            this.headerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scanButton.Location = new System.Drawing.Point(1583, 62);
            this.scanButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(112, 36);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "&Scan";
            this.scanButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.Location = new System.Drawing.Point(1703, 62);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 36);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // txtInputCode
            // 
            this.txtInputCode.Location = new System.Drawing.Point(215, 65);
            this.txtInputCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputCode.Name = "txtInputCode";
            this.txtInputCode.Size = new System.Drawing.Size(1360, 31);
            this.txtInputCode.TabIndex = 2;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.ForeColor = System.Drawing.Color.DimGray;
            this.titleLbl.Location = new System.Drawing.Point(8, 68);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(199, 25);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Enter coupon code:";
            // 
            // headerGroupBox
            // 
            this.headerGroupBox.BackColor = System.Drawing.Color.White;
            this.headerGroupBox.Controls.Add(this.historyButton);
            this.headerGroupBox.Controls.Add(this.txtInputCode);
            this.headerGroupBox.Controls.Add(this.titleLbl);
            this.headerGroupBox.Controls.Add(this.clearButton);
            this.headerGroupBox.Controls.Add(this.scanButton);
            this.headerGroupBox.Location = new System.Drawing.Point(17, 19);
            this.headerGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerGroupBox.Name = "headerGroupBox";
            this.headerGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerGroupBox.Size = new System.Drawing.Size(1943, 141);
            this.headerGroupBox.TabIndex = 5;
            this.headerGroupBox.TabStop = false;
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.historyButton.Location = new System.Drawing.Point(1823, 62);
            this.historyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(112, 36);
            this.historyButton.TabIndex = 4;
            this.historyButton.Text = "&History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.OnHistoryButtonClick);
            // 
            // elementHost
            // 
            this.elementHost.BackColor = System.Drawing.Color.White;
            this.elementHost.Location = new System.Drawing.Point(13, 169);
            this.elementHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elementHost.Name = "elementHost";
            this.elementHost.Size = new System.Drawing.Size(1943, 946);
            this.elementHost.TabIndex = 4;
            this.elementHost.Text = "couponDetailsHost";
            this.elementHost.Child = this.couponDetails;
            // 
            // couponsHistory
            // 
            this.couponsHistory.Location = new System.Drawing.Point(17, 170);
            this.couponsHistory.Name = "couponsHistory";
            this.couponsHistory.Size = new System.Drawing.Size(1939, 947);
            this.couponsHistory.TabIndex = 6;
            this.couponsHistory.Text = "couponsHistoryHost";
            this.couponsHistory.Child = this.couponsHistoryControl;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1974, 1129);
            this.Controls.Add(this.couponsHistory);
            this.Controls.Add(this.headerGroupBox);
            this.Controls.Add(this.elementHost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Tailwind Traders Coupon Reader";
            this.headerGroupBox.ResumeLayout(false);
            this.headerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox txtInputCode;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Integration.ElementHost elementHost;
        private CouponDetailsControl couponDetails;
        private System.Windows.Forms.GroupBox headerGroupBox;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Integration.ElementHost couponsHistory;
        private CouponsHistoryControl couponsHistoryControl;
    }
}