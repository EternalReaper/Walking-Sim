using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 0.5f;
    public float RotateSpeed = 1f;

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;

    CharacterController cc;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);

        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * RotateSpeed);
        cc.Move(transform.forward * Input.GetAxis("Vertical") * MoveSpeed);
        cc.SimpleMove(Physics.gravity);
    }
}
