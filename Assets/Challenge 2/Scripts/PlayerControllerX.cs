using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && fireRate <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            fireRate = 1;
        }
        fireRate -= Time.deltaTime;
    }
}
