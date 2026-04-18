namespace YT_Downloader;

partial class Main
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        txtUrl = new TextBox();
        txtPath = new TextBox();
        rbMp4 = new RadioButton();
        rbMp3 = new RadioButton();
        cmbQuality = new ComboBox();
        btnBrowse = new Button();
        btnDownload = new Button();
        progressBar = new ProgressBar();
        lblStatus = new Label();
        lblUrl = new Label();
        lblFmt = new Label();
        lblQuality = new Label();
        lblPath = new Label();
        ct_bt = new Button();
        SuspendLayout();
        // 
        // txtUrl
        // 
        txtUrl.BackColor = Color.Gainsboro;
        txtUrl.BorderStyle = BorderStyle.FixedSingle;
        txtUrl.Font = new Font("Segoe UI", 10.5F);
        txtUrl.ForeColor = Color.Black;
        txtUrl.Location = new Point(26, 54);
        txtUrl.Name = "txtUrl";
        txtUrl.Size = new Size(572, 35);
        txtUrl.TabIndex = 1;
        // 
        // txtPath
        // 
        txtPath.BackColor = Color.Gainsboro;
        txtPath.BorderStyle = BorderStyle.FixedSingle;
        txtPath.Font = new Font("Segoe UI", 10F);
        txtPath.ForeColor = Color.Black;
        txtPath.Location = new Point(26, 202);
        txtPath.Name = "txtPath";
        txtPath.Size = new Size(430, 34);
        txtPath.TabIndex = 8;
        txtPath.Text = "C:\\Users\\SH_DESKTOP\\Downloads";
        // 
        // rbMp4
        // 
        rbMp4.AutoSize = true;
        rbMp4.BackColor = Color.Transparent;
        rbMp4.Checked = true;
        rbMp4.Cursor = Cursors.Hand;
        rbMp4.ForeColor = Color.Black;
        rbMp4.Location = new Point(26, 132);
        rbMp4.Name = "rbMp4";
        rbMp4.Size = new Size(114, 32);
        rbMp4.TabIndex = 3;
        rbMp4.TabStop = true;
        rbMp4.Text = "🎬  MP4";
        rbMp4.UseVisualStyleBackColor = false;
        rbMp4.CheckedChanged += rbMp4_CheckedChanged;
        // 
        // rbMp3
        // 
        rbMp3.AutoSize = true;
        rbMp3.BackColor = Color.Transparent;
        rbMp3.Cursor = Cursors.Hand;
        rbMp3.ForeColor = Color.Black;
        rbMp3.Location = new Point(146, 132);
        rbMp3.Name = "rbMp3";
        rbMp3.Size = new Size(114, 32);
        rbMp3.TabIndex = 4;
        rbMp3.Text = "🎵  MP3";
        rbMp3.UseVisualStyleBackColor = false;
        // 
        // cmbQuality
        // 
        cmbQuality.BackColor = Color.Gainsboro;
        cmbQuality.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbQuality.FlatStyle = FlatStyle.Flat;
        cmbQuality.Font = new Font("Segoe UI", 10F);
        cmbQuality.ForeColor = Color.Black;
        cmbQuality.Items.AddRange(new object[] { "최고화질", "8K (4320p)", "4K (2160p)", "1080p", "720p", "480p", "360p" });
        cmbQuality.Location = new Point(376, 128);
        cmbQuality.Name = "cmbQuality";
        cmbQuality.Size = new Size(220, 36);
        cmbQuality.TabIndex = 6;
        cmbQuality.SelectedIndex = 0;
        // 
        // btnBrowse
        // 
        btnBrowse.BackColor = Color.FromArgb(255, 60, 60);
        btnBrowse.Cursor = Cursors.Hand;
        btnBrowse.FlatAppearance.BorderSize = 0;
        btnBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 40, 40);
        btnBrowse.FlatStyle = FlatStyle.Flat;
        btnBrowse.ForeColor = Color.White;
        btnBrowse.Location = new Point(462, 202);
        btnBrowse.Name = "btnBrowse";
        btnBrowse.Size = new Size(134, 34);
        btnBrowse.TabIndex = 9;
        btnBrowse.Text = "Browse";
        btnBrowse.UseVisualStyleBackColor = false;
        btnBrowse.Click += btnBrowse_Click;
        // 
        // btnDownload
        // 
        btnDownload.BackColor = Color.FromArgb(255, 60, 60);
        btnDownload.Cursor = Cursors.Hand;
        btnDownload.FlatAppearance.BorderSize = 0;
        btnDownload.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 20, 20);
        btnDownload.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 40, 40);
        btnDownload.FlatStyle = FlatStyle.Flat;
        btnDownload.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        btnDownload.ForeColor = Color.White;
        btnDownload.Location = new Point(24, 311);
        btnDownload.Name = "btnDownload";
        btnDownload.Size = new Size(572, 50);
        btnDownload.TabIndex = 12;
        btnDownload.Text = "⬇  Download";
        btnDownload.UseVisualStyleBackColor = false;
        btnDownload.Click += btnDownload_Click;
        // 
        // progressBar
        // 
        progressBar.Location = new Point(24, 242);
        progressBar.Name = "progressBar";
        progressBar.Size = new Size(572, 25);
        progressBar.TabIndex = 10;
        // 
        // lblStatus
        // 
        lblStatus.BackColor = Color.Transparent;
        lblStatus.Font = new Font("Segoe UI", 9F);
        lblStatus.ForeColor = Color.FromArgb(140, 140, 140);
        lblStatus.Location = new Point(24, 281);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(572, 27);
        lblStatus.TabIndex = 11;
        lblStatus.Text = "대기 중...";
        // 
        // lblUrl
        // 
        lblUrl.BackColor = Color.Transparent;
        lblUrl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblUrl.ForeColor = Color.FromArgb(140, 140, 140);
        lblUrl.Location = new Point(24, 21);
        lblUrl.Name = "lblUrl";
        lblUrl.Size = new Size(200, 20);
        lblUrl.TabIndex = 0;
        lblUrl.Text = "YouTube URL";
        // 
        // lblFmt
        // 
        lblFmt.BackColor = Color.Transparent;
        lblFmt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblFmt.ForeColor = Color.FromArgb(140, 140, 140);
        lblFmt.Location = new Point(26, 104);
        lblFmt.Name = "lblFmt";
        lblFmt.Size = new Size(200, 20);
        lblFmt.TabIndex = 2;
        lblFmt.Text = "File Format";
        // 
        // lblQuality
        // 
        lblQuality.BackColor = Color.Transparent;
        lblQuality.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblQuality.ForeColor = Color.FromArgb(140, 140, 140);
        lblQuality.Location = new Point(376, 104);
        lblQuality.Name = "lblQuality";
        lblQuality.Size = new Size(200, 29);
        lblQuality.TabIndex = 5;
        lblQuality.Text = "Video Quality";
        // 
        // lblPath
        // 
        lblPath.BackColor = Color.Transparent;
        lblPath.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPath.ForeColor = Color.FromArgb(140, 140, 140);
        lblPath.Location = new Point(24, 166);
        lblPath.Name = "lblPath";
        lblPath.Size = new Size(200, 25);
        lblPath.TabIndex = 7;
        lblPath.Text = "Save Path";
        // 
        // ct_bt
        // 
        ct_bt.Anchor = AnchorStyles.None;
        ct_bt.BackColor = Color.Gainsboro;
        ct_bt.FlatAppearance.BorderSize = 0;
        ct_bt.FlatStyle = FlatStyle.Flat;
        ct_bt.ForeColor = Color.Blue;
        ct_bt.Location = new Point(116, 378);
        ct_bt.Name = "ct_bt";
        ct_bt.Size = new Size(395, 43);
        ct_bt.TabIndex = 13;
        ct_bt.Text = "Contact / Support : Telegram @Rev708";
        ct_bt.UseVisualStyleBackColor = false;
        ct_bt.Click += ct_bt_Click;
        // 
        // Main
        // 
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(626, 433);
        Controls.Add(ct_bt);
        Controls.Add(lblUrl);
        Controls.Add(txtUrl);
        Controls.Add(lblFmt);
        Controls.Add(rbMp4);
        Controls.Add(rbMp3);
        Controls.Add(lblQuality);
        Controls.Add(cmbQuality);
        Controls.Add(lblPath);
        Controls.Add(txtPath);
        Controls.Add(btnBrowse);
        Controls.Add(progressBar);
        Controls.Add(lblStatus);
        Controls.Add(btnDownload);
        Font = new Font("Segoe UI", 10F);
        ForeColor = Color.FromArgb(240, 240, 240);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "YouTube Downloader";
        Load += Main_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    // 디자이너가 인식하는 컨트롤 필드
    private System.Windows.Forms.TextBox txtUrl = null!;
    private System.Windows.Forms.TextBox txtPath = null!;
    private System.Windows.Forms.RadioButton rbMp4 = null!;
    private System.Windows.Forms.RadioButton rbMp3 = null!;
    private System.Windows.Forms.ComboBox cmbQuality = null!;
    private System.Windows.Forms.Button btnBrowse = null!;
    private System.Windows.Forms.Button btnDownload = null!;
    private System.Windows.Forms.ProgressBar progressBar = null!;
    private System.Windows.Forms.Label lblStatus = null!;
    private Label lblUrl;
    private Label lblFmt;
    private Label lblQuality;
    private Label lblPath;
    private Button ct_bt;
}