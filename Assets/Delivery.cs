using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour

{
  bool hasPackage ;
  // This function is called when the object collides with another object
  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("collision");
  }

  // This function is called when the object enters a trigger collider
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package" && !hasPackage)
    {
      Debug.Log("Package picked up");
      Destroy(other.gameObject, 0.5f);
      hasPackage = true;
    }
    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Package delivered");
      hasPackage = false;
    }
  }
  
}
