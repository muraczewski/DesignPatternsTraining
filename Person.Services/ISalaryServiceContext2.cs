namespace Person.Services
{
    public interface ISalaryServiceContext2
    {
        void SetStrategy(AgreementType agreementType);

        decimal GetValueToPay(Person person);
    }
}