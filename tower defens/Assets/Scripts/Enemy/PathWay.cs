using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathWay : MonoBehaviour
{
    [SerializeField] private float Movespeed;

    [SerializeField] private Path path;

    private int stipsIndex;
    void Start()
    {
        path = FindObjectOfType<Path>();
        transform.position = path.Stips[stipsIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(stipsIndex <= path.Stips.Length -1 )
        {
            transform.position = Vector2.MoveTowards(transform.position, path.Stips[stipsIndex].transform.position, Movespeed * Time.deltaTime);

            if(Vector2.Distance(transform.position, path.Stips[stipsIndex].transform.position) <= .1f)
            {
                stipsIndex += 1;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PathEnd"))
        {
            FindObjectOfType<GameOver>().TakeDamage(1);
            Destroy(gameObject);
        }
    }
}
