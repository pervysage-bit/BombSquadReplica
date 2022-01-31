using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * horizontalInput * speed);

        float verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.forward * verticalInput * speed);

    }
}
