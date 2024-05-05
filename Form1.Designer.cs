namespace WinFormsApp7
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
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            monthCalendar1 = new MonthCalendar();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            photoFlowLayout = new FlowLayoutPanel();
            LocationsBox = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(118, 41);
            button1.TabIndex = 0;
            button1.Text = "Open file";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "date", "location" });
            checkedListBox1.Location = new Point(22, 478);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 70);
            checkedListBox1.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(1106, 341);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(22, 567);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Go";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1171, 565);
            button3.Name = "button3";
            button3.Size = new Size(125, 31);
            button3.TabIndex = 6;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 443);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 7;
            label1.Text = "Search by:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1106, 95);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 8;
            label2.Text = "Choose Location:";
            // 
            // photoFlowLayout
            // 
            photoFlowLayout.Location = new Point(209, 12);
            photoFlowLayout.Name = "photoFlowLayout";
            photoFlowLayout.Size = new Size(854, 584);
            photoFlowLayout.TabIndex = 9;
            // 
            // LocationsBox
            // 
            LocationsBox.FormattingEnabled = true;
            LocationsBox.Items.AddRange(new object[] { "NYC", "UAE", "EGY", "SKR" });
            LocationsBox.Location = new Point(1106, 135);
            LocationsBox.Name = "LocationsBox";
            LocationsBox.Size = new Size(151, 28);
            LocationsBox.TabIndex = 10;
            LocationsBox.SelectedIndexChanged += LocationsBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 633);
            Controls.Add(LocationsBox);
            Controls.Add(photoFlowLayout);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(monthCalendar1);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckedListBox checkedListBox1;
        private MonthCalendar monthCalendar1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel photoFlowLayout;
        private ComboBox LocationsBox;
    }
}
