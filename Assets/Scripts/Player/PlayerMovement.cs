using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public Transform head;

    public float forwardSpeed = 0.5f;
    public float strafeSpeed = 1f;
    public float sprintSpeed = 1f;

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
        float f = forwardSpeed * Input.GetAxis("Vertical");
        float s = strafeSpeed * Input.GetAxis("Horizontal");
        float r = sprintSpeed * Input.GetAxis("Sprint");
        cc.SimpleMove(transform.forward * f);
        cc.SimpleMove(transform.right * s);
        cc.SimpleMove(transform.forward * r);

        //transform.Rotate(v, h, 0);
        transform.Rotate(0, h, 0);
        head.Rotate(v, 0, 0);
    }
}
