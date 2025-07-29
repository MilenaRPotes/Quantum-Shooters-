using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMinimum, xMaximum, yMinimum, yMaximum;
}
public class PlayerController : MonoBehaviour
{
    public Mover moverComponent;
    public float speed;
    public Boundary boundary;
    
    void Update()
    {
        Vector3 displacement = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, transform.position.z);
        moverComponent.DoMove(displacement);

        //X:7.9
        //Y: 3.8 
        float x = Mathf.Clamp(transform.position.x, boundary.xMinimum, boundary.xMaximum);
        float y = Mathf.Clamp(transform.position.y, boundary.yMinimum, boundary.yMaximum);
        transform.position = new Vector3(x, y);
    }


}
