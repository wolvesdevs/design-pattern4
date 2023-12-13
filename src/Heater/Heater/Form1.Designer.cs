namespace Heater
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
            DisplayLabel = new Label();
            UpButton = new Button();
            SuspendLayout();
            // 
            // DisplayLabel
            // 
            DisplayLabel.BackColor = Color.White;
            DisplayLabel.BorderStyle = BorderStyle.FixedSingle;
            DisplayLabel.Font = new Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayLabel.ForeColor = Color.Purple;
            DisplayLabel.Location = new Point(125, 57);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(549, 125);
            DisplayLabel.TabIndex = 0;
            DisplayLabel.Text = "label1";
            DisplayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpButton
            // 
            UpButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UpButton.Location = new Point(304, 240);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(226, 76);
            UpButton.TabIndex = 1;
            UpButton.Text = "Up";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpButton);
            Controls.Add(DisplayLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label DisplayLabel;
        private Button UpButton;
    }
}