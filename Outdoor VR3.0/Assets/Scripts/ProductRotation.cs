using UnityEngine;
using System.Collections;

public class ProductRotation : MonoBehaviour
{
    public float speed = 50f;

    private EditorControls controls;

    public void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!controls.oculusMode)
        {
            float axisL = Input.GetAxis("Joystick Trigger Left");
            float axisR = Input.GetAxis("Joystick Trigger Right");
            if (axisL > 0)
            {
                transform.Rotate(Vector3.up, Time.deltaTime * speed * axisL);
            }
            else if (axisR > 0)
            {
                transform.Rotate(Vector3.up, Time.deltaTime * speed * -axisR);
            }
        }
    }
}
