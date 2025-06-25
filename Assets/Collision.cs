using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
  // This function is called when the object collides with another object
  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("collision");
  }

  // This function is called when the object enters a trigger collider
  void OnTriggerEnter2D(Collider2D other) {
    Debug.Log("triggered");
  }
}
