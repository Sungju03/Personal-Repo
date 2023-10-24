using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I copied the following code from youtube.com/watch?v=z7eojB_1wKg

public class CameraOrbit : MonoBehaviour
{
   public Transform target;

   public float horizmove = 20f;
   
   public void MoveHorizontal (bool right)
   {
        float dir = 1;
        if (!right)
            dir *= -1;
        transform.RotateAround (target.position, Vector3.up, horizmove * dir);
   }
}
