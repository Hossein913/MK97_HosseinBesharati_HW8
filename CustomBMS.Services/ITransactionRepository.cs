using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CustomBMS.Models;

namespace CustomBMS.Services
{
    public  interface ITransactionRepository
    {
        IEnumerable<TransactionModel> GetAllTransactions();
        void Create(TransactionModel transaction);
        int GetLastID();
        decimal GetBalance();
    }
}
