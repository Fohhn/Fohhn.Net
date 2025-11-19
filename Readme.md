# Fohhn.Net
Simple C# 12 .NET 10.0 based functions for Fohhn-Net communication.

## Table of contents
- [Fohhn.Net](#fohhn.net)
  - [Table of contents](#table-of-contents)
  - [Requirements](#requirements)
  - [Usage](#usage)
  - [License](#license)

## Requirements
- Installed .NET 10.0 SDK.
- Add Fohhn.Net.Core, Fohhn.Net.Devices and Fohhn.Net.IP or Fohhn.Net.Ports to your .NET project.

### Using COM Port on Windows
Go to device manager and activate **Load VCP** (Virtual COM Port) in the properties of the Fohhn USB device that is displayed as **USB Serial Converter**.
The USB device needs a reconnect to enumerate the COM Port.

## Usage
Example for sending a command and receiving a reply:
Always wait for a reply, or at least 350ms timeout, before sending the next command!

```csharp
Node node = new IpNode("192.168.1.40"); // IP address of Fohhn device
node.DataReceived += Node_DataReceived;
byte[] cmd = Info.BuildReadCmd(1); // Fohhn-Net ID 1
replyDecoder = new ReplyDecoder(1);

node.Send(cmd);

Thread.Sleep(500); // wait before exiting the test command line application
```

```csharp
private static ReplyDecoder replyDecoder;

private static void Node_DataReceived(object? sender, DataReceiveEventArgs e)
{
    if (replyDecoder != null)
    {
        if (replyDecoder.DecodeReceivedBytes(e.Data))
        {
            if (replyDecoder.Data != null)
            {
                ushort device = 0;
                byte[] version = [0, 0, 0];
                if(Info.ParseReadBack(replyDecoder.Data, ref device, ref version))
                {
                    Console.WriteLine(DeviceLookup.GetDeviceString(device));
                }
                else
                {
                    Console.WriteLine("invalid reply");
                }
            }
        }
    }
}
```

Example for using a USB Virtual COM Port:

```csharp
Node node = new SerialPortNode("COM5", SerialPortNode.B19200);
```

## License
Fohhn.Net licensed under the [MIT License](https://opensource.org/licenses/MIT), see [LICENSE](LICENSE) for more information.
