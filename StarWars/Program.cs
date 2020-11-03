using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace StarWars
{
    class Program
    {
        static void Main()
        {
            WebClient client = new WebClient();
            int number;
            Context context = new Context();
            number = int.Parse(Console.ReadLine());
            Task task1 = new Task(() => 
            {
              Console.WriteLine("All the Star Wars persons you've ever wanted From all SEVEN Star Wars films. Now with The Force Awakens data!");
              Console.WriteLine("Write number of character, who you want to see");
            });  
            Task task2 = new Task(() =>
            {
                var myNewObject = JsonConvert.DeserializeObject<Person>(client.DownloadString("https://swapi.dev/api/people/" + number.ToString() + "/"));
                Console.Write(myNewObject);
                context.Add(myNewObject);
            });
            task1.Start();
            task2.Wait(4000);
            task2.Start();
        }
    }
}
