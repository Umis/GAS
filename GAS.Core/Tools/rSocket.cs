﻿using System;
using System.Net.Sockets;
namespace GAS.Core
{
    class rSocket : Socket, IDisposable
    {
        public rSocket(SocketInformation socketinformation) : base(socketinformation) { }
        public rSocket(AddressFamily adressfamily, SocketType sockettype, ProtocolType protocoltype) : base(adressfamily, sockettype, protocoltype) { }
        public new void Dispose() {
            this.Dispose(true);
        }
    }
}
