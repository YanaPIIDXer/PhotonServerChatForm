using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Photon
{
	/// <summary>
	/// クライアント
	/// </summary>
	public class PhotonClient
	{
		/// <summary>
		/// 接続オブジェクト
		/// </summary>
		private PhotonConnection connection = new PhotonConnection();

		#region Singleton
		public static PhotonClient Instance {  get { return instance; } }
		private static PhotonClient instance = new PhotonClient();
		private PhotonClient() { }
		#endregion
	}
}
