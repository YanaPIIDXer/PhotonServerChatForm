using System;
using System.Collections.Generic;
using System.Text;
using Photon.SocketServer;

namespace Server
{
	/// <summary>
	/// サーバクラス
	/// </summary>
	public class ChatServer : ApplicationBase
	{
		protected override PeerBase CreatePeer(InitRequest initRequest)
		{
			return new ChatPeer(initRequest);
		}

		protected override void Setup()
		{
		}

		protected override void TearDown()
		{
		}
	}
}
