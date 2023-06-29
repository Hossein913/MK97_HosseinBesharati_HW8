using CustomBMS.Models;
using CustomBMS.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.Common;
using System.Transactions;

namespace CustomBMS.Pages
{
    public class AccountModel : PageModel
    {
        private readonly IUserServices _userServices;
        private readonly ITransactionRepository _transactionRepository;

        [BindProperty]
        public User user { get; set; }
        
        [BindProperty]
        public IEnumerable<TransactionModel> transactions { get; set; }

        public AccountModel(IUserServices userServices,ITransactionRepository TransactionRepository)
        {
            _userServices = userServices;
            _transactionRepository = TransactionRepository;
        }
        

        public void OnGet(int id)
        {
            user = _userServices.GetUserById(id);
            transactions = _transactionRepository.GetAllTransactions();
        }
    }
}
