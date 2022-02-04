using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.5f;

    public GameObject Camera1;

    private float gravity = 0f;

    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        Vector3 velocity = direction * speed;
        velocity = Camera.main.transform.TransformDirection(velocity);
        controller.Move(velocity * Time.deltaTime);
    }
}
