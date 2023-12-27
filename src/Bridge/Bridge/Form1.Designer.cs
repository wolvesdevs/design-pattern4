namespace Bridge
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
            NameLabel = new Label();
            button1 = new Button();
            MeasureLabel = new Label();
            KandoLabel = new Label();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.BackColor = Color.White;
            NameLabel.BorderStyle = BorderStyle.FixedSingle;
            NameLabel.Font = new Font("Yu Gothic UI", 18F);
            NameLabel.Location = new Point(68, 53);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(298, 60);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 18F);
            button1.Location = new Point(68, 296);
            button1.Name = "button1";
            button1.Size = new Size(197, 69);
            button1.TabIndex = 10;
            button1.Text = "温度";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MeasureLabel
            // 
            MeasureLabel.BackColor = Color.White;
            MeasureLabel.BorderStyle = BorderStyle.FixedSingle;
            MeasureLabel.Font = new Font("Yu Gothic UI", 18F);
            MeasureLabel.Location = new Point(68, 125);
            MeasureLabel.Name = "MeasureLabel";
            MeasureLabel.Size = new Size(298, 60);
            MeasureLabel.TabIndex = 4;
            MeasureLabel.Text = "label2";
            // 
            // KandoLabel
            // 
            KandoLabel.BackColor = Color.White;
            KandoLabel.BorderStyle = BorderStyle.FixedSingle;
            KandoLabel.Font = new Font("Yu Gothic UI", 18F);
            KandoLabel.Location = new Point(68, 198);
            KandoLabel.Name = "KandoLabel";
            KandoLabel.Size = new Size(298, 60);
            KandoLabel.TabIndex = 5;
            KandoLabel.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 520);
            Controls.Add(KandoLabel);
            Controls.Add(MeasureLabel);
            Controls.Add(button1);
            Controls.Add(NameLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label NameLabel;
        private Button button1;
        private Label MeasureLabel;
        private Label KandoLabel;
    }
}
