using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -10 && horizontalInput < 0)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }

        else if (transform.position.x >= 10 && horizontalInput > 0)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        else
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }

    }

    void OnMove(InputValue moveValue)
    {
        horizontalInput = moveValue.Get<Vector2>().x;
    }

    void OnFire()
    {
        Instantiate(projectilePrefab, new Vector3(transform.position.x, 0.5f, transform.position.z), projectilePrefab.transform.rotation);
    }
}