using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricView : MonoBehaviour
{
    public Vector3 offset = new Vector3(0f, 4f, 0f);
    public GameObject Player;

    void FixedUpdate()
    {

        transform.position = new Vector3(Player.transform.position.x + offset.x, Player.transform.position.y + offset.y, Player.transform.position.z + offset.z);
    }
}
