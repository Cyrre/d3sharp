/*
 * Copyright (C) 2011 D3Sharp Project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using D3Sharp.Core.Toons;
using D3Sharp.Net.BNet;
using D3Sharp.Utils;
using D3Sharp.Utils.Extensions;
using Google.ProtocolBuffers;
using bnet.protocol.channel_invitation;

namespace D3Sharp.Core.Services
{
    [Service(serviceID: 0x3, serviceName: "bnet.protocol.channel_invitation.ChannelInvitationService")]
    public class ChannelInvitationService: bnet.protocol.channel_invitation.ChannelInvitationService, IServerService
    {
        private static readonly Logger Logger = LogManager.CreateLogger();
        public IBNetClient Client { get; set; }

        public override void Subscribe(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel_invitation.SubscribeRequest request, System.Action<bnet.protocol.channel_invitation.SubscribeResponse> done)
        {
            Logger.Trace("Subscribe()");
            
            // NOTE: SubscribeRequest gives us an object_id
            // Client should be added as a subscriber to.. something
            
            /*
            // TODO: Set these to the correct values.
            const ulong accountHandle = 0x0000000000000000;
            const ulong gameAccountHandle = 0x0000000000000000;

            var invitation = bnet.protocol.invitation.Invitation.CreateBuilder()
                .SetId(0)
                .SetInviterIdentity(bnet.protocol.Identity.CreateBuilder()
                    .SetAccountId(Client.Account.BnetAccountID)
                    .SetGameAccountId(Client.Account.BnetGameAccountID)
                    .Build())
                .SetInviteeIdentity(bnet.protocol.Identity.CreateBuilder()
                    .SetAccountId(bnet.protocol.EntityId.CreateBuilder().SetHigh(accountHandle).SetLow(0x0).Build()) //TODO: Change SetLow to an actual index in the database.
                    .SetGameAccountId(bnet.protocol.EntityId.CreateBuilder().SetHigh(gameAccountHandle).SetLow(0x0).Build()) //TODO: Change SetLow to an actual index in the database.
                    .Build())
                .SetInviterName("YourName")
                .SetInviteeName("FriendName") // lookup this from agentid.toon_id?
                .SetInvitationMessage("Invite Message")
                .SetCreationTime(DateTime.Now.ToUnixTime())
                .SetExpirationTime(DateTime.Now.AddDays(2).ToUnixTime())
                .Build();

            var invite_collection = bnet.protocol.channel_invitation.InvitationCollection.CreateBuilder()
                .SetServiceType(0)
                .SetMaxReceivedInvitations(127)
                .SetObjectId(request.ObjectId)
                .AddReceivedInvitation(invitation)
                .Build();
            */

            var builder = bnet.protocol.channel_invitation.SubscribeResponse.CreateBuilder()
                //.AddCollection(invite_collection)
                /*.AddReceivedInvitation(invitation)*/;

            done(builder.Build());
        }

        public override void AcceptInvitation(Google.ProtocolBuffers.IRpcController controller, AcceptInvitationRequest request, System.Action<AcceptInvitationResponse> done)
        {
            throw new System.NotImplementedException();
        }

        public override void DeclineInvitation(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.invitation.GenericRequest request, System.Action<bnet.protocol.NoData> done)
        {
            throw new System.NotImplementedException();
        }

        public override void RevokeInvitation(Google.ProtocolBuffers.IRpcController controller, RevokeInvitationRequest request, System.Action<bnet.protocol.NoData> done)
        {
            throw new System.NotImplementedException();
        }

        public override void SendInvitation(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.invitation.SendInvitationRequest request, System.Action<bnet.protocol.invitation.SendInvitationResponse> done)
        {
            var invitee = ToonManager.GetToonByLowID(request.TargetId.Low);

            //var invitationInfo = request.GetExtension(bnet.protocol.channel_invitation.SendInvitationRequest.ChannelInvitation); returns all empty, there should be another way..
            Logger.Warn(String.Format("{0} invited {1} to his channel.", Client.CurrentToon.Name, invitee.Name));
        }

        public override void SuggestInvitation(Google.ProtocolBuffers.IRpcController controller, SuggestInvitationRequest request, System.Action<bnet.protocol.NoData> done)
        {
            throw new System.NotImplementedException();
        }

        public override void Unsubscribe(Google.ProtocolBuffers.IRpcController controller, UnsubscribeRequest request, System.Action<bnet.protocol.NoData> done)
        {
            throw new System.NotImplementedException();
        }
    }
}
