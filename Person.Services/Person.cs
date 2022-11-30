namespace Person.Services
{
    public class Person
    {
        public Person(int id, AgreementType agreementType, decimal salary)
        {
            Id = id;
            AgreementType = agreementType;
            Salary = salary;
        }

        public int Id { get; set; }

        public AgreementType AgreementType { get; set; }

        public decimal Salary { get; set; }
    }
}
