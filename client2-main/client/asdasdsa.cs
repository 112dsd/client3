using System.Net.Sockets;
using Syste.Text;
using system.text;

using Var tcpClient = new Socket(AddressFamily.InternetNetwork, socketType.Stream, ProtocolType.tcp);
try{
    await tcpClient.connectAsync("192.168.220.139", 1777);
    while (true)

{

    System.console.writeline("Введите команду для сервера");
string command = Console.ReadLine() + '\n';

byte[] imageData = file.readallbytes(img/yabloko.jpeg);

byte[] requestData = file.readallbytes(img/yabloko.jpeg);

await tcpClient.sendAsync(requestData, socketFlags.None);

Console.Writeline("Сообщение отправлено");

byte[] data = new byte[512];

}
}
catch (exception ex)
{
    Console.WriteLine(ex.Message);
}