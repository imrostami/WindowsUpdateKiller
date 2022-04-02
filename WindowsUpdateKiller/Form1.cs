using System.ServiceProcess;

namespace WindowsUpdateKiller
{
    public partial class Form1 : Form
    {
        private ServiceController updateService;
        const string serviceName = "wuauserv";
        public Form1()
        {
            InitializeComponent();
            updateService = ServiceController.GetServices().SingleOrDefault(f => f.ServiceName == serviceName);
        }

        private void Form1_Load(object sender, EventArgs e) => Start();
        void Start()
        {
            notfication.ShowBalloonTip(20000, "Windows Update Killer", "Windows Update Killer started successfully \n Get to work safely \n WUKiller is aware of Windows updates", System.Windows.Forms.ToolTipIcon.Info);
            appTimer.Start();

        }
        void Stop(bool crashed, string crashMsg = "")
        {
            if (crashed)
            {
                appTimer.Stop();
                MessageBox.Show($"Windows Update Kiler Has Crashed \n Error Message : {crashMsg}", "Windows Update Killer Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                appTimer.Stop();
                notfication.ShowBalloonTip(20000, "Windows Update Killer", "Windows Update Killer stoped \n Windows updates are no longer checked", System.Windows.Forms.ToolTipIcon.Info);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => Stop(false);

        private async void appTimer_Tick(object sender, EventArgs e)
        {
            updateService = ServiceController.GetServices().SingleOrDefault(f => f.ServiceName == serviceName);
            if (updateService.Status == ServiceControllerStatus.Running)
            {

                try
                {
                    KillUpdate();
                }
                catch (Exception ef)
                {
                    Stop(true, ef.Message);
                }

            }


        }

        private async void KillUpdate()
        {
            updateService.Stop();

        }

        private void menu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (appTimer.Enabled == true)
            {
                activeItem.Enabled = false;
                deactiveItem.Enabled = true;
            }
            else
            {
                activeItem.Enabled = true;
                deactiveItem.Enabled = false;
            }
        }

        private void activeItem_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void deactiveItem_Click(object sender, EventArgs e)
        {
            Stop(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop(false);
            Environment.Exit(0);
        }
    }
}