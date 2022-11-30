namespace Person.Services
{
    public interface ISalaryServiceContext
    {
        decimal GetValueToPay(Person person);
    }
}