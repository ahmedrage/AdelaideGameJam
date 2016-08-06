using UnityEngine;
using System.Collections;

public class tileScript : MonoBehaviour {
	public float yOffset;
	public float xMin;
	public float xMax;
	public GameObject[] prefabArray;
	GameObject spawnObject;
	// Use this for initialization
	void Awake () {
		GenerateObjects ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible() {
		Destroy (transform.parent.gameObject);
	}

	void GenerateObjects () {
		spawnObject = Instantiate(prefabArray[Random.Range(0, prefabArray.Length)], transform.position, transform.rotation) as GameObject;
		spawnObject.transform.parent = transform;
		spawnObject.transform.localPosition = new Vector2 (Random.Range (xMin, xMax), yOffset);
	}
}
