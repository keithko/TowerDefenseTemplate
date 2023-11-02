using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuiltManager : MonoBehaviour
{
    public static BuiltManager instance;
    private void Awake()
    {if (instance)
        {
            Debug.Log("te veel beeld manager. probeer opnieuw");
            return;
        }
        instance = this;
    }

    public GameObject standardTowerPrefab;


    private GameObject towerBuild;

    public GameObject buildtower()
    {
        return towerBuild;
    }

    public void SetTowerToBuild(GameObject Tower)
    {
        towerBuild = Tower;
    }
}
