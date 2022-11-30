namespace Person.Services
{
    public interface ISalaryServiceContext
    {
        //void SetStrategy(AgreementType agreementType);

        decimal GetValueToPay(Person person);
    }
}