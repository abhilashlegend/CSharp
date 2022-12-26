Console.WriteLine("Please enter student name");
string name = Console.ReadLine();

Console.WriteLine("Enter English Marks");
int english = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Kannada Marks");
int kannada = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Hindi Marks");
int hindi = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Maths Marks");
int maths = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Science Marks");
int science = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Social Marks");
int social = int.Parse(Console.ReadLine());

int totalSubjectMarks = 600;

int score = english + kannada + hindi + maths + science + social;
double percentage = ((double) score / totalSubjectMarks) * 100;

string grade;

if(percentage >= 85)
{
    grade = "A+";
}
else if(percentage >= 70 && percentage < 85)
{
    grade = "A";
}
else if(percentage >= 65 && percentage < 70){
    grade = "B+";
}
else if(percentage >= 60 && percentage < 65)
{
    grade= "B";
}
else if(percentage >= 50 && percentage < 60)
{
    grade = "C";
}
else if(percentage >= 35 && percentage < 50)
{
    grade = "D";
}
else
{
    grade = "Fail";
}

Console.WriteLine($"Total marked scord : {score}");
Console.WriteLine($"Percentage earned  : {percentage}");
Console.WriteLine($"Grade earned : {grade}");

switch (grade)
{
    case "A+":
        Console.WriteLine($"Congratulations {name}, You have scored A+ with {percentage}. Excellent");
        break;
    case "A":
        Console.WriteLine($"Congratulations {name}, You have scored A with {percentage}. Very Good");
        break;
    case "B+":
        Console.WriteLine($"Congratulations {name}, You have scored B+ with {percentage}. Good");
        break;
    case "B":
        Console.WriteLine($"Congratulations {name}, You have scored B with {percentage}.");
        break;
    case "C":
        Console.WriteLine($"You have scored C with {percentage}.You need to improve {name}");
        break;
    case "D":
        Console.WriteLine($"You have scored D with {percentage}. You need to work hard in your studies {name}");
        break;
    default:
        Console.WriteLine($"You have failed in your exam. You have to study hard {name}");
        break;
}
Console.ReadLine();