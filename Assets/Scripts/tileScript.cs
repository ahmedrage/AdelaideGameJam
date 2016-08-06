using UnityEngine;
using System.Collections;

public class tileScript : MonoBehaviour {
	public float yOffset;
	public float xMin;
	public float xMax;
	public GameObject[] prefabArray;
	GameObject spawnObject;
	int state;
	public levelGenerator levelScript;
	// Use this for initialization
	void Awake () {
		levelScript = GameObject.FindGameObjectWithTag ("Gm").GetComponent<levelGenerator> ();
		GenerateObjects ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible() {
		Destroy (transform.parent.gameObject);
	}

	void GenerateObjects () {
		int random;
		if (levelScript.state == 0) {
			random = 0;
		} else if (state == 1) {
			random = 1;
		}
		random = Random.Range (0, prefabArray.Length);
		spawnObject = Instantiate(prefabArray[Random.Range(0, prefabArray.Length)], transform.position, transform.rotation) as GameObject;
		spawnObject.transform.parent = transform;
		spawnObject.transform.localPosition = new Vector2 (Random.Range (xMin, xMax), yOffset);
	}
}
