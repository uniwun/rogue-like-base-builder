using System;
using UnityEngine;

public class teleport : MonoBehaviour
{
    Boolean ePressed = false;
    GameObject baseT;
    GameObject arenaT;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        baseT = GameObject.FindWithTag("baseTp");
        arenaT = GameObject.FindWithTag("arenaTp");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ePressed = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        
        Debug.Log(other.gameObject);
        if (other.gameObject == baseT && ePressed)
        {
            gameObject.transform.position = arenaT.transform.position;
            ePressed = false;    
        }else if (other.gameObject == arenaT && ePressed)
        {
            gameObject.transform.position = baseT.transform.position;
            ePressed = false;
        }
    }
}