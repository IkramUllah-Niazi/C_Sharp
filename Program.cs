//Equals
//In first way if case sensitive will return false
/*
 Console.WriteLine("Enter your text1 here");
string t1=Console.ReadLine()??"";

Console.WriteLine("Enter your Text2 here");
string t2 = Console.ReadLine() ?? "";

if(t2.Equals(t2))
{
    Console.WriteLine("Text1 And Text2 Are Equal To Each Other");
}
else
{
    Console.WriteLine("It's not equal to each other");
}
*/
/*
Console.WriteLine("Enter your text1 here");
string t1 = Console.ReadLine() ?? "";

Console.WriteLine("Enter your Text2 here");
string t2 = Console.ReadLine() ?? "";

if (t2.ToLower().Equals(t2.ToLower()))
{
    Console.WriteLine("Text1 And Text2 Are Equal To Each Other");
}
else
{
    Console.WriteLine("It's not equal to each other");
}
*/
/*
//In 2nd way if case sensitive during comparison will ignore and returns true
Console.WriteLine("Enter your text1 here");
string t1 = Console.ReadLine() ?? "";

Console.WriteLine("Enter your Text2 here");
string t2 = Console.ReadLine() ?? "";

if (t2.Equals(t2,StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Text1 And Text2 Are Equal To Each Other");
}
else
{
    Console.WriteLine("It's not equal to each other");
}
*/
/*
Console.WriteLine("Enter your text1 here");
string t1 = Console.ReadLine() ?? "";

Console.WriteLine("Enter your Text2 here");
string t2 = Console.ReadLine() ?? "";

int x= t1.CompareTo(t2);
Console.WriteLine(x);
*/
/*
//String Methods
//Advanced logic to and use of
//1)-
Console.WriteLine("Write a paragraph here");
string par = Console.ReadLine() ?? "";

Console.WriteLine("Enter a key here >>");
string key = Console.ReadLine() ?? "";

int index = -1;

while (true)
{
    index = par.IndexOf(key, ++index);//if put index++ then error
    if (index == -1)
    {
        Console.WriteLine($"Value will be show in last");
        break;
    }
    Console.WriteLine($"{key} is found at {index}");
}
Console.ReadLine();
*/
/*
string name = "Ali,Ikram,Usama,Kamran,Javeed";
string[] names=name.Split(',');
Array.Sort(names);
foreach (var item in names)
{
    Console.WriteLine(item);
}
Console.ReadLine();
*/
/*
string name = "Ali,Ikram,Usama,Kamran,Javed,Akbar";
string[] names = name.Split(',');

Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
Console.WriteLine(names[3]);
Console.WriteLine(names[4]);
Console.WriteLine(names[5]);
*/
/*
string name = "Ali,Ikram,Usama,Kamran,Javed";
string[] names = name.Split(',');
int i = 0;
foreach(string name2 in names)
{
    i++;
    Console.WriteLine($"At {i} Student Name Is {name2}");
}
*/
/*
//Date & Time
DateTime dt1 = DateTime.Now;
Console.WriteLine(dt1.ToString());

//DateTime dt1 = new DateTime(2023, 05, 20);

Console.WriteLine($"Year is {dt1.Year}");
Console.WriteLine($"Month is {dt1.Month}");
Console.WriteLine($"Day is {dt1.Day}");
Console.WriteLine($"Day Of Week is {dt1.DayOfWeek}");
Console.WriteLine($"Hour's is {dt1.Hour}");
Console.WriteLine($"Minutes is {dt1.Minute}");
Console.WriteLine($"Second is {dt1.Second}");
Console.WriteLine($"Millisecond is {dt1.Millisecond}");
*/
/*
DateTime dt = DateTime.Today;

Console.WriteLine(dt.ToString());
Console.WriteLine(dt.Year);
Console.WriteLine(dt.Month);
Console.WriteLine(dt.Day);
Console.WriteLine(dt.Hour);
Console.WriteLine(dt.Minute);
Console.WriteLine(dt.Second);

*/
/*
Console.WriteLine("Enter the DateTime YYYY-MM-DD");
DateTime dt=Convert.ToDateTime(Console.ReadLine());

Console.WriteLine($"Year is {dt.Year}");
Console.WriteLine($"Month is {dt.Month}");
Console.WriteLine($"Day is {dt.Day}");
*/
/*
Console.WriteLine("Enter the time in HH:MM:SS format:");
string userInput = Console.ReadLine()??"";

if (DateTime.TryParseExact(userInput, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime dt))
{
    Console.WriteLine($"Hour: {dt.Hour}");
    Console.WriteLine($"Minute: {dt.Minute}");
    Console.WriteLine($"Second: {dt.Second}");
}
else
{
    Console.WriteLine("Invalid time format.");
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();
*/
/*
Console.WriteLine("Enter The Time HH-MM-SS");
DateTime dt = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine($"Hour: {dt.Hour}");
Console.WriteLine($"Minute: {dt.Minute}");
Console.WriteLine($"Second: {dt.Second}");
*/
/*
Console.WriteLine("Enter The Time YYY-MM-DD");
DateTime dt = Convert.ToDateTime(Console.ReadLine());

string ds=dt.ToShortDateString();

Console.WriteLine(ds);
*/
/*
Console.WriteLine("Enter The Time YYY-MM-DD");
DateTime dt = Convert.ToDateTime(Console.ReadLine());

string ds = dt.ToLongDateString();

Console.WriteLine(ds);
*/
/*
DateTime dt = new DateTime(2023, 05, 20);

Console.WriteLine(dt.ToString("dd-MM-yy"));
Console.WriteLine(dt.ToString("dd-MMM-yy"));
Console.WriteLine(dt.ToString("dd-MMMM-yy"));
Console.WriteLine(dt.ToString("dd-MMMM-yyy"));
Console.WriteLine(dt.ToString("ddd-MMMM-yyy"));
Console.WriteLine(dt.ToString("dddd-MMMM-yyyy"));
Console.WriteLine(dt.ToString("ddddd-MMMM-yyyy hh:mm:ss t"));
Console.WriteLine(dt.ToString("dddd-MMMM-yyyy hh:mm:ss tt"));
*/
/*
DateTime dt = DateTime.Now;

DateOnly dt1= DateOnly.FromDateTime(DateTime.Now);
TimeOnly dt2= TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(dt.ToString());
Console.WriteLine(dt1);
Console.WriteLine(dt1.DayOfYear);
Console.WriteLine(dt1.DayOfWeek);
Console.WriteLine(dt1.DayNumber);
Console.WriteLine(dt2.ToString());
*/
/*
//Equals: There are Two ways 
//1) In, first way if case sensitive will return False
Console.Write("Enter some Text1 here: ");
string text1 = Console.ReadLine() ?? "";
Console.Write("Enter some Text2 here: ");
string text2 = Console.ReadLine() ?? "";
if (text1.Equals(text2))
{
    Console.WriteLine("Text 1 is Equal to Text 2");
}
else
{
    Console.WriteLine(" not equal");
}
Console.ReadLine();
*/
/*
//2) In, Second way  if case sensitive during comparison will ignore and returns True 
Console.Write("Enter some Text1 here: ");
string text1 = Console.ReadLine() ?? "";
Console.Write("Enter some Text2 here: ");
string text2 = Console.ReadLine() ?? "";
if (text1.Equals(text2, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Text 1 is Equal to Text 2");
}
else
{
    Console.WriteLine(" not equal");
}
Console.ReadLine();
*/
/*
//CompareTo()
Console.Write("Enter some Text1 here: ");
string text1 = Console.ReadLine() ?? "";
Console.Write("Enter some Text2 here: ");
string text2 = Console.ReadLine() ?? "";
int r = text1.CompareTo(text2);
Console.Write(r);
Console.ReadLine();
*/
/*
Console.WriteLine("Enter some text here");
string par=Console.ReadLine()??"4";
Console.WriteLine("Enter The Key Word");
string key = Console.ReadLine() ?? "4";

int index = -1;
while (true)
{
    index=par.IndexOf(key,++index);
    if (index == -1)
    {
        Console.WriteLine("Hi");
        break;
    }
    Console.WriteLine($"Key {key} is found as {index}");
}
*/
/*
string name = "Ali,Kamran,Rehan,Zaheer,Amir";
string[] names = name.Split(',');
Array.Sort(names);
foreach (var item in names)
{
    Console.WriteLine(item);
}
Console.ReadLine();
*/
/*
string name = "Ali,Kamran,Rehan,Zaheer,Amir";
string[] names=name.Split(',');

Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
Console.WriteLine(names[3]);
Console.WriteLine(names[4]);
Console.ReadLine();
*/

