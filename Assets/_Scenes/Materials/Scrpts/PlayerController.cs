using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour{

  // show up in inspecter as editable property
  public float speed;
  public Text countText;
  public Text winText;

  private Rigidbody rb;
  private int count;
  void Start (){
    rb = GetComponent<Rigidbody>();
    count = 0;
    SetCountText();
    winText.text = "";
  }

  void FixedUpdate()
  {
    float moveHoizonatal=Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3 (moveHoizonatal, 0.0f, moveVertical);

    rb.AddForce (movement * speed);
  }

/*
  When another trigger Collider is touched, the game opbject that the trigger
  Collider is attactched to through the reference other game object. The game object
  and all of its components will be removed from the scene.
*/
  void OnTriggerEnter(Collider other)
    {
      //Destroy(other.gameObject);  //this is the example code
      /* .CompareTag identify a gameObject by a tag value
          Must declare tags in the tags and layers panels before usiong them.
          Compare the tag of any gameObject value with a string value.
      */
       if (other.gameObject.CompareTag("Pick Up"))
       {
         other.gameObject.SetActive (false); //equilvent to clicking active checkbox next to name field in inspoector.
         count = count + 1;
         SetCountText();
       } //end iff

    }// end void

    void SetCountText(){
      countText.text = "Count: " + count.ToString();
      if(count >= 7)
      {
        winText.text = "You Win";
      }
    }

}// public class
