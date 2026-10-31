using System;
using System.Globalization;
using Human;
using EmploymentOffice;

namespace Management
{
    // كلاس مجسد ممتد من Employee[cite: 1]
    public class ManagementClass : Employee
    {
        private Student[] students;

        public ManagementClass() : base("Programmer", "Bachelor") { }

        // دالة ناسخة تمنع الاستنساخ مرة أخرى (sealed override)[cite: 1]
        public sealed override void Salary_inc()
        {
            base.Salary_inc();
            double totalSalary = Salary + Incentive;
            Console.WriteLine($"Salary: {Salary}$ | Incentive: {Incentive}$ | Total: {totalSalary}$");
        }

        // دالة ناسخة للدالة المجردة getData_emp[cite: 1]
        public override void getData_emp()
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            Console.Write("Enter number of students: ");
            int count = int.Parse(Console.ReadLine());
            students = new Student[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n--- Entering Data for Student #{i + 1} ---");
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Age: "); int age = int.Parse(Console.ReadLine());
                Console.Write("Gender: "); string gender = Console.ReadLine();
                Console.Write("Nationality: "); string nat = Console.ReadLine();
                Console.Write("Blood Type: "); string blood = Console.ReadLine();
                Console.Write("College: "); string college = Console.ReadLine();
                Console.Write("Department (CS/IT): "); string dept = Console.ReadLine();
                Console.Write("Level (1-4): "); int level = int.Parse(Console.ReadLine());

                // تحويل المخرجات والأسماء إلى TitleCase بناءً على الـ PDF[cite: 1]
                name = textInfo.ToTitleCase(name);
                dept = dept.ToUpper();

                students[i] = new Student(i + 1, name, age, gender, nat, blood, dept, level);
                students[i].College = textInfo.ToTitleCase(college);

                students[i].Input_Degrees();
            }

            Console.WriteLine("\n================ ALL STUDENTS RESULTS ================");
            foreach (var st in students)
            {
                Console.WriteLine("------------------------------------------------------");
                st.Person_Information();
                st.Print_Degrees();

                Console.Write("Employee System Details -> ");
                Salary_inc();
            }
        }
    }
}