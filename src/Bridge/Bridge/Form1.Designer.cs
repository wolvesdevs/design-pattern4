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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            BatteryLevelLabel = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SunLevelLabel = new Label();
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
            button1.Size = new Size(257, 69);
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
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 18F);
            button2.Location = new Point(331, 296);
            button2.Name = "button2";
            button2.Size = new Size(257, 69);
            button2.TabIndex = 11;
            button2.Text = "風力";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 18F);
            button3.Location = new Point(331, 385);
            button3.Name = "button3";
            button3.Size = new Size(257, 69);
            button3.TabIndex = 13;
            button3.Text = "風力バッテリー";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Yu Gothic UI", 18F);
            button4.Location = new Point(68, 385);
            button4.Name = "button4";
            button4.Size = new Size(257, 69);
            button4.TabIndex = 12;
            button4.Text = "温度バッテリー";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // BatteryLevelLabel
            // 
            BatteryLevelLabel.BackColor = Color.White;
            BatteryLevelLabel.BorderStyle = BorderStyle.FixedSingle;
            BatteryLevelLabel.Font = new Font("Yu Gothic UI", 18F);
            BatteryLevelLabel.Location = new Point(372, 198);
            BatteryLevelLabel.Name = "BatteryLevelLabel";
            BatteryLevelLabel.Size = new Size(298, 60);
            BatteryLevelLabel.TabIndex = 14;
            BatteryLevelLabel.Text = "label3";
            // 
            // button5
            // 
            button5.Font = new Font("Yu Gothic UI", 18F);
            button5.Location = new Point(598, 385);
            button5.Name = "button5";
            button5.Size = new Size(309, 69);
            button5.TabIndex = 16;
            button5.Text = "温度予測バッテリー";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Yu Gothic UI", 18F);
            button6.Location = new Point(598, 296);
            button6.Name = "button6";
            button6.Size = new Size(309, 69);
            button6.TabIndex = 15;
            button6.Text = "温度予測";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Yu Gothic UI", 18F);
            button7.Location = new Point(598, 474);
            button7.Name = "button7";
            button7.Size = new Size(309, 69);
            button7.TabIndex = 19;
            button7.Text = "温度予測太陽光";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Yu Gothic UI", 18F);
            button8.Location = new Point(331, 474);
            button8.Name = "button8";
            button8.Size = new Size(257, 69);
            button8.TabIndex = 18;
            button8.Text = "風力太陽光";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Yu Gothic UI", 18F);
            button9.Location = new Point(68, 474);
            button9.Name = "button9";
            button9.Size = new Size(257, 69);
            button9.TabIndex = 17;
            button9.Text = "温度太陽光";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // SunLevelLabel
            // 
            SunLevelLabel.BackColor = Color.White;
            SunLevelLabel.BorderStyle = BorderStyle.FixedSingle;
            SunLevelLabel.Font = new Font("Yu Gothic UI", 18F);
            SunLevelLabel.Location = new Point(676, 198);
            SunLevelLabel.Name = "SunLevelLabel";
            SunLevelLabel.Size = new Size(298, 60);
            SunLevelLabel.TabIndex = 20;
            SunLevelLabel.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 579);
            Controls.Add(SunLevelLabel);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(BatteryLevelLabel);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Label BatteryLevelLabel;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label SunLevelLabel;
    }
}
