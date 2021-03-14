using System;

namespace generic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Account account=new Account(){Id = "1",Sum = 50};
            // int id2 = (int)account.Id;
            // Console.WriteLine(id2);
            // Console.WriteLine(account.Id);
            // Console.WriteLine(account.Sum);
            Account acc1=new Account(1){Sum = 5000};
            Account acc2=new Account(2){Sum = 3000};
            Transaction<Account> transaction=new Transaction<Account>()
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 6000
            };
            transaction.Execute();
        }
    }
}