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
           _transactions = new List<TransactionModel>() {};
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
            int? Id = _transactions.Last().ID;
            if (Id == null)
            {
                return 0;
            }
            return (int)Id; 
        }
    }
}
