namespace Noisy
{
    partial class frmDecode
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
            this.ofdLoadClear = new System.Windows.Forms.OpenFileDialog();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pbxPreview = new System.Windows.Forms.PictureBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadClear = new System.Windows.Forms.Button();
            this.btnLoadEncoded = new System.Windows.Forms.Button();
            this.btnSaveDecoded = new System.Windows.Forms.Button();
            this.ofdLoadEncoded = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveImg = new System.Windows.Forms.SaveFileDialog();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).BeginInit();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdLoadClear
            // 
            this.ofdLoadClear.DefaultExt = "jpg";
            this.ofdLoadClear.Filter = "JPG Images|*.jpg|All Files|*.*";
            this.ofdLoadClear.Title = "Load Image";
            this.ofdLoadClear.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLoadClear_FileOk);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.pbxPreview, 0, 0);
            this.tlpMain.Controls.Add(this.flpButtons, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.Size = new System.Drawing.Size(732, 453);
            this.tlpMain.TabIndex = 2;
            // 
            // pbxPreview
            // 
            this.pbxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPreview.Location = new System.Drawing.Point(3, 3);
            this.pbxPreview.Name = "pbxPreview";
            this.pbxPreview.Size = new System.Drawing.Size(726, 411);
            this.pbxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPreview.TabIndex = 3;
            this.pbxPreview.TabStop = false;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnLoadClear);
            this.flpButtons.Controls.Add(this.btnLoadEncoded);
            this.flpButtons.Controls.Add(this.btnSaveDecoded);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.Location = new System.Drawing.Point(3, 420);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(726, 30);
            this.flpButtons.TabIndex = 0;
            // 
            // btnLoadClear
            // 
            this.btnLoadClear.Location = new System.Drawing.Point(3, 3);
            this.btnLoadClear.Name = "btnLoadClear";
            this.btnLoadClear.Size = new System.Drawing.Size(100, 23);
            this.btnLoadClear.TabIndex = 0;
            this.btnLoadClear.Text = "Load clear Image";
            this.btnLoadClear.UseVisualStyleBackColor = true;
            this.btnLoadClear.Click += new System.EventHandler(this.btnLoadClear_Click);
            // 
            // btnLoadEncoded
            // 
            this.btnLoadEncoded.Location = new System.Drawing.Point(109, 3);
            this.btnLoadEncoded.Name = "btnLoadEncoded";
            this.btnLoadEncoded.Size = new System.Drawing.Size(90, 23);
            this.btnLoadEncoded.TabIndex = 1;
            this.btnLoadEncoded.Text = "Load Encoded";
            this.btnLoadEncoded.UseVisualStyleBackColor = true;
            this.btnLoadEncoded.Click += new System.EventHandler(this.btnLoadEncoded_Click);
            // 
            // btnSaveDecoded
            // 
            this.btnSaveDecoded.Location = new System.Drawing.Point(205, 3);
            this.btnSaveDecoded.Name = "btnSaveDecoded";
            this.btnSaveDecoded.Size = new System.Drawing.Size(88, 23);
            this.btnSaveDecoded.TabIndex = 2;
            this.btnSaveDecoded.Text = "Save Decoded";
            this.btnSaveDecoded.UseVisualStyleBackColor = true;
            this.btnSaveDecoded.Click += new System.EventHandler(this.btnSaveDecoded_Click);
            // 
            // ofdLoadEncoded
            // 
            this.ofdLoadEncoded.Filter = "All Files|*.*";
            this.ofdLoadEncoded.Title = "Load File";
            this.ofdLoadEncoded.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLoadEncoded_FileOk);
            // 
            // sfdSaveImg
            // 
            this.sfdSaveImg.DefaultExt = "bmp";
            this.sfdSaveImg.Filter = "Bitmap Images|*.bmp";
            this.sfdSaveImg.Title = "Save Image";
            this.sfdSaveImg.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdSaveImg_FileOk);
            // 
            // frmDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(265, 160);
            this.Name = "frmDecode";
            this.Text = "Noisy Decoder";
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).EndInit();
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdLoadClear;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnLoadClear;
        private System.Windows.Forms.Button btnLoadEncoded;
        private System.Windows.Forms.Button btnSaveDecoded;
        private System.Windows.Forms.PictureBox pbxPreview;
        private System.Windows.Forms.OpenFileDialog ofdLoadEncoded;
        private System.Windows.Forms.SaveFileDialog sfdSaveImg;
    }
}

