namespace WindowsFormsApplication1
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
            this.runTest = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runTest
            // 
            this.runTest.Location = new System.Drawing.Point(332, 398);
            this.runTest.Name = "runTest";
            this.runTest.Size = new System.Drawing.Size(75, 23);
            this.runTest.TabIndex = 0;
            this.runTest.Text = "Run Test";
            this.runTest.UseVisualStyleBackColor = true;
            this.runTest.Click += new System.EventHandler(this.runTest_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(81, 130);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(37, 13);
            this.resultLbl.TabIndex = 1;
            this.resultLbl.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 433);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.runTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runTest;
        private System.Windows.Forms.Label resultLbl;
    }
}

