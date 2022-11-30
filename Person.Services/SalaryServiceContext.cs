namespace Person.Services
{
    public class SalaryServiceContext : ISalaryServiceContext
    {
        private readonly IEnumerable<ISalaryService> _salaryServices;
        private ISalaryService _salaryService;


        public SalaryServiceContext(IEnumerable<ISalaryService> salaryServices)
        {
            _salaryServices = salaryServices;
        }

        public decimal GetValueToPay(Person person)
        {
            _salaryService = _salaryServices.Single(ss => ss.AgreementType == person.AgreementType);
            return _salaryService.GetValueToPay(person);
        }
    }
}
