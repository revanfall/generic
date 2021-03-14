namespace generic
{
    public class Account
    {
        public int Id { get; private set; }
        public int Sum { get; set; }

        public Account(int id)
        {
            Id = id;
        }
    }
}