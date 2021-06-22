using System;
using System.Collections.Generic;
using System.Text;
using Photon.SocketServer;
using PhotonHostRuntimeInterfaces;

namespace Server
{
	/// <summary>
	/// Peer
	/// </summary>
	public class ChatPeer : ClientPeer
	{
		public ChatPeer(InitRequest initRequest)
			: base(initRequest)
		{
		}

		protected override void OnDisconnect(DisconnectReason reasonCode, string reasonDetail)
		{
		}

		protected override void OnOperationRequest(OperationRequest operationRequest, SendParameters sendParameters)
		{
		}
	}
}
