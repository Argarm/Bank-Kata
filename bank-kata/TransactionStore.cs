using System;
using bank_kata.Interfaces;

namespace bank_kata {
    public class TransactionStore: ITransactionStore {
        public ITimeProvider TimeProvider;

        public TransactionStore(ITimeProvider timeProvider) {
            TimeProvider = timeProvider;
        }

        public void AddDeposit(int amount) {
            throw new NotImplementedException();
        }

        public void AddWithdraw(int amount) {
            throw new NotImplementedException();
        }
    }
}