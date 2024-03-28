using UnityEngine.Playables;
using UnityEngine;


public class removerThing : MonoBehaviour
{
//   public GameObject removeLamp;
  //  public GameObject addLight;
    public GameObject removeObjectsTwo;
    public GameObject removeObjectsThree;
    public GameObject addObjects;
 //  public GameObject addObjectsTwo;
    public GameObject addSounds;

 //   public float zoom;
  //  private float zoomMultiplier = 4f;
  //  private float minZoom;
  //  private float maxZoom;
  //  private float velocity;
  //  private float smoothTime;

  //  [SerializeField] private Camera cam;

    private void Start()
    {
  //      zoom = cam.orthographicSize;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
 //           removeLamp.SetActive(false);
  //    addLight.SetActive(true);
        removeObjectsTwo.SetActive(false);
        removeObjectsThree.SetActive(false);
        addObjects.SetActive(true);
    //   addObjectsTwo.SetActive(true);
        addSounds.SetActive(true);
 //       zoom = 10;
 //       cam.orthographicSize = zoom;
        Debug.Log("pipo");
    }
}