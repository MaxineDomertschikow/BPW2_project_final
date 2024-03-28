using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    public GameObject addObject;
    private void Start()
    {
        
    }

    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D collider)
    {
        addObject.SetActive(true);
    }
}
