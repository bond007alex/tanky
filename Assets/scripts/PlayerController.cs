using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 25.0f;
    float fireTime = 0;
    public float fireDelay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        fireTime += Time.deltaTime;
        while (fireTime >= fireDelay)
        {
            fireTime = 0;
            Shoot();    
        }
    }
    void Shoot()
    {
        Instantiate(projectilePrefab, (transform.position + new Vector3(0, 3, 7)), projectilePrefab.transform.rotation);
    }
}
