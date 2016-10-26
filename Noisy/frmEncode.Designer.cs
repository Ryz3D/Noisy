namespace Noisy
{
    partial class frmEncode
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
            this.ofdLoadImg = new System.Windows.Forms.OpenFileDialog();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pbxPreview = new System.Windows.Forms.PictureBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.btnLoadTxt = new System.Windows.Forms.Button();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveImg = new System.Windows.Forms.SaveFileDialog();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).BeginInit();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdLoadImg
            // 
            this.ofdLoadImg.DefaultExt = "jpg";
            this.ofdLoadImg.Filter = "JPG Images|*.jpg|All Files|*.*";
            this.ofdLoadImg.Title = "Load Image";
            this.ofdLoadImg.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLoadImg_FileOk);
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
            this.flpButtons.Controls.Add(this.btnLoadImg);
            this.flpButtons.Controls.Add(this.btnLoadTxt);
            this.flpButtons.Controls.Add(this.btnSaveImg);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.Location = new System.Drawing.Point(3, 420);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(726, 30);
            this.flpButtons.TabIndex = 0;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Location = new System.Drawing.Point(3, 3);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImg.TabIndex = 0;
            this.btnLoadImg.Text = "Load Image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // btnLoadTxt
            // 
            this.btnLoadTxt.Location = new System.Drawing.Point(84, 3);
            this.btnLoadTxt.Name = "btnLoadTxt";
            this.btnLoadTxt.Size = new System.Drawing.Size(62, 23);
            this.btnLoadTxt.TabIndex = 1;
            this.btnLoadTxt.Text = "Load File";
            this.btnLoadTxt.UseVisualStyleBackColor = true;
            this.btnLoadTxt.Click += new System.EventHandler(this.btnLoadTxt_Click);
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Location = new System.Drawing.Point(152, 3);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(73, 23);
            this.btnSaveImg.TabIndex = 2;
            this.btnSaveImg.Text = "Save Image";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            this.btnSaveImg.Click += new System.EventHandler(this.btnSaveImg_Click);
            // 
            // ofdLoad
            // 
            this.ofdLoad.Filter = "All Files|*.*";
            this.ofdLoad.Title = "Load File";
            this.ofdLoad.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLoadTxt_FileOk);
            // 
            // sfdSaveImg
            // 
            this.sfdSaveImg.DefaultExt = "bmp";
            this.sfdSaveImg.Filter = "Bitmap Images|*.bmp";
            this.sfdSaveImg.Title = "Save Image";
            this.sfdSaveImg.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdSaveImg_FileOk);
            // 
            // frmEncode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(265, 160);
            this.Name = "frmEncode";
            this.Text = "Noisy Encoder";
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).EndInit();
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdLoadImg;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Button btnLoadTxt;
        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.PictureBox pbxPreview;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
        private System.Windows.Forms.SaveFileDialog sfdSaveImg;
    }
}

