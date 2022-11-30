using Person.Services;

namespace Person
{
    public static class RegisterDependencyExtension
    {
        public static void RegisterSalaryServiceStrategy(this IServiceCollection services)
        {
            services.AddScoped<ISalaryService, EmploymentAgreementSalaryService>();
            services.AddScoped<ISalaryService, FrameworkAgreementSalaryService>();
            services.AddScoped<ISalaryServiceContext, SalaryServiceContext>();
            services.AddScoped<ISalaryServiceContext2, SalaryServiceContext2>();
        }
    }
}
