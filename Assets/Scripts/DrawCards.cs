using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerArea;
    public GameObject Player2Area;
    public GameObject Player3Area;
    public GameObject Player4Area;
    public GameObject Player5Area;
    public GameObject StackPlayed;

    List <GameObject> 

    void Start()
    {
        
    }

    public void OnClick()
    {
        for(var i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(Card1, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerArea.transform, false);
        }
        
    }

    
}
