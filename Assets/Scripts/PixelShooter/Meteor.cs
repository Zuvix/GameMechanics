using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=0.02f;
    void Start()
    {
        Application.targetFrameRate = 80;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -speed)*Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
