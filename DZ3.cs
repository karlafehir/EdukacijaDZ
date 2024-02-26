// -----------------------------Z1--------------------------------
// Console.WriteLine("Enter a number in range 1-9:");
// var input = Console.ReadLine();

// try
// {
//     int num = Convert.ToInt32(input);
//     int height = num;

//     if (num >= 10 || num <= 0)
//     {
//         Console.WriteLine("Please enter a number in range 1-9.");
//     }
//     else
//     {
//         for (int i = 1; i < num + 1; i++)
//         {
//             for (int j = 0; j < height - 1; j++)
//             {
//                 Console.Write(" ");
//             }
//             for (int j = 1; j < i + 1; j++)
//             {
//                 Console.Write(j);
//             }
//             for (int j = i - 1; j > 0; j--)
//             {
//                 Console.Write(j);
//             }
//             Console.WriteLine();
//             height--;
//         }
//     }
// }
// catch (FormatException)
// {
//     Console.WriteLine("Not a correct format, please enter a number in range 1-9.");
// }







// -----------------------------Z2--------------------------------
// Console.Write("Enter number to generate Fibonacci sequence:");
// var input = Console.ReadLine();

// try
// {
//     int num = Convert.ToInt32(input);
//     calculateFibonacci(num);

// }
// catch (FormatException)
// {
//     Console.WriteLine("Not a correct format, please enter a number.");
// }

// void calculateFibonacci(int num)
// {
//     int a = 0, b = 1, c, sumOdd = 0, sumEven = 0;

//     for (int i = 0; a <= num; i++)
//     {

//         if (a % 2 == 0)
//         {
//             sumEven += a;
//         }
//         else
//         {
//             sumOdd += a;
//         }
//         Console.Write(a + " ");
//         c = a + b;
//         a = b;
//         b = c;

//     }
//     Console.WriteLine();
//     Console.WriteLine($"Sum of odd numbers in the sequence: {sumOdd}");
//     Console.WriteLine($"Sum of even numbers in the sequence: {sumEven}");
// }

//NOT COMPLETED - SUM MISSING








// -----------------------------Z3--------------------------------
// Console.Write("Enter first number:");
// var input1 = Console.ReadLine();

// Console.Write("Enter second number:");
// var input2 = Console.ReadLine();

// Console.Write("Enter operator (+,-,*,/,%,sve.):");
// var operatorInput = Console.ReadLine();

// try
// {
//     int num1 = Convert.ToInt32(input1);
//     int num2 = Convert.ToInt32(input2);

//     if (operatorInput.ToLower() == "sve")
//     {
//         CalculateAll(num1, num2);
//     }
//     else
//     {
//         if (IsValidOperator(operatorInput))
//         {
//             int result = SolveOperator(num1, num2, operatorInput);
//             Console.WriteLine($"{num1} {operatorInput} {num2} = {result}");
//         }
//         else
//         {
//             Console.WriteLine("Invalid operator.");
//         }
//     }
// }
// catch (FormatException)
// {
//     Console.WriteLine("Not a correct format, please enter a number.");
// }
// catch (InvalidOperationException ex)
// {
//     Console.WriteLine(ex.Message);
// }

// bool IsValidOperator(string op)
// {
//     return op == "+" || op == "-" || op == "*" || op == "/" || op == "%";
// }

// void CalculateAll(int a, int b)
// {
//     Console.WriteLine($"{a} + {b} = {a + b}");
//     Console.WriteLine($"{a} - {b} = {a - b}");
//     Console.WriteLine($"{a} * {b} = {a * b}");

//     if (b != 0)
//     {
//         Console.WriteLine($"{a} / {b} = {a / b}");
//         Console.WriteLine($"{a} % {b} = {a % b}");
//     }
//     else
//     {
//         Console.WriteLine("Cannot divide and calculate modul with 0.");
//     }
// }

// int SolveOperator(int a, int b, string op)
// {
//     switch (op)
//     {
//         case "+":
//             return a + b;
//         case "-":
//             return a - b;
//         case "*":
//             return a * b;
//         case "/":
//             return b != 0 ? a / b : throw new InvalidOperationException("Cannot divide by 0.");
//         case "%":
//             return b != 0 ? a % b : throw new InvalidOperationException("Cannot calculate moduls with 0.");
//         default:
//             Console.WriteLine("Invalid operator.");
//             return 0;
//     }
// }





// -----------------------------Z4--------------------------------
// Random random = new Random();
// int randomNum = random.Next(1, 101);
// bool isNumCorrect = false;

// Console.WriteLine(randomNum);
// Console.WriteLine("Guess the number:");

// while (!isNumCorrect)
// {
//     int guessedNum = Convert.ToInt32(Console.ReadLine());

//     if (guessedNum == randomNum)
//     {
//         Console.WriteLine("Number guessed!");
//         isNumCorrect = true;
//     }
//     else
//     {
//         if (guessedNum < randomNum)
//         {
//             Console.WriteLine("Number is too low. Try again.");
//         }
//         if (guessedNum > randomNum)
//         {
//             Console.WriteLine("Number is too high. Try again.");
//         }
//     }
// }





// -----------------------------Z5--------------------------------
// Console.Write("Enter a word: ");
// string input = Console.ReadLine();

// string reversedWord = "";
// Console.WriteLine(ReverseWord(input));

// string ReverseWord(string word)
// {
//     var charArray = word.ToCharArray();
//     for (int i = charArray.Length - 1; i > -1; i--)
//     {
//         reversedWord += charArray[i];
//     }
//     return reversedWord;
// }





// -----------------------------Z6--------------------------------
// Console.Write("Enter a sentence: ");
// string input = Console.ReadLine();

// string[] words = input.Split(' ');

// string shortest = words[0];
// string longest = words[0];

// for (int i = 0; i < words.Length; i++)
// {
//     if (words[i].Length < shortest.Length)
//     {
//         shortest = words[i];
//     }

//     if (words[i].Length > longest.Length)
//     {
//         longest = words[i];
//     }
// }

// Console.WriteLine($"Shortest Word: {shortest}");
// Console.WriteLine($"Longest Word: {longest}");



// -----------------------------Z7--------------------------------
// Console.WriteLine("Enter a word:");
// string input = Console.ReadLine();
// int vowelCount = 0;

// vowelCount = CountVowels(input);

// Console.Write($"Number of vowels is {vowelCount}");


// bool isVowel(char c)
// {
//     return "aeiou".Contains(c);
// }

// int CountVowels(string word)
// {
//     foreach (char letter in word.ToLower())
//     {
//         if (isVowel(letter))
//         {
//             vowelCount++;
//         }
//     }
//     return vowelCount;
// }



// -----------------------------Z8--------------------------------
// string writeText = "Hello World!";
// File.WriteAllText("filename.txt", writeText);

// string readText = File.ReadAllText("filename.txt");
// Console.WriteLine(readText);