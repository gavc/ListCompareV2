namespace ListCompareV2
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            btnClearA = new Button();
            btnClearB = new Button();
            btnExecute = new Button();
            comboBoxOperations = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(12, 55);
            textBoxA.Multiline = true;
            textBoxA.Name = "textBoxA";
            textBoxA.ScrollBars = ScrollBars.Vertical;
            textBoxA.Size = new Size(384, 780);
            textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(442, 55);
            textBoxB.Multiline = true;
            textBoxB.Name = "textBoxB";
            textBoxB.ScrollBars = ScrollBars.Vertical;
            textBoxB.Size = new Size(384, 780);
            textBoxB.TabIndex = 1;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(872, 55);
            textBoxC.Multiline = true;
            textBoxC.Name = "textBoxC";
            textBoxC.ScrollBars = ScrollBars.Vertical;
            textBoxC.Size = new Size(384, 780);
            textBoxC.TabIndex = 2;
            // 
            // btnClearA
            // 
            btnClearA.Location = new Point(246, 841);
            btnClearA.Name = "btnClearA";
            btnClearA.Size = new Size(150, 46);
            btnClearA.TabIndex = 3;
            btnClearA.Text = "Clear";
            btnClearA.UseVisualStyleBackColor = true;
            btnClearA.Click += btnClearA_Click;
            // 
            // btnClearB
            // 
            btnClearB.Location = new Point(676, 841);
            btnClearB.Name = "btnClearB";
            btnClearB.Size = new Size(150, 46);
            btnClearB.TabIndex = 4;
            btnClearB.Text = "Clear";
            btnClearB.UseVisualStyleBackColor = true;
            btnClearB.Click += btnClearB_Click;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(1056, 909);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(200, 46);
            btnExecute.TabIndex = 6;
            btnExecute.Text = "Run";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click_1;
            // 
            // comboBoxOperations
            // 
            comboBoxOperations.FormattingEnabled = true;
            comboBoxOperations.Location = new Point(620, 913);
            comboBoxOperations.Name = "comboBoxOperations";
            comboBoxOperations.Size = new Size(430, 40);
            comboBoxOperations.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 8;
            label1.Text = "List A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 20);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 9;
            label2.Text = "List B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(872, 20);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 10;
            label3.Text = "Results";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 967);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxOperations);
            Controls.Add(btnExecute);
            Controls.Add(btnClearB);
            Controls.Add(btnClearA);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Listdotnet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Button btnClearA;
        private Button btnClearB;
        private Button btnExecute;
        private ComboBox comboBoxOperations;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
