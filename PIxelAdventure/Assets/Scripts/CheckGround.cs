using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGounded = false;
    }


}
