namespace GetFilesMDI
{
    partial class MotherForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LbStatus = new System.Windows.Forms.Label();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Location = new System.Drawing.Point(28, 221);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(62, 18);
            this.LbStatus.TabIndex = 0;
            this.LbStatus.Text = "label1";
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(709, 449);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(201, 66);
            this.btnGetFile.TabIndex = 1;
            this.btnGetFile.Text = "Get Files";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // MotherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 564);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.LbStatus);
            this.Name = "MotherForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbStatus;
        private System.Windows.Forms.Button btnGetFile;
    }
}

