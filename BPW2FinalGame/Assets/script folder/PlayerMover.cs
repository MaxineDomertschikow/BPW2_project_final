using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterMovementController controllerSelf;
    public Animator animatorSelf;

    float horizontalMovement = 0f;

    public float runSpeeder = 40f;

    void Start()
    {
        
    }

    void Update()
    {
        animatorSelf.SetFloat("Speed", Mathf.Abs(horizontalMovement));

        horizontalMovement = Input.GetAxisRaw("Horizontal") * runSpeeder;

    }

}
