using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  [SerializeField] Color32 initialColor = new Color32(255, 255, 255, 255);
  [SerializeField] Color32 packageColor = new Color32(0, 255, 0, 255);

  [SerializeField] float destroyDelay = 0.5f;

  SpriteRenderer spriteRenderer;
  bool hasPackage;

  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }
  private void OnTriggerEnter2D(Collider2D other)
  {

    if (other.tag == "Package" && !hasPackage)
    {
      Debug.Log("Package pick up");
      spriteRenderer.color = packageColor;
      hasPackage = true;
      Destroy(other.gameObject, destroyDelay);
    }

    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Package delivery");
      spriteRenderer.color = initialColor;
      hasPackage = false;
    }
  }
}
