namespace prjWinCsRemax
{
    partial class frmHouseData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHouseData));
            this.dataHouses = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataHouses)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataHouses
            // 
            this.dataHouses.AllowUserToAddRows = false;
            this.dataHouses.AllowUserToDeleteRows = false;
            this.dataHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHouses.Location = new System.Drawing.Point(50, 50);
            this.dataHouses.Name = "dataHouses";
            this.dataHouses.ReadOnly = true;
            this.dataHouses.RowTemplate.Height = 24;
            this.dataHouses.Size = new System.Drawing.Size(801, 205);
            this.dataHouses.TabIndex = 0;
            this.dataHouses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHouses_CellContentClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(345, 349);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(162, 56);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "&Delete House";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(182, 349);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(142, 56);
            this.btn_Edit.TabIndex = 19;
            this.btn_Edit.Text = "&Edit House";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(22, 349);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(142, 56);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "&Add House";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.dataHouses);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(22, 45);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(830, 270);
            this.gb1.TabIndex = 17;
            this.gb1.TabStop = false;
            this.gb1.Text = "Beautiful Houses :";
            // 
            // frmHouseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gb1);
            this.Name = "frmHouseData";
            this.Text = "frmHouseData";
            this.Load += new System.EventHandler(this.frmHouseData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHouses)).EndInit();
            this.gb1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHouses;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox gb1;
    }
}