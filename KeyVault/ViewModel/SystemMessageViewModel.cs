using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyVault.ViewModel
{
    internal class SystemMessageViewModel: ViewModelBase
    {
        private SystemMessage? _systemMessage { get; set; }

        private string? _message;
        public string? Message
        {
            get => _message;
            set => OnPropertyChanged(ref _message, value);
        }
        public SystemMessageViewModel()
        {
            Message = "this is a custom message";
        }
    }
}
