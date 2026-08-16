using System;
using System.Collections.Generic;

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
if (optionChoice == "2")
{
    AddDevice();
}

static void ViewDevices()
{
    Console.WriteLine("No devices found.");
}

static void AddDevice()
{
    Console.WriteLine("Enter device name:");
    string DeviceName = Console.ReadLine();

    Console.WriteLine("Enter device type:");
    string DeviceType = Console.ReadLine();

    Console.WriteLine("Enter IP address:");
    string IpAddress = Console.ReadLine();

    Console.WriteLine("Enter MAC address:");
    string MacAddress = Console.ReadLine();

    Console.WriteLine($"Device '{DeviceName}' has been added.");
    Console.WriteLine($"'{DeviceName}' has been added to the '{DeviceType}' device type.");
    Console.WriteLine($"'{DeviceName}' have IP address '{IpAddress}' and MAC address '{MacAddress}'.");
}