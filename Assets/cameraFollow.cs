using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
	public GameObject player;
	public float followSpeed;
	bool started;
	float yStart;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		yStart = transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = Vector3.MoveTowards(transform.position, new Vector3 (player.transform.position.x + Camera.main.orthographicSize * (Screen.width / Screen.height) / 2 , yStart, transform.position.z), Time.deltaTime* followSpeed);
	}
}
