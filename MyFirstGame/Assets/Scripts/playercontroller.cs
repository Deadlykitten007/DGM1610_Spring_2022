using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{

    public float speed = 20.0f;
    public float speed = 50.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");

        // Makes the player move forward
      transform.translate(Vetcor3.forward * Time.deltaTime * speed * hInput);
      transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * fInput);  
    }
}
