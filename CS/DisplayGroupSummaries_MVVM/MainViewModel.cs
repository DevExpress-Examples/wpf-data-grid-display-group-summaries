using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DisplayGroupSummaries_MVVM {
    public class Account {
        public string UserName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Married { get; set; }
        public int Age { get; set; }
    }
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<Account> AccountList{ get; }
        public MainViewModel() {
            AccountList = new ObservableCollection<Account>(GetAccountList());
        }
        IEnumerable<Account> GetAccountList() {
            yield return new Account() {
                UserName = "Nick White",
                RegistrationDate = DateTime.Today,
                Married = true,
                Age = 42
            };
            yield return new Account() {
                UserName = "Jack Rodman",
                RegistrationDate = new DateTime(2009, 5, 10),
                Married = false,
                Age = 30
            };
            yield return new Account() {
                UserName = "Sandra Sherry",
                RegistrationDate = new DateTime(2008, 12, 22),
                Married = false,
                Age = 18
            };
            yield return new Account() {
                UserName = "Sabrina Vilk",
                RegistrationDate = DateTime.Today,
                Married = true,
                Age = 24
            };
            yield return new Account() {
                UserName = "Mike Pearson",
                RegistrationDate = new DateTime(2008, 10, 18),
                Married = true,
                Age = 37
            };
        }

        [Command]
        public void CustomSummaryExistsCommand(RowSummaryExistsArgs args) {
            args.Exists = args.GroupPath[0].GroupLevel == 0;
        }
    }
}
