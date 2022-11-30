namespace Person.Services
{
    public class FrameworkAgreementSalaryService : ISalaryService
    {
        private const decimal vatMultiplication = 1.23M;

        public AgreementType AgreementType => AgreementType.FrameworkAgreement;

        public decimal GetValueToPay(Person person)
        {
            return person.Salary * vatMultiplication;
        }
    }
}
