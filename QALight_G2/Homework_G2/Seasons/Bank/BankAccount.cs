//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bank
//{
//    class BankAccount
//    {
//        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
//        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

//        public void Debit(double amount)
//        {
//            if (amount > m_balance)
//            {
//                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
//            }

//            if (amount < 0)
//            {
//                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
//            }
//            m_balance += amount;
//        }
//    }
//}
