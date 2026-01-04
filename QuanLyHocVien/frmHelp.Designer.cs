
namespace QuanLyHocVien
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.memoHelp = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoHelp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoHelp
            // 
            this.memoHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoHelp.Location = new System.Drawing.Point(0, 0);
            this.memoHelp.Name = "memoHelp";
            this.memoHelp.Properties.ReadOnly = true;
            this.memoHelp.Size = new System.Drawing.Size(793, 394);
            this.memoHelp.TabIndex = 0;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 394);
            this.Controls.Add(this.memoHelp);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmHelp.IconOptions.LargeImage")));
            this.Name = "frmHelp";
            this.Text = "Đề Đồ Án";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoHelp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoHelp;
    }
}