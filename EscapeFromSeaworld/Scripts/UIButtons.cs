using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour {

	public static UIButtons instance;
	public static UIButtons Instance {get {return instance;} }

	public Player player;

	bool haveAlreadyPlayed; 


	public void StartGame () {
		Time.timeScale = 1.0f;
//		Canvas.gameObject.SetActive (false);
		SceneManager.LoadScene ("Scenes/Level1_WaterTest");
	}

	public void GoToHomeMenu () {
		SceneManager.LoadScene ("Scenes/Menus/HomeMenu");
	}

	public void PauseGoToHomeMenu () {
		GameManager.Instance.GameOver ();
		SceneManager.LoadScene ("Scenes/Menus/HomeMenu");
	}

	public void GoToBackToLevel () {
		SceneManager.LoadScene (0);
	}

	public void GoToLevel2() {
	}

	public void GoToLevel3() {
	}

	public void Quit() {
		Application.Quit ();
	}

	//public void ReplayLevel() {
		
		//RestartLevelContainer.Instance.LoadRestartedLevel ();
	//}
}
