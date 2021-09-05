using System;
using System.Collections.Generic;
using bank_kata.Interfaces;

namespace bank_kata {
    public class TransactionStore: ITransactionStore {
        public ITimeProvider timeProvider;
        private List<Transaction> allTransactions;
        private int balance;
        public TransactionStore(ITimeProvider timeProvider) {
            this.timeProvider = timeProvider;
            allTransactions = new List<Transaction>();
        }

        public void AddDeposit(int amount) {
            balance += amount;
            StoreTransaction(timeProvider.getTodayAsString(), amount);
        }

        public void AddWithdraw(int amount) {
            throw new NotImplementedException();
        }

        public List<Transaction> getAllTransactions() {
            return allTransactions;
        }

        private void StoreTransaction(string today, int amount) {
            allTransactions.Add(new Transaction {
                DayOfTransaction = today,
                Amount = amount,
                Balance = balance
            });
        }
    }
}