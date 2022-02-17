﻿namespace KeyVault.ViewModel
{
    internal class AppViewModel: ViewModelBase
    {
        private readonly INavigator? _navigator;
        public ViewModelBase? CurrentViewModel => _navigator.CurrentViewModel;
        public SystemMessage SystemMessage { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand AddAccountCommand { get; }

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
            //if (!IsLoggedIn)
            //{
            //    LoginView lv = new();
            //    lv.ShowDialog();
            //    IsLoggedIn = true;
            //}
              AddAccountCommand = new NavigateCommand<SingleAccountViewModel>(_navigator, () => new SingleAccountViewModel());
              CloseCommand = new RelayCommand(CloseApp);

           
           

        }

        private void CloseApp()
        {
           Application.Current.Shutdown();
        }

        private void OnViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
