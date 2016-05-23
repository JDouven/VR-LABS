using UnityEngine;
using System.Collections;

public class EditorCameraControls : MonoBehaviour {
	
	public void RotateY(float input)
    {
        this.transform.Rotate(new Vector3(1, 0, 0), input);
    }
}
