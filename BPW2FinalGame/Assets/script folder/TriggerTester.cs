using UnityEngine.Playables;
using UnityEngine;
using Unity.VisualScripting;


public class removerThing : MonoBehaviour
{

    public GameObject removeObjectsTwo;
    public GameObject removeObjectsThree;
    public GameObject addObjects;
    public GameObject addUserInterface;
    public GameObject removeUserInterface;
    public GameObject removeTimeSkipper;

    public GameObject addSounds;

    private int Checker = 0;




    private void OnTriggerStay2D(Collider2D collider)
    {
        Checker = 1;
        addUserInterface.SetActive(true);
    }

    private void Update()
    {
         if (Checker == 1 && Input.GetButtonDown("Jump"))
    {
removeObjectsTwo.SetActive(false);
        removeObjectsThree.SetActive(false);
        addObjects.SetActive(true);
            removeUserInterface.SetActive(false);
            removeTimeSkipper.SetActive(false);

        addSounds.SetActive(true);


        Debug.Log("pipo");
    }


    }
   


}  