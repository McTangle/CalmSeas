using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMenuRotate : MonoBehaviour
{


    int deg = 40;


    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(transform.position, Vector3.down, deg * Time.deltaTime);

    }
}
