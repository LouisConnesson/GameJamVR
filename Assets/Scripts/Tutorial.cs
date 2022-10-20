using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FirstStepFinished()
    {
        gameObjects[0].SetActive(false);
        gameObjects[1].SetActive(true);
    }
    public void SecondStepFinished()
    {
        gameObjects[1].SetActive(false);
        gameObjects[2].SetActive(true);
    }
    public void TutorialFinished()
    {
        gameObjects[2].SetActive(false);

    }
}
