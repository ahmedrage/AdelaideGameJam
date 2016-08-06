using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class statScript : MonoBehaviour {
	public int itemsPicked;
	public float timeLeft;
	public float money;
	public int endSceneIndex;
	public Text timerText;
	public Text moneyText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft <= 0) {
			SceneManager.LoadScene (endSceneIndex);
		}
		timeLeft -= Time.deltaTime;
		int seconds = Mathf.RoundToInt (timeLeft);
		timerText.text = string.Format ("{0:D2}:{1:D2}", (seconds / 60), (seconds % 60));
		moneyText.text = "$" + money.ToString();
		if (timeLeft <= 0) {
			Fail ();
		}
	}

	void Fail() {
	}

}
