namespace regExp
{
    partial class FormMainScreen
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
            this.buttonLog_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLog_in
            // 
            this.buttonLog_in.Location = new System.Drawing.Point(165, 100);
            this.buttonLog_in.Name = "buttonLog_in";
            this.buttonLog_in.Size = new System.Drawing.Size(117, 38);
            this.buttonLog_in.TabIndex = 0;
            this.buttonLog_in.Text = "Log in";
            this.buttonLog_in.UseVisualStyleBackColor = true;
            this.buttonLog_in.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 283);
            this.Controls.Add(this.buttonLog_in);
            this.Name = "FormMainScreen";
            this.Text = "Main App Screen";
            this.Load += new System.EventHandler(this.FormMainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLog_in;
    }
}

