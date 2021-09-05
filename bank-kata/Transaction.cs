namespace bank_kata {
    public class Transaction {
        public string DayOfTransaction { get; set; }
        public int Amount { get; set; }
        public int Balance { get; set; }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override string ToString() {
            return $"{DayOfTransaction} || {Amount} || {Balance}";
        }
    }
    
}