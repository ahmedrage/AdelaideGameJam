using UnityEngine;
using System.Collections;

public class m_Player : MonoBehaviour {
	public Rigidbody2D rb;
	public float speed;
	public float rateOfAcceleration;
	public float maxSpeed;
	public float yJump = 2.1f;
	public float jumpForce;
	public int level= 1;
	public float maxYVelocity;
	public AudioSource jumpSound;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		speed += Time.deltaTime * rateOfAcceleration;
		speed = Mathf.Clamp (speed, 0, maxSpeed);
		rb.velocity =new Vector2(transform.right.x * speed,rb.velocity.y);
		if (Input.GetKeyDown (KeyCode.W)) {
			Move (true);
		} else if ((Input.GetKeyDown (KeyCode.S))) {
			Move(false);
		}

		if (Input.GetButtonDown("Jump") && rb.velocity.y == 0){ 
			//rb.AddRelativeForce (Vector2.up * jumpForce);
			rb.velocity = new Vector2(rb.velocity.x, jumpForce);
		}

	}

	void Move (bool isUp) {
		if (isUp && level < 3) {
			jumpSound.Play ();
			transform.position = new Vector2 (transform.position.x, transform.position.y + yJump);
			level++;
		} else if (isUp == false && level > 1) {
			jumpSound.Play ();
			transform.position = new Vector2 (transform.position.x, transform.position.y - yJump);
			level--;
		}
	}
}