//DateTime dt = new DateTime(2023, 05, 17);
//Console.WriteLine(dt);

//DateTime dt = DateTime.Now;
//Console.WriteLine(dt.ToString());
/*
DateTime dt = new DateTime(2023, 05, 17,08,57,30);
Console.WriteLine(dt.Year);
Console.WriteLine(dt.Month);    
Console.WriteLine(dt.Day);
Console.WriteLine(dt.Hour);
Console.WriteLine(dt.Minute);
Console.WriteLine(dt.Second);
*/
/*
string text = "Hard work is key to success";
int NumOfWord=CountWords(text);
Console.WriteLine($"Number Of Word Is {NumOfWord}");

static int CountWords(string inputString)
{
    string[] words = inputString.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}
*/
/*
////q#01
string text = "hard work is key to success";
string[] words = text.Split(' ');
int numofwords = words.Length;
Console.WriteLine($"number of words in '{text}': {numofwords}");
*/

/*////Q#02
string text = "Pakistan is a very Beautiful Country. It is filled with resources. It is located in Asia.";
string key = "is";

int count = 0;
string[] words = text.Split(' ');
Console.WriteLine(text);

foreach (string word in words)
{
    if (word.Equals(key, StringComparison.OrdinalIgnoreCase))
    {
        count++;
    }
}

Console.WriteLine($"The word '{key}' appears {count} times.");
*/
/*
string text = "Pakistan is a very Beautiful Country. It is filled with resources. It is located in Asia.";
string key = "is";

int count = text.Split(' ').Count(word => word.Equals(key, StringComparison.OrdinalIgnoreCase));
Console.WriteLine($"The word '{key}' is {count} time.");
*/
/*
////q#03
//Console.WriteLine("enter a string:");
//string text = Console.ReadLine() ?? "0";

string text = "pakistan    zindabad        is       a      slogan.";
string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
string texts = string.Join(" ", words);
Console.WriteLine(texts);
*/
/*
////Q#04
string text = "Pakistan is our country";
char char1 = 'o';
char char2 = '8';

char[] charArray = text.ToCharArray();
for (int i = 0; i < charArray.Length; i++)
{
    if (charArray[i] == char1)
        charArray[i] = char2;
}

string newText = new string(charArray);
Console.WriteLine(newText);
*/
/*
string text = "Pakistan is our country";
char char1 = 'o';
char char2 = '8';

string newText = ReplaceCharacters(text, char1, char2);

Console.WriteLine(newText);

static string ReplaceCharacters(string text, char char1, char char2)
{
    return text.Replace(char1, char2);
}
*/
/*
/////Q#05
string text = "Hello World";
string Text = "";

foreach (char c in text)
{
    Text += new string(c, 3);
}

Console.WriteLine(Text);
*/
//////////////-----------------22/05/2023----------------//////////////////////
//Value Returns in Integer
/*
DateTime dt = DateTime.Now;

//Console.WriteLine(dt);
//Console.WriteLine(dt.Year+dt.Month+dt.Hour+dt.Minute);

Console.WriteLine($"{dt.Year}  {dt.Month}  {dt.Hour}  {dt.Minute}");
*/
/*
DateTime dt = new DateTime(2023, 05, 22);

Console.WriteLine(dt.Year);
Console.WriteLine(dt.Month);

DateTime dt1 = dt.AddDays(5);
//Console.WriteLine(dt.AddMonths);
Console.WriteLine(dt1);
Console.ReadLine();
*/

