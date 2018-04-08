using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace NameSpacesTest
{

    //This character controller uses a Rigidbody to move the character. 
    public class CharacterController1 : MonoBehaviour
    {
        public float moveSpeed;
        public Rigidbody rb;
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            Move();
        }
        public void Move()
        {
            float horizontalMove = Input.GetAxis("Horizontal");
            float verticalMove = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(horizontalMove, 0.0f, verticalMove);
            rb.AddForce(movement);
        }
    }
}
