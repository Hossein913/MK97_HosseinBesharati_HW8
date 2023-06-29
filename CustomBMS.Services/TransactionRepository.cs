using CustomBMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CustomBMS.Services
{
    public class TransactionRepository : ITransactionRepository
    {

        List<TransactionModel> _transactions;


        public TransactionRepository()
        {
           _transactions = new List<TransactionModel>() 
           {

            new TransactionModel() { ID = 1, credit =0 , debit = 900000, Discription = "انتقال به حساب", Date = DateTime.Parse("6/20/2023 10:41:31 AM"), balance = 900000 },
            new TransactionModel() { ID = 2, credit =100000 , debit = 0, Discription = "خرید اینترنتی", Date = DateTime.Parse("6/25/2023 6:41:31 AM"), balance = 800000 },
            new TransactionModel() { ID = 3, credit =0 , debit = 1000000, Discription = "کارت به کارت", Date = DateTime.Parse("6/29/2023 8:41:31 AM"), balance = 1800000 }
        };
        }


        public void Create(TransactionModel transaction)
        {
            _transactions.Add(transaction);
        }

        public IEnumerable<TransactionModel> GetAllTransactions()
        {
            return _transactions;
        }

        public decimal GetBalance()
        {
            decimal Balance = 0;

            if (_transactions.Count > 0) 
            {
                Balance = _transactions.Last().balance;
            }

            return Balance;
        }

        public int GetLastID()
        {
            int Id;

            if (_transactions.Count > 0)
            {
                Id = _transactions.Last().ID;
                return (int)Id;
            }
            return 0;

            
        }
    }
}
