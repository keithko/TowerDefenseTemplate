using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Node : MonoBehaviour
{
    private Color hoverColer;
    public Vector3 PositionOffSet;

    public GameObject tower;

    private Renderer rend;
    public Color StartColor;

    BuiltManager builtManager;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        StartColor = rend.material.color;

        builtManager = BuiltManager.instance;
    }

    private void OnMouseDown()
    {
        if (tower != null)
        {
            Debug.Log("can geen toren maken hier!");
            return;
        }

        GameObject towerToBuild = builtManager.buildtower();
        tower = Instantiate(towerToBuild, transform.position + PositionOffSet, transform.rotation);
        
    }   
    private void OnMouseEnter()
    {
        if (builtManager.buildtower() == null)
            return;
        rend.material.color = hoverColer;
    }

    private void OnMouseExit()
    {
        rend.material.color = StartColor;
    }
    
}
