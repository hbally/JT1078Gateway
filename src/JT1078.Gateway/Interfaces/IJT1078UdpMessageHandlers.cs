﻿using JT1078.Gateway.Metadata;
using JT1078.Protocol;
using System.Threading.Tasks;

namespace JT1078.Gateway.Interfaces
{
    public interface IJT1078UdpMessageHandlers
    {
        Task<JT1078Response> Processor(JT1078Request request);
    }
}
