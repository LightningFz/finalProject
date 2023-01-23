//made by Hamza

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 the purpose of this class is to change the color of the game object coin on every level.
 you are able to disable this feature through the inspector
*/
public class coinColorChanger : MonoBehaviour
{   
    //variables
    public SpriteRenderer coin; //this vairable accesses the sprite of the coin
    public Color[] color; //array to hold the diffrent colors the coin can change to
    public Color defaultColor; // uses the Color vairable built into unity to set the default color of the pet if the player doesnt want random pet colors
    public bool changePlayerColor;
    private int randomizer;

    // Start is called before the first frame update
    void Start()
    {
        randomizer = Random.Range(0, color.Length);//get a random number between 0 and the total amout of colors there are 
        if (changePlayerColor == true)
        {
            coin.color = color[randomizer];//change the backpetground color to a random color from the array
        }
        else if (changePlayerColor == false)
        {
            coin.color = defaultColor;//change the pet color to the default one
        }
    }

    // Update is called once per frame
    void Update()
    {   //check if the player wants to change the pet color
        if (changePlayerColor == false)
        {
            coin.color = defaultColor;
        }
    }
}
