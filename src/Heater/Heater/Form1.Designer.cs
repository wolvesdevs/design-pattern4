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
            DownButton = new Button();
            OnOffButton = new Button();
            SuspendLayout();
            // 
            // DisplayLabel
            // 
            DisplayLabel.BackColor = Color.White;
            DisplayLabel.BorderStyle = BorderStyle.FixedSingle;
            DisplayLabel.Font = new Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayLabel.ForeColor = Color.Purple;
            DisplayLabel.Location = new Point(125, 103);
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
            // DownButton
            // 
            DownButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DownButton.Location = new Point(304, 322);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(226, 76);
            DownButton.TabIndex = 2;
            DownButton.Text = "Down";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // OnOffButton
            // 
            OnOffButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            OnOffButton.Location = new Point(21, 12);
            OnOffButton.Name = "OnOffButton";
            OnOffButton.Size = new Size(226, 76);
            OnOffButton.TabIndex = 3;
            OnOffButton.Text = "ON/OFF";
            OnOffButton.UseVisualStyleBackColor = true;
            OnOffButton.Click += OnOffButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OnOffButton);
            Controls.Add(DownButton);
            Controls.Add(UpButton);
            Controls.Add(DisplayLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label DisplayLabel;
        private Button UpButton;
        private Button DownButton;
        private Button OnOffButton;
    }
}