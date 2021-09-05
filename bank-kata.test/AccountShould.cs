using System;
using bank_kata.Interfaces;
using NSubstitute;
using NUnit.Framework;

namespace bank_kata.test {
    public class AccountShould {
        private IPrinter printer;
        private ITransactionStore transactionStore;
        private Account account;
        private ITimeProvider timeProvider;

        [Test]
        public void print_statement_containing_all_transactions() {
            printer = Substitute.For<IPrinter>();
            timeProvider = Substitute.For<ITimeProvider>();
            transactionStore = Substitute.For<ITransactionStore>(null);
            account = new Account(printer,transactionStore);
            timeProvider.getTodayAsString().Returns("10-01-2012", "13-01-2012", "14-01-2012");

            account.deposit(1000);
            account.deposit(2000);
            account.withdraw(500);
            account.printStatement();

            printer.Received(1).print("Date || Amount || Balance");
            printer.Received(1).print("14/01/2012 || -500 || 2500");
            printer.Received(1).print("13/01/2012 || 2000 || 3000");
            printer.Received(1).print("10/01/2012 || 1000 || 1000");
        }
    }

    public class Account : AccountService {
        public IPrinter printer;
        public ITransactionStore transactionStore;

        public Account(IPrinter printer, ITransactionStore transactionStore) {
            this.printer = printer;
            this.transactionStore = transactionStore;
        }

        public void deposit(int amount) {

        }

        public void withdraw(int amount) {

        }

        public void printStatement() {
            
        }
    }
}