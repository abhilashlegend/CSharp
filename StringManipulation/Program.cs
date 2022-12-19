string name = "Abhilash";
string age = "33";
string job = "Developer";

// 1. string Concatenation
Console.WriteLine("String Concatenation");
Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old.");

// 2. string formating
Console.WriteLine("String Formating");
Console.WriteLine("Hello my name is {0}, I am {1} years old and I am a {2}", name, age, job);

// 3. String interpolation
// string Interpolation uses $ at the start which will allow us to write our variables like this {variablename}

Console.WriteLine("string interpolation");
Console.WriteLine($"Hello my name is {name}, I am {age} years old and I am a {job}");

// 4. Verbatim strings
// verbatim strings start with @ and tells the compiler to take the string 
// literally and ignore any spaces and escape characters like \n
Console.WriteLine("Verbatim strings");
Console.WriteLine(@"Lorem ipsum dolor sit amet, 
consequter.



Lorem ipsum dolor sit amet");


Console.ReadLine();

