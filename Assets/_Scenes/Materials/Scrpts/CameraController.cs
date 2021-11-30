using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

 /*Offset is private because value can be set in the script. Offset value
  takes current poition of the offset value and subtract the transform position of
  the player to find the distance between the two.
 */

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

/*
  Every frame we set the transform position to the players transform position
  + the offset. This means as the player moves by the keyboard inputs,
  that each frame before displaying what the camera can see, the camera is moved
  into new position aligned with the player object.
*/

    void LateUpdate() //LateUpdate runs every frame just like update and is guarentteed to run after all items have been processed in update.
    {
        transform.position = player.transform.position + offset;
    }
}
