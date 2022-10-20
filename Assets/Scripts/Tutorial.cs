using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();
    void Start()
    {
        foreach(GameObject go in gameObjects)
        {
            go.GetComponent<Outline>().OutlineWidth = 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TutorialFinished()
    {
        foreach (GameObject go in gameObjects)
        {
            go.GetComponent<Outline>().OutlineWidth = 0;
        }
    }
}
