namespace DDDCom
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
            textBox1 = new TextBox();
            MeasureButton = new Button();
            listBox1 = new ListBox();
            XORCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 18F);
            textBox1.Location = new Point(36, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 55);
            textBox1.TabIndex = 0;
            // 
            // MeasureButton
            // 
            MeasureButton.Font = new Font("Yu Gothic UI", 18F);
            MeasureButton.Location = new Point(36, 103);
            MeasureButton.Name = "MeasureButton";
            MeasureButton.Size = new Size(306, 67);
            MeasureButton.TabIndex = 1;
            MeasureButton.Text = "measure";
            MeasureButton.UseVisualStyleBackColor = true;
            MeasureButton.Click += MeasureButton_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Yu Gothic UI", 18F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 48;
            listBox1.Location = new Point(36, 192);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(842, 292);
            listBox1.TabIndex = 2;
            // 
            // XORCheckBox
            // 
            XORCheckBox.AutoSize = true;
            XORCheckBox.Font = new Font("Yu Gothic UI", 18F);
            XORCheckBox.Location = new Point(463, 30);
            XORCheckBox.Name = "XORCheckBox";
            XORCheckBox.Size = new Size(154, 52);
            XORCheckBox.TabIndex = 3;
            XORCheckBox.Text = "暗号化";
            XORCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 503);
            Controls.Add(XORCheckBox);
            Controls.Add(listBox1);
            Controls.Add(MeasureButton);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button MeasureButton;
        private ListBox listBox1;
        private CheckBox XORCheckBox;
    }
}
