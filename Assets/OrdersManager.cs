using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdersManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();
    [SerializeField] private List<GameObject> outlinedSnapZone = new List<GameObject>();
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

    private void Update()
    {
        if (currentObject)
        {
            if (currentObject.tag == "Sword")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 0;

                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineColor = Color.yellow;
            }
            if (currentObject.tag == "Shield")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 0;

                outlinedSnapZone[1].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineColor = new Color(255, 153, 0);
                outlinedSnapZone[5].GetComponent<Outline>().OutlineColor = Color.yellow;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineColor = Color.yellow;
            }
            if (currentObject.tag == "Helmet")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 0;

                outlinedSnapZone[0].GetComponent<Outline>().OutlineColor = new Color(255, 153, 0);
                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor = new Color(255, 153, 0);
                outlinedSnapZone[6].GetComponent<Outline>().OutlineColor = new Color(255, 153, 0);
                outlinedSnapZone[1].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineColor = Color.gray;
            }
            if (currentObject.tag == "Boots")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 8;

                outlinedSnapZone[1].GetComponent<Outline>().OutlineColor = new Color(255, 153, 0);
                outlinedSnapZone[7].GetComponent<Outline>().OutlineColor = new Color(255, 153, 0);
                outlinedSnapZone[2].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineColor = Color.gray;
            }
            if (currentObject.tag == "Pants")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 8;

                outlinedSnapZone[1].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[0].GetComponent<Outline>().OutlineColor = Color.green;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineColor = Color.green;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor = Color.yellow;
            }
            if (currentObject.tag == "Chestplate")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 8;

                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor = new Color(255, 153, 0);
                outlinedSnapZone[4].GetComponent<Outline>().OutlineColor = Color.blue;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineColor = Color.gray;
            }
            if (currentObject.tag == "MagicStaff")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 0;

                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor = Color.blue;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineColor = new Color(255, 153, 0);
                outlinedSnapZone[5].GetComponent<Outline>().OutlineColor = new Color(255, 153, 0);
                outlinedSnapZone[0].GetComponent<Outline>().OutlineColor = Color.green;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineColor = Color.green;
            }
        }
       
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
