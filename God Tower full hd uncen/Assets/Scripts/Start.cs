using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour {

	public void beginButton(){
		SceneManager.LoadScene ("level 1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
