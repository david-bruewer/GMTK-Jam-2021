using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public Interactable box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!box.goal)
        {
            if (Vector2.Distance(transform.position, box.transform.position) < 0.5f)
            {
                box.goal = gameObject;
                box.Disable();
            }
        }
    }
}
