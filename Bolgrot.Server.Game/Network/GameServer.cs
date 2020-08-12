﻿using System;
using System.Threading.Tasks;
using Bolgrot.Core.Common.Network;
using EmbedIO.WebSockets;

namespace Bolgrot.Server.Game.Network
{
    public class GameServer : AbstractServer
    {
        public GameServer(string urlPath) : base(urlPath, false)
        {
        }
        
        protected override Task OnClientConnectedAsync(IWebSocketContext context)
        {
            // Console.WriteLine($"Client {context.Id} connected");
            this._logger.Info($"Client {context.Id} connected");
            
            var client = new Client(context.Id, context);
            client.OnDisconnect += DisconnectEventHandler;
            
            this.Clients.TryAdd(context.Id, client);

            SendAsync(context, "0{\"sid\":\"h-Tc6sbvNVUqwrImAL-o\",\"upgrades\":[],\"pingInterval\":25000,\"pingTimeout\":5000}");
            
            
            Console.WriteLine("PROUT");
            
            return Task.CompletedTask;
        }
    }
}