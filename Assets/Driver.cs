using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

  [SerializeField] float steerSpeed = 200f;
  [SerializeField] float moveSpeed = 10f;

  [SerializeField] float boostSpeed = 20f;
  [SerializeField] float slowSpeed = 5f;

  // Update is called once per frame
  void Update()
  {
    float steerAmount = steerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
    float moveAmount = moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
    transform.Rotate(0, 0, -steerAmount);
    transform.Translate(0, moveAmount, 0);


    if (Input.GetKey("escape"))
    {
      Application.Quit();
    }
  }

  void OnCollisionEnter2D(Collision2D other)
  {
    moveSpeed = slowSpeed;
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Boost")
    {
      moveSpeed = boostSpeed;
    }
  }
}
