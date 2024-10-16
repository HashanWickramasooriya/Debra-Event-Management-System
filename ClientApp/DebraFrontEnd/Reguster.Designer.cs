namespace DebraFrontEnd
{
    partial class Reguster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reguster));
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(291, 346);
            button2.Name = "button2";
            button2.Size = new Size(211, 51);
            button2.TabIndex = 13;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Navy;
            textBox2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(362, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 44);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Navy;
            textBox1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(362, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 44);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(210, 198);
            label3.Name = "label3";
            label3.Size = new Size(73, 27);
            label3.TabIndex = 10;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(202, 126);
            label2.Name = "label2";
            label2.Size = new Size(81, 27);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(247, 27);
            label1.Name = "label1";
            label1.Size = new Size(321, 47);
            label1.TabIndex = 8;
            label1.Text = "Partner Register";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Navy;
            textBox3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(362, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 44);
            textBox3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(166, 273);
            label4.Name = "label4";
            label4.Size = new Size(115, 27);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // Reguster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Reguster";
            Text = "Reguster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
    }
}