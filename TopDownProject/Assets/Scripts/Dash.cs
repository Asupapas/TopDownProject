using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float Cooldown;
    float timer = 0;
    private float DashCounter;
    public float DashLength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Jump"))
        {
            if (timer >= Cooldown)
            {
                if (Time.timeScale > 0)
                {
                    timer = 0;
                    GetComponent<Movement>().speed = 40;
                    DashLength = 3;
                }
            }
        }
        if (DashLength > 0)
        {
            DashLength -= Time.deltaTime;
        }
        if (DashLength <= 0)
        {
            GetComponent<Movement>().speed = 15;
        }
    }
}
