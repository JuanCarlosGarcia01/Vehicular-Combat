using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform Player;

    float camOffsetZ;

    void Start()
    {
        camOffsetZ = gameObject.transform.position.z - Player.position.z;
    }


    void Update()
    {
        Vector3 moveCamara = new Vector3(Player.position.x, gameObject.transform.position.y, Player.position.z + camOffsetZ);

        gameObject.transform.position = moveCamara;
    }
}
