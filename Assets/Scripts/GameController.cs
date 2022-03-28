using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject dolphin;
    public float x;
    public float y;
    public float z;
    public float rotateZ;
    public Vector3 sizeChange;
    private Vector3 newPosition;
    private Vector3 initialCoor;
    
    void start(){
        initialCoor = dolphin.transform.position;
    }

    public void MoveLeft()
    {
        newPosition = dolphin.transform.position;
        newPosition.x = newPosition.x - 0.1f;
        dolphin.transform.position = newPosition;
    }

    public void MoveRight()
    {
        newPosition = dolphin.transform.position;
        newPosition.x = newPosition.x + 0.1f;
        dolphin.transform.position = newPosition;
    }

    public void MoveUp()
    {
        newPosition = dolphin.transform.position;
        newPosition.y = newPosition.y + 0.1f;
        dolphin.transform.position = newPosition;
    }

    public void MoveDown()
    {
        newPosition = dolphin.transform.position;
        newPosition.y = newPosition.y - 0.1f;
        dolphin.transform.position = newPosition;
    }

    public void RotateRight(){
        rotateZ = rotateZ + 1f;
        dolphin.transform.Rotate(0f, rotateZ, 0f);
    }

    public void RotateLeft(){
        rotateZ = rotateZ - 1f;
        dolphin.transform.Rotate(0f, rotateZ, 0f);
    }

    public void GrowUp(){
        dolphin.transform.localScale = dolphin.transform.localScale + sizeChange;
    }

    public void GrowDown(){
        dolphin.transform.localScale = dolphin.transform.localScale - sizeChange;
    }

    public void ResetValues(){
        dolphin.transform.position = initialCoor;
        dolphin.transform.rotation = Quaternion.Euler(new Vector3(0f, rotateZ, 0f));
        dolphin.transform.localScale = new Vector3(1,1,1);
    }
}
