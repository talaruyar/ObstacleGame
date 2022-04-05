using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        //ba�lang��ta bu "�eyin"(neye ba�lad�ysak scripti) transform position'�n�na e�it olsun
        startPos = transform.position;
        //get component, hangi component'in �zelliklerini �n y�zden buraya �a��rmak istiyorsak kulland���m�z method. 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // frame g�ncellendik�e position'� resetlensin ama bitti�inde
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
