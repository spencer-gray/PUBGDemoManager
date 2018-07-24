namespace PUBGDemoManager
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelReplays = new System.Windows.Forms.Label();
            this.buttonDlt = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelBackups = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.ColumnSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSelected2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDIR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSelected,
            this.ColumnDIR,
            this.ColumnDate,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(63, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(504, 495);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelReplays
            // 
            this.labelReplays.AutoSize = true;
            this.labelReplays.BackColor = System.Drawing.Color.Transparent;
            this.labelReplays.Location = new System.Drawing.Point(60, 38);
            this.labelReplays.Name = "labelReplays";
            this.labelReplays.Size = new System.Drawing.Size(48, 13);
            this.labelReplays.TabIndex = 1;
            this.labelReplays.Text = "Replays:";
            // 
            // buttonDlt
            // 
            this.buttonDlt.ForeColor = System.Drawing.Color.Crimson;
            this.buttonDlt.Location = new System.Drawing.Point(601, 468);
            this.buttonDlt.Name = "buttonDlt";
            this.buttonDlt.Size = new System.Drawing.Size(93, 44);
            this.buttonDlt.TabIndex = 3;
            this.buttonDlt.Text = "Delete";
            this.buttonDlt.UseVisualStyleBackColor = true;
            this.buttonDlt.Click += new System.EventHandler(this.buttonDlt_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBackup.Location = new System.Drawing.Point(601, 250);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(93, 44);
            this.buttonBackup.TabIndex = 3;
            this.buttonBackup.Text = "Backup -->";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRefresh.Location = new System.Drawing.Point(601, 188);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(93, 44);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelBackups
            // 
            this.labelBackups.AutoSize = true;
            this.labelBackups.BackColor = System.Drawing.Color.Transparent;
            this.labelBackups.Location = new System.Drawing.Point(727, 38);
            this.labelBackups.Name = "labelBackups";
            this.labelBackups.Size = new System.Drawing.Size(52, 13);
            this.labelBackups.TabIndex = 5;
            this.labelBackups.Text = "Backups:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSelected2,
            this.ColumnDIR2,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(730, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(495, 495);
            this.dataGridView2.TabIndex = 6;
            // 
            // buttonLoad
            // 
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoad.Location = new System.Drawing.Point(601, 339);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(93, 44);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "<-- Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // ColumnSelected
            // 
            this.ColumnSelected.HeaderText = "Selected";
            this.ColumnSelected.Name = "ColumnSelected";
            this.ColumnSelected.Width = 40;
            // 
            // ColumnDIR
            // 
            this.ColumnDIR.HeaderText = "Directory";
            this.ColumnDIR.Name = "ColumnDIR";
            this.ColumnDIR.Width = 140;
            // 
            // ColumnDate
            // 
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Length";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Map";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mode";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Rank";
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // ColumnSelected2
            // 
            this.ColumnSelected2.HeaderText = "Selected";
            this.ColumnSelected2.Name = "ColumnSelected2";
            this.ColumnSelected2.Width = 40;
            // 
            // ColumnDIR2
            // 
            this.ColumnDIR2.HeaderText = "Directory";
            this.ColumnDIR2.Name = "ColumnDIR2";
            this.ColumnDIR2.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Length";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Map";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Mode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 623);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelBackups);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.buttonDlt);
            this.Controls.Add(this.labelReplays);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "DemoSaver";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelReplays;
        private System.Windows.Forms.Button buttonDlt;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelBackups;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelected2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDIR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