/*//////////////-----------------23/05/2023----------------//////////////////////
//Date & Time
//Time Spend
*//*
Console.WriteLine("Last lec Delivered date");
DateTime lastLect=Convert.ToDateTime(Console.ReadLine());

DateTime dt=Convert.ToDateTime("2023,05,20 22:50:36");

*//*

Console.WriteLine("Enter Starts date");
DateTime sc = Convert.ToDateTime(Console.ReadLine());

DateTime dt = Convert.ToDateTime("2023,05,20 22:50:36");

TimeSpan ts = dt.Subtract(sc);

Console.WriteLine($"Days {ts.TotalDays}");
Console.WriteLine($"Hours {ts.TotalHours}");
Console.WriteLine($"Minutes {ts.TotalMinutes}");
Console.WriteLine($"Seconds {ts.TotalSeconds}");
*/
/*

Console.WriteLine("Enter Starts date");
DateTime sc = Convert.ToDateTime(Console.ReadLine());

DateTime dt = DateTime.Today;
TimeSpan ts = dt.Subtract(sc);

Console.WriteLine(ts.TotalDays);
Console.WriteLine(ts.TotalHours);
Console.WriteLine(ts.TotalMinutes);
Console.WriteLine(ts.TotalSeconds);

int year = (int)(ts.TotalDays / 365);
Console.WriteLine("Year are " + year);

int month = (int)(ts.TotalDays / 365) * 12;
Console.WriteLine("Month are " + month);
*/
//Console.WriteLine($"Years: {dt.Year - sc.Year}");
//Console.WriteLine($"Months: {(dt.Year - sc.Year) * 12 + (sc.Month - sc.Month)}");

