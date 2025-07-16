namespace Variable
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
            btnInt = new Button();
            btnDouble = new Button();
            btnString = new Button();
            lbResult = new Label();
            SuspendLayout();
            // 
            // btnInt
            // 
            btnInt.Location = new Point(133, 97);
            btnInt.Name = "btnInt";
            btnInt.Size = new Size(94, 29);
            btnInt.TabIndex = 0;
            btnInt.Text = "정수형출력";
            btnInt.UseVisualStyleBackColor = true;
            btnInt.Click += btnInt_Click;
            // 
            // btnDouble
            // 
            btnDouble.Location = new Point(133, 152);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(94, 29);
            btnDouble.TabIndex = 1;
            btnDouble.Text = "실수형출력";
            btnDouble.UseVisualStyleBackColor = true;
            btnDouble.Click += btnDouble_Click;
            // 
            // btnString
            // 
            btnString.Location = new Point(133, 215);
            btnString.Name = "btnString";
            btnString.Size = new Size(94, 29);
            btnString.TabIndex = 2;
            btnString.Text = "문자열출력";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(437, 161);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(39, 20);
            lbResult.TabIndex = 3;
            lbResult.Text = "결과";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResult);
            Controls.Add(btnString);
            Controls.Add(btnDouble);
            Controls.Add(btnInt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInt;
        private Button btnDouble;
        private Button btnString;
        private Label lbResult;
    }
}
