using System;

namespace StudentApplication
{
    public class Student
    {
        int _stuId = 0;
        string _firstName = String.Empty;
        string _lastName = String.Empty;
        decimal _loanAmount = 0;
        char _gender = '\0';
        bool _isNew = false; 

        public Student(int stuId, string firstName, string lastName, decimal loanAmount, char gender, bool isNew)
        {
            _stuId = stuId;
            _firstName = firstName;
            _lastName = lastName;
            _loanAmount = loanAmount;
            _gender = gender;
            _isNew = isNew;
        }

        public string StudentData()
        {
            string studentData = $"stuId: {_stuId}, firstName: {_firstName}, loanAmount: {_loanAmount}";
            return studentData;
        }

        public void UpdateLoanAmount(decimal loanAmount)
        {
            _loanAmount = loanAmount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int stuId = 0;
            string firstName = String.Empty;
            string lastName = String.Empty;
            decimal loanAmount = 0;
            char gender = '\0';
            bool isNew = false;

            Console.WriteLine("Student id: ");
            stuId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Loan amount: ");
            loanAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Gender: ");
            gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Is new (true/false): ");
            isNew = Convert.ToBoolean(Console.ReadLine());

            Student student = new Student(stuId, firstName, lastName, loanAmount, gender, isNew);
            Console.Clear();

            Student studentCopy = student;
            Console.WriteLine("Student data: " + student.StudentData());
            Console.WriteLine();

            Console.WriteLine("Student data, copy: " + studentCopy.StudentData());
            Console.WriteLine();

            Console.WriteLine("Update student's loan amount");
            student.UpdateLoanAmount(Convert.ToDecimal(Console.ReadLine()));

            string dividerText = "After loan update!";
            Console.WriteLine(new String('-', dividerText.Length));
            Console.WriteLine(dividerText);
            Console.WriteLine(new String('-', dividerText.Length));

            Console.WriteLine("Student data " + student.StudentData());
            Console.WriteLine();
            Console.WriteLine("Student data, copy: " + studentCopy.StudentData());


            decimal quantity = 0;
            decimal quantityCopy = 0;
            Console.WriteLine("Enter number: ");
            quantity = Convert.ToDecimal(Console.ReadLine());
            quantityCopy = quantity;
            Console.WriteLine($"quantity: {quantity}, quantityCopy: {quantityCopy}");
            Console.ReadKey();

            quantity = quantity + 60;
            Console.WriteLine();
            Console.WriteLine("After adding 60");
            Console.WriteLine($"quantity: {quantity}, quantityCopy: {quantityCopy}");
            Console.ReadKey();

        }
    }
}
