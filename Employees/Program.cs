//Welcome message
Console.WriteLine("Employees");
Console.WriteLine("---------");
Console.WriteLine();

//Prepare variables
Dictionary<int, string> employees = new Dictionary<int, string>();

employees.Add(2022003, "Juan Dela Cruz");
employees.Add(2022005, "Samuel Jackson");
employees.Add(2022001, "Manny Azero");
employees[2022004] = "Wapali Sanchez";
employees[2022002] = "Abayga Lingtalaga";

//Show results
Console.WriteLine($"2022001: {employees[2022001]}");
Console.WriteLine();
Console.WriteLine($"2022002: {employees[2022002]}");
Console.WriteLine();
Console.WriteLine($"2022003: {employees[2022003]}");
Console.WriteLine();
Console.WriteLine($"2022004: {employees[2022004]}");
Console.WriteLine();
Console.WriteLine($"2022005: {employees[2022005]}");
Console.WriteLine();

//End of program
Console.WriteLine("End of program.");
Console.ReadLine();