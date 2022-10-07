namespace Ezzatron.HelloCli;

using Ezzatron.Hello;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine(Greeter.Greet(args[0]));
  }
}
