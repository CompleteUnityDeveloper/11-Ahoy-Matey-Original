using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {
	
	public void MyStartHost () {
		Debug.Log ("Starting Host at " + Time.timeSinceLevelLoad);
		StartHost ();
	}

	public override void OnStartHost() {
		Debug.Log ("Host started at " + Time.timeSinceLevelLoad);
	}
}
