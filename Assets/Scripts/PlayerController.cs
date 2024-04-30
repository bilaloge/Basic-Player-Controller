using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        movePlayer();
        oyuncukýsýtlama();
    }
    void movePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(-Vector3.forward * horizontalInput*Time.deltaTime*5);
        transform.Translate(Vector3.right * verticalInput * Time.deltaTime*5);
    }
    void oyuncukýsýtlama()
    {
        if (transform.position.x < -2)
        {
            transform.position = new Vector3(-2, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 7)
        {
            transform.position = new Vector3(7, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -4)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -4);
        }
        if (transform.position.z > 4)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 4);
        }
    }
}
