using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shade : MonoBehaviour

{
private static float _start=0f;
    public void Update(){

        
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        Color color=textmeshPro.color;
        _start+=0.01f;
        Color end=new Color(color.r,color.g,color.b,_start);
        gameObject.GetComponent<TextMeshPro>().color=Color.Lerp(color,end,1);
       }
        
        

    
}
