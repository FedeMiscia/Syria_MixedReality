using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinaretoShow : MonoBehaviour
{

    public GameObject monument;
    public GameObject button;
    public GameObject model;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void InstantiateArc()
    {
        Instantiate(monument);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
