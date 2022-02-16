using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyVault.ViewModel
{
    internal class AccountViewModel: ViewModelBase
    {

        private readonly AppDbContextFactory _dbFactory;

        public AccountViewModel()
        {
           // _dbFactory = dbFactory;
            Accounts = new List<Account>();
            Accounts.Add(new Account { Name = "Google", Url = "www.google.com" });
            Accounts.Add(new Account { Name = "Inked Apparel", Url = "www.inkedappareltees.com" });
        }


        //we need a List<Account> to hold all the saved accounts from the Database.
        private List<Account> _accounts;
        public List<Account> Accounts
        {
            get => _accounts;
            set => OnPropertyChanged(ref _accounts, value);
        }
    }
}
