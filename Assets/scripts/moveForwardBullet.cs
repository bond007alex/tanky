using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForwardBullet : MonoBehaviour
{
    public float speed = 40.0f;
    Rigidbody rb;
    private GameObject player;
    // Start is called before the first frame update
    GameObject FindInActiveObjectByName(string name)
    {
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].name == name)
                {
                    return objs[i].gameObject;
                }
            }
        }
        return null;
    }
    void Start()
    {
        player = FindInActiveObjectByName("player");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    void FixedUpdate()
    {
        
        rb.MovePosition(transform.position + Vector3.forward*Time.deltaTime*speed);
    }
}
