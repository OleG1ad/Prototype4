using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;

        // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 center = new Vector3(0, 0, 0)

if(Vector3.Distance(gameObject.transform.position), center) > centerDistanceLimit))
{
       Vector3 centerDirection = (center - transform.position).normalized;
enemyRb.AddForce(centerDirection* speed);
} 
else 
{
      Vector3 lookDirection = (player.transform.position - transform.position).normalized;
enemyRb.AddForce(lookDirection* speed);
}*/

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;


        enemyRb.AddForce(lookDirection * speed);

        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}