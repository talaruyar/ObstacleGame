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
        //baþlangýçta bu "þeyin"(neye baðladýysak scripti) transform position'ýnýna eþit olsun
        startPos = transform.position;
        //get component, hangi component'in özelliklerini ön yüzden buraya çaðýrmak istiyorsak kullandýðýmýz method. 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // frame güncellendikçe position'ý resetlensin ama bittiðinde
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
