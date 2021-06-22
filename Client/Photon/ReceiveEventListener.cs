using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExitGames.Client.Photon;

namespace Client.Photon
{
	/// <summary>
	/// 受信イベントリスナ
	/// </summary>
	public interface IReceiveEventListener
	{	
		/// <summary>
		/// イベント受信
		/// </summary>
		/// <param name="eventData">イベントデータ</param>
		void OnEvent(EventData eventData);

		/// <summary>
		/// オペレーションレスポンス受信
		/// </summary>
		/// <param name="operationResponse">レスポンス</param>
		void OnOperationResponse(OperationResponse operationResponse);
	}
}
