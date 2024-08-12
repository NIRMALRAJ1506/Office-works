namespace OopsAdvanceDemo
{
    internal class Employee:Person
    {
       public int empId { get; set; }
       public int salary { get; set; }

        public override string getDetails()
        {
            return "FirstName: " + firstName + "\n" + "LastName: " + lastName + "\n" + "Gender: " + Gender + "\n"
                + "Student ID: " + this.empId + "\n" + "Student Mark: " + this.salary;
        }
    }
}
