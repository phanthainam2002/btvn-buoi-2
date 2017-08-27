using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneScript : MonoBehaviour {

	public Text levelText;
	public InputField inputField;
	public Button submitButton;
	public Text hintText;
	public Button NextLevelButton;

	public string levelContent = "LEVELS";
	public string levelNumber;
	public string levelAnswer;
	string answer;

	// Use this for initialization
	void Start () {
		NextLevelButton.gameObject.SetActive (false);
		levelText.text = levelContent;
		StartCoroutine (ChangeLevelTextRoutine());


	}
	public void nextLevelbutton(){
		SceneManager.LoadScene("Level"+" "+ (int.Parse(levelNumber) + 1));
		NextLevelButton.gameObject.SetActive (false);
		
	}
	public void GetInput(){
		answer = inputField.text;
		CheckAnswer ();

	}
	public void CheckAnswer(){
		if (answer == levelAnswer) {
			hintText.color = Color.black;
			hintText.text = "Congrat bro :<<, You passed level" + levelNumber ;
			NextLevelButton.gameObject.SetActive (true);
			//TODO : ChangeScene
		} else {
			hintText.text ="WRONNGGGG !!!";
			hintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
		}
	}

	IEnumerator ChangeLevelTextRoutine(){
		while (true) {
			levelText.text = levelContent;
			//waait 2 secs;
			yield return new WaitForSeconds (2f);
			Debug.Log ("QUSAwhauhsn");
			levelText.text = levelNumber;
			yield return new WaitForSeconds (2f);


		}
	}
	public void startscene() {
		SceneManager.LoadScene ("Level 1");
	}
	
	// Update is called once 		per frame
	void Update () {
		
	}
}
