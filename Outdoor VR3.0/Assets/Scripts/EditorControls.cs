using UnityEngine;
using System.Collections;

public class EditorControls : MonoBehaviour
{
    public EditorCameraControls cameraControls;
    public float speed = 2f;
    public bool oculusMode = true;

    private CharacterController cc;

    public void Awake()
    {
        cc = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.JoystickButton7))
        {
            oculusMode = true;
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton6))
        {
            oculusMode = false;
        }

        if (oculusMode)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            if (v != 0)
            {
                cc.SimpleMove(transform.forward * speed * v);
            }
            if (h != 0)
            {
                cc.SimpleMove(transform.right * speed * h);
            }

#if UNITY_EDITOR

            float x = Input.GetAxis("Joystick Look X");
            transform.Rotate(transform.up, x);

            float y = Input.GetAxis("Joystick Look Y");
            cameraControls.RotateY(y);

#endif
        }
    }

}
