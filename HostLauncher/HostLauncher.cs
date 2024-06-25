using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HostLauncher
{
    public partial class HostLauncher : Form
    {
        private string hostsFilePath = @"C:\Windows\System32\drivers\etc\hosts";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectGn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        Point lastPoint;
        public HostLauncher()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectGn(0, 0, Width, Height, 20, 20));
        }

        private void HostLauncher_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {

                string ipText = IpTextBox.Text;
                string hostsContent = $@"# Hosts Launcher by Artemis/JordanIsADev
# Github: https://github.com/jordanisadev
{ipText} www.growtopia1.com
{ipText} www.growtopia2.com";
                File.WriteAllText(hostsFilePath, hostsContent);

                MessageBox.Show("Hosts file updated successfully.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied. Please run the application as an administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LaunchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    string appPath = Path.Combine(appDataPath, "Growtopia\\", "Growtopia.exe");
                    if (File.Exists(appPath))
                    {
                        Process.Start(appPath);
                    }
                    else
                    {
                        MessageBox.Show(appPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(hostsFilePath, "");
                MessageBox.Show("Hosts file cleared");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiscordButton_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/jordanisadev";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {githubUrl}") { CreateNoWindow = true });
        }
    }
}
