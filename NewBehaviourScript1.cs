using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turntodragon : MonoBehaviour
{
    public GameObject newFish;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "TestCube")

        {
            //  dragon. summondragon;

            //   dragon. clone;
            // clone = Instantiate(gameObject, transform.position, transform.rotation);
            Instantiate(newFish, DragonStart.position, DragonStart.rotation);
            print("Dragon Made");
            //clone.velocity = transform.TransformDirection(Vector3.forward * 10);
            print("Fish destroyed");
            Destroy(gameObject);

        }


    }
}
