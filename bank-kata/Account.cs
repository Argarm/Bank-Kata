using bank_kata.Interfaces;

namespace bank_kata {
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
            printer.print("Date || Amount || Balance");
            
        }
    }
}