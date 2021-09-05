namespace bank_kata.Interfaces {
    public interface ITransactionStore {
        void AddDeposit(int amount);
        void AddWithdraw(int amount);
    }
}