using System;

namespace Human
{
    // كلاس مجسد جزئي (وليس Abstract) ويرث من Person
    public partial class Student : Person
    {
        // الخصائص التلقائية والمحمية حسب الـ PDF
        public string College { get; set; }
        public string Department { get; set; }
        public string Degree { get; set; }
        public int Level { get; set; }
        public double Sum { get; set; }
        protected double Average { get; set; }
        protected string Grade { get; set; }

        protected double[] degrees;
        protected string[] subjects;

        // دالة بناء بالمعاملات المحددة بالظبط في الـ PDF[cite: 1]
        public Student(int id, string name, int age, string gender, string nationality, string bloodType, string department, int level)
            : base(id, name, age, gender, nationality, bloodType)
        {
            Department = department;
            Level = level;
        }

        // دالة طباعة البيانات باسم Person_Information بناءً على الـ PDF[cite: 1]
        public new void Person_Information()
        {
            base.Person_Information();
            Console.WriteLine($"College: {College} | Department: {Department} | Degree: {Degree} | Level: {Level}");
        }

        // دالة إدخال الدرجات مع 3 محاولات لكل مادة وتحديد النجاح/الرسوب[cite: 1]
        public void Input_Degrees()
        {
            if (Department.ToUpper() == "CS")
            {
                if (Level == 1) subjects = new string[] { "Programming 1", "Math 1", "Digital Logic" };
                else if (Level == 2) subjects = new string[] { "OOP", "Data Structures", "Discrete Math" };
                else if (Level == 3) subjects = new string[] { "Algorithms", "OS", "Database" };
                else subjects = new string[] { "AI", "Software Engineering", "Compiler" };
            }
            else // IT 
            {
                if (Level == 1) subjects = new string[] { "Intro to IT", "Web Basics", "Math 1" };
                else if (Level == 2) subjects = new string[] { "Networking 1", "OOP", "Data Structures" };
                else if (Level == 3) subjects = new string[] { "Web Dev", "Database 2", "Cyber Security" };
                else subjects = new string[] { "Cloud Computing", "IT Management", "Project" };
            }

            degrees = new double[subjects.Length];
            Sum = 0;

            for (int i = 0; i < subjects.Length; i++)
            {
                int attempts = 3;
                bool valid = false;

                while (attempts > 0 && !valid)
                {
                    Console.Write($"Enter {subjects[i]} degree: ");
                    if (double.TryParse(Console.ReadLine(), out double inputDeg) && inputDeg >= 0 && inputDeg <= 100)
                    {
                        degrees[i] = inputDeg;
                        Sum += inputDeg;
                        valid = true;
                        string status = inputDeg >= 50 ? "Passed (ناجح)" : "Failed (راسب)";
                        Console.WriteLine($"Status: {status}");
                    }
                    else
                    {
                        attempts--;
                        Console.WriteLine($"خطأ في الإدخال! المتبقي {attempts} محاولات.");
                    }
                }

                if (!valid) degrees[i] = 0;
            }

            Average = Sum / subjects.Length;
            if (Average >= 90) Grade = "Excellent";
            else if (Average >= 80) Grade = "Very Good";
            else if (Average >= 70) Grade = "Good";
            else if (Average >= 50) Grade = "Pass";
            else Grade = "Fail";
        }

        // دالة طباعة النتيجة Print_Degrees حسب الـ PDF[cite: 1]
        public void Print_Degrees()
        {
            Console.WriteLine("\n--- Student Degrees ---");
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{subjects[i]}: {degrees[i]}");
            }
            Console.WriteLine($"Sum: {Sum} | Average: {Average:F2} | Grade: {Grade}");
        }
    }
}