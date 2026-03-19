namespace CVMatcherApp
{
    partial class CVMatcherForm
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
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCVIput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCV
            // 
            this.txtCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCV.Location = new System.Drawing.Point(21, 67);
            this.txtCV.Multiline = true;
            this.txtCV.Name = "txtCV";
            this.txtCV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCV.Size = new System.Drawing.Size(152, 28);
            this.txtCV.TabIndex = 0;
            this.txtCV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.ForeColor = System.Drawing.Color.Black;
            this.txtJob.Location = new System.Drawing.Point(240, 67);
            this.txtJob.Multiline = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJob.Size = new System.Drawing.Size(157, 28);
            this.txtJob.TabIndex = 1;
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyse.ForeColor = System.Drawing.Color.White;
            this.btnAnalyse.Location = new System.Drawing.Point(158, 124);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(135, 63);
            this.btnAnalyse.TabIndex = 2;
            this.btnAnalyse.Text = "Analyse Match";
            this.btnAnalyse.UseVisualStyleBackColor = false;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResult.Location = new System.Drawing.Point(-3, 223);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(812, 229);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result will appear here";
            // 
            // lblCVIput
            // 
            this.lblCVIput.AutoSize = true;
            this.lblCVIput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCVIput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVIput.ForeColor = System.Drawing.Color.Black;
            this.lblCVIput.Location = new System.Drawing.Point(21, 38);
            this.lblCVIput.Name = "lblCVIput";
            this.lblCVIput.Size = new System.Drawing.Size(92, 26);
            this.lblCVIput.TabIndex = 4;
            this.lblCVIput.Text = "CV Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(240, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Job Description";
            // 
            // CVMatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCVIput);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtCV);
            this.Name = "CVMatcherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skill Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCVIput;
        private System.Windows.Forms.Label label2;
    }
}

