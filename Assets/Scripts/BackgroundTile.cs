using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BackgroundTile : MonoBehaviour
{

    public GameObject[] foodElements;

    // Start is called before the first frame update
    void Start()
    {
        Initialise();
    }

    // Update is called once per frame
    void Initialise()
    {

        int foodElementToUse = UnityEngine.Random.Range(0, foodElements.Length);
        GameObject foodElement = Instantiate(foodElements[foodElementToUse], transform.position, quaternion.identity);
        foodElement.transform.parent = this.transform;
        foodElement.name = this.gameObject.name;
    }
}
