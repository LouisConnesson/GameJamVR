using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdersManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();
    [SerializeField] private GameObject orderSpawner;
    [SerializeField] private GameObject currentObject;
    [SerializeField] private int currentOrder = 0;
    //[SerializeField] private bool isOrderFinish = false;
    [SerializeField] private int score = 0;

    void Start()
    {
        currentObject =  Instantiate(gameObjects[0], orderSpawner.transform.position, Quaternion.Euler(0,-90f,0));
        if(currentObject.GetComponent<Rigidbody>())
            currentObject.GetComponent<Rigidbody>().useGravity = false;
        if (currentObject.GetComponent<Outline>())
            currentObject.GetComponent<Outline>().OutlineWidth = 5;
       currentOrder = 0;
    }

 
    private void NewOrder()
    {
        int newOrder = Random.Range(0, gameObjects.Count);
        currentObject = Instantiate(gameObjects[newOrder], orderSpawner.transform.position, Quaternion.identity);
        if (currentObject.GetComponent<Rigidbody>())
            currentObject.GetComponent<Rigidbody>().useGravity = false;
        if (currentObject.GetComponent<Outline>())
            currentObject.GetComponent<Outline>().OutlineWidth = 5;

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == gameObjects[currentOrder].tag)
        {
            Debug.Log("ojbet bon");
            score += 1;
            Destroy(other.gameObject    );
            Destroy(currentObject.gameObject) ;
            NewOrder();
        }
        else
            Debug.Log("ojbet pas bon");

    }
}
