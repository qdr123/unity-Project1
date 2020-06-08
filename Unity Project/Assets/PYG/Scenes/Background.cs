using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    Material ma;
    private float y = 0.5f;
    float Offset;
    Vector2 v2;
    // Start is called before the first frame update
    void Start()
    {
       ma = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

        //  ma.SetTextureOffset("_MainTex",v2(0, Offset));
        BackgroundScroll();

    }
    private void BackgroundScroll()
    {
        Offset += Time.deltaTime * y;
        Vector2 offset= ma.mainTextureOffset;
        offset.Set(0, Offset);
        ma.mainTextureOffset = offset;
    }
}
