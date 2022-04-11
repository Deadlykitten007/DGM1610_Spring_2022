using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    public float retreatDistance;

    private Tranform target;

    private float shotDelay;
    public float starDelay;

    public GameObject projecttile;

    // Start is called before the first frame update
    void Start()
    {
       target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
       shotDelay = starDelay; 
    }

    // Update is called once per frame
    void Update()
    {
       if(Vector2.Distance(tranform.position, target.position) > stopDistance)
       {
           transform.position = Vector2.MoveTowards(transform.position, targets.position, speed * Time.deltaTime);
       } 
    }  else if(Vector2.Distance(transform.position, target.position) < stopDistance && Vector2.Distance(transform.position, target.position) < retreatDistance)
    {
        transform.position = this.transform.position;
    }
}   else if(Vector2)
