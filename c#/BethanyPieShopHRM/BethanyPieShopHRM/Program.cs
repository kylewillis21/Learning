using BethanyPieShopHRM.HR;
using BethanyPieShopHRM.Accounting;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@gmail.com", new DateTime
    (1979, 1, 16), 25, EmployeeType.Manager);

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");
Employee george = new Employee("George", "Jones", "george@gmail.com", new DateTime(1984, 3, 28),
    30, EmployeeType.Research);


#region First run Bethany

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.RecieveWage();
bethany.DisplayEmployeeDetails();

#endregion


#region First run George

george.PerformWork(10);
george.PerformWork();
george.PerformWork();
george.RecieveWage();
george.DisplayEmployeeDetails();

#endregion

Employee.taxRate = 0.02;

#region Second run Bethany

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.RecieveWage();
bethany.DisplayEmployeeDetails();

#endregion


#region Second run George

george.PerformWork(10);
george.PerformWork();
george.PerformWork();
george.RecieveWage();
george.DisplayEmployeeDetails();

#endregion

Employee.DisplayTaxRate();