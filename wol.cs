using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;

[assembly: AssemblyTitle("Wake-On-LAN Magic Packet Generator")]
[assembly: AssemblyProduct("Wake-On-LAN")]
[assembly: AssemblyCopyright("© 2017 Mateusz Adamowski")]
[assembly: AssemblyVersion("0.0.2.0")]
[assembly: AssemblyFileVersion("0.0.2.0")]

public class WakeOnLan_Tool {

    // FIXME : put your MAC here
    static readonly byte[] MAC = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

    public static int Main(){
        var bcast = new IPEndPoint( new IPAddress( 0xffffffff ), 9 );

        var magicpacket = new byte[ 17 * 6 ];

        for ( int i = 0; i < magicpacket.Length; i++ )
            magicpacket[ i ] = i < 6 ? (byte) 0xff : MAC[ i % 6 ];

        var client = new UdpClient();
        client.Send( magicpacket, magicpacket.Length, bcast );

        Console.WriteLine( "Magic packet sent" );
        return 0;
    }
}

