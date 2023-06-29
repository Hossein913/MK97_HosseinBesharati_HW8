using CustomBMS.Models;
using CustomBMS.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomBMS.Pages
{
    public class DebitModel : PageModel
    {

        private readonly ITransactionRepository _transactionRepository;
        private TransactionModel actionModel;

        public DebitModel(ITransactionRepository TransactionRepository)
        {
            _transactionRepository = TransactionRepository;
        }

        public int CurentUserId { get; set; }

        public void OnGet(int id)
        {
            CurentUserId = id;
        }

        public ActionVM actionVM = new ActionVM();
        public void OnPost(int id)
        {

            actionVM.amount = Convert.ToDecimal(Request.Form["actionVM.amount"]);
            actionVM.Description = Request.Form["actionVM.Description"];


            decimal _balance = actionVM.amount + _transactionRepository.GetBalance();

            int Actionid = _transactionRepository.GetLastID();
            actionModel = new TransactionModel() { ID = Actionid + 1, credit =0 , debit = actionVM.amount, Discription = actionVM.Description, Date = DateTime.Now, balance = _balance };
            _transactionRepository.Create(actionModel);
            CurentUserId = id;
            actionVM = new ActionVM();
        }
    }
}
