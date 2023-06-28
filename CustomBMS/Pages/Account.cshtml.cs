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
        private readonly UserServices _userServices;
        private readonly TransactionRepository _transactionRepository;

        [BindProperty]
        public User user { get; set; }
        
        [BindProperty]
        public IEnumerable<TransactionModel> transactions { get; set; }

        public AccountModel()
        {
            _userServices = new UserServices();
            _transactionRepository = new TransactionRepository();
        }
        

        public void OnGet(int id)
        {
            user = _userServices.GetUserById(id);
            transactions = _transactionRepository.GetAllTransactions();
        }
    }
}
