namespace DebraFrontEnd
{
    partial class SellTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellTicket));
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(278, 276);
            button2.Name = "button2";
            button2.Size = new Size(211, 51);
            button2.TabIndex = 29;
            button2.Text = "Sell";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Navy;
            textBox2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(381, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 44);
            textBox2.TabIndex = 28;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Navy;
            textBox1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(381, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 44);
            textBox1.TabIndex = 27;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(141, 184);
            label3.Name = "label3";
            label3.Size = new Size(150, 27);
            label3.TabIndex = 26;
            label3.Text = "Commission";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(182, 112);
            label2.Name = "label2";
            label2.Size = new Size(106, 27);
            label2.TabIndex = 25;
            label2.Text = "Ticket ID";
            // 
            // SellTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "SellTicket";
            Text = "SellTicket";
            Load += SellTicket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
    }
}