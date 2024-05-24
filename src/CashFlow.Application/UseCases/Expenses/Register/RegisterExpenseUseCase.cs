using CashFlow.Comunication.Requests;
using CashFlow.Comunication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

        return new ResponseRegisterExpenseJson();
    }
    private void Validate(RequestRegisterExpenseJson request)
    {
        #region Validação antiga
        //var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);
        //if(titleIsEmpty)
        //{
        //    throw new ArgumentException("The title is required");
        //}

        //if(request.Amount <= 0)
        //{
        //    throw new ArgumentException("The Amount must be greater than zero.");
        //}

        //var result = DateTime.Compare(request.Date, DateTime.UtcNow);
        //if(result > 0)
        //{
        //    throw new ArgumentException("Expenses cannot be for the future");
        //}

        //var paymentTypeIsValid = Enum.IsDefined(typeof(PaymentType), request.PaymentType);
        //if(paymentTypeIsValid == false)
        //{
        //    throw new ArgumentException("Payment Type is not valid");
        //} 
        #endregion

        var validator = new RegisterExpenseValidator();
        var result = validator.Validate(request);

        result.Errors.Select(f => f.ToString());
    }

}
