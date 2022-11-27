using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
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
            player.circles++; // when the player reaches the circles it will increase ++
            player.circleText.text = "Circles: " + player.circles.ToString();
            Destroy(gameObject); // the object disappears when we reach it
        }
    }
}
