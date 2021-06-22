using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ExitGames.Client.Photon;

namespace Client.Photon
{
	/// <summary>
	/// クライアント
	/// </summary>
	public class PhotonClient : IDisposable, IPhotonPeerListener
	{
		/// <summary>
		/// Peer
		/// </summary>
		private PhotonPeer peer = null;

		/// <summary>
		/// １フレームの時間
		/// </summary>
		private static readonly int FrameTime = 1000 / 60;

		/// <summary>
		/// 接続された
		/// </summary>
		public Action OnConnected { set; private get; }

		/// <summary>
		/// Serviceのキャンセレーショントークンソース
		/// </summary>
		private CancellationTokenSource serviceCancellationTokenSource = null;
		
		public void Connect()
		{
			peer = new PhotonPeer(this, ConnectionProtocol.Tcp);
			peer.Connect("127.0.0.1:5678", "ChatServer");
			serviceCancellationTokenSource = new CancellationTokenSource();
			Task.Run(async () =>
			{
				while (true)
				{
					peer.Service();
					await Task.Delay(FrameTime);
				}
			}, serviceCancellationTokenSource.Token);
		}

		/// <summary>
		/// Dispose
		/// </summary>
		public void Dispose()
		{
			CancelService();
		}

		/// <summary>
		/// Serviceのキャンセル
		/// </summary>
		private void CancelService()
		{
			if (serviceCancellationTokenSource != null)
			{
				serviceCancellationTokenSource.Cancel();
				serviceCancellationTokenSource = null;
			}
		}

		public void DebugReturn(DebugLevel level, string message)
		{
		}

		public void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		public void OnStatusChanged(StatusCode statusCode)
		{
			if (statusCode == StatusCode.Connect)
			{
				OnConnected?.Invoke();
			}
		}

		public void OnEvent(EventData eventData)
		{
		}

		public void OnMessage(object messages)
		{
		}

		/// <summary>
		/// デストラクタ
		/// </summary>
		~PhotonClient()
		{
			Dispose();
		}

		#region Singleton
		public static PhotonClient Instance {  get { return instance; } }
		private static PhotonClient instance = new PhotonClient();
		private PhotonClient() { }

		#endregion
	}
}
