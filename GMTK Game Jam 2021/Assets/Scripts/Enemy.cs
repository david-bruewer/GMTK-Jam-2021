using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Vector2 spawnpoint; 

    // Start is called before the first frame update
    void Start()
    {
        spawnpoint = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
