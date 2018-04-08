using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NameSpacesTest;

public class Move : MonoBehaviour {
    CharacterController1 cc;
    CharacterController2 characterController2;

    //CharacterController2 characterController2;
    private void Awake()
    {
        cc = GetComponent<CharacterController1>();
        characterController2 = GetComponent<CharacterController2>();
    }
    private void Update()
    {
        characterController2.Move();
    }
}
