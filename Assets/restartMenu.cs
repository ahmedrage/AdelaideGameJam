using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restartMenu : MonoBehaviour {
	public Text moneyText;
	// Use this for initialization
	void Start () {
		moneyText.text = "$" + PlayerPrefs.GetFloat ("Money").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void restart () {
		SceneManager.LoadScene (0);
	}
}