/*
Console.WriteLine("Enter Your Birthday Date: ");
DateTime dob=Convert.ToDateTime(Console.ReadLine());

DateTime tdt = DateTime.Today;
//DateTime tdt=DateTime.Now;

TimeSpan ts = tdt.Subtract(dob);
Console.WriteLine($"Days {ts.TotalDays}");
Console.WriteLine($"Hour's {ts.TotalHours}");
Console.WriteLine($"Minutes {ts.TotalMinutes}");
Console.WriteLine($"Second {ts.TotalSeconds}");

int ys = (int)(ts.TotalDays / 365.25);
int mts = (int)(ts.TotalDays / 365.25) * 12;

Console.WriteLine($"Your Age Is {ys} And Months are: {mts}");
*/

/*
Console.WriteLine("Enter Your Birthday Date: ");
DateTime dob = Convert.ToDateTime(Console.ReadLine());

//DateTime tdt = DateTime.Today;
DateTime tdt = DateTime.Now;

TimeSpan ts = tdt.Subtract(dob);

int ys = (int)(ts.TotalDays / 365.25);
int mts = (int)(ts.TotalDays / 365.25) * 12;

Console.WriteLine($"Your Age Is {ys} And Months are: {mts}");

Console.ReadLine();
*/
/*
Console.WriteLine("Enter Your Birthday Date:");
DateTime dob = Convert.ToDateTime(Console.ReadLine());

DateTime currentDate = DateTime.Today;

int years = currentDate.Year - dob.Year;
int months = currentDate.Month - dob.Month;

if (currentDate.Day < dob.Day)
{
    months--;
}

if (months < 0)
{
    years--;
    months += 12;
}

Console.WriteLine($"Your Age is {years} years and {months} months.");

*/

