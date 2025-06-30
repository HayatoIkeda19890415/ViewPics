namespace ViewPics
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
            this.folderpath = new System.Windows.Forms.TextBox();
            this.readDir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.randomDir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // folderpath
            // 
            this.folderpath.Location = new System.Drawing.Point(47, 17);
            this.folderpath.Name = "folderpath";
            this.folderpath.Size = new System.Drawing.Size(538, 19);
            this.folderpath.TabIndex = 0;
            // 
            // readDir
            // 
            this.readDir.Location = new System.Drawing.Point(607, 15);
            this.readDir.Name = "readDir";
            this.readDir.Size = new System.Drawing.Size(75, 23);
            this.readDir.TabIndex = 1;
            this.readDir.Text = "取込";
            this.readDir.UseVisualStyleBackColor = true;
            this.readDir.Click += new System.EventHandler(this.readDir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(47, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 370);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(12, 160);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(29, 52);
            this.prev.TabIndex = 3;
            this.prev.Text = "←";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(769, 160);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(28, 52);
            this.next.TabIndex = 4;
            this.next.Text = "→";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // randomDir
            // 
            this.randomDir.Location = new System.Drawing.Point(688, 15);
            this.randomDir.Name = "randomDir";
            this.randomDir.Size = new System.Drawing.Size(75, 23);
            this.randomDir.TabIndex = 5;
            this.randomDir.Text = "ランダム";
            this.randomDir.UseVisualStyleBackColor = true;
            this.randomDir.Click += new System.EventHandler(this.randomDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.randomDir);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.readDir);
            this.Controls.Add(this.folderpath);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderpath;
        private System.Windows.Forms.Button readDir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button randomDir;
    }
}

