namespace DebraFrontEnd
{
    partial class AddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent));
            textBox3 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Navy;
            textBox3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(339, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(311, 44);
            textBox3.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(143, 286);
            label4.Name = "label4";
            label4.Size = new Size(109, 27);
            label4.TabIndex = 22;
            label4.Text = "Location";
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(281, 354);
            button2.Name = "button2";
            button2.Size = new Size(211, 51);
            button2.TabIndex = 21;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Navy;
            textBox1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(339, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 44);
            textBox1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(187, 211);
            label3.Name = "label3";
            label3.Size = new Size(65, 27);
            label3.TabIndex = 18;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(179, 139);
            label2.Name = "label2";
            label2.Size = new Size(81, 27);
            label2.TabIndex = 17;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(269, 34);
            label1.Name = "label1";
            label1.Size = new Size(279, 47);
            label1.TabIndex = 16;
            label1.Text = "Add an Event";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Navy;
            dateTimePicker1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(339, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(311, 44);
            dateTimePicker1.TabIndex = 24;
            // 
            // AddEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddEvent";
            Text = "AddEvent";
            Load += AddEvent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label4;
        private Button button2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}