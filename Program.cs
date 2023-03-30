// See https://aka.ms/new-console-template for more information


using SYSPROWCFServicesClientLibrary40;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test Syspro DLL..!!");

        SYSPROWCFServicesPrimitiveClient client = new SYSPROWCFServicesPrimitiveClient("net.tcp://APPSERVER:31001/SYSPROWCFService/Soap", SYSPROWCFBinding.NetTcp);

        Console.WriteLine("Version: ");
        client.GetVersion();
        Console.ReadLine();

        Console.WriteLine("Service Name: ");
        client.GetServiceName();
        Console.ReadLine();

    }
}
 