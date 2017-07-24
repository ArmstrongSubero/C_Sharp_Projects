namespace SQL_Tester
{
    partial class frmSqlTester
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
            this.grdSQLTester = new System.Windows.Forms.DataGridView();
            this.txtSQLTester = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSQLTester)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSQLTester
            // 
            this.grdSQLTester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSQLTester.Location = new System.Drawing.Point(12, 12);
            this.grdSQLTester.Name = "grdSQLTester";
            this.grdSQLTester.Size = new System.Drawing.Size(471, 215);
            this.grdSQLTester.TabIndex = 0;
            this.grdSQLTester.TabStop = false;
            // 
            // txtSQLTester
            // 
            this.txtSQLTester.Location = new System.Drawing.Point(13, 233);
            this.txtSQLTester.Multiline = true;
            this.txtSQLTester.Name = "txtSQLTester";
            this.txtSQLTester.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSQLTester.Size = new System.Drawing.Size(316, 71);
            this.txtSQLTester.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(335, 233);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(147, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.TabStop = false;
            this.btnTest.Text = "Test SQL Statement";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(332, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Records Returned";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.BackColor = System.Drawing.SystemColors.Window;
            this.lblRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(448, 276);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(20, 22);
            this.lblRecords.TabIndex = 4;
            this.lblRecords.Text = "0";
            this.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSqlTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 316);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtSQLTester);
            this.Controls.Add(this.grdSQLTester);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSqlTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Tester";
            this.Load += new System.EventHandler(this.frmSqlTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSQLTester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSQLTester;
        private System.Windows.Forms.TextBox txtSQLTester;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecords;
    }
}

