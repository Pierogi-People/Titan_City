using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public Camera Starting_Camera;
    public Camera Power_Camera;
    public Camera Gym_Camera;

    public GameObject Player;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Starting_Camera.enabled)
            {
                Power_Camera.enabled = true;
                Starting_Camera.enabled = false;
                
                Player.transform.position = new Vector3(-7.0f, -32.0f, -1.5f);
            }
            else if (Power_Camera.enabled)
            {
                Gym_Camera.enabled = true;
                Power_Camera.enabled = false;
                
                Player.transform.position = new Vector3(-7.0f, -16.0f, -1.5f);
            }
    

        }
    }
}
