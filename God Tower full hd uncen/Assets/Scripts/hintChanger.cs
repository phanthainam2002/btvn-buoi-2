using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class hintChanger : MonoBehaviour {
//
//	public Image hint1;
//	public Image hint2;
	public List<Image> hintsList;
	public Button hintButton;

	int hintCurrentIndex = 0;
//
//	// Use this for initialization

	public void OnHintButtonClick(){
		Debug.Log ("clicked");

		hintCurrentIndex++;
		if (hintCurrentIndex == hintsList.Count-1) {
			hintButton.transform.localScale = new Vector3 (-1, 1, 1);
		} else {
			hintButton.transform.localScale = new Vector3 (1, 1, 1);
		}
		if (hintCurrentIndex == hintsList.Count) {
			hintCurrentIndex = 0;
		}

		for (int i = 0; i < hintsList.Count; i++) {
			if (i == hintCurrentIndex) {
				hintsList [i].gameObject.SetActive (true);

			} else {
				hintsList [i].gameObject.SetActive (false);
			}
		}
	}
//	int hintCurrentIndex = 1;
//
//	public void OnHintButtonClick(){
//		if (hintCurrentIndex == 1) {
//			hint1.gameObject.SetActive (false);
//			hint2.gameObject.SetActive (true);
//			hintCurrentIndex = 2;
//
//		} else if (hintCurrentIndex == 2) {
//			hint1.gameObject.SetActive (true);
//			hint2.gameObject.SetActive (false);
//			hintCurrentIndex = 1;
//
//		}
//	}
//
	
	// Update is called once per frame
	void Update () {
		
	}
}
