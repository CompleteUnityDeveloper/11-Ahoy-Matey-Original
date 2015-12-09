using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {
	
	public void MyStartHost () {
		Debug.Log (Time.timeSinceLevelLoad + " Starting Host.");
		StartHost ();
	}

	public override void OnStartHost() {
		Debug.Log (Time.timeSinceLevelLoad + " Host started.");
	}

	public override void OnStartClient(NetworkClient myClient) {
		Debug.Log (Time.timeSinceLevelLoad + " Client start requested.");
		InvokeRepeating ("PrintDots", 0f, 1f);
	}

	public override void OnClientConnect(NetworkConnection conn) {
		Debug.Log (Time.timeSinceLevelLoad + " Client is connect to IP: " + conn.address);
		CancelInvoke ();
	}

	void PrintDots () {
		Debug.Log (".");
	}
}
