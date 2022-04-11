using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector2 mouseInput;
    public float mouseSensitivity = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       // Hide and lock cursor
       Cursor.visible = false;
       Cursor. lockstate = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        Input = new Vector3(Input.GetAxis("Horizonal"), 0,Input.GetAxis("Vertical"));
        Vector3 moveH = transform.right * moveInput.x;
        Vecotr3 moveV = transform.forward * moveInput.z;
        rb.velocity = (moveH + moveV) * moveSpeed;

        mouseInput = new Vector2(moveInput.GetAxis("Mouse X"), moveInput.GetAxis("Mouse Y")) * mouseSensitivity;
        tranform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, tranform.rotation.eulerAngles.y) - mouseInput.z, tranform.rotation.eulerAngles.z);
    }
}
