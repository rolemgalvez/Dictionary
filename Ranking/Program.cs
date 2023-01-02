//Welcome message
Console.WriteLine("Ranking");
Console.WriteLine("-------");
Console.WriteLine();

//Declare variables
Dictionary<int, int> ranks = new Dictionary<int, int>();

ranks.Add(1, 2022007);
ranks.Add(2, 2022004);
ranks.Add(3, 2022092);
ranks.Add(4, 2022010);
ranks.Add(5, 2022009);

//Show results
Console.WriteLine("Rank\tEmployee ID");
Console.WriteLine("----\t-----------");
int ctr = 1;
while (ctr <= 5)
{
    Console.WriteLine($"{ctr}\t{ranks[ctr++]}");
}
Console.WriteLine();

//End of program
Console.WriteLine("End of program.");
Console.ReadLine();