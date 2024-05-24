namespace CashFlow.Exception.ExceptionsBase;
public class ErrorOnValidationException : CashFlowException
{
    public ErrorOnValidationException(List<String> errorMessages) 
    {
       Errors = errorMessages;
    }
    public List<string> Errors { get; set; }
}
