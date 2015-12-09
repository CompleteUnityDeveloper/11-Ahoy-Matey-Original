using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyHUD : MonoBehaviour {

	private NetworkManager networkManager;

	// Use this for initialization
	void Start () {
		networkManager = GetComponent<NetworkManager> ();
	}

	public void MyStartHost () {
		Debug.Log ("Starting Host at " + Time.timeSinceLevelLoad);
		networkManager.StartHost ();
	}
	

	void OnStartHost() {
		Debug.Log ("Host started at " + Time.timeSinceLevelLoad);
	}
}
