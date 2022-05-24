using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : Interactable
{
    [SerializeField]
    private static int maxsouls=0;
    public int GetSoulsCont()
    {
        return maxsouls;
    }
    private void Start()
    {
        maxsouls++;
    }

    int ptsRandom=0;
    public override void Interact(PlayerController playerController)
    {   
        System.Random rnd = new System.Random();
        ptsRandom = rnd.Next(1,10);
        playerController.ContFragmentos++;
        playerController.UpdatePuntaje(ptsRandom);
        Destroy(gameObject);
        if(playerController.ContFragmentos >=maxsouls)
        {
            Scene_Manager sceneManager = new Scene_Manager();
            sceneManager.LoadMainMenu();
        }
    }
}
