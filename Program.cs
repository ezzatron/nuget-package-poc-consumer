namespace Ezzatron.HelloCli;

using Ezzatron.Hello;
using Newtonsoft.Json;

class Program
{
  static int Main(string[] args)
  {
    if (args.Length < 1)
    {
      Console.Error.WriteLine($"usage: {System.AppDomain.CurrentDomain.FriendlyName} <name>");

      return 1;
    }

    Console.WriteLine(JsonConvert.SerializeObject(Greeter.Greet(args[0])));

    return 0;
  }
}
