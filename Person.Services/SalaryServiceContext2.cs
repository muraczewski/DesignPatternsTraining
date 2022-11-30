namespace Person.Services
{
    public class SalaryServiceContext2 : ISalaryServiceContext2
    {
        private readonly IEnumerable<ISalaryService> _salaryServices;
        private ISalaryService _salaryService;


        public SalaryServiceContext2(IEnumerable<ISalaryService> salaryServices)
        {
            _salaryServices = salaryServices;
        }

        public decimal GetValueToPay(Person person)
        {
            return _salaryService.GetValueToPay(person);
        }

        public void SetStrategy(AgreementType agreementType)
        {
            _salaryService = _salaryServices.Single(ss => ss.AgreementType == agreementType);
        }
    }
}
