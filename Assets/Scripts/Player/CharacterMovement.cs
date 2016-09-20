using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{
    public float MoveSpeed = 0.5f;
    public float RotateSpeed = 1f;
    CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * RotateSpeed);
        cc.Move(transform.forward * Input.GetAxis("Vertical") * MoveSpeed);
        cc.SimpleMove(Physics.gravity);
    }
}