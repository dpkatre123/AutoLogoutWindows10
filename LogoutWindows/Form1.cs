using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace LogoutWindows
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        System.Timers.Timer logoutTimer;
        System.Timers.Timer labelUpdateTimer;
        DateTime logoutTimeEstimated = DateTime.Now;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            initializeTimer();
        }

        private void initializeTimer()
        {
            lblErrorText.Text = "";
            try
            {
                if (double.Parse(txtTime.Text) > 1)
                {
                    if (logoutTimer != null)
                    {
                        logoutTimer.Stop();
                        logoutTimer.Dispose();
                    }
                    if (labelUpdateTimer != null)
                    {
                        labelUpdateTimer.Stop();
                        labelUpdateTimer.Dispose();
                    }
                    Thread.Sleep(1000);
                    logoutTimer = new System.Timers.Timer(double.Parse(txtTime.Text) * 60 * 1000);
                    logoutTimer.Elapsed += LogoutTimer_Elapsed;
                    logoutTimer.Enabled = true;
                    logoutTimer.Start();

                    labelUpdateTimer = new System.Timers.Timer(1000);
                    labelUpdateTimer.Elapsed += LabelUpdateTimer_Elapsed;
                    labelUpdateTimer.Enabled = true;
                    labelUpdateTimer.Start();
                    logoutTimeEstimated = DateTime.Now.AddMinutes(double.Parse(txtTime.Text));
                    lblErrorText.Text = "";
                }
                else
                {
                    lblErrorText.Text = "minnimum 1 min required";
                }
            }catch(Exception ex)
            {
                lblErrorText.Text = ex.Message;
            }
        }
        private void updateLabel()
        {
            TimeSpan timeSpan = logoutTimeEstimated - DateTime.Now;
            lblLgout.Text = "Hours:" + timeSpan.Hours + " Minutes:" + timeSpan.Minutes + " Seconds:" + timeSpan.Seconds;
            if(timeSpan.Hours == 0 && timeSpan.Minutes <= 5)
            {
                this.Activate();
                this.WindowState = FormWindowState.Normal;
                lblLgout.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                lblLgout.BackColor = System.Drawing.Color.LightBlue;
            }
           
        }
        private void LabelUpdateTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Action updateTime = () => updateLabel();

            if (this.InvokeRequired)
            {
                this.Invoke(updateTime);
            }
            else
            {
                updateLabel();
            }
        }

        private void LogoutTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            logout();
        }

        private void logout()
        {
            try
            {
                ExitWindowsEx(0, 0);
                Action closeForm = () => Close();

                if (this.InvokeRequired)
                {
                    this.Invoke(closeForm);
                }
                else
                {
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            initializeTimer();

        }
    }
}