/*
Console.WriteLine("Enter Your Birthday Date:");
DateTime dob = Convert.ToDateTime(Console.ReadLine());

DateTime cd = DateTime.Today;

int years = cd.Year - dob.Year;
int months = cd.Month - dob.Month;

Console.WriteLine("Your Age is "+years+"Years and " + months+"months");

Console.ReadLine();
*/
/*
Console.WriteLine("WEb Sites $ Mobile Apps 6th Month Course");
Console.WriteLine("Enter Start Date:");
//DateTime sd = Convert.ToDateTime(Console.ReadLine());
DateTime sd = new DateTime(2023, 03, 16);

DateTime cd = DateTime.Today;
TimeSpan du = cd.Subtract(sd);

Console.WriteLine("Days: " + du.TotalDays);
Console.WriteLine("Hours: " + du.TotalHours);
Console.WriteLine("Minutes: " + du.TotalMinutes);
Console.WriteLine("Seconds: " + du.TotalSeconds);

int years = (int)(du.TotalDays / 365);
Console.WriteLine("Years: " + years);

int months = (int)(du.TotalDays / 30.44);
Console.WriteLine("Months: " + months);

int weeks = (int)(du.TotalDays / 7);
Console.WriteLine("Weeks: " + weeks);

Console.ReadLine();
*/
/*
/////////////-------------------------ATM Codes------------------------//////////////////
int balance = 100000; // Initial account balance

while (true)
{
    Console.WriteLine("Welcome to the ATM!");
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Deposit");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Your balance is: $" + balance);
            break;
        case 2:
            Console.Write("Enter the amount to withdraw: ");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());

            if (withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
                Console.WriteLine("Withdrawal successful. Remaining balance: $" + balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
            break;
        case 3:
            Console.Write("Enter the amount to deposit: ");
            int depositAmount = Convert.ToInt32(Console.ReadLine());

            balance += depositAmount;
            Console.WriteLine("Deposit successful. New balance: $" + balance);
            break;
        case 4:
            Console.WriteLine("Thank you for using the ATM. Goodbye!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

    Console.WriteLine();
}
*/

