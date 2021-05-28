using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, ITarget
{
    [SerializeField]
    private Vector3 cameraPosition;
    [SerializeField]
    private Vector3 cameraRotation;

    Vector3 ITarget.getCameraPosition()
    {
        return this.cameraPosition;
    }

    Quaternion ITarget.getCameraRotation()
    {
        return Quaternion.Euler(this.cameraRotation.x, this.cameraRotation.y, this.cameraRotation.z);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
