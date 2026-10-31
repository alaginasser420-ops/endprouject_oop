using System;

namespace EmploymentOffice
{
    // 1- كلاس مجرد كلي[cite: 1]
    public abstract class Employee
    {
        // 2- الخصائص الديناميكية[cite: 1]
        public double Salary { get; set; } 
        public double Incentive { get; set; }
        public string Job_type { get; set; }
        public string Scientific_degree { get; set; }

        // 3- دالة بناء[cite: 1]
        public Employee(string jobType, string scientificDegree)
        {
            Job_type = jobType;
            Scientific_degree = scientificDegree;
        }

        // 4- دالة وهمية لتحديد الراتب والحافز[cite: 1]
        public virtual void Salary_inc()
        {
            switch (Job_type.ToLower())
            {
                case "manager": Salary = 1500; break;
                case "programmer": Salary = 1200; break;
                case "teacher": Salary = 1000; break;
                case "accountant": Salary = 900; break;
                default: Salary = 700; break;
            }

            switch (Scientific_degree.ToLower())
            {
                case "doctora": Incentive = 500; break;
                case "master": Incentive = 300; break;
                case "bachelor": Incentive = 150; break;
                default: Incentive = 50; break;
            }
        }

        // 5- دالة مجردة[cite: 1]
        public abstract void getData_emp();
    }
}