///////////////////-----------------24/05/2023--------------------////////////////////////////
/*
Console.WriteLine("Enter you DOB: ");
DateTime dob = Convert.ToDateTime(Console.ReadLine());

DateTime dt = DateTime.Now;

Console.WriteLine("Days: " + dt.Subtract(dob).Days);
Console.WriteLine("Hour's: " + dt.Subtract(dob).Hours);
Console.WriteLine("Min: " + dt.Subtract(dob).Minutes);
*/
/*
Console.Write("Enter you DOB: ");
DateTime dob = Convert.ToDateTime(Console.ReadLine());

TimeSpan ts = DateTime.Today.Subtract(dob);

int years = (int)(ts.TotalDays / 365.25);
//int months = (int)(ts.TotalDays / 365.25) * 12;
int month1 = (int)(ts.TotalDays % 365.25) / 31;

//Console.WriteLine("Year is: " + years + " and Months are: " + months);
Console.WriteLine("Your age is: " + years + " Year's and: " + month1 + " moths old");
*/
/*
Console.Write("Enter you DOB: ");
DateTime dob = Convert.ToDateTime(Console.ReadLine());

TimeSpan ts = DateTime.Today.Subtract(dob);

int years = (int)(ts.TotalDays / 365.25);
int month1 = (int)(ts.TotalDays % 365.25) / 31;
Console.WriteLine("Your age is: " + years + " Year's and: " + month1 + " moths old");
*/
/*
DayOfWeek x = DayOfWeek.Saturday;
if (x != DayOfWeek.Saturday && x!=DayOfWeek.Sunday)
{
    Console.WriteLine(x + " is the working days");
}
else
{
    Console.WriteLine(x + " Saturday and sunday are off, take rest");
}
*/
/*
Console.WriteLine("Enter Your Days");
DayOfWeek x = (DayOfWeek)Enum.Parse(typeof(DayOfWeek),Console.ReadLine());

if (x.ToString() != "Saturday" && x.ToString() != "Sunday") 
{
    Console.WriteLine(x + "  is the working days");
}
else
{
    Console.WriteLine(x + "  Saturday and sunday are off, take rest");
}
Console.ReadLine();

//(Saturday != "Saturday" && Saturday != "Sunday")
//(Saturday != "Saturday" && Sunday != "Sunday")
//(Monday != "Saturday" && Monday != "Sunday")
*/
/*
Console.Write("Enter your DOB: ");
DateTime dob = Convert.ToDateTime(Console.ReadLine());

TimeSpan ts = DateTime.Today.Subtract(dob);
int years = (int)(ts.TotalDays / 365.25);

string age;

if (years >= 0 && years <= 10)
{
    age = "You are Child";
}
else if (years > 10 && years <= 18)
{
    age = "You are Boy";
}
else if (years > 18 && years <= 40)
{
    age = "You Are Adult";
}
else if (years > 40 && years <= 90)
{
    age = "You Are Old";
}
else
{
    age = "Unknown";
}

Console.WriteLine("Your age is: " + years + " years old");
Console.WriteLine("Age category: " + age);

Console.ReadLine();
*/
/*
Console.Write("Enter year: ");
int year = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter month: ");
int month = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter day: ");
int day = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter days to add: ");
int daysToAdd = Convert.ToInt32(Console.ReadLine());

DateTime initialDate = new DateTime(year, month, day);
DateTime futureDate = initialDate.AddDays(daysToAdd);

string dayOfWeek = futureDate.DayOfWeek.ToString();

Console.WriteLine("{0} days after {1}-{2}-{3} is {4}", daysToAdd, day, month, year, dayOfWeek);

Console.ReadLine();
*/
/*
Console.Write("Enter year: ");
int year = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter month: ");
int month = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter day: ");
int day = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter days to add: ");
int dt = Convert.ToInt32(Console.ReadLine());

DateTime dt1 = new DateTime(year, month, day).AddDays(dt);

DayOfWeek dW = dt1.DayOfWeek;

Console.WriteLine($"Date After Add is: {dt1.ToString("d")} {dW}");
Console.ReadLine();
*/
/*
Console.Write("Enter the days to add: ");
int ad = Convert.ToInt32(Console.ReadLine());

DateTime dt = DateTime.Today;

DateTime dt1 = dt.AddDays(ad);

DayOfWeek dw = dt.DayOfWeek;

int dy = dt1.DayOfYear;

Console.WriteLine($"Current date is {dt},\nAfter {ad} days the date is {dt1},\nThe day is {dw}");
Console.WriteLine($"The date is the {dy} days of the year.");

Console.ReadLine();
*/
/*
Console.Write("Enter the days to add: ");
int ad = Convert.ToInt32(Console.ReadLine());

DateTime dt = DateTime.Today;

DateTime dt1 = dt.AddDays(ad);

DayOfWeek dw = dt.DayOfWeek;

int dy = dt1.DayOfYear;

Console.WriteLine($"Current date is {dt.ToString("dd-MM-yyyy")}");
Console.WriteLine($"After {ad} days, the date is {dt1.ToString("dd-MM-yyyy")}");
Console.WriteLine($"The day is {dw}");
Console.WriteLine($"The date is the {dy} days of the year.");
Console.ReadLine();
*/
/*
Console.WriteLine("Enter date 1 (dd MM yyyy):");
DateTime d1 = DateTime.ParseExact(Console.ReadLine(), "dd MM yyyy", null );

Console.WriteLine("Enter date 2 (dd MM yyyy):");
DateTime d2 = DateTime.ParseExact(Console.ReadLine(), "dd MM yyyy", null);

TimeSpan span = d2 - d1;
int td = span.Days;

for (int i = 0; i <= td; i++)
{
    DateTime cd = d1.AddDays(i);
    Console.WriteLine($"{cd.ToString("dd - MM - yyyy")} = {cd.ToString("dddd")}");
}

Console.ReadLine();
*/

////////////////----------------25/05/2023-------------------/////////////////////////////
//Enum: it is a value types.so its maybe convert or cost.
//Custom Data type
//Enum means counting hel to define a type
//What is nameSpace: its mean logical grouping of related constants.   (20 is int type letrail)
/*
namespace CompanyA
{
    public class Orderstatus
    {
       
    }
}

namespace CompanyB
{
    public class Cde
    {
        // Code for CompanyB.MyClass
    }
}
*/
/*
using CharStringDateTimeSpanEnumTypeof_25_2023
    enum CityCode
{

}
*/

