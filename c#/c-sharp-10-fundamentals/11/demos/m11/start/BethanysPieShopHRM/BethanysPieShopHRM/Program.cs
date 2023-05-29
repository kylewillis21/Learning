using BethanysPieShopHRM.HR;

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16),
    30);
JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new
    DateTime(1988, 1, 23), 17);

bethany.DisplayEmployeeDetails();
bethany.PerformWork(8);
bethany.PerformWork();
bethany.PerformWork(3);
bethany.ReceiveWage();

mary.DisplayEmployeeDetails();
mary.PerformWork(25);
mary.PerformWork();
mary.PerformWork();
mary.AttendManagementMeeting();
mary.ReceiveWage();

bobJunior.ResearchNewPieTastes(5);
bobJunior.ResearchNewPieTastes(5);
bobJunior.ResearchNewPieTastes(5);
bobJunior.ReceiveWage();