using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyErrant : MonoBehaviour
{
    private float topBound = 270;
    private float botBound = -25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < botBound)
        {
            Destroy(gameObject);
        }
    }
}
