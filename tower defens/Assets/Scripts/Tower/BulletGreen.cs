using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGreen : MonoBehaviour
{
    public float Bspeed = 10f;

    private Transform Target;

    private void Update()
    {
        if (Target == null)
        {
            Destroy(gameObject);
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, Target.position, Bspeed * Time.deltaTime) + new Vector3(0, 0, -0.3f);
    }

    public void SetTarget(Transform newTarget)
    {
        Target = newTarget;
    }
}
