using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesDif : MonoBehaviour
{
	private Button button;
    public PlayerControllerX playerX;
    public int dificultad;
	
    void Start()
    {
        playerX = GameObject.Find("Player").GetComponent<PlayerControllerX>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " fue clickeado");
        playerX.StartGame(dificultad);
    }
}
