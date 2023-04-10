using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] private string Destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            MovetoNextScene();
        }
    }

    private void MovetoNextScene()
    {
        if (Destination.Equals(""))
        {
            Debug.Log("no destination bro");
        }
        else
        {
            SceneManager.LoadScene(Destination);
        }
    }
}
