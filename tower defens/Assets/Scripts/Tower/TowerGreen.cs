using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerGreen : MonoBehaviour
{
    [SerializeField] private Transform target;

    private float range = 3.16f;

    public Transform PartToRotate;

    public float rotateNow=0;

    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private float fireTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("UpdateTarget", 0f, 0.5f);
        StartCoroutine(ShootAtTarget());
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
        float ShortDistanceEnemy = Mathf.Infinity;
        GameObject NearestEnemy = null; 
        
        foreach (GameObject enemy in enemies)
        {
            float DistanceEnemy = Vector2.Distance(transform.position, enemy.transform.position);
            if(DistanceEnemy < ShortDistanceEnemy)
            {
                ShortDistanceEnemy = DistanceEnemy;
                NearestEnemy= enemy;
            }
        }
        
        if (NearestEnemy != null && ShortDistanceEnemy <= range)
        {
            target = NearestEnemy.transform;
        } else
        {
            target = null;
        }
    }

    IEnumerator ShootAtTarget()
    {
        while(true)
        {
            Debug.Log("test");
            if (target != null)
            {
                GameObject go = Instantiate(bulletPrefab);
                go.transform.position = transform.position;
                BulletGreen bullet = go.GetComponent<BulletGreen>();
                bullet.SetTarget(target);
            }
            yield return new WaitForSeconds(0.5f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector2 dir = target.position - transform.position;
        Quaternion LookRotation = Quaternion.FromToRotation(Vector2.up, dir);
        PartToRotate.rotation = LookRotation;
       
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
