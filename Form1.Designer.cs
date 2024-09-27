namespace DebuggingDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPrincipal = new TextBox();
            textBoxInterestRate = new TextBox();
            labelPrincipal = new Label();
            labelInterestRate = new Label();
            labelOutput = new Label();
            buttonShow = new Button();
            SuspendLayout();
            // 
            // textBoxPrincipal
            // 
            textBoxPrincipal.Location = new Point(428, 88);
            textBoxPrincipal.Name = "textBoxPrincipal";
            textBoxPrincipal.Size = new Size(175, 35);
            textBoxPrincipal.TabIndex = 0;
            // 
            // textBoxInterestRate
            // 
            textBoxInterestRate.Location = new Point(428, 181);
            textBoxInterestRate.Name = "textBoxInterestRate";
            textBoxInterestRate.Size = new Size(175, 35);
            textBoxInterestRate.TabIndex = 1;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Location = new Point(39, 93);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(330, 30);
            labelPrincipal.TabIndex = 2;
            labelPrincipal.Text = "Please enter the principal amount:";
            // 
            // labelInterestRate
            // 
            labelInterestRate.AutoSize = true;
            labelInterestRate.Location = new Point(104, 186);
            labelInterestRate.Name = "labelInterestRate";
            labelInterestRate.Size = new Size(265, 30);
            labelInterestRate.TabIndex = 3;
            labelInterestRate.Text = "Please enter intereset rate: ";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(356, 295);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 30);
            labelOutput.TabIndex = 4;
            labelOutput.Click += label3_Click;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(327, 252);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(193, 40);
            buttonShow.TabIndex = 5;
            buttonShow.Text = "Show Income";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShow);
            Controls.Add(labelOutput);
            Controls.Add(labelInterestRate);
            Controls.Add(labelPrincipal);
            Controls.Add(textBoxInterestRate);
            Controls.Add(textBoxPrincipal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPrincipal;
        private TextBox textBoxInterestRate;
        private Label labelPrincipal;
        private Label labelInterestRate;
        private Label labelOutput;
        private Button buttonShow;
    }
}
