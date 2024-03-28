using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTeleporter : MonoBehaviour
{
    public GameObject teleporterSubject;
    public float teleporterGoalX;
    public float teleporterGoalY;
    public float teleporterGoalZ;
    void Start()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        teleporterSubject.transform.position = new Vector3(teleporterGoalX, teleporterGoalY, teleporterGoalZ);
    }
}
