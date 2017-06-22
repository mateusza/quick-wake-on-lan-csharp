using System;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Reflection;

[assembly: AssemblyTitle("Wake-On-LAN Magic Packet Generator")]
[assembly: AssemblyProduct("Wake-On-LAN")]
[assembly: AssemblyCopyright("© 2017 Mateusz Adamowski")]
[assembly: AssemblyVersion("0.0.4.0")]
[assembly: AssemblyFileVersion("0.0.4.0")]

public static class WakeOnLan_Tool {
    public static string MAC = "00:01:a2:a3:04:05";
    // put your MAC here:       ^^^^^^^^^^^^^^^^^

    public static int Main(){
        byte[] macaddr = PhysicalAddress.Parse( MAC.ToUpper().Replace(":","-") ).GetAddressBytes();

        byte[] magicpacket = new byte[ 0x11 * macaddr.Length ];
        for ( int i = 0; i < magicpacket.Length; i++ ){
            magicpacket[ i ] = i < 6 ? (byte) 0xff : macaddr[ i % macaddr.Length ];
            Console.Write( "{0:X2} ", magicpacket[ i ] );
            if ( i % 6 == 5 ) Console.WriteLine("");
        }

        ( new UdpClient()).Send( magicpacket, magicpacket.Length, new IPEndPoint( IPAddress.Broadcast, 9 ) );
        Console.WriteLine( "Magic packet broadcasted" );
        return 0;
    }
}

