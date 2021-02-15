namespace prjWinCsRemax
{
    partial class frmSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_HouseType = new System.Windows.Forms.RadioButton();
            this.rb_Agent = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_SearchInfo = new System.Windows.Forms.ComboBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_SearchInfo);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.rb_Agent);
            this.groupBox1.Controls.Add(this.rb_HouseType);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search BY:";
            // 
            // rb_HouseType
            // 
            this.rb_HouseType.AutoSize = true;
            this.rb_HouseType.Location = new System.Drawing.Point(15, 37);
            this.rb_HouseType.Name = "rb_HouseType";
            this.rb_HouseType.Size = new System.Drawing.Size(126, 21);
            this.rb_HouseType.TabIndex = 0;
            this.rb_HouseType.TabStop = true;
            this.rb_HouseType.Text = "By House Type";
            this.rb_HouseType.UseVisualStyleBackColor = true;
            this.rb_HouseType.CheckedChanged += new System.EventHandler(this.rb_HouseType_CheckedChanged);
            // 
            // rb_Agent
            // 
            this.rb_Agent.AutoSize = true;
            this.rb_Agent.Location = new System.Drawing.Point(15, 74);
            this.rb_Agent.Name = "rb_Agent";
            this.rb_Agent.Size = new System.Drawing.Size(127, 21);
            this.rb_Agent.TabIndex = 1;
            this.rb_Agent.TabStop = true;
            this.rb_Agent.Text = "By Agent Name";
            this.rb_Agent.UseVisualStyleBackColor = true;
            this.rb_Agent.CheckedChanged += new System.EventHandler(this.rb_Agent_CheckedChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(544, 45);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(133, 41);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_SearchInfo
            // 
            this.cb_SearchInfo.FormattingEnabled = true;
            this.cb_SearchInfo.Location = new System.Drawing.Point(214, 54);
            this.cb_SearchInfo.Name = "cb_SearchInfo";
            this.cb_SearchInfo.Size = new System.Drawing.Size(272, 24);
            this.cb_SearchInfo.TabIndex = 4;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.dataSearch);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(12, 168);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(731, 270);
            this.gb1.TabIndex = 18;
            this.gb1.TabStop = false;
            this.gb1.Text = "Find Your Dream House :";
            // 
            // dataSearch
            // 
            this.dataSearch.AllowUserToAddRows = false;
            this.dataSearch.AllowUserToDeleteRows = false;
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.Location = new System.Drawing.Point(27, 38);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.ReadOnly = true;
            this.dataSearch.RowTemplate.Height = 24;
            this.dataSearch.Size = new System.Drawing.Size(675, 205);
            this.dataSearch.TabIndex = 0;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSearch";
            this.Text = "Remax - Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_SearchInfo;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.RadioButton rb_Agent;
        private System.Windows.Forms.RadioButton rb_HouseType;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.DataGridView dataSearch;
    }
}