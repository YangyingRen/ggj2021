using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShadeSprites : MonoBehaviour

{
private static float _start=0f;
    public void Start(){
        _start=0f;
    }
    public void Update(){

        
    
        Color color=gameObject.GetComponent<SpriteRenderer>().color;
        _start+=0.01f;
        Color end=new Color(color.r,color.g,color.b,_start);

        gameObject.GetComponent<SpriteRenderer>().color=Color.Lerp(color,end,1);
        
        

    }
}
