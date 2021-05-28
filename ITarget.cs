using UnityEngine;

interface ITarget
{
    Quaternion getCameraRotation();
    Vector3 getCameraPosition();
}