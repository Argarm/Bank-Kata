using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using bank_kata.Interfaces;

namespace bank_kata {
    public class Account : AccountService {
        public IPrinter printer;
        public ITransactionStore transactionStore;
        const string HEADER = "Date || Amount || Balance";

        public Account(IPrinter printer, ITransactionStore transactionStore) {
            this.printer = printer;
            this.transactionStore = transactionStore;
        }

        public void deposit(int amount) {
            transactionStore.AddDeposit(amount);
        }

        public void withdraw(int amount) {
            transactionStore.AddWithdraw(amount);
        }

        public void printStatement() {
            printer.print(HEADER);
            foreach (var transaction in transactionStore.getAllTransactions()) {
                printer.print(transaction.ToString());
            }
        }
    }
}