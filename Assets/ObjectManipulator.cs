using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManipulator : MonoBehaviour
{
    public GameObject detective;
    public float value;
    public Vector3 rotationChange;

    public void MoveRight()
    { 
        value += 0.1f;
        detective.transform.position = new Vector3(value,0,0);

    }

    public void MoveLeft()
    {
        value -= 0.1f;
        detective.transform.position = new Vector3(value, 0, 0);
    }

    public void ResetObject()
    {
        detective.transform.position = new Vector3(0, 0, 0);
    }
}
