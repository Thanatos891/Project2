using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Uses the characters transform to move the character. 
namespace NameSpacesTest
{
    public class CharacterController2 : MonoBehaviour
    {
        public float moveSpeed;
        public float rotateSpeed;
        private Transform tf;

        private void Awake()
        {
            tf = GetComponent<Transform>();
        }

        private void Update()
        {
            Move();
        }
        public void Move()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                tf.position = Vector3.up * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                tf.position = Vector3.down * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                tf.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                tf.Rotate(-Vector3.forward * rotateSpeed * Time.deltaTime);
            }
        }
    }
}
