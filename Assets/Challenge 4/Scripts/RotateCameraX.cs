using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraX : MonoBehaviour
{
    private float speed = 200;
    public GameObject player;
    public ParticleSystem force;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * speed * Time.deltaTime);

        transform.position = player.transform.position; // Move focal point with player

        float auxSpeed = (Input.GetKey(KeyCode.Space)) ? speed * 5 : speed;

        if (Input.GetKey(KeyCode.Space))
            force.Play();
        else
            force.Stop();
    }
}
