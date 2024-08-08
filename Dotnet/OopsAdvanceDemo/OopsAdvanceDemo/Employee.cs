namespace OopsAdvanceDemo
{
    internal class Employee:Person
    {
       public int empId { get; set; }
       public int salary { get; set; }

        public Employee(string firstName, string lastName, string Gender, int empId, int salary) : base(firstName, lastName, Gender)
        {
            this.empId = empId;
            this.salary = salary;
        }
        public void DisplayEmployeeDetails()
        {
            base.getDetails();
            Console.WriteLine("Employee Id: " + this.empId);
            Console.WriteLine("Employee Salary: " + this.salary);
        }
    }
}
