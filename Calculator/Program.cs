namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator App";

            Console.Write("Enter First Number: ");
            decimal num1 = UserInputValidation();
            //+ - * /
            Console.WriteLine("Choose: +, -, *, /");
            Console.Write("Answer: ");
            string answer = Console.ReadLine();

            Console.Write("Enter Second Number: ");
            decimal num2 = UserInputValidation();

            switch (answer)
            {
                case "+":
                    Console.WriteLine(AddNumbers(num1,num2));
                    break;
                case "-":
                    Console.WriteLine(SubtractNumbers(num1,num2));
                    break;
                case "*":
                    Console.WriteLine(MultiplyNumbers(num1,num2));
                    break;
                case "/":
                    Console.WriteLine(DivideNumbers(num1,num2));
                    break;
                default: Console.WriteLine("Invalid User Input, try Again"); 
                    break;
            }

        }
        public static decimal UserInputValidation()
        {
            decimal result = 0; // if this is  decimal
            string? answer = Console.ReadLine(); // if this is null or white space

            while (true)
            {
                if(!string.IsNullOrWhiteSpace(answer) && decimal.TryParse(answer, out result))
                {
                    return result;
                }
                else
                {
                    //error message
                    Console.WriteLine("Invalid User Input");
                    //let them try again
                    Console.Write("Answer: ");
                    answer = Console.ReadLine();
                }
            }
        }
        public static decimal AddNumbers(decimal a, decimal b) => a + b;
        public static decimal SubtractNumbers(decimal a, decimal b) => a - b;
        public static decimal MultiplyNumbers(decimal a, decimal b) => a * b;
        public static decimal DivideNumbers(decimal a, decimal b)
        {
            if(b == 0)
                Console.WriteLine("Cannot divide by zero");
            return a / b;
        }
     
    }
}
