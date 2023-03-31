// See https://aka.ms/new-console-template for more information


using SYSPROWCFServicesClientLibrary40;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test Syspro DLL..!!");

        // SYSPROWCFServicesPrimitiveClient client = new SYSPROWCFServicesPrimitiveClient("net.tcp://APPSERVER:31001/SYSPROWCFService/Soap", SYSPROWCFBinding.NetTcp);
        SYSPROWCFServicesPrimitiveClient client = new SYSPROWCFServicesPrimitiveClient("net.tcp://localhost:91/SYSPROWCFService/Soap", SYSPROWCFBinding.NetTcp);
        var version = client.GetVersion();
        Console.WriteLine("Version: " + version);
        Console.ReadLine();

        Console.WriteLine("Service Name: ");
        var name = client.GetServiceName();
        Console.WriteLine(name);
        Console.ReadLine();


    }
}
 