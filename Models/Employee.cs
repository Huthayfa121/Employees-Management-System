namespace Employees_Manangement_System.Models
{
    public class Employee: UserActivities
    {
        public int Id { get; set; }

        public string EmpNo { get; set; }


        public string Fname { get; set; }

        public string Mname { get; set; }

        public string Lname { get; set; }

        public string FullName => $"{Fname} {Mname} {Lname}";


        public int PhoneNo { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public DateTime DOB { get; set; }

        public string Address { get; set; }

        public string Departnment { get; set; }

        public string Designation { get; set; }







    }
}
