// Mathematics >= 90; Biology >= 90; Chemistry >= 90;

int math, bio, chem;

Console.WriteLine("Enter your Mathematics result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chem = Int32.Parse(Console.ReadLine());

if(math >= 90 && bio >= 90 && chem >= 90)
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}