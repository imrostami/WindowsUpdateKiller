using System.Security.Principal;

namespace WindowsUpdateKiller
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                if (!IsAdministrator)
                {
                    MessageBox.Show("Windows Update Killer requires admin access level to control Windows Update service. Please run the program with Run as Adninistrator option.", "Access level error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show($"{Environment.OSVersion.Platform}  Platform not Supported", "Platform Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

        }
        public static bool IsAdministrator =>
   new WindowsPrincipal(WindowsIdentity.GetCurrent())
       .IsInRole(WindowsBuiltInRole.Administrator);
    }
}