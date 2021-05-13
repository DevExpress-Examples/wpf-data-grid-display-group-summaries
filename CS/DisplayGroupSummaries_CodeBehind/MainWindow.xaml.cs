using DevExpress.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DisplayGroupSummaries_CodeBehind {
    public class Account {
        public string UserName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Married { get; set; }
        public int Age { get; set; }
    }
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = GetAccountList().ToList();
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

        void OnCustomSummaryExists(object sender, CustomSummaryExistEventArgs e) {
            e.Exists = e.GroupLevel == 0;
        }
    }
}
