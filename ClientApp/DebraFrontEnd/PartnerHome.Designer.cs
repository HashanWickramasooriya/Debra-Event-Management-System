namespace DebraFrontEnd
{
    partial class PartnerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerHome));
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(437, 275);
            button2.Name = "button2";
            button2.Size = new Size(250, 72);
            button2.TabIndex = 15;
            button2.Text = "Earnings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(254, 56);
            label1.Name = "label1";
            label1.Size = new Size(284, 47);
            label1.TabIndex = 12;
            label1.Text = "Partner Home";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(119, 156);
            button1.Name = "button1";
            button1.Size = new Size(250, 72);
            button1.TabIndex = 16;
            button1.Text = "Add Events";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(437, 156);
            button3.Name = "button3";
            button3.Size = new Size(250, 72);
            button3.TabIndex = 17;
            button3.Text = "Add Tickets";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(119, 275);
            button4.Name = "button4";
            button4.Size = new Size(250, 72);
            button4.TabIndex = 18;
            button4.Text = "Sell Tickets";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // PartnerHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "PartnerHome";
            Text = "PartnerHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}