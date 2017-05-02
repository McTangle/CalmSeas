using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreationController : MonoBehaviour {

    public void ButtonHandlerPlay()
    {

        // loads the Game scene
        SceneManager.LoadSceneAsync(2);

        

    }
}
