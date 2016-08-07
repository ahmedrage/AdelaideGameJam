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
	public Text tutorialText;
	public string[] tutorialTexts;
	public levelGenerator levelScript;
	public float initialTimeLeft;
	// Use this for initialization
	void Start () {
		levelScript = GetComponent<levelGenerator> ();
		initialTimeLeft = timeLeft;
	}
	
	// Update is called once per frame
	void Update () {
		if (levelScript.state == 2) {
			timeLeft -= Time.deltaTime;
		}
		int seconds = Mathf.RoundToInt (timeLeft);
		timerText.text = string.Format ("{0:D2}:{1:D2}", (seconds / 60), (seconds % 60));
		moneyText.text = "$" + money.ToString();
		if (timeLeft <= 0) {
			Fail ();
		}

			tutorialText.text = tutorialTexts [levelScript.state];
	}

	public void Fail() {
		PlayerPrefs.SetFloat ("Money", money);
		SceneManager.LoadScene (endSceneIndex);
	}

}
