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
        for(int i = 0; i < _materials.Count; i++)
        {
            Vector3 startPos = _spawners[i].transform.position;
            startPos.y += 1f;
            Instantiate(_materials[i], startPos, _spawners[i].transform.rotation);

        }

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
