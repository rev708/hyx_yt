namespace YT_Downloader
{
    partial class Donate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donate));
            pictureBox1 = new PictureBox();
            name = new Label();
            dt = new Label();
            label1 = new Label();
            btc_bt = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(509, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 218);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            name.ForeColor = Color.Blue;
            name.Location = new Point(11, 14);
            name.Name = "name";
            name.Size = new Size(249, 38);
            name.TabIndex = 1;
            name.Text = "Contact / Support";
            // 
            // dt
            // 
            dt.AutoSize = true;
            dt.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            dt.ForeColor = Color.Red;
            dt.Location = new Point(12, 118);
            dt.Name = "dt";
            dt.Size = new Size(358, 38);
            dt.TabIndex = 2;
            dt.Text = "❤️💕❤️ Donate ❤️💕💕";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 10F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(47, 63);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 3;
            label1.Text = "Telegram : @Rev708";
            // 
            // btc_bt
            // 
            btc_bt.BackColor = Color.LightGray;
            btc_bt.FlatAppearance.BorderSize = 0;
            btc_bt.FlatStyle = FlatStyle.Flat;
            btc_bt.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btc_bt.Location = new Point(35, 169);
            btc_bt.Name = "btc_bt";
            btc_bt.Size = new Size(447, 34);
            btc_bt.TabIndex = 4;
            btc_bt.Text = "Bitcoin : 1Pjz9dzPsLkbfDdvjqSxeqgJCLZSGxJJ2f";
            btc_bt.UseVisualStyleBackColor = false;
            btc_bt.Click += btc_bt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Location = new Point(4, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 1);
            panel1.TabIndex = 5;
            // 
            // Donate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 216);
            Controls.Add(panel1);
            Controls.Add(btc_bt);
            Controls.Add(label1);
            Controls.Add(dt);
            Controls.Add(name);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Donate";
            Text = "Donate pls.......";
            Load += donate_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label name;
        private Label dt;
        private Label label1;
        private Button btc_bt;
        private Panel panel1;
    }
}