namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.button_exe_20200630 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exe_20200630
            // 
            this.button_exe_20200630.Location = new System.Drawing.Point(48, 98);
            this.button_exe_20200630.Name = "button_exe_20200630";
            this.button_exe_20200630.Size = new System.Drawing.Size(245, 33);
            this.button_exe_20200630.TabIndex = 0;
            this.button_exe_20200630.Text = "20200630　old項目情報まとめ";
            this.button_exe_20200630.UseVisualStyleBackColor = true;
            this.button_exe_20200630.Click += new System.EventHandler(this.button_exe_20200630_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_exe_20200630);
            this.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exe_20200630;
    }
}

