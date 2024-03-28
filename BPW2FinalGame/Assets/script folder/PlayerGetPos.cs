using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetPos : MonoBehaviour
{
    public Transform PlayerObject;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        Vector3 MoverPositie = PlayerObject.position;
    }
}
