﻿/*
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
using System.Text;
using D3Sharp.Net.Game.Message.Definitions.Game;
using D3Sharp.Net.Game.Messages;

namespace D3Sharp.Net.Game.Message.Definitions.Connection
{
    [IncomingMessage(Opcodes.LogoutComplete)]
    public class LogoutComplete:GameMessage
    {
        public override void Handle(GameClient client)
        {
            if (client.IsLoggingOut)
            {
                client.SendMessageNow(new QuitGameMessage()
                {
                    Id = 0x0003,
                    // Field0 - quit reason?
                    // 0 - logout
                    // 1 - kicked by party leader
                    // 2 - disconnected due to client-server (version?) missmatch
                    Field0 = 0,
                });
            }
        }

        public override void Parse(GameBitBuffer buffer)
        {
            
        }

        public override void Encode(GameBitBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public override void AsText(StringBuilder b, int pad)
        {
            throw new NotImplementedException();
        }
    }
}
