using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterCreation : MonoBehaviour {

    // stores various boat models
    private static List<GameObject> models;

    private static int selectionIndex = 0;

	// Use this for initialization
	void Start () {

        models = new List<GameObject>();

        // iterates through boats
        foreach(Transform t in transform)
        {
            // adds boat to the list
            models.Add(t.gameObject);

            // sets all boats to invisible
            t.gameObject.SetActive(false);
        }

        // make active the current selection
        models[selectionIndex].SetActive(true);

	}

    // enables player boat choice
    public void Select(int index)
    {
        // do nothing if they match, selection already correct
        if (index == selectionIndex)
            return;

        // do nothing if index goes out of bounds do nothing
        if(index < 0 || index >= models.Count)
        {
            return;
        }

        // unload previous ship
        models[selectionIndex].SetActive(false);
        selectionIndex = index;
        // load new ship
        models[selectionIndex].SetActive(true);

    }



	public void ButtonHandlerPlay()
    {
        SceneManager.LoadSceneAsync(2);
    }


    // Update is called once per frame
    void Update () {
		
        
        /*
        // move selection rightward on D press
        if(Input.GetKeyDown(KeyCode.D) && selectionIndex < 4)
        {
            Select(selectionIndex + 1);
            
        }

        // move selection leftward on A press
        if (Input.GetKeyDown(KeyCode.A) && selectionIndex >= 0)
        {
            Select(selectionIndex - 1);

        }
        */

    }
}
