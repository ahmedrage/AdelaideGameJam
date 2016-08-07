using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
	public GameObject player;
	bool started;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.transform.position.x + Camera.main.orthographicSize * (Screen.width / Screen.height) / 2 , transform.position.y, transform.position.z);
	}
}
