string firstName = "Abhilash";
string lastName = "Dollar";

string fullname = string.Concat("", firstName," ", lastName, "");
Console.WriteLine(fullname);
Console.WriteLine(firstName.Substring(4));
Console.WriteLine(firstName.ToLower());
Console.WriteLine(lastName.ToUpper());
Console.WriteLine(fullname.Trim());
Console.WriteLine(firstName.IndexOf("i"));
Console.WriteLine(String.IsNullOrWhiteSpace(firstName));