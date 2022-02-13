namespace KeyVault.Navigation
{
    internal interface INavigator
    {
        public event Action CurrentViewModelChanged;
        public ViewModelBase CurrentViewModel { get; set; }
    }
}
