﻿using UnityEngine;
using System.Collections;

public class tileScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible() {
		Destroy (transform.parent.gameObject);
	}
}
