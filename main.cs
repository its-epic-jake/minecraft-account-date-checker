using System;
using System.Net;

class MainClass {
  public static void Main (string[] args) {
    WebClient client = new WebClient();

    Console.WriteLine("Minecraft name checker | Coded by its jake#0001\n");
    Console.WriteLine("Minecraft name you want to check: ");

    string name = Console.ReadLine();

    try
    {
      string ApiResult = client.DownloadString("https://api.ashcon.app/mojang/v2/user/" + name);

      int start = ApiResult.IndexOf("\"created_at\": \"") + "\"created_at\": \"".Length;
      int end = ApiResult.LastIndexOf("\"");

      string result = ApiResult.Substring(start, end - start);

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
