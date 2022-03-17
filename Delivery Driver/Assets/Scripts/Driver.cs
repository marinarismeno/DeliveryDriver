using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount, 0);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Booooost");
        }
        //else if (other.tag == "Slow")
        //{
        //    moveSpeed = slowSpeed;
       // }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;
    }
} 
