using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineAction : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kenny is trying to mine");
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Kenny is finished mining");
    }
}
