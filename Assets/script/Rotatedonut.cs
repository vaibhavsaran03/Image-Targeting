using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatedonut : MonoBehaviour
{
    public Animator myRotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayRotate()
    {
        myRotate.Play("RotateAnime");
    }

    public void StopRotate()
    {
        myRotate.Play("Idle");     
    }
}
