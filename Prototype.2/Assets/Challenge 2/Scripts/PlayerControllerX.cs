using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {

    }
    void OnFire()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}

