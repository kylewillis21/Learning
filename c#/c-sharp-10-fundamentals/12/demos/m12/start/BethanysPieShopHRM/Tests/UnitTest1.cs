using BethanysPieShopHRM.HR;

namespace Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void PerfromWork_Adds_NumberOfHours()
        {
            //Arrange
            Employee employee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

            int numberOfHours = 3;
            //Act
            employee.PerformWork(numberOfHours);

            //Assert
            Assert.Equal(numberOfHours, employee.NumberOfHoursWorked);
        }

        [Fact]
        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
        {
            Employee employeee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

            employeee.PerformWork();

            Assert.Equal(1, employeee.NumberOfHoursWorked);
        }
    }
}