using UnityEngine;
using System.Collections;

public class pickupScript : MonoBehaviour {
	public enum pickUpType
	{
		Money, hidingSpot, Enemy
	};
	public pickUpType type;
	public float value;
	public AudioSource moneySound;
	public statScript stats;
	public GameObject particleEffect;
	// Use this for initialization
	void Start () {
		stats = GameObject.FindGameObjectWithTag ("Gm").GetComponent<statScript> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (type == pickUpType.Money) {
			stats.money += value;
			stats.timeLeft += value / 100;
			moneySound = other.gameObject.GetComponent<AudioSource> ();
			moneySound.Play ();
			Instantiate (particleEffect, transform.position, particleEffect.transform.rotation);
			Destroy (gameObject);
		} else if (type == pickUpType.hidingSpot) {
			if (other.gameObject.tag == "Player") {
				Camera.main.gameObject.GetComponent<screenShake> ().Shake ();
				other.gameObject.GetComponent<m_Player> ().speed = 0.1f;
			}
		} else if (type == pickUpType.Enemy) {
			GameObject.FindGameObjectWithTag ("Gm").GetComponent<statScript> ().Fail ();
		}
	}
}
