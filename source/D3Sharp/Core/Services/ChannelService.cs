﻿using D3Sharp.Net;
using D3Sharp.Utils;
using D3Sharp.Core.Channels;

namespace D3Sharp.Core.Services
{
    [Service(serviceID: 0x10, serviceName: "bnet.protocol.channel.Channel")]
    public class ChannelService : bnet.protocol.channel.Channel, IServerService
    {
        protected static readonly Logger Logger = LogManager.CreateLogger();
        public IClient Client { get; set; }

        public override void AddMember(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.AddMemberRequest request, System.Action<bnet.protocol.NoData> done)
        {
            throw new System.NotImplementedException();
        }

        public override void Dissolve(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.DissolveRequest request, System.Action<bnet.protocol.NoData> done)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveMember(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.RemoveMemberRequest request, System.Action<bnet.protocol.NoData> done)
        {
            Logger.Trace("RemoveMember");
            Logger.Debug("request:\n{0}", request.ToString());
            Logger.Debug("ToonId:\n{0}", this.Client.CurrentToon.BnetEntityID.ToString());
            this.Client.CurrentChannel.NotifyChannelState((Client)this.Client);
            this.Client.CurrentChannel = null;
            done(bnet.protocol.NoData.CreateBuilder().Build());
        }

        public override void SendMessage(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.SendMessageRequest request, System.Action<bnet.protocol.NoData> done)
        {
            throw new System.NotImplementedException();
        }

        public override void SetRoles(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.SetRolesRequest request, System.Action<bnet.protocol.NoData> done)
        {
            throw new System.NotImplementedException();
        }

        public override void UpdateChannelState(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.UpdateChannelStateRequest request, System.Action<bnet.protocol.NoData> done)
        {
            Logger.Trace("UpdateChannelState");
            Logger.Debug("request:\n{0}", request.ToString());
            this.Client.CurrentChannel.NotifyChannelState((Client)this.Client);
            done(bnet.protocol.NoData.CreateBuilder().Build());
        }

        public override void UpdateMemberState(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.UpdateMemberStateRequest request, System.Action<bnet.protocol.NoData> done)
        {
            throw new System.NotImplementedException();
        }
    }
}
