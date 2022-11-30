using Microsoft.AspNetCore.Mvc;
using Person.Services;
using PersonModel = Person.Services.Person;
namespace PersonApiController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonApiController : ControllerBase
    {
        private readonly ISalaryServiceContext _salaryServiceContext;
        private readonly ISalaryServiceContext2 _salaryServiceContext2;

        private readonly List<PersonModel> _people = new List<PersonModel>
        {
            new PersonModel(1, AgreementType.EmploymentAgreemnet, 15000),
            new PersonModel(2, AgreementType.FrameworkAgreement, 15000),
        };

        public PersonApiController(ISalaryServiceContext salaryServiceContext, ISalaryServiceContext2 salaryServiceContext2)
        {
            _salaryServiceContext = salaryServiceContext;
            _salaryServiceContext2 = salaryServiceContext2;
        }

        [HttpGet]        
        [Route("getValueToPay/{personId}")]
        public decimal GetValueToPay(int personId)
        {
            var person = _people.Single(p => p.Id == personId);

            var result = _salaryServiceContext.GetValueToPay(person);
            return result;
        }

        [HttpGet]
        [Route("getValueToPayWithSetStrategy/{personId}")]
        public decimal GetValueToPayWithSetStrategy(int personId)
        {
            var person = _people.Single(p => p.Id == personId);

            _salaryServiceContext2.SetStrategy(person.AgreementType);
            var result = _salaryServiceContext2.GetValueToPay(person);
            return result;
        }
    }
}