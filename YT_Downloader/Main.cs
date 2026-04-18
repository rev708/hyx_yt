using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;

namespace YT_Downloader;

public partial class Main : Form
{
    // ── 색상 팔레트 ─────────────────────────────────────
    private readonly Color C_ACCENT = Color.FromArgb(255, 60, 60);
    private readonly Color C_ACCENT2 = Color.FromArgb(200, 40, 40);

    public Main()
    {
        InitializeComponent();
        _ = EnsureToolsAsync();
    }

    // ────────────────────────────────────────────────────
    //  다운로드
    // ────────────────────────────────────────────────────
    private async void btnDownload_Click(object sender, EventArgs e)
    {
        string url = txtUrl.Text.Trim();
        string path = txtPath.Text.Trim();

        if (string.IsNullOrEmpty(url)) { MessageBox.Show("URL을 입력해주세요.", "입력 오류"); return; }
        if (!Directory.Exists(path)) { MessageBox.Show("유효한 저장 폴더를 선택해주세요.", "경로 오류"); return; }

        SetDownloading(true);

        try
        {
            var ytdl = new YoutubeDL
            {
                YoutubeDLPath = "yt-dlp.exe",
                FFmpegPath = "ffmpeg.exe",
                OutputFolder = path,
                OutputFileTemplate = "%(title)s.%(ext)s"
            };

            var progress = new Progress<DownloadProgress>(p =>
            {
                lblStatus.Text = p.State switch
                {
                    DownloadState.Downloading => $"다운로드 중: {p.Progress * 100:0.0}%  속도: {p.DownloadSpeed}",
                    DownloadState.PostProcessing => "변환 중 (FFmpeg)...",
                    _ => lblStatus.Text
                };

                // 진행바 업데이트
                if (p.State == DownloadState.Downloading)
                {
                    int value = (int)(p.Progress * 100);
                    if (value >= 0 && value <= 100)
                        progressBar.Value = value;
                }
            });

            RunResult<string> result;

            if (rbMp3.Checked)
            {
                result = await ytdl.RunAudioDownload(
                    url, AudioConversionFormat.Mp3, progress: progress);
            }
            else
            {
                string format = cmbQuality.SelectedItem?.ToString() switch
                {
                    "8K (4320p)" => "bestvideo[height<=4320][ext=mp4]+bestaudio[ext=m4a]/bestvideo[height<=4320]+bestaudio/best",
                    "4K (2160p)" => "bestvideo[height<=2160][ext=mp4]+bestaudio[ext=m4a]/bestvideo[height<=2160]+bestaudio/best",
                    "1080p" => "bestvideo[height<=1080][ext=mp4]+bestaudio[ext=m4a]/best[height<=1080][ext=mp4]",
                    "720p" => "bestvideo[height<=720][ext=mp4]+bestaudio[ext=m4a]/best[height<=720][ext=mp4]",
                    "480p" => "bestvideo[height<=480][ext=mp4]+bestaudio[ext=m4a]/best[height<=480][ext=mp4]",
                    "360p" => "bestvideo[height<=360][ext=mp4]+bestaudio[ext=m4a]/best[height<=360][ext=mp4]",
                    _ => "bestvideo[ext=mp4]+bestaudio[ext=m4a]/best[ext=mp4]/best"
                };

                result = await ytdl.RunVideoDownload(
                    url, format: format,
                    mergeFormat: DownloadMergeFormat.Mp4,
                    progress: progress);
            }

            if (result.Success)
            {
                lblStatus.Text = "✅ 다운로드 완료!";
                MessageBox.Show($"완료!\n저장 위치: {path}", "성공",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblStatus.Text = "❌ 오류 발생";
                MessageBox.Show(string.Join("\n", result.ErrorOutput), "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text = "❌ 오류 발생";
            MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            SetDownloading(false);
        }
    }

    // ────────────────────────────────────────────────────
    //  찾아보기
    // ────────────────────────────────────────────────────
    private void btnBrowse_Click(object sender, EventArgs e)
    {
        using var dlg = new FolderBrowserDialog { SelectedPath = txtPath.Text };
        if (dlg.ShowDialog() == DialogResult.OK)
            txtPath.Text = dlg.SelectedPath;
    }

    // ────────────────────────────────────────────────────
    //  형식 변경 시 화질 콤보박스 활성/비활성
    // ────────────────────────────────────────────────────
    private void rbMp4_CheckedChanged(object sender, EventArgs e)
        => cmbQuality.Enabled = rbMp4.Checked;

    // ────────────────────────────────────────────────────
    //  yt-dlp / ffmpeg 자동 다운로드
    // ────────────────────────────────────────────────────
    private async Task EnsureToolsAsync()
    {
        if (!File.Exists("yt-dlp.exe"))
        {
            lblStatus.Text = "yt-dlp 다운로드 중...";
            await YoutubeDLSharp.Utils.DownloadYtDlp();
        }
        if (!File.Exists("ffmpeg.exe"))
        {
            lblStatus.Text = "ffmpeg 다운로드 중...";
            await YoutubeDLSharp.Utils.DownloadFFmpeg();
        }
        lblStatus.Text = "준비 완료!";
    }

    // ────────────────────────────────────────────────────
    //  상태 제어
    // ────────────────────────────────────────────────────
    private void SetDownloading(bool active)
    {
        btnDownload.Enabled = !active;
        btnDownload.Text = active ? "다운로드 중..." : "⬇  다운로드 시작";
        btnDownload.BackColor = active ? C_ACCENT2 : C_ACCENT;

        if (active)
        {
            progressBar.Style = ProgressBarStyle.Blocks;  // Marquee → Blocks
            progressBar.Value = 0;
            lblStatus.Text = "다운로드 준비 중...";
        }
        else
        {
            progressBar.Value = 0;  // 완료 후 초기화
        }
    }

    private void Main_Load(object sender, EventArgs e) { }
    private void ct_bt_Click(object sender, EventArgs e)
    {
        ct_bt.Click += (s, e) => new Donate().ShowDialog(this);

    }
}