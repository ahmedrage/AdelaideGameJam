using UnityEngine;
using System.Collections;

public class m_Player : MonoBehaviour {
	public Rigidbody2D rb;
	public float speed;
	public float rateOfAcceleration;
	public float maxSpeed;
	public float yJump = 2.1f;
	public int level= 1;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		speed += Time.deltaTime * rateOfAcceleration;
		speed = Mathf.Clamp (speed, 0, maxSpeed);
		rb.velocity = transform.right * speed;
		if (Input.GetKeyDown (KeyCode.W)) {
			Move (true);
		} else if ((Input.GetKeyDown (KeyCode.S))) {
			Move(false);
		}

	}

	void Move (bool isUp) {
		if (isUp && level < 3) {
			transform.position = new Vector2 (transform.position.x, transform.position.y + yJump);
			level++;
		} else if (isUp == false && level > 1) {
			transform.position = new Vector2 (transform.position.x, transform.position.y - yJump);
			level--;
		}
	}
}
