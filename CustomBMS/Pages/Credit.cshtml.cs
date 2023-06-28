using CustomBMS.Models;
using CustomBMS.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomBMS.Pages
{
    public class CreditModel : PageModel
    {


        private readonly ITransactionRepository _transactionRepository;
        private TransactionModel actionModel;
        public CreditModel(ITransactionRepository TransactionRepository)
        {
            _transactionRepository = TransactionRepository;
        }

        public void OnGet()
        {

        }

        
         public ActionVM actionVM = new ActionVM();
        public void OnPost()
        {

            actionVM.amount = Convert.ToDecimal(Request.Form["actionVM.amount"]);
            actionVM.Description = Request.Form["actionVM.Description"];


            decimal _balance = _transactionRepository.GetBalance();
            if (_balance == 0)
            {
                
            }
            else
            {
                _balance -= actionVM.amount;
            }
            int id = _transactionRepository.GetLastID();
            actionModel = new TransactionModel() { ID = id, credit = actionVM.amount, debit = 0, Discription = actionVM.Description, Date = DateTime.Now, balance = _balance };


        }
    }
}
