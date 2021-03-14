using System;

namespace generic
{
    public class Transaction<T> where T:Account
    {
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public int Sum { get; set; }

        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine(
                    $"Счёт аккаунта {ToAccount.Id}-{ToAccount.Sum}\nСчёт аккаунта {FromAccount.Id}-{FromAccount.Sum}");
            }
            else
            {
                Console.WriteLine($"На счёте аккаунта {FromAccount.Id} недостаточно денег");
            }
        }
    }
}