namespace Person.Services
{
    public class EmploymentAgreementSalaryService : ISalaryService
    {
        private const decimal PensionContributionRate = 0.1371M;
        private const decimal HealthCareContributionRate = 0.09M;
        private const int EmployeerCost = 250;
        private const decimal TaxRate = 0.12M;
        private const int NonTaxAmount = 300;

        public AgreementType AgreementType => AgreementType.EmploymentAgreemnet;

        public decimal GetValueToPay(Person person)
        {
            var pensionContribution = person.Salary * PensionContributionRate;
            var healthCareContribtuin = (person.Salary - pensionContribution) * HealthCareContributionRate;
            var income = person.Salary - pensionContribution - EmployeerCost;
            var advance = (income * TaxRate) - NonTaxAmount;

            var valueToPay = person.Salary - pensionContribution - healthCareContribtuin - advance;

            return valueToPay;
        }
    }
}
