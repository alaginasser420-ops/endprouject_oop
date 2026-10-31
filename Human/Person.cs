using System;

namespace Human
{
    // 2- كلاس مجرد جزئي
    public abstract partial class Person
    {
        // 3- الحقول الثابتة ذات محدد وصول من داخل الكلاس
        private int id;
        private string name;
        private int age;
        private string gender;
        private string nationality;
        private string bloodType;

        // 4- دالة بناء لتهيئة الحقول يتم الوصول إليها من خلال الوراثة
        protected Person(int id, string name, int age, string gender, string nationality, string bloodType)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.nationality = nationality;
            this.bloodType = bloodType;
        }

        // 5- دالة لطباعة البيانات يتم الوصول إليها بالوراثة
        protected void Person_Information()
        {
            Console.WriteLine($"ID: {id} | Name: {name} | Age: {age} | Gender: {gender} | Nationality: {nationality} | Blood Type: {bloodType}");
        }
    }
}