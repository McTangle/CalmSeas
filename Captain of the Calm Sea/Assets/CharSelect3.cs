using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect3 : MonoBehaviour {

    private GameObject[] characterList;





	// Use this for initialization
	void Start () {

        // sets array size
        characterList = new GameObject[transform.childCount];

        // fills array with boats
        for (int i = 0; i < transform.childCount; i++)
                characterList[i] = transform.GetChild(i).gameObject;
        
        // make boats invisible
        foreach (GameObject go in characterList)
                go.SetActive(false);

        if (characterList[0])
            characterList[0].SetActive(true);
	}
	

	}

