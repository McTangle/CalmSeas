using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatSelector : MonoBehaviour {

    public List<GameObject> boatList;
    public int index = 0;



	// Use this for initialization
	void Start () {

		GameObject[] boats = Resources.LoadAll<GameObject>("CompleteBoats");

        foreach(GameObject g in boats)
        {

            GameObject boat = Instantiate(g) as GameObject;
            boat.transform.SetParent(GameObject.Find("BoatList").transform);

            boatList.Add(boat);
            boat.SetActive(false);
            boatList[index].SetActive(true);

        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
