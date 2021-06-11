using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    public GameObject present; 
    public GameObject past; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchTimelines()
    {   
        if(present.active)
        {
            present.SetActive(false);
            past.SetActive(true);
        } else 
        {
            past.SetActive(false);
            present.SetActive(true);
        }
    }
}
