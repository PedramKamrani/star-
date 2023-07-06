

for (int i = 0; i < 5; i++)
{
    Console.Write("*");
	for (int j = 0; j < 4; j++)
	{
        if (j%2==0)
        {
            Console.Write("+");
        }
        else
        {
            Console.Write("*");
        }
		
      
	}
    Console.WriteLine("");
}


int number;
Console.WriteLine("Please Enter Number");
 number=int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Even Number");
}
else
{
    Console.WriteLine("Odd Number");
}