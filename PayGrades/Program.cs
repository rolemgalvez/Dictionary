//Welcome message
Console.WriteLine("Pay Grades");
Console.WriteLine("----------");
Console.WriteLine();

//Prepare variables
Dictionary<string, decimal> payGrades = new Dictionary<string, decimal>();

payGrades.Add("Level 1", 10000);
payGrades.Add("Level 2", 20000);
payGrades.Add("Level 3", 30000);
payGrades.Add("Level 4", 40000);
payGrades.Add("Level 5", 50000);

//Show results
int ctr = 1;
while (ctr <= 5)
{
    Console.WriteLine($"Level {ctr}: {payGrades[$"Level {ctr++}"]}");
}

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();