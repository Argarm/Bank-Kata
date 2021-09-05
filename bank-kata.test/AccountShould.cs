using System;
using System.Collections.Generic;
using System.Text;
using bank_kata.Interfaces;
using NSubstitute;
using NUnit.Framework;

namespace bank_kata.test {
    public class AccountShould {
        private Account account;
        private ITransactionStore transactionStore;
        private ITimeProvider timeProvider;
        private IPrinter printer;

        [Test]
        public void print_empty_statement_when_there_not_any_movements() {
            printer = Substitute.For<IPrinter>();
            timeProvider = Substitute.For<ITimeProvider>();
            transactionStore = Substitute.For<ITransactionStore>(null);
            account = new Account(printer, transactionStore);

            account.printStatement();

            printer.Received(1).print("Date || Amount || Balance");
        }
    }
}
