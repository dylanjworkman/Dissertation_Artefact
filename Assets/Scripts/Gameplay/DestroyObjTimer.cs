using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjTimer : MonoBehaviour
{
    private void Awake()
     {  
        StartCoroutine(waiter());
     }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(12);
        Object.Destroy(this.gameObject);}
}
