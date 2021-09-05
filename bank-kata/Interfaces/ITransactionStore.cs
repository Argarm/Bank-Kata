using System.Collections.Generic;

namespace bank_kata.Interfaces {
    public interface ITransactionStore {
        void AddDeposit(int amount);
        void AddWithdraw(int amount);
        List<Transaction> getAllTransactions();
    }
}