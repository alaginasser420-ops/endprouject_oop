using System;

namespace Management
{
    // كلاس مجسد عقيم (sealed class)[cite: 1]
    public sealed class ControlClass : ManagementClass
    {
        // دالة ناسخة لدالة getData_emp بناءً على طلب الـ PDF[cite: 1]
        public override void getData_emp()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("   WELCOME TO ACADEMIC & EMPLOYMENT SYSTEM");
            Console.WriteLine("==================================================");
            Console.WriteLine("Group Members:");
            Console.WriteLine("1. Naser Mohammed Al-Aji");
            Console.WriteLine("2. Ayman Abdulhamid Al-Harugi");
            Console.WriteLine("3. Mohammed Saleh Al-Harugi");
            Console.WriteLine("4. Hakeem Al-Qaysi");
            Console.WriteLine("==================================================");
            Console.WriteLine("Press ANY key to clear screen and start execution...");
            Console.ReadKey();

            // إزالة البيانات السابقة[cite: 1]
            Console.Clear();

            // تنفيذ الدالة الرئيسية
            base.getData_emp();
        }
    }
}