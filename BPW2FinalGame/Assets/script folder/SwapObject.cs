using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObjectOne : MonoBehaviour
{
    public GameObject removeObject;
    public GameObject addObject;


    private void Start()
    {
        //      zoom = cam.orthographicSize;
    }

    private void   OnTriggerEnter2D(Collider2D collider)
    {        addObject.SetActive(true);
        removeObject.SetActive(false);

        Debug.Log("pipo");

    }
}
