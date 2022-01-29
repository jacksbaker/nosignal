using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HypnosisActivation : MonoBehaviour
{

    public GameObject coll;
    public float timer;

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        GameObject coll = GameObject.Find("coll");
        timer = 0f;

        GameObject panel = GameObject.Find("Panel");

        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        timer = timer - Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.H))
        {
            
            coll.SetActive(true);
            timer = 5;

        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(timer > 0)
        {
            if (collision.tag == "Hypnosis")
            {
                Debug.Log("Hypnosis");
                panel.SetActive(true);
                coll.SetActive(false);
            }
        }
        
    }

}

