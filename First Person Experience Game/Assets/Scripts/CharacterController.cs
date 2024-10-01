using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float movementSpeed;
   public float gravity;
   public float gravityLimit;
   public float gravityMultiplier;
   public float jumpForce;
   public float cameraSpeed;
   Vector2 inputs;

   public CharacterController controller;
   public GameObject cam;
   public GameObject playerHead;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();
        Rotation();
    }

    void Movement()
    {
        inputs = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 movement = new Vector3(inputs.x, gravity, inputs.y);
        movement = Quaternion.Euler(0, cam.transform.eulerAngles.y,0) * movement; 
        controller.Move(movement * movementSpeed * Time.deltaTime);

    }

    void Jump()
    {
        if (gravity < gravityLimit)
        {
            gravity = gravityLimit;
        }
        else
        {
            gravity -= Time.deltaTime * gravityMultiplier;
        }
    if (controller.isGrounded && Input.GetButtonDown("Jump"))
    {
        gravity = Mathf.Sqrt(jumpForce);
    }

    }

    void Rotation()
    {
        playerHead.transform.rotation = Quaternion.Slerp(playerHead.transform.rotation, cam.transform.rotation, cameraSpeed * Time.deltaTime);
    }





}
