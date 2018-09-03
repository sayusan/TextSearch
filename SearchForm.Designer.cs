namespace TextSearch
{
    partial class SearchForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.filePass = new System.Windows.Forms.TextBox();
            this.serchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brouseButton = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.TextBox();
            this.kensakuButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "検索する文字列を入力してください";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(65, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "出力ファイルパスを入力してください";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // filePass
            // 
            this.filePass.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.filePass.Location = new System.Drawing.Point(67, 260);
            this.filePass.Multiline = true;
            this.filePass.Name = "filePass";
            this.filePass.Size = new System.Drawing.Size(445, 33);
            this.filePass.TabIndex = 4;
            this.filePass.WordWrap = false;
            this.filePass.TextChanged += new System.EventHandler(this.filePass_TextChanged);
            // 
            // serchText
            // 
            this.serchText.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serchText.Location = new System.Drawing.Point(69, 80);
            this.serchText.Multiline = true;
            this.serchText.Name = "serchText";
            this.serchText.Size = new System.Drawing.Size(445, 33);
            this.serchText.TabIndex = 4;
            this.serchText.WordWrap = false;
            this.serchText.TextChanged += new System.EventHandler(this.serchText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(63, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "検索するディレクトリを選択してください";
            // 
            // brouseButton
            // 
            this.brouseButton.Location = new System.Drawing.Point(525, 170);
            this.brouseButton.Name = "brouseButton";
            this.brouseButton.Size = new System.Drawing.Size(53, 33);
            this.brouseButton.TabIndex = 3;
            this.brouseButton.Text = "・・・";
            this.brouseButton.UseVisualStyleBackColor = true;
            this.brouseButton.Click += new System.EventHandler(this.brouseButton_Click);
            // 
            // directory
            // 
            this.directory.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.directory.Location = new System.Drawing.Point(67, 170);
            this.directory.Multiline = true;
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(445, 33);
            this.directory.TabIndex = 5;
            this.directory.WordWrap = false;
            this.directory.TextChanged += new System.EventHandler(this.directory_TextChanged);
            // 
            // kensakuButton
            // 
            this.kensakuButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.kensakuButton.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kensakuButton.Location = new System.Drawing.Point(525, 347);
            this.kensakuButton.Name = "kensakuButton";
            this.kensakuButton.Size = new System.Drawing.Size(80, 37);
            this.kensakuButton.TabIndex = 6;
            this.kensakuButton.Text = "検 索";
            this.kensakuButton.UseVisualStyleBackColor = false;
            this.kensakuButton.Click += new System.EventHandler(this.kensakuButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(177, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kensakuButton);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.serchText);
            this.Controls.Add(this.filePass);
            this.Controls.Add(this.brouseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "検索";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox filePass;
        private System.Windows.Forms.TextBox serchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button brouseButton;
        private System.Windows.Forms.TextBox directory;
        private System.Windows.Forms.Button kensakuButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

