/*The goal is for the cube to spin. We want to change the values of the transform
 after every frame.*/

using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      transform.Rotate(new Vector3(15,30,45)* Time.deltaTime);
    }//end void
}//end public class
