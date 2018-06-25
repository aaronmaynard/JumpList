using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Text;
using System.Windows.Shell;
using System.Diagnostics;

namespace nJumpList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            if (InstanceAlreadyExist())
            {
                MessageBox.Show("The application is already running.", "Application", MessageBoxButton.OK, MessageBoxImage.Information);
                Current.Shutdown();
                return;
            }
        }

        private static bool InstanceAlreadyExist()
        {
            var currentProcess = Process.GetCurrentProcess();
            var allComuterProcess = Process.GetProcessesByName(currentProcess.ProcessName);

            var isAlreadyStarted = false;
            foreach (var oneProcess in allComuterProcess)
            {
                if ((oneProcess.Id != currentProcess.Id) && (oneProcess.MainModule.FileName == currentProcess.MainModule.FileName))
                {
                    isAlreadyStarted = true;
                    break;
                }
            }

            return isAlreadyStarted;
        }

        private void JumpList_JumpItemsRejected(object sender, System.Windows.Shell.JumpItemsRejectedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Jump Items Rejected:\n", e.RejectionReasons.Count);
            for (int i = 0; i < e.RejectionReasons.Count; ++i)
            {
                if (e.RejectedItems[i].GetType() == typeof(JumpPath))
                    sb.AppendFormat("Reason: {0}\tItem: {1}\n", e.RejectionReasons[i], ((JumpPath)e.RejectedItems[i]).Path);
                else
                    sb.AppendFormat("Reason: {0}\tItem: {1}\n", e.RejectionReasons[i], ((JumpTask)e.RejectedItems[i]).ApplicationPath);
            }

            MessageBox.Show(sb.ToString());
        }

        private void JumpList_JumpItemsRemovedByUser(object sender, System.Windows.Shell.JumpItemsRemovedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Jump Items Removed by the user:\n", e.RemovedItems.Count);
            for (int i = 0; i < e.RemovedItems.Count; ++i)
            {
                sb.AppendFormat("{0}\n", e.RemovedItems[i]);
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
