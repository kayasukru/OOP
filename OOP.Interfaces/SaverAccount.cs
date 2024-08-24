using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class SaverAccount : IBankAccount
    {
        private decimal _balance;

        public decimal Balance => _balance;

        // Aşağıdaki metod kısaltılabilir
        // public void PayIn(decimal amount) => _balance += amount;
        public void PayIn(decimal amount)
        {
            _balance = _balance + amount;
        }

        public bool Withdraw(decimal amount)
        {
            if(_balance >= amount)
            {
                _balance = _balance - amount;
                return true;
            }
            Console.WriteLine("Para çekme girişimi başarısız oldu.");
            return false;
        }

        public override string ToString() => 
            $"Banka Hesabı : Bakiye: {_balance}";
    }
}
