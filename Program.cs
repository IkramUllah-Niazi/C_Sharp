using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            /*
            //            Console.WriteLine("Hello, World!");
            //            Console.WriteLine("Hello How are you ?");
            //            Console.WriteLine("I love Pakistan");
            //            Console.Write("Hello  ");
            //            Console.WriteLine("I am from Gilgit Baltistan");
            //            Console.WriteLine("Hello\nWorld");

            //            Console.WriteLine(6 + 5);    //11
            //            Console.WriteLine(8 - 4);    //4
            //            Console.WriteLine(6.0/5);    //1.2
            //            Console.WriteLine(5*6);    //30
            //            Console.WriteLine(5%6);    //5
            //            Console.WriteLine(8 % 6);   //2
            //            int a = 113;
            //            a++;
            //            Console.WriteLine(a);//114
            //            int b = 125;
            //            b--;
            //            Console.WriteLine(b);//124

            //             > Greater than
            //             < Less than
            //             >= Greater than or equal to 
            //             <= Less than or equal to
            //             != Equal or not

            //            Console.WriteLine(20>10); //true
            //            Console.WriteLine(10<20);  //true
            //            Console.WriteLine(20>=10); //true
            //            Console.WriteLine(10<=20); //true
            //            Console.WriteLine(20!=10); //true


            //            Console.WriteLine(206 | 76);  //206
            //            Console.WriteLine(206 & 76);  //76
            //            Console.WriteLine(80 | 90);  //90
            //            Console.WriteLine(80 & 90);  //80
            //            Console.WriteLine(970 | 409);  //987
            //            Console.WriteLine(970 & 409);  //392
            //            Console.WriteLine(764 | 119);//767
            //            Console.WriteLine(764 & 119); // 116

            //            Console.WriteLine("Hello \n Pakistan"); //line break
            //            Console.WriteLine("Hello \t Pakistan"); //give space between
            //            Console.WriteLine("Hello\a\b Pakistan");
            //            Console.WriteLine("Hello 'Pakistan'");


            //            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
            //            Console.WriteLine("The length of the txt string is: " + txt.Length); //length of text

            //            string & float price
            //            int age =20;  //declaration + initialization
            //            int age=20;//declaration
            //            int ages =22;  // initialization

            //            Console.WriteLine(age); //20
            //            Console.WriteLine(ages); //22

            //            float price = 500.99f;
            //            float frq = 500.99999999f;
            //            double frqu = 500.55555f;
            //            decimal ab = 50.000000m;
            //            Console.WriteLine(price);
            //            Console.WriteLine(frq);
            //            Console.WriteLine(frqu);
            //            Console.WriteLine(ab);

            //            char key ='i';
            //            Console.WriteLine(key);

            //            string name ="IkramUllah";
            //            Console.WriteLine(name);


            //            string firstName = "Ikram";
            //            string lastName = "Ullah";
            //            string FullName = firstName + lastName;  //IkramUllah

            //            string firstNames = "IkramUllah";
            //            string lastNames = "Balti";
            //            Console.WriteLine(firstNames + "  " + lastNames); //Ikram Ullah


            //            bool X = true;
            //            bool Y = false;
            //            Console.WriteLine(X);   // Outputs True
            //            Console.WriteLine(Y);   // Outputs False

            //            int sugerPrice = 100, ricePrice = 130, breadPrice = 160;
            //            sugerPrice=125;
            //            Console.WriteLine("Suger Price Is = "+ sugerPrice + "\n" + "Rice Price is = " + ricePrice +"\n"+"Bread Price is = " + breadPrice);
            //            Console.WriteLine("Suger Price Is = " + sugerPrice + " " + "Rice Price is = " + ricePrice + " " + "Bread Price is = " + breadPrice);

            //            string FirstName = "Ikram";
            //            string LastName = "Ullah";
            //            string Name = $"My full name is: {FirstName} {LastName}";
            //            Console.WriteLine(name);

            //            const string schoolName= "kips School";
            //            Console.WriteLine(schoolName);

            //            string tx = "I am \"IkramUllah\" from the north Pakistan.";
            //             Console.WriteLine(tx);

            //            string tex = "I am \'IkramUllah\' from the north Pakistan.";
            //            Console.WriteLine(tex);

            //            string text = "I am \\IkramUllah\\ from the north Pakistan.";
            //            Console.WriteLine(text);

            //            int remainder = 4 % 3;
            //            Console.WriteLine(remainder);

            //            int remander = 106 % 3;
            //            Console.WriteLine(remander);

            //            int rmainder = 8 % 4;
            //            Console.WriteLine(rmainder);

            //            int remaindr = 18 % 7;
            //            Console.WriteLine(remaindr);


            //            double abc = 6.99;
            //            double bac = 3.243;
            //            double e = Math.Pow(abc, 3);
            //            double x = Math.Sqrt(abc);
            //            double d = Math.Abs(abc);
            //            double f = Math.Round(abc);
            //            double g = Math.Ceiling(abc);
            //            double h = Math.Floor(abc);
            //            double i = Math.Max(abc, bac);
            //            double j = Math.Min(abc, bac);

            //            Console.WriteLine(e);
            //            Console.WriteLine(x);
            //            Console.WriteLine(d);
            //            Console.WriteLine(f);
            //            Console.WriteLine(g);
            //            Console.WriteLine(h);
            //            Console.WriteLine(i);
            //            Console.WriteLine(j);

            //            Random random = new Random();
            //            int num = random.Next(1, 101);
            //            int nm = random.Next(1, 5);
            //            double nme = random.Next();
            //            Console.WriteLine("Random number: " + num);
            //            Console.WriteLine("Random number: " + nm);
            //            Console.WriteLine("Random number: " + nme);

            //            Find hypotenuse
            //            Console.WriteLine("Enter side of A= ");
            //            double A = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Enter side of B= ");
            //            double B = Convert.ToDouble(Console.ReadLine());
            //            double C = Math.Sqrt((A * A) + (B * B));
            //            Console.WriteLine("The hypotenuse is =" + C);


            //            To upper case
            //            string FulName = "Ikramullah";
            //            FullName = FullName.ToUpper();
            //            Console.WriteLine(FullName);

            //            To Lower case
            //            string FulNme = "Ikramullah";
            //            FulNme = FulNme.ToLower();
            //            Console.WriteLine(FulNme);

            //            string phoneNumber = "123-45468-976";
            //            phoneNumber = phoneNumber.Replace("-", "/");
            //            Console.WriteLine(phoneNumber);

            //            string userName = FullName.Insert(0, "Mr ");
            //            Console.WriteLine(userName);
            //            Console.WriteLine(FulNme.Length);

            //            string fullName = "Ikramullah";
            //            string firstName = fullName.Substring(0, 5);
            //            string lastName = fullName.Substring(5, 5);
            //            Console.WriteLine(firstName);
            //            Console.WriteLine(lastName);


            //            if statement = a basic form of decision making
            //            Console.WriteLine("Please Enter Your Age = ");
            //            int age = Convert.ToInt32(Console.ReadLine());
            //            if (age >= 18)
            //            {
            //                Console.WriteLine("Your are now signed up!");
            //            }
            //            else if (age > 100)
            //            {
            //                Console.WriteLine("Your are too old to sign up!");
            //            }
            //            else if (age < 0)
            //            {
            //                Console.WriteLine("You have not been born yrt!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("You must be 18+ to sign up! ");
            //            }


            //            Console.WriteLine("Please Enter Your Name = ");
            //            string name = Console.ReadLine();
            //            if (name == " ")
            //            {
            //                Console.WriteLine("You did not enter your name!");
            //            }
            //            else 
            //            {
            //                Console.WriteLine("Hello " + name);
            //            }


            //            Console.WriteLine("Please Enter Your Name = ");
            //            string name = Console.ReadLine();
            //            if (name != " ")
            //            {
            //                Console.WriteLine("Hello " + name);
            //            }
            //            else
            //            {
            //                Console.WriteLine("You did not enter your name!");
            //            }

            //             */
            //            /*
            //             Switch = an efficient alternative to many else if statements

            //            Console.WriteLine("What day is it today ?");
            //            string day = Console.ReadLine();
            //            if (day == "Monday")
            //            {
            //                Console.WriteLine("It's Monday");
            //            }
            //            else if (day == "Tuesday")
            //            {
            //                Console.WriteLine("It's Tuesday");
            //            }
            //            else if (day == "Wednesday")
            //            {
            //                Console.WriteLine("It's Wednesday");
            //            }
            //            else if (day == "Thursday")
            //            {
            //                Console.WriteLine("It's Thursday");
            //            }
            //            else if (day == "Friday")
            //            {
            //                Console.WriteLine("It's Friday");
            //            }
            //            else if (day == "Saturday")
            //            {
            //                Console.WriteLine("It's Saturday");
            //            }
            //            else if (day == "Sunday")
            //            {
            //                Console.WriteLine("It's Sunday");
            //            }
            //            else 
            //            {
            //                Console.WriteLine(day + " is nat a day");            
            //            }
            //            */

            //            Switch = an efficient alternative to many else if statements
            //            /*
            //            Console.WriteLine("What day is it today ?");
            //            string day = Console.ReadLine();
            //            switch (day)
            //                {
            //                  case "Monday":
            //                    Console.WriteLine("It's Monday!");
            //                    break;
            //                  case "Tuesday":
            //                    Console.WriteLine("It's Tuesday!");
            //                    break;
            //                case "Wednesday":
            //                    Console.WriteLine("It's Wednesday!");
            //                    break;
            //                case "Thursday":
            //                    Console.WriteLine("It's Thursday!");
            //                    break;
            //                case "Friday":
            //                    Console.WriteLine("It's Friday!");
            //                    break;
            //                case "Saturday":
            //                    Console.WriteLine("It's Saturday!");
            //                    break;
            //                case "Sunday":
            //                    Console.WriteLine("It's Sunday!");
            //                    break;
            //                 default:
            //                    Console.WriteLine(day + " is not a day");
            //                    break;
            //            }
            //            */
            //                /*
            //                Logical operators = Can be used to check if more than 1 condition is true/false.
            //                && (AND) || (OR)
            //                Console.WriteLine("What's the temperature outside:(c)");
            //                double temp = Convert.ToDouble(Console.ReadLine());
            //                if (temp >= 10 && temp <= 25)
            //                {
            //                    Console.WriteLine("It's warm outside!");
            //                }
            //                else if (temp <= -50 || temp >= 50)
            //                {
            //                    Console.WriteLine("Do not go outside!");
            //                }

            //                 While loop = repeats some code while some condition remains true

            //                Console.WriteLine("What your name ?");
            //                string names = Console.ReadLine();
            //                while (1 == 1)
            //                {
            //                    Console.WriteLine("HELP! I am stuck in an infinite loops: ");

            //                }
            //                Console.WriteLine("Hdello : " + names);

            //                Console.WriteLine("What your name ?");
            //                string name = Console.ReadLine();
            //                while (name == "")
            //                {
            //                    Console.WriteLine("Enter your name: ");
            //                    Console.ReadLine();
            //                }
            //                Console.WriteLine("Your name is : " + name);
            //                */
            //             For loop = repeats some code a finite amount of time
            //            /*
            //            for (int i = 0; i <= 10; i++)
            //            {
            //                Console.WriteLine(i);
            //            }

            //            for (int i = 10; i > 0; i--)
            //            {
            //                Console.WriteLine(i);
            //            }
            //            Console.WriteLine("Happy new year");

            //            for (int a = 0; a <= 1000; a++)
            //            {
            //                Console.WriteLine("   IkramUllah  From  Gilgit  Baltistan");
            //            }

            //            for (int i = 10; i > 0; i--)
            //            {
            //                Console.WriteLine(i);
            //            }
            //            Console.WriteLine("Happy new year");
            //            */
            //            /*
            //             Nested Loops = loop inside of another loop uses vary.Used a lot in sorting algorithums.
            //            Console.WriteLine("How many rows?: ");
            //            int rows = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("How many columns?: ");
            //            int columns = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("What symbol:");
            //            string symbol = Console.ReadLine();
            //            for (int i = 0; i < rows; i++)
            //            {
            //                for (int j = 0; j < columns; j++)
            //                {
            //                    Console.WriteLine(symbol);
            //                }
            //                Console.WriteLine();
            //            }
            //            */
            //            /*
            //            Random random = new Random();
            //            bool playAgain = true;
            //            int min = 1;
            //            int max = 100;
            //            int guess;
            //            int number;
            //            int guesses;
            //            string response;

            //            while (playAgain)
            //            {
            //                guess = 0;
            //                guesses = 0;
            //                response = "";
            //                number = random.Next(min, max + 1);

            //                while (guess != number)
            //                {
            //                    Console.WriteLine("Guess a number between " + min + " _ " + max + " : ");
            //                    guess = Convert.ToInt32(Console.ReadLine());
            //                    Console.WriteLine("Guess: " + guess);

            //                    if (guess != number)
            //                    {
            //                        Console.WriteLine(guess + " is to high!");
            //                    }
            //                    else if (guess < number)
            //                    {
            //                        Console.WriteLine(guess + " is to low!");
            //                    }
            //                    guesses++;
            //                }
            //                Console.WriteLine("Number: " + number);
            //                Console.WriteLine("You Win!");
            //                Console.WriteLine("Guesses: " + guesses);

            //                Console.WriteLine("Would you like to play again (Y/N): ");
            //                response = Console.ReadLine();
            //                response = response.ToUpper();

            //                if (response == "Y")
            //                {
            //                    playAgain = true;
            //                }
            //                else
            //                {
            //                    playAgain = false;
            //                }
            //            }

            //            Console.WriteLine("Thanks for playing!...I guess");

            //            Console.WriteLine("Enter hour: ");
            //            int hour = Convert.ToInt32(Console.ReadLine());

            //            if (hour >= 7 && hour <= 11)
            //            {
            //                Console.WriteLine("Good Morning");
            //            }
            //            else if (hour >= 12 && hour <= 15)
            //            {
            //                Console.WriteLine("Good Noon");
            //            }
            //            else if (hour >= 16 && hour <= 18)
            //            {
            //                Console.WriteLine("Good Afternoon");
            //            }
            //            else if (hour >= 19 && hour <= 22)
            //            {
            //                Console.WriteLine("Good Evening");
            //            }
            //            else if ((hour >= 0 && hour <= 6) || hour > 24)
            //            {
            //                Console.WriteLine("Good Night");
            //            }
            //            else
            //            {
            //                Console.WriteLine(hour + " is not a valid hour's! ");
            //            }
            //            */

            //            /*
            //            int num1, num2, result;
            //            char op;

            //            Console.Write("Enter first number: ");
            //            num1 = int.Parse(Console.ReadLine());

            //            Console.Write("Enter second number: ");
            //            num2 = int.Parse(Console.ReadLine());

            //            Console.Write("Enter an operator (+, -, *, /): ");
            //            op = char.Parse(Console.ReadLine());

            //            switch (op)
            //            {
            //                case '+':
            //                    result = num1 + num2;
            //                    Console.WriteLine("Result: " + result);
            //                    break;
            //                case '-':
            //                    result = num1 - num2;
            //                    Console.WriteLine("Result: " + result);
            //                    break;
            //                case '*':
            //                    result = num1 * num2;
            //                    Console.WriteLine("Result: " + result);
            //                    break;
            //                case '/':
            //                    if (num2 != 0)
            //                    {
            //                        result = num1 / num2;
            //                        Console.WriteLine("Result: " + result);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Cannot divide by zero!");
            //                    }
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid operator!");
            //                    break;
            //            }

            //            */
            //            /*
            //            int hours;
            //            char hours;

            //            Console.WriteLine("Enter hour: ");
            //            hours = Convert.Todouble(Console.ReadLine());

            //            switch (hours)
            //            {
            //                case 'A':
            //                case 'a':
            //                    Console.WriteLine("Good Morning");
            //                    break;
            //                case 'B':
            //                case 'b':
            //                    Console.WriteLine("Good Noon");
            //                    break;
            //                case 'C':
            //                case 'c':
            //                    Console.WriteLine("Good Afternoon");
            //                    break;
            //                case 'D':
            //                case 'd':
            //                    Console.WriteLine("Good Evening");
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid option");
            //                    break;
            //            }

            //            if (hours >= 19 && hours <= 22)
            //            {
            //                Console.WriteLine("Result: ");
            //            }
            //            else if (hours < 7 || hours > 22)
            //            {
            //                Console.WriteLine("Invalid hour");
            //            }
            //            */
            //            /*
            //            char hour;

            //            Console.WriteLine("Enter time period (A, B, C, D): ");
            //            hour = Console.ReadKey().KeyChar;

            //            switch (hour)
            //            {
            //                case 'A':
            //                case 'a':
            //                    Console.WriteLine("Good Morning");
            //                    break;
            //                case 'B':
            //                case 'b':
            //                    Console.WriteLine("Good Noon");
            //                    break;
            //                case 'C':
            //                case 'c':
            //                    Console.WriteLine("Good Afternoon");
            //                    break;
            //                case 'D':
            //                case 'd':
            //                    Console.WriteLine("Good Evening");
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid option");
            //                    break;
            //            }
            //            Console.ReadLine();
            //           */
            //            /*
            //            int hours;

            //            Console.WriteLine("Enter hour (0-23): ");
            //            hours = Convert.ToInt32(Console.ReadLine());

            //            switch (hours)
            //            {
            //                case int n when ((n >= 0 && n < 7) || n > 24):
            //                    Console.WriteLine("Good Night");
            //                    break;
            //                case int n when (n >= 7 && n < 12):
            //                    Console.WriteLine("Good Morning");
            //                    break;
            //                case int n when (n >= 12 && n < 15):
            //                    Console.WriteLine("Good Noon");
            //                    break;
            //                case int n when (n >= 16 && n < 19):
            //                    Console.WriteLine("Good Afternoon");
            //                    break;
            //                case int n when (n >= 19 && n < 23):
            //                    Console.WriteLine("Good Evening");
            //                    break;
            //                case int n when (n >= 23 && n < 24):
            //                    Console.WriteLine("Good Night");
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid option");
            //                    break;
            //            }
            //            */
            //            DateTime currentTime = DateTime.Now;
            //            int hour = currentTime.Hour;


            //            if (hour >= 7 && hour <= 11)
            //            {
            //                Console.WriteLine("Good Morning");
            //            }
            //            else if (hour >= 12 && hour <= 15)
            //            {
            //                Console.WriteLine("Good Noon");
            //            }
            //            else if (hour >= 16 && hour <= 18)
            //            {
            //                Console.WriteLine("Good Afternoon");
            //            }
            //            else if (hour >= 19 && hour <= 22)
            //            {
            //                Console.WriteLine("Good Evening");
            //            }
            //            else if ((hour >= 0 && hour <= 6) || hour > 24)
            //            {
            //                Console.WriteLine("Good Night");
            //            }
            //            else
            //            {
            //                Console.WriteLine(hour + " is not a valid hour's! ");
            //            }

            //            Console.ReadLine(); // Wait for user input to exit




            //            Casting
            //               With the help of an operator

            //            implicit casting
            //                       (automatically) - converting a smaller type to a larger type size
            //             char -> int -> long -> float -> double
            //            char a = 'z';
            //        int b = a;
            //        long c = a;
            //        float d = a;
            //        double e = a;
            //        Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e);

            //            int B = 65;
            //        long C = B;
            //        float D = B;
            //        double E = B;
            //        Console.WriteLine(B + "\n" + C + "\n" + D + "\n" + E);

            //            long c = 30000;
            //        float d = c;
            //        double e = c;
            //        Console.WriteLine(c + "\n" + d + "\n" + e);

            //            float d = 123.4254f;
            //        double e = d;
            //        Console.WriteLine(d + "\n" + e);

            //            byte b = 36;
            //        short s = b;
            //        Console.WriteLine(s);

            //             Explicit casting
            //                (manually) - converting a larger type to a smaller size type
            //            double -> float -> long -> int -> char
            //            double L = 785367.89;
            //        float M = (float)L;
            //        long O = (long)L;
            //        int P = (int)L;
            //        Char Q = (Char)L;
            //        Console.WriteLine(L + "\n" + M + "\n" + O + "\n" + P + "\n" +Q);

            //            double l = 65.2424244;
            //        float m = (float)L;
            //        long o = (long)L;
            //        int p = (int)L;
            //        Char q = (Char)L;
            //        Console.WriteLine(l + "\n" + m + "\n" + o + "\n" + p + "\n" + q);

            //            float M = 452.67475f;
            //        long O = (long)M;
            //        int P = (int)M;
            //        Char Q = (Char)M;
            //        Console.WriteLine(M + "\n" + O + "\n" + P + "\n" + Q);

            //            float m = 97.655554f;
            //        long o = (long)m;
            //        int p = (int)m;
            //        Char q = (Char)m;
            //        Console.WriteLine(m + "\n" + o + "\n" + p + "\n" + q);

            //            long O = 4265476;
            //        int P = (int)O;
            //        Char Q = (Char)O;
            //        Console.WriteLine(O + "\n" + P + "\n" + Q);

            //            long o = 0065;
            //        int p = (int)o;
            //        Char q = (Char)p;
            //        Console.WriteLine(o + "\n" + p + "\n" + q);

            //            int P = 99;
            //        Char Q = (Char)P;
            //        Console.WriteLine(P + "\n" + Q);

            //            int p = 78;
            //        Char q = (Char)p;
            //        Console.WriteLine(p + "\n" + q);

            //            int s = 677;
            //        byte c = (byte)s;
            //        double d = 9.78;
            //        int z = (int)d;

            //        Console.WriteLine(s);
            //            Console.WriteLine(c);
            //            Console.WriteLine(d);
            //            Console.WriteLine(z);

            //            Decimal g = 20.90m;
            //        //conversion key
            //        char h = 'M';
            //        string v = Convert.ToString(h);
            //        //int w = int.Parse(v);

            //        Console.WriteLine(g);
            //            Console.WriteLine(h);
            //            Console.WriteLine(v);

            //            int p = 8;
            //        object o = 13; //boxing
            //        int u = (int)o; //un-boxing
            //        int k = Convert.ToInt32(u);
            //        Console.WriteLine(p* 2);
            //            Console.WriteLine(o);
            //            Console.WriteLine(k);

            //            //var is a strongly type //scope is local
            //            var t = "abc";
            //        Console.WriteLine(t);

            //            dynamic x = "hello";
            //        Console.WriteLine(x);

            //            x = 42;
            //            Console.WriteLine(x);

            //            // // Dynamic is a strongly type
            //             dynamic d = 10;
            //        Console.WriteLine(d-2);

            //            int num = 100;
            //        short K = Convert.ToInt16(num);
            //        int myInt = 10;
            //        float myFloat = Convert.ToSingle(myInt);
            //        Console.WriteLine(myFloat.ToString());
            //            Console.WriteLine(K);

            //            int l = 10000;
            //        double m = 5.25;
            //        bool B = true;

            //        Console.WriteLine(Convert.ToString(l));
            //            Console.WriteLine(Convert.ToDouble(l));
            //            Console.WriteLine(Convert.ToInt32(m));
            //            Console.WriteLine(Convert.ToString(B));

            //            int Z = 500;

            //        // get type of numInt
            //        Type n = Z.GetType();

            //        // Implicit Conversion
            //        double numDouble = Z;

            //        // get type of numDouble
            //        Type n1 = numDouble.GetType();

            //        // Value before conversion
            //        Console.WriteLine("numInt value: " + Z);
            //            Console.WriteLine("numInt Type: " + n);

            //            // Value after conversion
            //            Console.WriteLine("numDouble value: " + numDouble);
            //            Console.WriteLine("numDouble Type: " + n1);

            //            int i = 1;
            //        object o = i; // boxing  
            //        int j = (int)o; // unboxing
            //        Console.WriteLine(i+"\n"+o+"\n"+j);

            //            int value = 42;
            //        object boxedValue = value; // boxing occurs here
            //        int newValue = (int)boxedValue; // unboxing occurs here

            //        Console.WriteLine(value);
            //            Console.WriteLine(boxedValue);
            //            Console.WriteLine(newValue);

            //            //object obj = 3.14;
            //            //float f = (float)obj;
            //            //Console.WriteLine(f);

            //            var number = 42; // number is an int
            //        var name = "John"; // name is a string
            //        var list = new List<int>(); // list is a List<int>
            //        Console.WriteLine(number);


            //            05/04/2023
            //             Variables
            //            var is a strongly type.
            //            object a = 15;
            //        int b = Convert.ToInt16(a);
            //        Console.WriteLine(b* 2);

            //            object A = 39;
            //        double B = Convert.ToInt64(A);
            //        Console.WriteLine(B* 2);
            //            //var must be particular type we cannot change its types. ie var a; and a=3; is not correct.
            //            var c = 18;
            //        int d = Convert.ToInt16(c);
            //        Console.WriteLine(d* 2);

            //            var e = 10.5;
            //        e = 30.56;
            //            Console.WriteLine(e);

            //            var E = 100.5;
            //        E = 'a';
            //            Console.WriteLine(E);

            //            var cd = 32;
            //        string ad = Convert.ToString(c);
            //        Console.WriteLine(a);

            //            int L = 65;
            //        var C = 32;
            //        string Ab = Convert.ToString(C);
            //        Console.WriteLine(Ab.CompareTo("L"));

            //            var cc = 62;
            //        string ac = Convert.ToString(cc);
            //        Console.WriteLine(ac.CompareTo("62"));

            //            dynamic CC;
            //        CC = 32;
            //            string AA = Convert.ToString(CC);
            //        Console.WriteLine(AA);
            //            Console.WriteLine(AA.CompareTo("20"));

            //            dynamic bb = 12;
            //        Console.WriteLine(bb* 20);

            //            dynamic bB = 12;
            //        Console.WriteLine(bB + 20);

            //            object dd = 12; //boxing
            //        int n = Convert.ToInt32(bb);   //un-boxing
            //        Console.WriteLine(n* 20);

            //            string u = Convert.ToString(dd);
            //        Console.WriteLine(u);

            //            var name = "ikram";
            //        Console.WriteLine(name);
            //            //Console.WriteLine(name*2);//in var passed string thats why 
            //            Console.WriteLine(name.Length);

            //            //Operators (+, -, *, /, ==, %, &&, ||, !=)
            //            int a = 3;
            //        a = a + 16;
            //            Console.WriteLine(a);

            //            int A = 38;
            //        A += 16;
            //            Console.WriteLine(A);

            //            int aa = 3;
            //        aa -= 16;
            //            Console.WriteLine(aa);

            //            int aaa = 3;
            //        aaa *= 16;
            //            Console.WriteLine(aaa);

            //            int bbb = 30;
            //        bbb /= 16;
            //            Console.WriteLine(bbb);

            //            int bb = 3;
            //        bb %= 16;
            //            Console.WriteLine(bb);



            //            //Uniary Operator
            //            int a = 1;
            //        Console.WriteLine(a++);  //4 bits


            //            int b = 1;
            //        int y = b++;
            //        Console.WriteLine(y++);

            //            int by = 1;
            //        int yb = b++;
            //        Console.WriteLine(yb); //1

            //            int ab = 1;
            //        int xy = ++ab;
            //        Console.WriteLine(xy);

            //            int bb = 1;
            //        //int yy = b;
            //        Console.WriteLine(++bb);

            //            int Ab = 2;
            //        Console.WriteLine(Ab--);

            //            int cd = 2;
            //        Console.WriteLine(--cd);

            //            int d = 2;
            //        int e = d--;
            //        Console.WriteLine(e);

            //            int f = 2;
            //        int g = --f;
            //        Console.WriteLine(g);

            //            int h = 2;
            //        int i = h--;
            //        i++;   // i=h+1;
            //            Console.WriteLine(i);

            //            int j = 2;
            //        int k = --j;
            //        k = k + 1;
            //            // k++;
            //            Console.WriteLine(k);

            //            int a = 12;
            //        float b = 34.4f;
            //        string c = "4567";
            //        char d = 'k';
            //        var f = 347456;
            //        long l = 545667;
            //        double sum = (double)a + (double)b + Convert.ToDouble(c) + (double)d + (double)f + (double)l;
            //        Console.WriteLine(sum);

            //            //        05/05/2023
            //            //Operator Web
            //            Console.WriteLine("Ikramullah");
            //            Console.WriteLine("Hello" + " " + "String " + "!");
            //            string author = "Mahesh Chand";
            //        string book = "C# Programm";
            //        string bookAuthor = $"{author} is the author of {book}.";
            //        Console.WriteLine(bookAuthor);
            //            Console.WriteLine(5 > 7);
            //            Console.WriteLine(6 < 4);
            //            Console.WriteLine(4 == 4);
            //            Console.WriteLine(5 != 7);
            //            Console.WriteLine(6 >= 4);
            //            Console.WriteLine(4 <= 8);
            //            Console.WriteLine(8 != 8 && 4 != 3);
            //            Console.WriteLine(!(true));
            //            Console.WriteLine(!(false));
            //            Console.WriteLine((true));
            //            Console.WriteLine(5 + 9);
            //            Console.WriteLine("4" + "6");  //string should be write in double comma or quotition
            //            Console.WriteLine("756" + "6778");//its can't give sum of two num
            //            Console.WriteLine(5 * 4);
            //            Console.WriteLine(4 / 4);
            //            Console.WriteLine(35 % 40);// The % operator is called the modulus operator
            //            Console.WriteLine(7 % 4);

            //            // alternative concatenate
            //            int a = 32;
            //        string nam = "ikram";
            //        Console.WriteLine(a + " | " + nam);

            //            int x = 22;
            //        int y = 43;
            //        string name = "ikram";
            //        Console.WriteLine($"{x + y}{name}");

            //            string str1 = "Hello";
            //        string str2 = "world";
            //        Console.WriteLine($"{str1} {str2}");

            //            int A = 45;
            //        int B = 67;
            //        Console.WriteLine(A* B);

            //            string b = "ikram";
            //        string c = "balti";
            //        Console.WriteLine(b + " " + c);

            //            string d = "The answer is:";
            //        int e = 54;
            //        Console.WriteLine(d + " " + e);

            //            var f = "Gilgit";
            //        string g = "Baltistan";
            //        char i = 'A';
            //        int h = 443566;
            //        Console.WriteLine($"{f}{" "}{g}{" "}{i}{" "}{h}");

            //            //a=p+p*i*n
            //            //p is investment
            //            //n duration
            //            Console.WriteLine("Please Enter Your desired Investment: ");
            //            //string temp = Console.ReadLine(); //warning show green line & error show read line
            //            string? temp = Console.ReadLine();
            //        int p = Convert.ToInt32(temp);

            //        Console.WriteLine("Please Enter Your desired duration (years): ");
            //            string? temp1 = Console.ReadLine();
            //        int n = Convert.ToInt32(temp1);

            //        float i = 0.1f;//its mean 10% 0.1
            //        int a = (int)(p + p * i * n); //costing value is very high
            //                                      //Console.WriteLine("Now your account is " + a + "after investment of year  " + p + "with percentage of  "+i);
            //        Console.WriteLine($"Now your account is  { a}   after investment of  {p} with percentage of  { i}");

            //            Console.WriteLine("Please Enter Your desired Investment: ");
            //            string? temp = Console.ReadLine();
            //        int p = Convert.ToInt32(temp);

            //        Console.WriteLine("Please Enter Your desired duration (years): ");
            //            string? temp1 = Console.ReadLine();
            //        int n = Convert.ToInt32(temp1);

            //        float i = 0.5f;//its mean 50% 
            //        int a = (int)(p + p * i * n);
            //        Console.WriteLine($"Now your account is  {a}   after investment of  {p} with percentage of  {i}");

            //            Console.WriteLine("Please Enter Your desired Investment: ");
            //            string? temp = Console.ReadLine();
            //        int p = Convert.ToInt32(temp);

            //        Console.WriteLine("Please Enter Your desired duration (years): ");
            //            string? temp1 = Console.ReadLine();
            //        int n = Convert.ToInt32(temp1);

            //        float i = 0.5f;//its mean 50% 
            //        int a = (int)(p + p * i * n);
            //        Console.WriteLine("Now your account is  " + a + " after investment of  " p + "with percentage of   "  + i);



            //            string str = "hello, world";
            //        Console.WriteLine(str[0]);
            //            Console.WriteLine(str[1]);
            //            Console.WriteLine(str[2]);
            //            Console.WriteLine(str[3]);
            //            Console.WriteLine(str[4]);
            //            Console.WriteLine(str[5]);
            //            Console.WriteLine(str[6]);
            //            Console.WriteLine(str[7]);
            //            Console.WriteLine(str[8]);
            //            Console.WriteLine(str[9]);
            //            Console.WriteLine(str[10]);

            //            int length = str.Length;
            //        Console.WriteLine("Length: " + length);

            //            string str = "hello, world";
            //        string substr = str.Substring(0);
            //        string substr1 = str.Substring(0, 5);
            //        string substr3 = str.Substring(5, 5);
            //        string substr2 = str.Substring(6);
            //        Console.WriteLine(substr);
            //            Console.WriteLine(substr1);
            //            Console.WriteLine(substr2);
            //            Console.WriteLine(substr3);

            //            string bio = "Mahesh Chand is a founder of C# Corner.";
            //        string authorName = bio.Substring(0, 10);
            //        Console.WriteLine(authorName);

            //            string txt = "Hello World";
            //        Console.WriteLine(txt.ToUpper());
            //            Console.WriteLine(txt.ToLower());
            //            Console.WriteLine(str[7]);//to find position of character 

            //            Console.WriteLine(str.IndexOf("H"));
            //            Console.WriteLine(str.IndexOf("o"));
            //            Console.WriteLine(str.IndexOf("d"));
            //            Console.WriteLine(str.Substring(0, 9));
            //            Console.WriteLine(str.Substring(6, 11));
            //            escape characters concept
            //             Console.WriteLine("Hello! \"Good Morning");
            //        Console.WriteLine("Hello! \"Good Morning\"");
            //             //Types of Loop
            //            // while loop
            //             int j = 0;
            //             while (j <= 10)
            //             {
            //                 Console.WriteLine(j);
            //                 j++;
            //             }
            //    Console.WriteLine();
            //             //While Loop
            //             int b = 1;
            //             while (b <= 10)
            //             {
            //                 Console.WriteLine(b + " : " + "Hi Ikramullah");
            //                 b++;
            //             }
            //Console.WriteLine();


            //// Do While Loop
            //int k = 1;
            //do
            //{
            //    Console.WriteLine(k);
            //    k++;
            //} while (k <= 10);
            //Console.WriteLine();

            //for (int a = 0; a <= 10; a++)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine();

            ////Two Tables
            //int number = 2;
            //do
            //{
            //    Console.WriteLine(number);
            //    number += 2;

            //} while (number <= 20);
            //Console.WriteLine(number);

            //Console.WriteLine();
            ////Three Tables
            //int numb = 3;
            //do
            //{
            //    Console.WriteLine(numb);
            //    numb += 3;
            //} while (numb <= 30);
            //Console.WriteLine();

            ////Even Number
            //int number = 2;
            //do
            //{
            //    Console.WriteLine(number);
            //    number += 2;

            //} while (number <= 50);
            //Console.WriteLine(number);

            //Console.WriteLine();
            ////Odd Number
            //int numb = 1;
            //do
            //{
            //    Console.WriteLine(numb);
            //    numb += 2;
            //} while (numb <= 50);
            //Console.WriteLine();

            ////For Loop
            //Console.WriteLine("Enter a Number");
            //int numb = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 20; i++)

            //{
            //    Console.WriteLine(numb + "\tX\t" + i + "\t=\t" + numb * i);
            //}

            ////While Loop
            //Console.WriteLine("Enter a Number");
            //int numb = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //while (i <= 20)
            //{
            //    Console.WriteLine(numb + "\tX\t" + i + "\t=\t" + numb * i);
            //    i++;
            //}

            //////---------------------11/05/2023-------------------------//////

            ////For loop is used when the program run

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        if (i == 0)
            //        {
            //            continue;
            //        }
            //        //if (i == 4)
            //        //{
            //        //    continue;
            //        //}
            //        Console.WriteLine("This is Even Number" + i);
            //    }
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        if (i == 0)
            //        {
            //            continue;
            //        }
            //        Console.WriteLine("This is Odd Number" + i);
            //    }
            //}
            //Console.WriteLine();
            //while loop is used for condition and its run pre codition

            //int a = 0;
            //bool first = true;
            //while (a <= 10)
            //{
            //    if (a == 0 && first)
            //    {
            //        first = false;
            //        a++;
            //        continue;
            //    }

            //    if (a % 2 == 0)
            //    {
            //        Console.WriteLine("this is an even number: " + a);
            //    }

            //    a++;
            //}

            ////While Loop to find odd number
            //int a = 0;
            //bool first = true;
            //while (a <= 10)
            //{
            //    if (a == 0 && first)
            //    {
            //        first = false;
            //        a++;
            //        continue;
            //    }

            //    if (a % 2 == 1)
            //    {
            //        Console.WriteLine("This is An Odd Number: " + a);
            //    }

            //    a++;
            //}

            //int i = 0;
            //bool first = true;
            //while (i <= 10)
            //{
            //    if (i == 0 && first)
            //    {
            //        first = false;
            //        continue;
            //    }

            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("this is an even number: " + i);
            //    }

            //    i++;
            //}

            ////Do-While Loop
            ////loop continues run
            //bool isCountTime = true;
            //bool isFirst = false;

            //do
            //{
            //    if (isFirst)
            //    {
            //        Console.WriteLine("Press any key to continue:");
            //        Console.ReadKey();
            //        Console.Clear();

            //    }

            //    Console.WriteLine("My Menu");
            //    Console.WriteLine("---------------");
            //    Console.WriteLine("1 - Loop Demo");
            //    Console.WriteLine("2 - Array Demo");
            //    Console.WriteLine("3 - DataTime Demo");
            //    Console.WriteLine("4 - Exit");

            //    int choice;
            //    bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);

            //    if (isValidChoice)
            //    {
            //        switch (choice)
            //        {
            //            case 1:
            //                Console.WriteLine("This is Loop Demo");
            //                break;
            //            case 2:
            //                Console.WriteLine("This is Array Demo");
            //                break;
            //            case 3:
            //                Console.WriteLine("This is DateTime Demo");
            //                break;
            //            case 4:
            //                isCountTime = false;
            //                break;
            //            default:
            //                Console.WriteLine("Invalid choice");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number.");
            //    }
            //    isFirst = false;
            //} while (isCountTime);

            //bool isCountTime = true;
            //bool isFirst = true;

            //do
            //{
            //    if (isFirst)
            //    {
            //        Console.WriteLine("Press any key to continue:");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }

            //    Console.WriteLine("Main Menu");
            //    Console.WriteLine("---------------");
            //    Console.WriteLine("1 - Investment Calculator");
            //    Console.WriteLine("2 - Array Demo");
            //    Console.WriteLine("3 - DataType Demo");
            //    Console.WriteLine("4 - Exit");                                                                                                                                ine("4 - Exit");

            //    int choice;
            //    bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);

            //    if (isValidChoice)
            //    {
            //        switch (choice)
            //        {
            //            case 1:
            //                InvestmentCalculator();
            //                break;
            //            case 2:
            //                Console.WriteLine("This is Array Demo");
            //                break;
            //            case 3:
            //                Console.WriteLine("This is DateTime Demo");
            //                break;
            //            case 4:
            //                isCountTime = false;
            //                break;
            //            default:
            //                Console.WriteLine("Invalid choice");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number.");
            //    }
            //    isFirst = false;
            //} while (isCountTime);

            //static void InvestmentCalculator()
            //{
            //    Console.WriteLine("Please Enter Your desired Investment: ");
            //    string? temp = Console.ReadLine();
            //    int p = Convert.ToInt32(temp);

            //    Console.WriteLine("Please Enter Your desired duration (years): ");
            //    string? temp1 = Console.ReadLine();
            //    int n = Convert.ToInt32(temp1);

            //    float i = 0.10f;//its mean 10% 

            //    int a = (int)(p * (Math.Pow(1 + i, n)));
            //    Console.WriteLine($"Now your account is  {a}   after investment of  {p} with percentage of  {i}");

            //    int grossProfit = a - p;
            //    Console.WriteLine($"Gross Profit ={grossProfit}");

            //    int tax = 0;
            //    //if (grossProfit > 50000)
            //    //{
            //    //    tax = (int)(grossProfit * 0.15);
            //    //}
            //    //else
            //    //{
            //    //    tax = (int)(grossProfit * 0.10);
            //    //}

            //    tax = (grossProfit > 500000) ? tax = (int)(grossProfit * 0.15) : tax = (int)(grossProfit * 0.10);
            //    int netProfit = grossProfit - tax;
            //    Console.WriteLine("The tax you paid is:" + tax);
            //    Console.WriteLine($"The net profit is : {netProfit}");
            //}
            // Console.WriteLine("Thank you for using My Program. Goodbye!");

            //bool isRunning = true;
            //bool isFirst = false;

            //do
            //{
            //    if (isFirst)
            //    {
            //        Console.WriteLine("Press any key to continue:");
            //        Console.ReadKey();
            //        Console.Clear();

            //    }

            //        Console.WriteLine("Welcome to My Program");
            //        Console.WriteLine("----------------------");
            //        Console.WriteLine("1 - Calculator");
            //        Console.WriteLine("2 - Enter The Hour's: ");
            //        Console.WriteLine("3 - Show Time");
            //        Console.WriteLine("4 - Exit");

            //        Console.Write("Please enter your choice: ");
            //        string? input = Console.ReadLine();

            //        if (int.TryParse(input, out int choice))
            //        {
            //            switch (choice)
            //            {
            //                case 1:
            //                    calculator();
            //                    break;
            //                case 2:
            //                    hours();
            //                    break;
            //                case 3:
            //                    Main();
            //                    break;
            //                case 4:
            //                    isRunning = false;
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid choice");
            //                    break;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a number.");
            //        }

            //        isFirst = false;
            //} while (isRunning);

            //            static void calculator()
            //    {
            //        Console.WriteLine("Enter Your 1st Number");
            //        int num1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Enter your 2nd Number");
            //        int num2 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Operator +,-,/,*");
            //        char? op = Convert.ToChar(Console.ReadLine() ?? "0");

            //        switch (op)
            //        {
            //            case '+':
            //                Console.WriteLine($"Result: {num1 + num2}");
            //                break;
            //            case '-':
            //                Console.WriteLine($"Result: {num1 - num2}");
            //                break;
            //            case '*':
            //                Console.WriteLine($"Result: {num1 * num2}");
            //                break;
            //            case '/':
            //                if (num2 != 0)
            //                {
            //                    Console.WriteLine($"Result: {num1 / (double)num2}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Error: Division by zero is not allowed.");
            //                }
            //                break;
            //            default:
            //                Console.WriteLine("Invalid operator");
            //                break;
            //        }
            //    }
            //    static void hours()
            //    {
            //        Console.WriteLine("Enter hour (0-23): ");
            //        int hours = Convert.ToInt32(Console.ReadLine());

            //        switch (hours)
            //        {
            //            case int n when ((n >= 0 && n < 7) || n > 24):
            //                Console.WriteLine("Good Night");
            //                break;
            //            case int n when (n >= 7 && n < 12):
            //                Console.WriteLine("Good Morning");
            //                break;
            //            case int n when (n >= 12 && n < 15):
            //                Console.WriteLine("Good Noon");
            //                break;
            //            case int n when (n >= 16 && n < 19):
            //                Console.WriteLine("Good Afternoon");
            //                break;
            //            case int n when (n >= 19 && n < 23):
            //                Console.WriteLine("Good Evening");
            //                break;
            //            case int n when (n >= 23 && n < 24):
            //                Console.WriteLine("Good Night");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid option");
            //                break;
            //        }
            //    }

            //    static void Main()
            //    {
            //        while (true)
            //        {
            //            Console.Clear();
            //            DateTime currentTime = DateTime.Now;
            //            Console.WriteLine(currentTime.ToString("HH:mm:ss"));
            //            Thread.Sleep(1000);
            //            if (Console.KeyAvailable)
            //            {
            //                Console.ReadKey(true);
            //                break;
            //            }
            //        }
            //    }

            //    Console.WriteLine("Thank you for using My Program. Goodbye!");


            ///////---------------12/05/2023------------/////////
            //    double result = 0.0;

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Calculator");
            //    Console.WriteLine("----------");
            //    Console.WriteLine("Result: " + result);
            //    Console.WriteLine();

            //    Console.WriteLine("Enter an operator (+, -, *, /) or 'q' to quit:");
            //    string? input = Console.ReadLine();

            //    if (input == "q")
            //        break;

            //    Console.WriteLine("Enter a number:");
            //    double number = double.Parse(Console.ReadLine()??"0");

            //    switch (input)
            //    {
            //        case "+":
            //            result += number;
            //            break;
            //        case "-":
            //            result -= number;
            //            break;
            //        case "*":
            //            result *= number;
            //            break;
            //        case "/":
            //            result /= number;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operator!");
            //            break;
            //    }

            //}


            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Calculator");
            //    Console.WriteLine("----------");
            //    Console.WriteLine();

            //    Console.WriteLine("Enter the first number:");
            //    double num1 = double.Parse(Console.ReadLine()??"0");

            //    Console.WriteLine("Enter an operator (+, -, *, /):");
            //    string? op = Console.ReadLine();

            //    Console.WriteLine("Enter the second number:");
            //    double num2 = double.Parse(Console.ReadLine()??"0");

            //    double result = 0.0;

            //    switch (op)
            //    {
            //        case "+":
            //            result = num1 + num2;
            //            break;
            //        case "-":
            //            result = num1 - num2;
            //            break;
            //        case "*":
            //            result = num1 * num2;
            //            break;
            //        case "/":
            //            if (num2 != 0)
            //            {
            //                result = num1 / num2;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Division by zero!");
            //                continue;
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operator!");
            //            continue;
            //    }

            //    Console.WriteLine("Result: " + result);
            //    Console.WriteLine();

            //    Console.WriteLine("Press any key to continue or 'q' to quit.");
            //    string? input = Console.ReadLine();

            //    if (input == "q")
            //        break;
            //}



            //////     Lecture
            /////Topic# Methods: 1- Parameter less method 2-Parametric method
            //static void ParameterLess()
            //{
            //    Console.WriteLine("dcvz ");
            //}

            //static void IsLogin(string username, string password)
            //{
            //    Console.WriteLine();
            //}

            ////Arrays: Two ways 1)- One by one in variables   2)-Take all 10 varibles in one box called array.
            ////(Multi Lines )
            ////int a1 = 10;
            ////int b1 = 20;
            ////int c1 = 30;
            ////int d = 23;
            //////declear and initialize
            //////Array must be initialize before use
            //////Must be initialized at declearation time
            //int[] marks = new int[10];  //new is keyword that declear to store a space in programing
            //marks[0] = 23; //always memory store values store in zero to onward. index zero
            //marks[1] = 13;
            //marks[2] = 24;
            //marks[3] = 63;
            //marks[4] = 83;
            //marks[5] = 76;
            //marks[6] = 34;
            //marks[7] = 78;
            //marks[8] = 90;
            //marks[9] = 87;   //this is static programing lang 

            //Console.WriteLine(marks[0]);
            //Console.WriteLine(marks[1]);
            //Console.WriteLine(marks[2]);
            //Console.WriteLine(marks[3]);
            //Console.WriteLine(marks[4]);
            //Console.WriteLine(marks[5]);
            //Console.WriteLine(marks[6]);
            //Console.WriteLine(marks[7]);
            //Console.WriteLine(marks[8]);
            //Console.WriteLine(marks[9]);

            ////static void Main()
            ////{
            ////    Console.WriteLine("Average Calculator");
            ////    Console.WriteLine("------------------");

            ////    Console.WriteLine("How many numbers do you want to enter?");
            ////    int count = int.Parse(Console.ReadLine()??"0");

            ////    int[] numbers = new int[count];

            ////    for (int i = 0; i < count; i++)
            ////    {
            ////        Console.WriteLine($"Enter number {i + 1}:");
            ////        numbers[i] = int.Parse(Console.ReadLine()??"0");
            ////    }

            ////    int sum = 0;
            ////    foreach (int number in numbers)
            ////    {
            ////        sum += number;
            ////    }

            ////    double average = (double)sum / count;

            ////    Console.WriteLine("The average is: " + average);
            ////}



            //int[] marks = { 132, 432, 563, 784, 325, 896, 237, 128, 922 };

            ////How to get value by an index

            //int m = marks[0];
            ////how to update marks at a specific index
            ////marks[2] = 80;

            //int len = marks.Length;
            //int[] newArray = new int[15];

            //marks.CopyTo(newArray, 0);

            //for (int i = 0; i < len; i++)
            //{
            //    Console.WriteLine($"this is a {i} {marks[i]} ");
            //}
            //Console.WriteLine(marks[0] + " " + marks[1] + " " + marks[2] + " " + marks[3]);

            //int index = 0;
            //foreach (int i in newArray)
            //{
            //    Console.WriteLine("this is a " + index + i);
            //    index++;
            //}

            //// foreach (char item in marks) //A special type of loop which used to iterate.
            ////foreach (string item in marks)
            //// foreach (int item in marks)

            //int[] marks = { 132, 432, 563, 784, 325, 896, 237, 128, 922 };

            ////How to get value by an index

            //int m = marks[0];
            ////how to update marks at a specific index
            ////marks[2] = 80;

            //int len = marks.Length;
            //int[] newArray = new int[15];
            //foreach (var item in marks)
            //{
            //    Console.WriteLine("this is a " + item);
            //}
            ////string[] names = { "ALI", "ikram", "usman", "javed" };
            ////int[] marks = new int[names.Length];

            ////Console.WriteLine("Enter Student Marks");
            ////for (int i = 0; i < names.Length; i++)
            ////{
            ////    Console.Write($"Enter marks for {names[i]}: ");
            ////    marks[i] = Convert.ToInt32(Console.ReadLine());
            ////}

            ////Console.WriteLine("Name\t\tMarks");
            ////Console.WriteLine("-----------------");
            ////for (int i = 0; i < names.Length; i++)
            ////{
            ////    Console.WriteLine($"{names[i]}\t\t{marks[i]}");
            ////}

            ////Console.WriteLine("Index\t\tMarks");
            ////Console.WriteLine("-----------------");
            ////for (int i = 0; i < marks.Length; i++)
            ////{
            ////    Console.WriteLine($"{i}\t\t{marks[i]}");
            ////}

            //int[] mark = { 13432, 56432, 87563, 70084, 32125, 89634, 23721, 17728, 23922 };
            //int m = mark[0];
            //int leng = mark.Length;
            //int[] newArray = new int[15];
            //mark.CopyTo(newArray, 0);
            //foreach (var items in mark)
            //{
            //    Console.WriteLine("this is a " + items);
            //}

            ////// Arrays
            ////One by One in variables


            //int[] marks = { 132, 432, 563, 784, 325, 896, 237, 128, 922 };

            //int mark1 = marks[0];
            //int mark2 = marks[1];
            //int mark3 = marks[2];
            //int mark4 = marks[3];
            //int mark5 = marks[4];
            //int mark6 = marks[5];
            //int mark7 = marks[6];
            //int mark8 = marks[7];
            //int mark9 = marks[8];

            //Console.WriteLine(mark1);
            //Console.WriteLine(mark2);
            //Console.WriteLine(mark3);
            //Console.WriteLine(mark4);
            //Console.WriteLine(mark5);
            //Console.WriteLine(mark6);
            //Console.WriteLine(mark7);
            //Console.WriteLine(mark8);
            //Console.WriteLine(mark9);

            //        Arrays
            //Take all 10 variables in one box that box called Array

            //        int[] numericArray = { 132, 432, 563, 784, 325, 896, 237 };
            //        string[] nameArray = { "Ikram", "Imran", "Balti", "Irshad", "Usama", "Ali" };

            //        for (int i = 0; i < numericArray.Length; i++)
            //        {
            //            Console.WriteLine(numericArray[i]);
            //        }

            //        for (int i = 0; i < nameArray.Length; i++)
            //        {
            //            Console.WriteLine(nameArray[i]);
            //        }


            //        Console.ReadKey();

            //static void Arrays()
            //{
            //    k
            //}

            //double[] numbers = new double[2];

            //Console.WriteLine("Enter the first number:");
            //numbers[0] = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //numbers[1] = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the operator (+, -, *, /):");
            //char op = Convert.ToChar(Console.ReadLine()??"0");

            //double result = 0.0;

            //switch (op)
            //{
            //    case '+':
            //        result = numbers[0] + numbers[1];
            //        break;
            //    case '-':
            //        result = numbers[0] - numbers[1];
            //        break;
            //    case '*':
            //        result = numbers[0] * numbers[1];
            //        break;
            //    case '/':
            //        result = numbers[0] / numbers[1];
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator!");
            //        return;
            //}

            //Console.WriteLine("Result: " + result);

            //Console.WriteLine("Enter the number of students:");
            //int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            //string[] names = new string[numberOfStudents];
            //int[] marks = new int[numberOfStudents];

            //for (int i = 0; i < numberOfStudents; i++)
            //{
            //    Console.WriteLine($"Enter name for student {i + 1}:");
            //    names[i] = Console.ReadLine()??"0";

            //    Console.WriteLine($"Enter marks for student {i + 1}:");
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Name\t\tMarks");
            //Console.WriteLine("-----------------");

            //for (int i = 0; i < numberOfStudents; i++)
            //{
            //    Console.WriteLine($"{names[i]}\t\t{marks[i]}");
            //}

            //int[] numbers = new int[15];
            //int sum = 0;

            //Console.WriteLine("Enter 15 numbers:");

            //for (int i = 0; i < 15; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += numbers[i];
            //}

            //Console.WriteLine("\nSum of the numbers: " + sum);

            //            int[] numbers = { 132, 432, 563, 784, 325, 896, 237, 128, 922, 566, 213, 788, 986, 213, 455 };
            //             int sum = 0;

            //             foreach (int number in numbers)
            //{
            //    sum += number;
            //}

            //             Console.WriteLine("Sum of the numbers: " + sum);
            //             Console.ReadLine();

            //int[] marks = { 20, 35, 45, 65, 70 };

            //int sum = 0;
            //foreach (int item in marks)
            //{
            //   sum += item;
            //}
            //Console.WriteLine(sum);

            //Console.WriteLine("Enter The Value ");
            //int marks = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //foreach (int item in marks)
            //{
            //    sum += item;
            //}
            //Console.WriteLine(sum);

            //Console.ReadLine();

            //int[] numbers = new int[15];

            //Console.WriteLine("Enter 15 values:");
            //for (int i = 0; i < 15; i++)
            //{
            //    Console.Write($"Enter value {i + 1}: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sum = 0;
            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}

            //Console.WriteLine("Sum of the values: " + sum);


            //string[] names = { "ALI", "ikram", "usman", "javed" };
            //int[] marks = { 80, 90, 70, 85 };

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Name\t\tMarks");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"{names[i]}\t\t{marks[i]}");
            //}


            //int Students = 4;
            //string[] names = new string[Students];
            //int[] marks = new int[Students];

            //for (int i = 0; i < Students; i++)
            //{
            //    Console.Write("Enter name of student {0}: ", i + 1);
            //    names[i] = Console.ReadLine()??"0";

            //    Console.Write("Enter marks of student {0}: ", i + 1);
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Name\t\tMarks");
            //for (int i = 0; i < Students; i++)
            //{
            //    Console.WriteLine("{0}\t\t{1}", names[i], marks[i]);
            //}

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Index\tName\t\tMarks");
            //for (int i = 0; i < Students; i++)
            //{
            //    Console.WriteLine("{0}\t{1}\t\t{2}", i, names[i], marks[i]);
            //}

            ////string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            ////foreach (string a in cars)
            ////{
            ////    Console.WriteLine(a);
            ////}

            //////Nested Loops
            ////for (int k = 1; k <= 2; ++k)
            ////{
            ////    Console.WriteLine("Outer: " + k);
            ////    for (int j = 1; j <= 3; j++)
            ////    {
            ////        Console.WriteLine(" Inner: " + j);
            ////    }
            ////    Console.ReadLine();
            ////}

            ////int l = 0;
            ////while (l < 5)
            ////{
            ////    Console.WriteLine(l);
            ////    l++;
            ////}
            ////Console.WriteLine();

            ////int c = 0;
            ////do
            ////{
            ////    Console.WriteLine(c);
            ////    c++;
            ////}
            ////while (c <= 5);

            //////Foreach Loop
            ////int[] numbers = { 1, 2, 3, 4, 5 };

            ////foreach (int num in numbers)
            ////{
            ////    Console.WriteLine(num);
            ////}




            //////for (int i = 0; i <= 3; i++)

            //////{

            //////    string[] names = { "ikram", "Usama", "Imran", "Ali" };
            //////    int[] numbers = { 1, 2, 3, 4 };
            //////    Console.WriteLine("{0}\t{1}\t{2}", i, names[i], numbers[i] + "\n");

            //////    int books = 6;
            //////    string[] name = { "Math", "Bio", "Chemistry", "Physics", "Urdu", "English", "Pak Stadies" };
            //////    int[] mark = { 45, 56, 67, 89, 43, 67, 98 };
            //////    for (int j = 0; j <= books; j++)
            //////    {
            //////        Console.WriteLine("{0}\t{1}\t{2}", j, name[j], mark[j]);
            //////    }
            //////    Console.ReadLine();
            //////}

            ///////////////-------------15/05/2023-----------//////////////////////


            //int i=10;
            //bool isZero = true;
            //while(i<10)
            //{
            //    if (i != 10 && isZero)
            //    {
            //        isZero = false;
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }

            //}

            //int i = 0; ;
            //bool isZero = true;
            //while (i < 10)
            //{
            //    if (i != 10 && isZero)
            //    {
            //        i++;
            //        isZero = false;
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //}

            //int i = 0;
            ////bool isZero = true;
            //while (i < 10)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //}

            ////char & string & its function

            //static void charDemo()
            //{
            //    string s = "Pakistan zindabad";
            //    int k = s.Length;
            //    Console.WriteLine(s+"\n"+k);
            //}
            //charDemo();

            //static void charDemo()
            //{
            //    string s = "Pakistan zindabad";
            //    char l = s[0];
            //    char r = s[1];
            //    char t = s[2];
            //    char x= s[3];
            //    char y= s[4];
            //    char z = s[5];
            //    char x1 = s[6];
            //    char x2 = s[7];
            //    char x3 = s[8];
            //    Console.WriteLine(s + "\n" + l + "\n" + r + "\n" + t + "\n" + x + "\n"+y + "\n"+z + "\n"+x1 + "\n"+x2 + "\n"+x3);
            //}
            //charDemo();


            //static void CharDemo()
            //{
            //    string s = "Pakistan zindabad";
            //    //bool isDigit = char.IsDigit(s[0]);
            //    //Console.WriteLine(isDigit);

            //    bool r = char.IsLetterOrDigit(s[0]);
            //    Console.WriteLine(r);

            //    bool rd = char.IsLetterOrDigit(s[6]);
            //    Console.WriteLine(rd);

            //    char c = 'A';
            //    Console.WriteLine(c);

            //    System.Char cd = 'A';
            //    Console.WriteLine(cd);

            //}

            //CharDemo();

            //static void CharDemo()
            //{
            //    string s = "Pakistan zindabad";
            //    int len = s.Length;
            //    char s1 = 'a';
            //    if (char.IsPunctuation(s1))
            //    {
            //        Console.WriteLine(s1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(s1);
            //    }

            //}
            //CharDemo();

            //static void CharDemo()
            //{
            //    string s = "Pakistan zindabad";
            //    int len = s.Length;
            //    char s1 = char.ToLower(s[0]);
            //    char s2= s1;
            //    char s3 = char.ToLower(s2);



            //}
            //CharDemo();

            //static void CharDemo()
            //{
            //    Console.WriteLine("Enter the value");
            //    string text=Console.ReadLine();
            //    foreach(char ch in text)
            //        {
            //        Console.WriteLine(ch);
            //    }

            //}

            //static void CharDemo()
            //{
            //    Console.WriteLine("Enter the value");
            //    string text = Console.ReadLine();
            //    if (text != null)
            //    {
            //        foreach (char ch in text)
            //        {
            //            Console.WriteLine(ch);
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Plz Enter A Valid Value")
            //    }
            //}
            //CharDemo();

            //static void CharDemo()
            //{
            //    Console.WriteLine("Enter the value");
            //    string text = Console.ReadLine()??"0";
            //    if (string.IsNullOrEmpty (text))
            //    {
            //        foreach (char ch in text)
            //        {
            //            Console.WriteLine("Hi" + ch);
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Plz Enter A Valid Value");
            //    }
            //}
            //CharDemo();

            //static void CharDemo()
            //{
            //    Console.WriteLine("Enter the value");
            //    string text = Console.ReadLine() ?? "0";
            //    foreach (char c in text)
            //    {
            //        if(char.IsWhiteSpace(c))
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine(c);
            //        }
            //    }


            //}
            //CharDemo();

            //static void CharDemo()
            //{
            //    Console.WriteLine("Enter the value");
            //    string text = Console.ReadLine() ?? "0";
            //    foreach (char c in text)
            //    {
            //        if (char.IsWhiteSpace(c))
            //        {
            //            Console.WriteLine($"{c}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("==");
            //        }

            //    }


            //}
            //CharDemo();

            //static void JoinArray()
            //{
            //    string firstName = "Ikram ";
            //    Console.WriteLine("First Name: " + firstName);

            //    string lastName = "Ullah";
            //    Console.WriteLine("Last Name: " + lastName);

            //    string fullName = string.Concat(firstName, lastName);
            //    Console.WriteLine("Full Name: " + fullName);

            //    Console.ReadLine();
            //}
            //JoinArray();



            //static void CharDemo()
            //{
            //    string? name;
            //    int alp, digit,splch,i,l;
            //    alp = digit = splch = i = 0;


            //    Console.WriteLine("\n\nCount totalnumberof alphabets, digits and special characters : \n");
            //    Console.WriteLine("------------------------------------------------------------------");
            //    Console.WriteLine("Input the string : ");
            //    name = Console.ReadLine();
            //    l = name.Length;
            //    while (i < l)
            //    {
            //        if ((name[i] >= 'a' && name[i] >= 'z') || (name[i] >= 'A' && name[i] <= 'Z'))
            //        {
            //            alp++;
            //        }
            //        else if ((name[i] >= '0' && name[i]<='9'))
            //        {
            //            digit++;
            //        }
            //        else
            //        {
            //            splch++;
            //        }
            //        i++;
            //    }
            //    Console.WriteLine("Number Of Alphabets in the string is: {0}\n\n", alp);
            //    Console.WriteLine("Number Of Digits in the string is: {0}\n", digit);
            //    Console.WriteLine("Number Of special characters in the string is: {0}\n\n", splch);
            //}
            //CharDemo();

            //static void CharDemo()
            //{
            //    Console.WriteLine("Input the string: ");
            //    string name = Console.ReadLine()??"";

            //    int alphabetCount = 0;
            //    int digitCount = 0;
            //    int specialCharCount = 0;

            //    foreach (char c in name)
            //    {
            //        if (char.IsLetter(c))
            //        {
            //            alphabetCount++;
            //        }
            //        else if (char.IsDigit(c))
            //        {
            //            digitCount++;
            //        }
            //        else
            //        {
            //            specialCharCount++;
            //        }
            //    }

            //    Console.WriteLine("Number of Alphabets in the string: {0}", alphabetCount);
            //    Console.WriteLine("Number of Digits in the string: {0}", digitCount);
            //    Console.WriteLine("Number of special characters in the string: {0}", specialCharCount);
            //}

            //CharDemo();


            /*
            Console.WriteLine("Enter the string");
            string name = Console.ReadLine() ??"";
            int a = 0;
            int b = 0;  
            int c = 0;
            foreach(char e in name)
            {
                if ((char.IsLetter(e)))
                {
                    a++;
                }
                else if ((char.IsDigit(e)))
                {
                    b++;
                }
                else
                {
                    c++;
                }

            }
            Console.WriteLine($"The Alphabat Number{a} \n{b} \n{c}");


            Console.WriteLine("Enter the string");
            string nam = Console.ReadLine() ?? "";
            for (int x = nam.Length - 1; x >= 0; x--)
            {
                Console.WriteLine(nam[x]);
            }
            Console.ReadLine();

            Console.WriteLine("Enter the string");
            string Y = Console.ReadLine() ?? "";
            int IsVavole = 0;
            for (int y = 0; y < Y.Length; y++)
            {
                if (Y[y] == 'a' || Y[y] == 'A')
                {
                    IsVavole++;
                }
                else if (Y[y] == 'e' || Y[y] == 'E')
                {
                    IsVavole++;
                }
                else if (Y[y] == 'i' || Y[y] == 'I')
                {
                    IsVavole++;
                }
                else if (Y[y] == 'o' || Y[y] == 'O')
                {
                    IsVavole++;
                }
                else if (Y[y] == 'u' || Y[y] == 'U')
                {
                    IsVavole++;
                }
            }
            Console.WriteLine($"The Vavole Number Is : {IsVavole}");
            */


            //static void CharDemo()
            //{
            //    string nam, nam1 = "";
            //    int i, l;
            //    Console.WriteLine("Enter The String");
            //    nam = Console.ReadLine();
            //    l = nam1.Length - 1;
            //    for(i = l; i >=0; i--)
            //    {
            //        nam1 = nam1 + nam[i];
            //    }
            //    Console.WriteLine("{0}",nam1);
            //}
            //CharDemo();

            //Count the Number of Digits Symbols and Alphabets in a String
            //Console.WriteLine("Enter text");
            //string? text = Console.ReadLine();
            //int digits = 0, symbols = 0, alphabets = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (char.IsNumber(text[i]))
            //    {
            //        digits++;
            //    }
            //    else if (char.IsPunctuation(text[i]))
            //    {
            //        symbols++;
            //    }
            //    else if (char.IsLetter(text[i]))
            //    {
            //        alphabets++;
            //    }

            //}
            //Console.WriteLine("Number " + digits);
            //Console.WriteLine("Number " + alphabets +"\n"+ symbols);


            //string str = "Pakistan";

            //for (int i = str.Length - 1; i >= 0; i--)
            //{


            //    Console.Write(str[i]);


            //}

            //Console.WriteLine("The Number of Digits in the String is " + digits);
            //Console.WriteLine("The Number of symbols in the String is " + symbols);
            //Console.WriteLine("The Number of Alphabets in the String is " + alphabets);

            ////Print the String in Reverse
            //string p = "Pakistan";
            //for (int i = p.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(p[i]);

            //}

            ////Write a Program to Count the Number of Vowels in Any String

            //string name = "IKramUllah Balti";
            //int Isvowel = 0;
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] == 'a' || name[i] == 'A')
            //    {
            //        Isvowel++;
            //    }
            //    else if (name[i] == 'e' || name[i] == 'E')
            //    {
            //        Isvowel++;
            //    }
            //    else if (name[i] == 'i' || name[i] == 'I')
            //    {
            //        Isvowel++;
            //    }
            //    else if (name[i] == 'o' || name[i] == 'O')
            //    {
            //        Isvowel++;
            //    }
            //    else if (name[i] == 'u' || name[i] == 'U')
            //    {
            //        Isvowel++;
            //    }


            //}
            //Console.WriteLine("Thre are" + Isvowel + " vowel in string " + name);

            //for (int i = 3; i <= 50; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 3; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //Replace whitespace & display string in upper case

            //Console.WriteLine("Enter some text here");
            //string text=Console.ReadLine()??"";
            //foreach(char ikr in text)
            //{
            //    if(char.IsWhiteSpace(ikr))
            //    {
            //        Console.Write(char.ToUpper(ikr));
            //    }

            //}

            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //foreach (char ikr in text)
            //{
            //    if (char.IsWhiteSpace(ikr) && char.IsLetter(ikr))
            //    {
            //        Console.Write(char.ToUpper(ikr));
            //    }

            //}


            // Console.Write("Enter some Text here: ");
            // string? text = Console.ReadLine();
            //// string? name = newString[len];
            // foreach (char ch in text)
            // {
            //     if ((!char.IsWhiteSpace(ch))&&char.IsLetter(ch))
            //     {
            //         string name=Convert.ToString(char.ToUpper(ch));
            //        // Console.Write(name);
            //     }
            // }
            // Console.WriteLine(names);


            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //int len = text.Length;
            //foreach(var ch in text)
            //{
            //    if (char.IsWhiteSpace(ch))
            //    {
            //        Console.WriteLine(char.ToUpper(ch));
            //    }
            //    Console.WriteLine(ch);
            //}


            //string strts = "hello world";
            //string mame = strts.Replace(" "  ,  " ").ToUpper();
            //Console.WriteLine(mame);



            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //string nm = Convert.ToString(text);
            //Console.WriteLine(nm);
            //foreach(char ch in text)
            //{
            //    if(char.IsDigit(ch))
            //    {
            //        Console.WriteLine(ch);
            //    }
            //    string texts= Convert.ToString(char.ToUpper(ch));
            //    Console.WriteLine(texts);
            //}

            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //string? name = null;
            //if(text.StartsWith("pak"))
            //{
            //    Console.WriteLine("word is pak");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Text");
            //}

            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //string? name = null;
            //bool r = text.StartsWith("pak");
            //if (!r)
            //{
            //    Console.WriteLine("Word Pak");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a Valid number!");
            //}

            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";

            //int index = text.ToUpper().IndexOf("pak");
            //if (index != -1)
            //{
            //    Console.WriteLine("Word Pak");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Text");
            //}

            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";

            //int index = text.Trim().ToUpper().IndexOf("");
            //Console.WriteLine(index);

            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";

            //int index = text.IndexOf("m");
            //Console.WriteLine(index);

            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";

            //int index = text.ToLower().IndexOf("pak");
            //Console.WriteLine(index);

            //Console.WriteLine("Enter the text here");
            //string text = Console.ReadLine() ?? "";
            //int index = text.Trim().ToUpper().IndexOf(' ');

            //// Check if the space character was found
            //if (index != -1)
            //{
            //    Console.WriteLine("index: " + index);
            //}
            //else
            //{
            //    Console.WriteLine("No string.");
            //}

            //Console.WriteLine("Enter some text1 here");
            //string text1 = Console.ReadLine() ?? "";

            //Console.WriteLine("Enter the text2 here");
            //string text2 = Console.ReadLine() ?? "";
            //if (text1.Equals(text2))
            //{
            //    Console.WriteLine("It is equal to each other");
            //}
            //else
            //{
            //    Console.WriteLine("Its not equal to each other");
            //}

            //Console.WriteLine("Enter some text1 here");
            //string text1 = Console.ReadLine() ?? "";

            //Console.WriteLine("Enter the text2 here");
            //string text2 = Console.ReadLine() ?? "";
            //if (text1.Equals(text2, StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("It is equal to each other");
            //}
            //else
            //{
            //    Console.WriteLine("Its not equal to each other");
            //}

            ////////////------Assigment----------///////////

            ////(01)
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";

            //foreach(char ch in text)
            //{
            //    if ((!char.IsWhiteSpace(ch)) && char.IsLetter(ch))
            //    {
            //        Console.WriteLine(ch);
            //    }
            //}
            //Console.ReadLine();

            //////(02)String Demo
            //Console.WriteLine("Enter some text here");
            //string? text = Console.ReadLine();
            //int len = text.Length;
            //Console.WriteLine(len);
            //Console.ReadLine();

            ///////(03)StratWith() program
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine()??"";
            //bool r = text.StartsWith("Pakistan");
            //Console.WriteLine(r);
            //Console.ReadLine()

            ///////(04)StratWith() program with compare to upper in case user define a value in any case
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //bool r = text.ToUpper().StartsWith("Pakistan");
            //Console.WriteLine(r);
            //Console.ReadLine();

            ///////(05)If Null Comes Replace with an Empty String program
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";

            //Console.WriteLine(text);
            //Console.ReadLine();

            ///////(06)EndWith() program
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //bool r = text.ToUpper().EndsWith("Pakistan");
            //Console.WriteLine(r);
            //Console.ReadLine();

            ///////(07)IndexOf() program
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //int index = text.IndexOf("Pak");
            //Console.WriteLine(index);
            //Console.ReadLine();

            ///////(08)IndexOf() program with start find from a specific index number
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //int index = text.IndexOf("Pak",5);
            //Console.WriteLine(index);
            //Console.ReadLine();

            ///////(09)LastIndexOf() program with start find from a specific index number
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //int index = text.LastIndexOf("Pak");
            //Console.WriteLine(index);
            //Console.ReadLine();

            ///////(10)Substring() program  with start index and slice number of characters if the index,automatically take last -1. Return a new string.

            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //string newText = text.Substring(5, 3);
            //Console.WriteLine(newText);
            //Console.ReadLine();

            ///////(11)TrimStart() program  will remove space from starts 
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //string newText = text.TrimStart();
            //Console.WriteLine(newText);
            //Console.ReadLine();

            ///////(12)TrimEnd() program  will remove space from the Ends 
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //string newText = text.TrimEnd();
            //Console.WriteLine(newText);
            //Console.ReadLine();

            ///////(13)Trim() program  will remove space from the start and ends 
            //Console.WriteLine("Enter some text here");
            //string text = Console.ReadLine() ?? "";
            //string newText = text.Trim();
            //Console.WriteLine(newText);
            //Console.ReadLine();

            /*/////(14)Split() program  will slice on the basis of any character or space 
            Console.WriteLine("Enter some text here");
            string text = Console.ReadLine() ?? "";
            string[] newText = text.Split(" ");
            foreach (string s in newText)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();*/

            /*   
                Console.WriteLine("Enter some text here");
               string text = Console.ReadLine() ?? "";
               int index = text.IndexOf("Pak");
               Console.WriteLine(index);
               Console.ReadLine();
             */
            /*
            string par = "Pakistan, officially known as the " +
    "Islamic Republic of Pakistan, is a country " +
    "located in South Asia. It shares borders   " +
    "with India, Afghanistan, Iran, and China. " +
    "With a population of over 220 million people, " +
    "Pakistan is the fifth-most populous country in " +
    "the world. Islamabad is the capital city, while" +
    " Karachi is the largest city and main financial hub. " +
    "Pakistan has a diverse culture, rich history, " +
    "and a blend of various ethnic groups, languages," +
    " and traditions. The country is known for its " +
    "beautiful landscapes, including the stunning " +
    "peaks of the Himalayas, the ancient ruins of " +
    "Mohenjo-Daro and Taxila, and the vibrant cities " +
    "like Lahore with its Mughal architecture and bustling " +
    "bazaars. Pakistan gained independence from British rule " +
    "in 1947, and since then, it has faced various challenges " +
    "and achievements on its path to development and progress. " +
    "The economy of Pakistan is diverse, with agriculture, industry," +
    " and services sectors playing vital roles.";

            string WordToFind = "Pakistan";

            Console.WriteLine(par);
            Console.WriteLine($"Occurrences of the word '{WordToFind}' in this paragraph:");

            for (int index = 0; index < par.Length; index++)


            {
                index = par.IndexOf(WordToFind, index);
                if (index != -1)
                {
                    Console.WriteLine(index);
                    index += WordToFind.Length;
                }
            }

            Console.ReadLine();*/

            /*string par = "Pakistan, officially known as the " +
            "Islamic Republic of Pakistan, is a country " +
            "located in South Asia. It shares borders   " +
            "with India, Afghanistan, Iran, and China. " +
            "With a population of over 220 million people, " +
            "Pakistan is the fifth-most populous country in " +
            "the world. Islamabad is the capital city, while" +
            " Karachi is the largest city and main financial hub. " +
            "Pakistan has a diverse culture, rich history, " +
            "and a blend of various ethnic groups, languages," +
            " and traditions. The country is known for its " +
            "beautiful landscapes, including the stunning " +
            "peaks of the Himalayas, the ancient ruins of " +
            "Mohenjo-Daro and Taxila, and the vibrant cities " +
            "like Lahore with its Mughal architecture and bustling " +
            "bazaars. Pakistan gained independence from British rule " +
            "in 1947, and since then, it has faced various challenges " +
            "and achievements on its path to development and progress. " +
            "The economy of Pakistan is diverse, with agriculture, industry," +
            " and services sectors playing vital roles." ?? "";

            string WordToFind = "Pakistan" ?? "";

            Console.WriteLine("par");
            Console.WriteLine(par);

            Console.WriteLine($"index of {WordToFind} in this paragraph");
            int index = -1;

            do
            {
                index = par.IndexOf(WordToFind, index + 1);
                if (index != -1)
                {
                    Console.WriteLine(index);
                }
            }
            while (index != -1);
            Console.ReadLine();*/

            ////////---------17/05/2023-----------//////////
            /*
            Console.WriteLine("Enter some text here");
            string para=Console.ReadLine()??"";

            Console.WriteLine("Enter a key>>");
            string key = Console.ReadLine() ?? "";

            int index = -1; //start with zero

            while (true)
            {
                index=para.IndexOf(key, ++index);
                if (index == -1)
                {
                    break;
                }
                Console.WriteLine($"{key} is at index {index}");
            }

            Console.ReadLine();
            */

            /* 
            Console.WriteLine("Enter some text here");
            string para = Console.ReadLine() ?? "";

            Console.WriteLine("Enter a key>>");
            string key = Console.ReadLine() ?? "";

            int index = -1; //start with zero

            while (true)
            {
                index = para.IndexOf(key, ++index);
                if (index == -1)
                {
                    Console.WriteLine("last ma ya aya ga");
                    break;
                }
                Console.WriteLine($"{key} is at index {index}");
            }
            Console.WriteLine("Out of loop");
            Console.ReadLine();
            */
            /*
                        Console.WriteLine("Enter some text here");
                        string para = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter a key>>");
                        string key = Console.ReadLine() ?? "";

                        int index = 0; 

                        while (index != -1)
                        {
                            index = para.IndexOf(key, index+1);               
                            Console.WriteLine($"{key} is at index {index}");
                        }
                        Console.WriteLine("Out of loop");
                        Console.ReadLine();
            */
            /*
            Console.WriteLine("Enter some string");
            string str=Console.ReadLine()??"";

            Console.WriteLine("Enter the key word");
            string key = Console.ReadLine() ??;

            for(int i=0; i<str.Length; i++)
            {
                //if (str.IndexOf(str, i) == 1)
                //{
                 //   Console.WriteLine(i);
                //}
                i= str.IndexOf(str, i);
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */
            /*
                        Console.WriteLine("Enter some string");
                        string str = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter the key word");
                        string key = Console.ReadLine() ??;

                        int index str.IndexOf(key);

                        while (index!= -1)
                        {
                            Console.WriteLine($"{index}");
                            index str.IndexOf(key, index+1);
                        }

                        Console.ReadLine();
            */

            Console.WriteLine("Enter some string");
            string str = Console.ReadLine() ?? "";

            Console.WriteLine("Enter the key word");
            string key = Console.ReadLine() ??"";

            int index = -1;

            do
            {
                index = str.IndexOf(key, index + 1);
                if (index != -1)
                {
                    Console.WriteLine(index);
                }
            }
            while (index != -1);
            Console.ReadLine();
        }

    }
}


