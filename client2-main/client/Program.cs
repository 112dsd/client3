using System.Net.Sockets;
using Syste.Text;
using system.runtime.interopservices.marshaling;

using Var tcpClient = new Socket(AddressFamily.InternetNetwork, socketType.Stream, ProtocolType.tcp);
try{
    await tcpClient.connectAsync("192.168.220.139", 1777);
    while (true)

{

    string path = ".img/yabloko.jpeg";

byte[] requestData = encoding.UTF8.GetBytes(path);

await tcpClient.sendAsync(requestData);

Console.Writeline("Сообщение отправлено");

byte[] data = new byte[512];

int bytes = await tcpClient.ReceiveAsync(data);

string time = Encoding.UTF8.GetString(data, 0, bytes);

Console.Writeline("");
}
}
catch (exception ex)
{
    Console.WriteLine(ex.Message);
}