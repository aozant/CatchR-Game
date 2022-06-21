using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
   // NavMeshAgent enemy;
    public float speed;
    public Transform target;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       target = GameObject.FindGameObjectWithTag("Player"). GetComponent<Transform>();
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
