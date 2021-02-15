namespace prjWinCsRemax
{
    partial class frmAgentData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgentData));
            this.dataAgents = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAgents)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataAgents
            // 
            this.dataAgents.AllowUserToAddRows = false;
            this.dataAgents.AllowUserToDeleteRows = false;
            this.dataAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAgents.Location = new System.Drawing.Point(18, 27);
            this.dataAgents.Name = "dataAgents";
            this.dataAgents.ReadOnly = true;
            this.dataAgents.RowTemplate.Height = 24;
            this.dataAgents.Size = new System.Drawing.Size(740, 205);
            this.dataAgents.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(373, 349);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(162, 56);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "&Delete Agent";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(210, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 56);
            this.button1.TabIndex = 19;
            this.button1.Text = "&Edit Agent";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(50, 349);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(142, 56);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "&Add Agent";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.dataAgents);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(50, 45);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(776, 248);
            this.gb1.TabIndex = 17;
            this.gb1.TabStop = false;
            this.gb1.Text = "Agents :";
            // 
            // frmAgentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 456);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgentData";
            this.Text = "Remax - Agents";
            this.Load += new System.EventHandler(this.frmAgentData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAgents)).EndInit();
            this.gb1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAgents;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox gb1;
    }
}