using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectableCounter : MonoBehaviour
{
    //wat gebeurt er als ik een pickup oppak?
    //counter + 1
    //pick up 
    //hoeveel pickups zijn er in de scene?
    public Text counterText;

    private int counter;
    private int collectablesInScene;

    void Start()
    {
        GameObject[] collectablesObjs = GameObject.FindGameObjectsWithTag("Collectable");
        collectablesInScene = collectablesObjs.Length;
        UpdateCounterUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectable")
        {
            counter++;
            Destroy(other.gameObject);
            UpdateCounterUI();
            if (counter >= collectablesInScene)
            {
                Debug.Log("You got em all, go finish da game");
            }
        }
    }

    void UpdateCounterUI()
    {
        counterText.text = "Collectables: " + counter + " / " + collectablesInScene;
    }
}

