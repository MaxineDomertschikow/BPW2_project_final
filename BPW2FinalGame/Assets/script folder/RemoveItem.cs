using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveItem : MonoBehaviour
{
    public GameObject removeObject;
    private void Start()
    {
        
    }

    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D collider)
    {
        removeObject.SetActive(false);
    }
}
