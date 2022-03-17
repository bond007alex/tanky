using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyErrant : MonoBehaviour
{
    private float topBound = 270;
    private float botBound = -25;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
            gameManager.AddLives(-1);
        }
        else if (transform.position.z < botBound)
        {
            Destroy(gameObject);
        }
    }
}
