using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private List<GameObject> _materials = new List<GameObject>();  
    [SerializeField] private List<GameObject> _spawners = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InstantiateMaterial(int index)
    {
        Instantiate(_materials[index], _spawners[index].transform.position,_spawners[index].transform.rotation);
    }
}
