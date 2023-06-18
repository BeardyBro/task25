int ReadLine(string finish)
{
    Console.Write(finish);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
int Num (int num1, int num2)
{
    int num =1;
    for (int i =0; i<num2; i++)
    {
        num*=num1;
    }
    return num;
}
bool badnum2(int num2)
{
    if (num2 <0)
    {Console.WriteLine("bad number");
    return false;}
    return true;
}
int num1 = ReadLine("inset first number: ");
int num2 = ReadLine("insert second number: ");
if (badnum2(num2))
{
    Console.WriteLine($"Number {num1} in exponent {num2} equals {Num(num1, num2)}");
}

