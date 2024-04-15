using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boink
{
    internal class BankAccount
    {
        int money = 0;
     
        public void Deposit(int amount)
        {
            money = money + amount;


        }

        public void Withdraw(int amount)
        {
            if (money < amount)
            {
                Console.WriteLine("You dont have enough money.. ): this is all you have:" + money);
            }
            if (money > amount)
            {
                money = money - amount;
            }
            
        }

        public int GetBalance()
        {
            return money;
        }
    }
}
