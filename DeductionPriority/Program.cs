//Welcome message
Console.WriteLine("Deduction Priority");
Console.WriteLine("------------------");
Console.WriteLine();

//Declare variables
Dictionary<int, string> deductions = new Dictionary<int, string>();

deductions.Add(1, "SSS");
deductions.Add(2, "PHIC");
deductions.Add(3, "HDMF");
deductions.Add(4, "Tax");

//Show results
int ctr = 1;
while (ctr <= 4)
{
    Console.WriteLine($"{ctr}. {deductions[ctr++]}");
}

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();