using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHiddenObj : MonoBehaviour
{
    public GameObject monument;
    public GameObject button;
    public GameObject button_reset;
    public GameObject model;
    public GameObject arco;
    public GameObject tempio;
    public GameObject minareto;

    public List<GameObject> instantiated = new List<GameObject>();
    public List<GameObject> instantiated_model = new List<GameObject>();
    public List<Vector3> initial_positions = new List<Vector3>();
    public List<Quaternion> initial_rotations = new List<Quaternion>();

    // Start is called before the first frame update
    void Start()
    {
        initial_positions.Add(arco.transform.position);
        initial_rotations.Add(arco.transform.rotation);
        initial_positions.Add(tempio.transform.position);
        initial_rotations.Add(tempio.transform.rotation);
        initial_positions.Add(minareto.transform.position);
        initial_rotations.Add(minareto.transform.rotation);
    }
    
    public void InstantiateArc()
    {   
        GameObject temp;
        var position = model.transform.position;
        var rotation = model.transform.rotation;
        temp = Instantiate(monument, position, rotation);
        instantiated.Add(temp);
        instantiated_model.Add(model);
    }

    public void ResetM()
    {   
        for(int i=0;i < instantiated_model.Count; i++)
        {
            Destroy(instantiated[i]);
            instantiated_model[i].SetActive(false);
            switch (instantiated_model[i].name)
            {
                case "arco_palmira":
                    instantiated_model[i].transform.position = initial_positions[0];
                    instantiated_model[i].transform.rotation = initial_rotations[0];
                    instantiated_model[i].SetActive(true);
                    break;
                case "temple":
                    instantiated_model[i].transform.position = initial_positions[1];
                    instantiated_model[i].transform.rotation = initial_rotations[1];
                    instantiated_model[i].SetActive(true);
                    break;
                case "minareto":
                    instantiated_model[i].transform.position = initial_positions[2];
                    instantiated_model[i].transform.rotation = initial_rotations[2];
                    instantiated_model[i].SetActive(true);
                    break;
                default:
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
