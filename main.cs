using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Minecraft_name_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();

            Console.WriteLine("Minecraft name checker | Coded by its jake#0001\n");
            Console.WriteLine("Minecraft name you want to check: ");
            string name = Console.ReadLine();
            try
            {
                string ApiResult = client.DownloadString("https://api.ashcon.app/mojang/v2/user/" + name);

                var userObj = JObject.Parse(ApiResult);
                var result = Convert.ToString(userObj["created_at"]);
                Console.WriteLine("\nThe date this account was made on was: " + result);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("\nThis account doesnt exist, or api error.");
                Console.ReadKey();
            }

        }
    }
}
