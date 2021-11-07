using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

  [SerializeField] float steerSpeed = 200f;
  [SerializeField] float moveSpeed = 10f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float steerAmount = steerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
    float moveAmount = moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
    transform.Rotate(0, 0, -steerAmount);
    transform.Translate(0, moveAmount, 0);
  }
}
