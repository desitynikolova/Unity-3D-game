using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monument : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FirstPersonController").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "FirstPersonController"){
            if(player.circles == 5){
                player.circleText.text = "Game is finished. You collected 5 circles.";
            }
            else if(player.circles <= 5){
                player.circleText.text = "Not ready. You should be collect 5 circles.";
            }
        }
    }
}
