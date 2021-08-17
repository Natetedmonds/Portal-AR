using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PortalScript : MonoBehaviour
{

    private GameObject spawnedObject;
    [SerializeField] private GameObject targetFrame;
    [SerializeField] private GameObject spawnedRoom;

    void Awake()
    {
        Renderer[] rs = spawnedRoom.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
          r.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began)
        {
          spawnedObject = Instantiate(spawnedRoom, spawnedRoom.transform.position, spawnedRoom.transform.rotation);

          Renderer[] rs = spawnedObject.GetComponentsInChildren<Renderer>();
          foreach (Renderer r in rs)
            r.enabled = true;

          Destroy(targetFrame);
          Destroy(spawnedRoom);

        }
    }
}
