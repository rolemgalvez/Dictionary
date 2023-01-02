//Welcome message
Console.WriteLine("Job Description");
Console.WriteLine("---------------");
Console.WriteLine();

//Prepare variables
Dictionary<string, string> jobs = new Dictionary<string, string>();

jobs["Information Technology"] = "Deals in computer related task.";
jobs["Human Resource"] = "Manage man power of the company.";
jobs["Accountant"] = "Monitor the financial occurences.";
jobs["Developer"] = "Create useful things for the organization.";
jobs["Manager"] = "Leads the group of employees.";

//Display result
Console.WriteLine($"Information Technology: {jobs["Information Technology"]}");
Console.WriteLine();
Console.WriteLine($"Human Resource: {jobs["Human Resource"]}");
Console.WriteLine();
Console.WriteLine($"Accountant: {jobs["Accountant"]}");
Console.WriteLine();
Console.WriteLine($"Developer: {jobs["Developer"]}");
Console.WriteLine();
Console.WriteLine($"Manager: {jobs["Manager"]}");
Console.WriteLine();

//End of program
Console.WriteLine("End of program.");
Console.ReadLine();