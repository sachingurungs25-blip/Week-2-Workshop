namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----

            // TODO 1: declare a variable called userName that holds your name.
            //         Text needs the type string.
            string userName = "Sachin Gurung";

            // TODO 2: declare a variable called luckyNumber holding your
            //         favourite single-digit number. A whole number is int.
            int luckyNumber = 9827;

            // TODO 3: print ONE line that reads exactly:
            //         Hello, <your name>! Your lucky number is <the number>.
            //         Use string interpolation, not the + operator.
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");


            // ---- Task 2: constants ----

            // TODO 2: create a Circle object and print Circle.PI.
            //         PI is a constant, so you read it through the class
            //         name rather than through an object.
            Circle circle = new Circle();
            Console.WriteLine($"Circle PI is {Circle.PI}");

            // TODO 3: now write this on a line of its own:
            //             Circle.PI = 3.15;
            //         then build and read the error.
            //         When you have read it, delete the line again so the
            //         remaining tasks still run.

            // Circle.PI = 3.15;


            // ---- Task 3: data types and type conversion ----

            byte tiny = 200;
            short small = 30000;

            // TODO 4: declare one variable for each of these types and give
            //         it a sensible value:
            //             int, long, float, double, decimal, char, bool
            int number = 100000;
            long bigNumber = 1000000000L;
            float decimalNumber = 3.14f;
            double doubleNumber = 3.14159;
            decimal money = 99.99m;
            char letter = 'A';
            bool isStudent = true;

            // TODO 5: convert the number 42 into a string, storing the
            //         result in a new variable.
            string numberString = 42.ToString();

            // TODO 6: convert the string "3.14" into a double, storing the
            //         result in a new variable.
            double convertedDouble = double.Parse("3.14");

            // These two lines are done for you as a model.
            Console.WriteLine($"byte   = {tiny}      (type: byte)");
            Console.WriteLine($"short  = {small}     (type: short)");

            // TODO 7: print one labelled line for each of the remaining
            //         variables, including the two you converted.
            //         Keep the spacing so the columns line up.
            Console.WriteLine($"int    = {number}      (type: int)");
            Console.WriteLine($"long   = {bigNumber}      (type: long)");
            Console.WriteLine($"float  = {decimalNumber}      (type: float)");
            Console.WriteLine($"double = {doubleNumber}      (type: double)");
            Console.WriteLine($"decimal = {money}      (type: decimal)");
            Console.WriteLine($"char   = {letter}      (type: char)");
            Console.WriteLine($"bool   = {isStudent}      (type: bool)");
            Console.WriteLine($"string = {numberString}      (type: string)");
            Console.WriteLine($"converted double = {convertedDouble}      (type: double)");


            // ---- Task 4: arrays and Array methods ----
            int[] numbers = { 42, 7, 19, 3, 88 };

            // TODO 8: print the numbers in their original order on one
            //         line, separated by commas.
            Console.WriteLine($"Original : {string.Join(", ", numbers)}");

            // TODO 9: sort them ascending with Array.Sort, then print the
            //         line again.
            Array.Sort(numbers);
            Console.WriteLine($"Sorted   : {string.Join(", ", numbers)}");

            // TODO 10: reverse them with Array.Reverse, then print again.
            Array.Reverse(numbers);
            Console.WriteLine($"Reversed : {string.Join(", ", numbers)}");

            // TODO 11: print each element on its own line using a for loop,
            //          showing the index as well as the value.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"  [{i}] = {numbers[i]}");
            }

            // TODO 12: use Array.IndexOf to find the position of 19 and
            //          print it. Then look up 100 and print that too.
            Console.WriteLine($"IndexOf(19)  = {Array.IndexOf(numbers, 19)}");
            Console.WriteLine($"IndexOf(100) = {Array.IndexOf(numbers, 100)}");


            // ---- Task 5: DateTime and TimeSpan ----
            DateTime birthDate = new DateTime(2006, 7, 17);

            // TODO 13: declare a DateTime holding the current date and time,
            //          called today.
            DateTime today = DateTime.Now;

            // TODO 14: subtract birthDate from today. The result is a
            //          TimeSpan — name it ageSpan.
            //          Subtracting two DateTimes gives you a TimeSpan, so
            //          there is nothing to convert explicitly.
            TimeSpan ageSpan = today - birthDate;

            // TODO 15: work out the age in whole years from the TimeSpan and
            //          store it in an int called years.
            //          ageSpan.TotalDays / 365.25 gives a decimal number of
            //          years — cast it to int to drop the fraction.
            int years = (int)(ageSpan.TotalDays / 365.25);

            // TODO 16: print your birth date, today's date, your age in
            //          years, and your birth date plus 10 days.
            Console.WriteLine($"Birth date : {birthDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Today      : {today.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Total days : {(int)ageSpan.TotalDays}");
            Console.WriteLine($"Age        : {years} years");
            Console.WriteLine($"Birth + 10 days : {birthDate.AddDays(10).ToString("yyyy-MM-dd")}");

            // ---- Task 6: List<T> and Dictionary<K,V> ----
List<string> fruits = new() { "Apple", "Mango", "Banana" };

// TODO 17: add one more fruit to the end of the list.
fruits.Add("Orange");

// TODO 18: remove one fruit from the list.
fruits.Remove("Mango");

// TODO 19: print every remaining fruit on its own line using a
//          foreach loop.
foreach (string fruit in fruits)
{
    Console.WriteLine($"  {fruit}");
}

// TODO 20: declare a Dictionary<int, string> called byId whose
//          keys are 1, 2 and 3 and whose values are fruit names.
Dictionary<int, string> byId = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Mango" },
    { 3, "Banana" }
};

// TODO 21: add a fourth entry, then print every key-value pair
//          using a foreach loop over the dictionary.
byId.Add(4, "Orange");

foreach (KeyValuePair<int, string> pair in byId)
{
    Console.WriteLine($"  {pair.Key} -> {pair.Value}");
}
        }
    }
}