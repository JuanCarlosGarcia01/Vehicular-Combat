using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackEnemy : MonoBehaviour
{
    public static float score;

    private void Start()
    {
        score = 0;
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Dead");
        }
        else if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            score += 1;
        }
        if (score == 4)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
