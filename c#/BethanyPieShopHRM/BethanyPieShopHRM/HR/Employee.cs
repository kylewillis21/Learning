namespace BethanyPieShopHRM.HR
{
    internal class Employee
    {
        // Fields
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;
        public EmployeeType employeeType;

        public static double taxRate = 0.15;

        // Constants
        const int minimalHoursWorkedUnit = 1;
        const double managerRate = 1.25;

        // Constructors
        public Employee(string first, string last, string em, DateTime bd) : this(first,
            last, em, bd, 0, EmployeeType.StoreManager)
        {
        }

        public Employee(string first, string last, string em, DateTime bd, double rate, EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
            employeeType = empType;
        }

        // Methods
        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public double RecieveWage(bool resetHours = true)
        {
            double wageBeforeTax = 0.0;

            if (employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {firstName} is a manager!");
                wageBeforeTax = numberOfHoursWorked * hourlyRate * managerRate;
            }
            else
            {
                wageBeforeTax = numberOfHoursWorked * hourlyRate;
            }

            double taxAmount = wageBeforeTax * taxRate;

            wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{firstName} {lastName} has recieved a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if (resetHours)
            {
                numberOfHoursWorked = 0;
            }

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: \t{firstName}\nLast Name: \t{lastName}\nEmail:" +
                $"\t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\nTax rate: \t" +
                $"{taxRate}");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }
    }
}
