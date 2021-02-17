using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotSpot : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = Camera.main.transform.parent.gameObject;
    }

    public void OnPointerClick()
    {
        // move the player to its position
        // speed depends on the distance between player and the spot
        float distance = Vector3.Distance(transform.position, player.transform.position);
        LeanTween.move(player, transform.position, distance / 2f);
    }
}