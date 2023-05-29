using BethanysPieShopHRM.HR;

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
Employee mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16),
    30);
JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new
    DateTime(1988, 1, 23), 17);
StoreManager kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime
    (1953, 12, 12), 10);
StoreManager kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime
    (1993, 8, 8), 10);

List<Employee> employees = new List<Employee>();
employees.Add(bethany);
employees.Add(mary);
employees.Add(bobJunior);
employees.Add(kevin);
employees.Add(kate);

foreach (Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
    Console.WriteLine("");
}





/*Employee jake = new Employee("Jake", "Nicols", "jake@snowball.be", new DateTime(1995, 8,
    16), 25, "New street", "123", "123456", "Pie Ville");


bethany.DisplayEmployeeDetails();
bethany.PerformWork(8);
bethany.PerformWork();
bethany.PerformWork(3);
bethany.ReceiveWage();

mary.DisplayEmployeeDetails();
mary.PerformWork(25);
mary.PerformWork();
mary.PerformWork();
//mary.AttendManagementMeeting();
mary.ReceiveWage();
mary.GiveBonus();


bobJunior.ResearchNewPieTastes(5);
bobJunior.ResearchNewPieTastes(5);*/