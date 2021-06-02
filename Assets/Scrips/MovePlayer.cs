using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    private CharacterController moveCharacterController;

    [Header("MovePlayer")]
    float moveHorizontal;
    float moveVertical;
    public float PlayerSpeed = 0.1f;

    void Start()
    {
        moveCharacterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        Vector3 movePlayer = new Vector3(moveHorizontal, 0f, moveVertical) * PlayerSpeed;

        moveCharacterController.Move(movePlayer);
    }
}
