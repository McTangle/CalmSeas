using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect2 : MonoBehaviour
{

    private GameObject[] characterList;

    private void Start()
    {
        // create array of size equal to number of boats
        characterList = new GameObject[transform.childCount];

        // fills array with boats
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;

            // make boats invisible
            foreach (GameObject go in characterList)
            {
                go.SetActive(false);



            }
            if (characterList[0])
                characterList[0].SetActive(true);


        }
    }

}



