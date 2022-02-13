namespace KeyVault.View
{
    public partial class LoginView : Window
    {
        
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (UtilityHelper.IsWindowOpen<Window>("AppWindow"))
            {
                Window? wnd = Application.Current.Windows.OfType<Window>().FirstOrDefault();
                if (wnd != null)
                    wnd.Show();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (UtilityHelper.IsWindowOpen<Window>("AppWindow"))
            {
                Window? wnd = Application.Current.Windows.OfType<Window>().FirstOrDefault();
                if (wnd != null)
                    wnd.Show();
            }
        }
    }
}
