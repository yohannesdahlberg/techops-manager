Console.WriteLine("=== TechOps Manager ===");

Console.WriteLine("Select an option:");
Console.WriteLine("1. View devices");
Console.WriteLine("2. Add device");
Console.WriteLine("3. Remove device");
Console.WriteLine("4. View device details");
Console.WriteLine("5. Exit");

string optionChoice = Console.ReadLine();

if (optionChoice == "1")
{
    ViewDevices();
}

static void ViewDevices()
{
    Console.WriteLine(\\"No devices found.");
}