namespace KeyVault.ViewModel
{
    internal class AppViewModel: ViewModelBase
    {
        private readonly INavigator? _navigator;
        public ViewModelBase? CurrentViewModel => _navigator.CurrentViewModel;

        private bool _isLoggedIn;
        public bool IsLoggedIn
        {
            get => _isLoggedIn;
            set => OnPropertyChanged(ref _isLoggedIn, value);
        }

        public AppViewModel(INavigator? navigator)
        {
            _navigator = navigator;
            _navigator.CurrentViewModelChanged += OnViewModelChanged;

            if(!IsLoggedIn)
            {
                LoginView lv = new();
                lv.ShowDialog();
            }

        }

        private void OnViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
