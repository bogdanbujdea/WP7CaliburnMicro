using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CaliburnAppWP7
{
    public partial class App : Application
    {
        public static PhoneApplicationFrame RootFrame { get; private set; }

        public App()
        {
            // Standard Silverlight initialization
            InitializeComponent();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Current.Host.Settings.EnableFrameRateCounter = true;
                PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
            }

        }
    }
}