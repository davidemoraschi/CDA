namespace CDA
{
    partial class frm_CDA
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
            this.btn_SUBMIT = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.txt_NADMI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_SUBMIT
            // 
            this.btn_SUBMIT.Location = new System.Drawing.Point(12, 38);
            this.btn_SUBMIT.Name = "btn_SUBMIT";
            this.btn_SUBMIT.Size = new System.Drawing.Size(100, 38);
            this.btn_SUBMIT.TabIndex = 0;
            this.btn_SUBMIT.Text = "Submit";
            this.btn_SUBMIT.UseVisualStyleBackColor = true;
            this.btn_SUBMIT.Click += new System.EventHandler(this.btn_SUBMIT_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(12, 82);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(167, 174);
            this.txt_Result.TabIndex = 1;
            // 
            // txt_NADMI
            // 
            this.txt_NADMI.Location = new System.Drawing.Point(12, 12);
            this.txt_NADMI.Name = "txt_NADMI";
            this.txt_NADMI.Size = new System.Drawing.Size(100, 20);
            this.txt_NADMI.TabIndex = 2;
            this.txt_NADMI.Text = "760842";
            // 
            // frm_CDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 268);
            this.Controls.Add(this.txt_NADMI);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_SUBMIT);
            this.Name = "frm_CDA";
            this.Text = "CDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SUBMIT;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.TextBox txt_NADMI;
    }
}

