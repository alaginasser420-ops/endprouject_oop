namespace Management
{
    class Program
    {

        static void Main(string[] args)
        {
         
            // التنفيذ باستخدام Control Class حسب الـ PDF[cite: 1]
            ControlClass control = new ControlClass();
            control.getData_emp();

            Console.WriteLine("\nPress ANY key to exit...");
            Console.ReadKey();
        }
    }
}