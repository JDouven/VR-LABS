using UnityEngine;
using System.Collections;

public class HMDPointer : MonoBehaviour
{

    public Camera mainCamera;

    // Use this for initialization
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.TransformDirection(mainCamera.transform.forward), out hit, 10f))
        {
            Debug.Log("Hit: " + hit.transform.name);
        }
    }
}
