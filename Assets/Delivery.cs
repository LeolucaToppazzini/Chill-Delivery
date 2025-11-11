using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Delivery : MonoBehaviour

{
  [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
  [SerializeField] Color32 noPackageColor = new Color32(1, 1, 0, 1);
  bool hasPackage;
  SpriteRenderer spriteRenderer;

  void Start() {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }

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
      spriteRenderer.color = hasPackageColor;
      
    }
    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Package delivered");
      hasPackage = false;
      spriteRenderer.color = noPackageColor;
    }
  }
  
}
