using System;

namespace AutoSendMailService.Model
{
    class Employee
    {
        private int id;
        private DateTime dateOfBirth;
        private string name = "";
        private string employeeType = "";
        private string sex;

        public Employee(int id, DateTime dateOfBirth, string name, string employeeType, string sex)
        {
            this.id = id;
            this.dateOfBirth = dateOfBirth;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.employeeType = employeeType ?? throw new ArgumentNullException(nameof(employeeType));
            this.sex = sex ?? throw new ArgumentNullException(nameof(sex));
        }

        public Employee()
        {
        }
        public int getId() { return this.id; }
        public void setId(int value) { this.id = value; }
        public DateTime getDateOfBirth() { return this.dateOfBirth; }
        public void setDateOfBirth(DateTime value) { this.dateOfBirth = value; }
        public string getName() { return this.name; }
        public void setName(string value) { this.name = value; }
        public string getEmployeeType() { return this.employeeType; }
        public void setEmployeeType(string value) { this.employeeType = value; }
        public string getSex() { return this.sex; }
        public void setSex(string value) { this.sex = value; }


    }
}
