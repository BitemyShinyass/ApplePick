using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefeb;
    public int numBasket = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    // Start is called before the first frame update
    void Start()
    {
        for ( int i = 0; i < numBasket; i++ )
        {
            GameObject tbasketGO = Instantiate(basketPrefeb) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tbasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
