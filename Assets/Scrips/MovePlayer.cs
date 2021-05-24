using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
    public float playerSpeed, playerJumpForce;

    private Vector3 direction;
    private VariableJoystick joystick;
    void Start () {
        joystick = GameObject.Find ("Variable Joystick").GetComponent<VariableJoystick> ();
    }

    void Update () {
        MoveMobile ();
        Rotation ();
    }

    void MoveMobile () {
        direction = (Vector3.forward * joystick.Vertical) + (Vector3.right * joystick.Horizontal);
    }
    void Rotation () {
        if (direction != Vector3.zero) {
            transform.rotation = Quaternion.LookRotation (direction);
        }
        transform.Translate (direction * (playerSpeed * Time.deltaTime), Space.World);
    }
}