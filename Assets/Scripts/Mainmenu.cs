using UnityEngine;
using System.Collections;

public class Mainmenu : MonoBehaviour {

	public string startLevel;

	public string levelSelect;



	public void Play () {
		Application.LoadLevel (startLevel);
	}
	

	public void LevelSelect () {
		Application.LoadLevel (levelSelect);
	}

	public void QuitGame(){
		Application.Quit();
	}
}
