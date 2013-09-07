namespace QTViewer
{
    partial class QTFullScreenViewer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QTFullScreenViewer));
            this.axQTControl1 = new AxQTOControlLib.AxQTControl();
            ((System.ComponentModel.ISupportInitialize)(this.axQTControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axQTControl1
            // 
            this.axQTControl1.Enabled = true;
            this.axQTControl1.Location = new System.Drawing.Point(0, 0);
            this.axQTControl1.Name = "axQTControl1";
            this.axQTControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axQTControl1.OcxState")));
            this.axQTControl1.Size = new System.Drawing.Size(192, 192);
            this.axQTControl1.TabIndex = 1;
            // 
            // QTFullScreenViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.axQTControl1);
            this.Name = "QTFullScreenViewer";
            this.Text = "QTFullScreenViewer";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.axQTControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxQTOControlLib.AxQTControl axQTControl1;

    }
}

