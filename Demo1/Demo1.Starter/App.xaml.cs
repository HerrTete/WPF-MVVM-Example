using System.Windows;

namespace Demo1.Starter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Integration _integration;

        public App():base()
        {
            _integration = new Integration();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _integration.Init();
            _integration.Run();
        }
    }
}
