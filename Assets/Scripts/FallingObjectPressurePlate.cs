using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectPressurePlate : MonoBehaviour
{
    // Start is called before the first frame update
    //public float stopwatch;
    public GameObject fallingObjectScript;

    void Start()
    {
            GameObject fallingObejct = GameObject.Find("Object");
            FallingObject fallingObjectScript = fallingObejct.GetComponent<FallingObject>();
    }

        // Update is called once per frame
        void Update()
        {
            //stopwatch -= Time.deltaTime;

            //if (stopwatch <= 5 || stopwatch >= 0)
            //{

            //}
        }


        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player" && fallingObjectScript.GetComponent<StopTime>().stopTime != true)
            {
            //stopwatch = 5;
            FallingObject.fallingObjectIsTrue = true;
            }
        }

    
}
