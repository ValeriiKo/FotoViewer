namespace FotoViewer
{
    partial class fFotoViewer
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
            this.lbFV = new System.Windows.Forms.ListBox();
            this.folderBrowserDialogFV = new System.Windows.Forms.FolderBrowserDialog();
            this.pbFV = new System.Windows.Forms.PictureBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFV
            // 
            this.lbFV.FormattingEnabled = true;
            this.lbFV.Location = new System.Drawing.Point(12, 65);
            this.lbFV.Name = "lbFV";
            this.lbFV.Size = new System.Drawing.Size(120, 459);
            this.lbFV.TabIndex = 0;
            this.lbFV.SelectedIndexChanged += new System.EventHandler(this.lbFV_SelectedIndexChanged);
            // 
            // pbFV
            // 
            this.pbFV.Location = new System.Drawing.Point(164, 65);
            this.pbFV.Name = "pbFV";
            this.pbFV.Size = new System.Drawing.Size(662, 459);
            this.pbFV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFV.TabIndex = 1;
            this.pbFV.TabStop = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(13, 13);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 13);
            this.lblPath.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 542);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(121, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Открыть папку";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(207, 542);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(105, 23);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "Предыдущее";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(429, 542);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Следующее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // fFotoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(867, 580);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.pbFV);
            this.Controls.Add(this.lbFV);
            this.Name = "fFotoViewer";
            this.Text = "FotoViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pbFV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFV;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogFV;
        private System.Windows.Forms.PictureBox pbFV;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
    }
}

