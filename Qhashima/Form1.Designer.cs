namespace Qhashima
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
            this.Kiffolder = new System.Windows.Forms.FolderBrowserDialog();
            this.Kiflabel = new System.Windows.Forms.Label();
            this.Constlabel1 = new System.Windows.Forms.Label();
            this.Folderselector = new System.Windows.Forms.Button();
            this.Readkif = new System.Windows.Forms.Button();
            this.Kiflist = new System.Windows.Forms.ListBox();
            this.Constlabel2 = new System.Windows.Forms.Label();
            this.Player1_selector = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Constlabel3 = new System.Windows.Forms.Label();
            this.Winlosestat = new System.Windows.Forms.Label();
            this.Constlabel4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AIname1 = new System.Windows.Forms.TextBox();
            this.AIname2 = new System.Windows.Forms.TextBox();
            this.Search_AI = new System.Windows.Forms.Button();
            this.Readinfo = new System.Windows.Forms.Label();
            this.Outputplots = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OutstatByValue = new System.Windows.Forms.Button();
            this.Constlabel5 = new System.Windows.Forms.Label();
            this.StatByValueWithPlyfilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kiffolder
            // 
            this.Kiffolder.Description = "棋譜ファイルの入ったフォルダを選んでください";
            // 
            // Kiflabel
            // 
            this.Kiflabel.BackColor = System.Drawing.Color.White;
            this.Kiflabel.Location = new System.Drawing.Point(34, 62);
            this.Kiflabel.Name = "Kiflabel";
            this.Kiflabel.Size = new System.Drawing.Size(404, 19);
            this.Kiflabel.TabIndex = 0;
            this.Kiflabel.Text = "棋譜のフォルダ名";
            // 
            // Constlabel1
            // 
            this.Constlabel1.AutoSize = true;
            this.Constlabel1.Location = new System.Drawing.Point(34, 29);
            this.Constlabel1.Name = "Constlabel1";
            this.Constlabel1.Size = new System.Drawing.Size(200, 15);
            this.Constlabel1.TabIndex = 1;
            this.Constlabel1.Text = "以下のフォルダの棋譜を読み込む";
            // 
            // Folderselector
            // 
            this.Folderselector.Location = new System.Drawing.Point(457, 54);
            this.Folderselector.Name = "Folderselector";
            this.Folderselector.Size = new System.Drawing.Size(106, 30);
            this.Folderselector.TabIndex = 2;
            this.Folderselector.Text = "フォルダ選択";
            this.Folderselector.UseVisualStyleBackColor = true;
            this.Folderselector.Click += new System.EventHandler(this.Folderselector_Click);
            // 
            // Readkif
            // 
            this.Readkif.Location = new System.Drawing.Point(37, 190);
            this.Readkif.Name = "Readkif";
            this.Readkif.Size = new System.Drawing.Size(90, 29);
            this.Readkif.TabIndex = 3;
            this.Readkif.Text = "読み込み";
            this.Readkif.UseVisualStyleBackColor = true;
            this.Readkif.Click += new System.EventHandler(this.Readkif_Click);
            // 
            // Kiflist
            // 
            this.Kiflist.FormattingEnabled = true;
            this.Kiflist.ItemHeight = 15;
            this.Kiflist.Location = new System.Drawing.Point(37, 125);
            this.Kiflist.Name = "Kiflist";
            this.Kiflist.Size = new System.Drawing.Size(535, 49);
            this.Kiflist.TabIndex = 5;
            // 
            // Constlabel2
            // 
            this.Constlabel2.AutoSize = true;
            this.Constlabel2.Location = new System.Drawing.Point(34, 97);
            this.Constlabel2.Name = "Constlabel2";
            this.Constlabel2.Size = new System.Drawing.Size(169, 15);
            this.Constlabel2.TabIndex = 6;
            this.Constlabel2.Text = "以下の棋譜が読み込まれる";
            // 
            // Player1_selector
            // 
            this.Player1_selector.FormattingEnabled = true;
            this.Player1_selector.Location = new System.Drawing.Point(195, 594);
            this.Player1_selector.Name = "Player1_selector";
            this.Player1_selector.Size = new System.Drawing.Size(207, 23);
            this.Player1_selector.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 594);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // Constlabel3
            // 
            this.Constlabel3.AutoSize = true;
            this.Constlabel3.Location = new System.Drawing.Point(269, 241);
            this.Constlabel3.Name = "Constlabel3";
            this.Constlabel3.Size = new System.Drawing.Size(21, 15);
            this.Constlabel3.TabIndex = 9;
            this.Constlabel3.Text = "vs";
            // 
            // Winlosestat
            // 
            this.Winlosestat.AutoSize = true;
            this.Winlosestat.Location = new System.Drawing.Point(34, 285);
            this.Winlosestat.Name = "Winlosestat";
            this.Winlosestat.Size = new System.Drawing.Size(302, 15);
            this.Winlosestat.TabIndex = 10;
            this.Winlosestat.Text = "↑で選んだAI同士データが抽出される（部分一致）";
            // 
            // Constlabel4
            // 
            this.Constlabel4.AutoSize = true;
            this.Constlabel4.Location = new System.Drawing.Point(34, 335);
            this.Constlabel4.Name = "Constlabel4";
            this.Constlabel4.Size = new System.Drawing.Size(145, 15);
            this.Constlabel4.TabIndex = 11;
            this.Constlabel4.Text = "X手目での評価値分布";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(227, 333);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            495,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AIname1
            // 
            this.AIname1.Location = new System.Drawing.Point(51, 238);
            this.AIname1.Name = "AIname1";
            this.AIname1.Size = new System.Drawing.Size(199, 22);
            this.AIname1.TabIndex = 13;
            // 
            // AIname2
            // 
            this.AIname2.Location = new System.Drawing.Point(318, 238);
            this.AIname2.Name = "AIname2";
            this.AIname2.Size = new System.Drawing.Size(199, 22);
            this.AIname2.TabIndex = 14;
            // 
            // Search_AI
            // 
            this.Search_AI.Location = new System.Drawing.Point(367, 278);
            this.Search_AI.Name = "Search_AI";
            this.Search_AI.Size = new System.Drawing.Size(71, 29);
            this.Search_AI.TabIndex = 15;
            this.Search_AI.Text = "検索";
            this.Search_AI.UseVisualStyleBackColor = true;
            this.Search_AI.Click += new System.EventHandler(this.Search_AI_Click);
            // 
            // Readinfo
            // 
            this.Readinfo.AutoSize = true;
            this.Readinfo.Location = new System.Drawing.Point(147, 197);
            this.Readinfo.Name = "Readinfo";
            this.Readinfo.Size = new System.Drawing.Size(12, 15);
            this.Readinfo.TabIndex = 16;
            this.Readinfo.Text = " ";
            // 
            // Outputplots
            // 
            this.Outputplots.Location = new System.Drawing.Point(331, 328);
            this.Outputplots.Name = "Outputplots";
            this.Outputplots.Size = new System.Drawing.Size(71, 29);
            this.Outputplots.TabIndex = 17;
            this.Outputplots.Text = "出力";
            this.Outputplots.UseVisualStyleBackColor = true;
            this.Outputplots.Click += new System.EventHandler(this.Outputplots_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"csvファイル|*.csv|txtファイル|*.txt|すべてのファイル|*.*\"";
            // 
            // OutstatByValue
            // 
            this.OutstatByValue.Location = new System.Drawing.Point(294, 389);
            this.OutstatByValue.Name = "OutstatByValue";
            this.OutstatByValue.Size = new System.Drawing.Size(71, 29);
            this.OutstatByValue.TabIndex = 18;
            this.OutstatByValue.Text = "出力";
            this.OutstatByValue.UseVisualStyleBackColor = true;
            this.OutstatByValue.Click += new System.EventHandler(this.OutstatByValue_Click);
            // 
            // Constlabel5
            // 
            this.Constlabel5.AutoSize = true;
            this.Constlabel5.Location = new System.Drawing.Point(34, 396);
            this.Constlabel5.Name = "Constlabel5";
            this.Constlabel5.Size = new System.Drawing.Size(244, 15);
            this.Constlabel5.TabIndex = 19;
            this.Constlabel5.Text = "点数別勝率（1000点上限、50点刻み）";
            // 
            // StatByValueWithPlyfilter
            // 
            this.StatByValueWithPlyfilter.Location = new System.Drawing.Point(421, 326);
            this.StatByValueWithPlyfilter.Name = "StatByValueWithPlyfilter";
            this.StatByValueWithPlyfilter.Size = new System.Drawing.Size(179, 29);
            this.StatByValueWithPlyfilter.TabIndex = 20;
            this.StatByValueWithPlyfilter.Text = "点数別勝率の出力";
            this.StatByValueWithPlyfilter.UseVisualStyleBackColor = true;
            this.StatByValueWithPlyfilter.Click += new System.EventHandler(this.StatByValueWithPlyfilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 629);
            this.Controls.Add(this.StatByValueWithPlyfilter);
            this.Controls.Add(this.Constlabel5);
            this.Controls.Add(this.OutstatByValue);
            this.Controls.Add(this.Outputplots);
            this.Controls.Add(this.Readinfo);
            this.Controls.Add(this.Search_AI);
            this.Controls.Add(this.AIname2);
            this.Controls.Add(this.AIname1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Constlabel4);
            this.Controls.Add(this.Winlosestat);
            this.Controls.Add(this.Constlabel3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Player1_selector);
            this.Controls.Add(this.Constlabel2);
            this.Controls.Add(this.Kiflist);
            this.Controls.Add(this.Readkif);
            this.Controls.Add(this.Folderselector);
            this.Controls.Add(this.Constlabel1);
            this.Controls.Add(this.Kiflabel);
            this.Name = "Form1";
            this.Text = "QHApaq SHogI MAanager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog Kiffolder;
        private System.Windows.Forms.Label Kiflabel;
        private System.Windows.Forms.Label Constlabel1;
        private System.Windows.Forms.Button Folderselector;
        private System.Windows.Forms.Button Readkif;
        private System.Windows.Forms.ListBox Kiflist;
        private System.Windows.Forms.Label Constlabel2;
        private System.Windows.Forms.ComboBox Player1_selector;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Constlabel3;
        private System.Windows.Forms.Label Winlosestat;
        private System.Windows.Forms.Label Constlabel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox AIname1;
        private System.Windows.Forms.TextBox AIname2;
        private System.Windows.Forms.Button Search_AI;
        private System.Windows.Forms.Label Readinfo;
        private System.Windows.Forms.Button Outputplots;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button OutstatByValue;
        private System.Windows.Forms.Label Constlabel5;
        private System.Windows.Forms.Button StatByValueWithPlyfilter;
    }
}

