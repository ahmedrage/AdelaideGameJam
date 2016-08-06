using UnityEngine;
using System.Collections;

public class levelGenerator : MonoBehaviour {
	public GameObject tilePrefab;
	public GameObject currentTile;
	public Renderer _renderer;
	public int state;
	// Use this for initialization
	void Start () {
		currentTile = GameObject.Find("startTile");
		_renderer = currentTile.transform.FindChild("Lane1").GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (_renderer.isVisible) {
			spawnTile ();
		}
	}

	void spawnTile () {
		if (currentTile != null && currentTile.transform.FindChild ("objectSpawn") != null) {
			Transform spawnPos = currentTile.transform.FindChild ("objectSpawn");
			currentTile = Instantiate (tilePrefab, spawnPos.position, spawnPos.rotation) as GameObject;
			_renderer = currentTile.transform.FindChild("Lane1").GetComponent<Renderer>();
		}
	}
}
