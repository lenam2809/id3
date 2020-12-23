namespace Decision_Tree_ID3
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateBest_ID3 = new System.Windows.Forms.Button();
            this.btnOpenExcelSource = new System.Windows.Forms.Button();
            this.dataGridViewClauses = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kiemTra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClauses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(339, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "CÂY QUYẾT ĐỊNH ID3";
            // 
            // btnCreateBest_ID3
            // 
            this.btnCreateBest_ID3.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateBest_ID3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBest_ID3.FlatAppearance.BorderSize = 0;
            this.btnCreateBest_ID3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCreateBest_ID3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateBest_ID3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateBest_ID3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBest_ID3.ForeColor = System.Drawing.Color.Black;
            this.btnCreateBest_ID3.Location = new System.Drawing.Point(342, 508);
            this.btnCreateBest_ID3.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateBest_ID3.Name = "btnCreateBest_ID3";
            this.btnCreateBest_ID3.Size = new System.Drawing.Size(342, 58);
            this.btnCreateBest_ID3.TabIndex = 4;
            this.btnCreateBest_ID3.Text = ">>View Best Decision Tree<<";
            this.btnCreateBest_ID3.UseVisualStyleBackColor = false;
            this.btnCreateBest_ID3.Click += new System.EventHandler(this.btnCreateBest_ID3_Click);
            // 
            // btnOpenExcelSource
            // 
            this.btnOpenExcelSource.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenExcelSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenExcelSource.FlatAppearance.BorderSize = 0;
            this.btnOpenExcelSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnOpenExcelSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenExcelSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenExcelSource.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenExcelSource.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpenExcelSource.Location = new System.Drawing.Point(387, 3);
            this.btnOpenExcelSource.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenExcelSource.Name = "btnOpenExcelSource";
            this.btnOpenExcelSource.Size = new System.Drawing.Size(159, 34);
            this.btnOpenExcelSource.TabIndex = 6;
            this.btnOpenExcelSource.TabStop = false;
            this.btnOpenExcelSource.Text = "Open Excel Source";
            this.btnOpenExcelSource.UseVisualStyleBackColor = false;
            this.btnOpenExcelSource.Click += new System.EventHandler(this.btnOpenExcelSource_Click);
            // 
            // dataGridViewClauses
            // 
            this.dataGridViewClauses.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewClauses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClauses.Location = new System.Drawing.Point(16, 161);
            this.dataGridViewClauses.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClauses.Name = "dataGridViewClauses";
            this.dataGridViewClauses.RowHeadersWidth = 51;
            this.dataGridViewClauses.Size = new System.Drawing.Size(952, 342);
            this.dataGridViewClauses.TabIndex = 3;
            this.dataGridViewClauses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClauses_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOpenExcelSource);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(16, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 43);
            this.panel1.TabIndex = 5;
            // 
            // kiemTra
            // 
            this.kiemTra.BackColor = System.Drawing.SystemColors.GrayText;
            this.kiemTra.Location = new System.Drawing.Point(16, 522);
            this.kiemTra.Name = "kiemTra";
            this.kiemTra.Size = new System.Drawing.Size(103, 33);
            this.kiemTra.TabIndex = 8;
            this.kiemTra.Text = "<<BACK";
            this.kiemTra.UseVisualStyleBackColor = false;
            this.kiemTra.Click += new System.EventHandler(this.kiemTra_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 567);
            this.Controls.Add(this.kiemTra);
            this.Controls.Add(this.dataGridViewClauses);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateBest_ID3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClauses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateBest_ID3;
        private System.Windows.Forms.Button btnOpenExcelSource;
        private System.Windows.Forms.DataGridView dataGridViewClauses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kiemTra;
    }
}

