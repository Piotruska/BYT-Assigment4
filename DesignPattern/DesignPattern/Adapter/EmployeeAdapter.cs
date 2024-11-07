// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            var listOfEmps = new List<Employee>();
            for(int i = 0 ; i < employeesArray.GetUpperBound(0) ; i++)
            {
                var idOriginal = Convert.ToInt32(employeesArray[i, 0]);
                var nameOriginal = employeesArray[i, 1];
                var designationOriginal = employeesArray[i, 2];
                var salaryOriginal = Convert.ToDecimal(employeesArray[i, 3]);
                listOfEmps.Add(new Employee(idOriginal,nameOriginal,designationOriginal,salaryOriginal));
            }
            thirdPartyBillingSystem.ProcessSalary(listOfEmps);
        }
    }
}
