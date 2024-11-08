namespace Am_I_Positive
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
            this.integerLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.integerInput = new System.Windows.Forms.TextBox();
            this.integerOutput = new System.Windows.Forms.Label();
            this.divisibleOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integerLabel
            // 
            this.integerLabel.AutoSize = true;
            this.integerLabel.Location = new System.Drawing.Point(149, 88);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Size = new System.Drawing.Size(82, 13);
            this.integerLabel.TabIndex = 0;
            this.integerLabel.Text = "Input an Integer";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(240, 136);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // integerInput
            // 
            this.integerInput.Location = new System.Drawing.Point(251, 88);
            this.integerInput.Name = "integerInput";
            this.integerInput.Size = new System.Drawing.Size(100, 20);
            this.integerInput.TabIndex = 2;
            // 
            // integerOutput
            // 
            this.integerOutput.AutoSize = true;
            this.integerOutput.Location = new System.Drawing.Point(159, 207);
            this.integerOutput.Name = "integerOutput";
            this.integerOutput.Size = new System.Drawing.Size(0, 13);
            this.integerOutput.TabIndex = 3;
            // 
            // divisibleOutput
            // 
            this.divisibleOutput.AutoSize = true;
            this.divisibleOutput.Location = new System.Drawing.Point(149, 293);
            this.divisibleOutput.Name = "divisibleOutput";
            this.divisibleOutput.Size = new System.Drawing.Size(0, 13);
            this.divisibleOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.divisibleOutput);
            this.Controls.Add(this.integerOutput);
            this.Controls.Add(this.integerInput);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.integerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox integerInput;
        private System.Windows.Forms.Label integerOutput;
        private System.Windows.Forms.Label divisibleOutput;
    }
}

