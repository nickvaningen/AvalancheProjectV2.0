using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class groeifactor : MonoBehaviour {
    private float player_Size = 10;
    public static float speed;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "ground")
        {
            player_Size++;
            speed += 1;
            gameObject.transform.localScale=new Vector3(player_Size/10,player_Size/10, 1);
        }
        if (other.gameObject.tag == "stone")
        {
            player_Size = player_Size / 2;
            speed += -1;
            gameObject.transform.localScale = new Vector3(player_Size / 10, player_Size / 10, 1);
        }
    }
}
    
