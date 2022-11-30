namespace Person.Services
{
    public interface ISalaryService
    {
        decimal GetValueToPay(Person person);

        AgreementType AgreementType { get; }
    }
}