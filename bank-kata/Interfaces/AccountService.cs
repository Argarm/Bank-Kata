namespace bank_kata.Interfaces {
    public interface AccountService {
        void deposit(int amount);
        void withdraw(int amount);
        void printStatement();
    }
}