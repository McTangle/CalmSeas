using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public void ButtonHandlerPlay() {

        // loads the boat select scene 

		SceneManager.LoadSceneAsync (1);
	}

}
