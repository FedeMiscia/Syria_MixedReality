using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMonuments : MonoBehaviour
{
    public GameObject arco;
    public GameObject tempio;
    public GameObject minareto;

    public GameObject arco_fractured;
    public GameObject tempio_fractured;
    public GameObject minareto_fractured;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        arco_fractured = (GameObject) Instantiate(arco_fractured);
        GameObject.DestroyImmediate(arco_fractured,true);
        //GameObject.DestroyImmediate(tempio_fractured,true);
        //GameObject.DestroyImmediate(minareto_fractured,true);
        Instantiate(arco);
        //Instantiate(tempio);
        //Instantiate(minareto);
    }
}
