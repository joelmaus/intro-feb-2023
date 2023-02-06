using System;
using Utils;

namespace Finger
{
    
    public class Program
    {
        //Entry point to application
        public static void Main()
        {
                Console.WriteLine("What is your status?");
                string? status = Console.ReadLine();

            if (status != null)
            {
            StatusMessage myStatus = new StatusMessage("I'm good", DateTimeOffset.Now);
                Console.WriteLine($"you said your status was {myStatus.Status} at {myStatus.When:T}");
            }
            else
            {
                Console.WriteLine("Sorry, cannot have a null status");
            }
        }

    }
}

namespace Utils
{
    public record StatusMessage(string Status, DateTimeOffset When);
}