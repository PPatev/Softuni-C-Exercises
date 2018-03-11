using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Parking_Validation
{
    class ParkingValidation
    {
        static void Main(string[] args)
        {
            var usersPaltes = new Dictionary<string, string>();
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var username = input[1];
                var command = input[0];

                switch (command)
                {
                    case "register":
                        var plate = input[2];
                        if (usersPaltes.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {usersPaltes[username]}");
                            continue;
                        }

                        if (!CheckPlate(plate))
                        {
                            Console.WriteLine($"ERROR: invalid license plate {plate}");
                            continue;
                        }

                        if (CheckIfExists(plate, usersPaltes))
                        {
                            Console.WriteLine($"ERROR: license plate {plate} is busy");
                            continue;
                        }

                        usersPaltes.Add(username, plate);
                        Console.WriteLine($"{username} registered {plate} successfully");
                        break;
                    case "unregister":
                        if (!usersPaltes.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                            continue;
                        }

                        usersPaltes.Remove(username);
                        Console.WriteLine($"user {username} unregistered successfully");
                        break;
                }
            }

            var output = usersPaltes.Select(kvp => $"{kvp.Key} => {kvp.Value}");
            Console.WriteLine(string.Join(Environment.NewLine, output));
        }

        private static bool CheckIfExists(string plate, Dictionary<string, string> usersPaltes)
        {
            if (usersPaltes.ContainsValue(plate))
            {
                return true;
            }

            return false;
        }

        private static bool CheckPlate(string plate)
        {
            if (plate.Length == 8)
            {
                if (char.IsUpper(plate[0])
                && char.IsUpper(plate[1])
                && char.IsUpper(plate[6])
                && char.IsUpper(plate[7]))
                {
                    if (char.IsDigit(plate[2])
                && char.IsDigit(plate[3])
                && char.IsDigit(plate[4])
                && char.IsDigit(plate[5]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
