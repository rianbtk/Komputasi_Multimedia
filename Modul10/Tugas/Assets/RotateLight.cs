using UnityEngine;
using System.Collections;
public class RotateLight : MonoBehaviour{
    public float speed = -2.0f;
    void Update(){
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    } 
}