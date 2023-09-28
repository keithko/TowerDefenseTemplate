using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathWay : MonoBehaviour
{
    [SerializeField] Transform[] Stips;

    [SerializeField] private float Movespeed;

    private int stipsIndex;
    void Start()
    {
        transform.position = Stips[stipsIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(stipsIndex <= Stips.Length -1 )
        {
            transform.position = Vector2.MoveTowards(transform.position, Stips[stipsIndex].transform.position, Movespeed * Time.deltaTime);

            if(Vector2.Distance(transform.position, Stips[stipsIndex].transform.position) <= .1f)
            {
                stipsIndex += 1;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PathEnd"))
        {
            Destroy(gameObject);
        }
    }
}
