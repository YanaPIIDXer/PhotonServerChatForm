using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExitGames.Client.Photon;

namespace Client.Photon
{
	/// <summary>
	/// PhotonServerとの接続クラス
	/// </summary>
	class PhotonConnection : IPhotonPeerListener
	{
		/// <summary>
		/// Peer
		/// </summary>
		private PhotonPeer peer = new PhotonPeer(ConnectionProtocol.Tcp);

		/// <summary>
		/// 接続
		/// </summary>
		public void Connect()
		{
			peer.Connect("127.0.0.1:5678", "ChatServer");
		}

		public void DebugReturn(DebugLevel level, string message)
		{
			Console.WriteLine(message);
		}

		public void OnEvent(EventData eventData)
		{
		}

		public void OnMessage(object messages)
		{
		}

		public void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		#region Connect and Disconnect

		private Task ConnectionTask = null;

		public void OnStatusChanged(StatusCode statusCode)
		{
		}

		#endregion
	}
}
