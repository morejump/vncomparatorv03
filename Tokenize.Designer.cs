namespace vnComparatorV03
{
    partial class Tokenize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tokenize));
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSencond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblSimilarity = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bcgProcess = new System.ComponentModel.BackgroundWorker();
            this.progressPanel01 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(146, 19);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(536, 20);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.Tag = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Sentence";
            // 
            // txtSencond
            // 
            this.txtSencond.Location = new System.Drawing.Point(146, 57);
            this.txtSencond.Name = "txtSencond";
            this.txtSencond.Size = new System.Drawing.Size(536, 20);
            this.txtSencond.TabIndex = 0;
            this.txtSencond.Tag = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sencond Sentence";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(146, 92);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(81, 28);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Tag = "2";
            this.btnCompare.Text = "Get Similarity";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblSimilarity
            // 
            this.lblSimilarity.AutoSize = true;
            this.lblSimilarity.Location = new System.Drawing.Point(490, 107);
            this.lblSimilarity.Name = "lblSimilarity";
            this.lblSimilarity.Size = new System.Drawing.Size(138, 13);
            this.lblSimilarity.TabIndex = 4;
            this.lblSimilarity.Text = "Teo nua hien ket qua o day";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(256, 92);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 28);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Tag = "3";
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // bcgProcess
            // 
           // this.bcgProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bcgProcess_DoWork);
          //  this.bcgProcess.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bcgProcess_ProgressChanged);
          //  this.bcgProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bcgProcess_RunWorkerCompleted);
            // 
            // progressPanel01
            // 
            this.progressPanel01.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel01.Appearance.Options.UseBackColor = true;
            this.progressPanel01.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel01.AppearanceCaption.Options.UseFont = true;
            this.progressPanel01.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel01.AppearanceDescription.Options.UseFont = true;
            this.progressPanel01.Location = new System.Drawing.Point(146, 156);
            this.progressPanel01.Name = "progressPanel01";
            this.progressPanel01.Size = new System.Drawing.Size(246, 66);
            this.progressPanel01.TabIndex = 6;
            this.progressPanel01.Text = "progressPanel1";
            // 
            // Tokenize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vnComparatorV03.Properties.Resources._4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(747, 273);
            this.Controls.Add(this.progressPanel01);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSimilarity);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSencond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirst);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tokenize";
            this.Text = "vnComparatorV03 by Luu Thao";
            this.Load += new System.EventHandler(this.Tokenize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSencond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblSimilarity;
        private System.Windows.Forms.Button btnRefresh;
        private System.ComponentModel.BackgroundWorker bcgProcess;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel01;
    }
}

