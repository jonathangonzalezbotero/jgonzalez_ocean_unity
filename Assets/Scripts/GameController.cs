using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject dolphin;
    //I removed the floats as you can store these values in a Vector 3 (See inside Unity)
    //public float x; 
    //public float y;
    //public float z;
    private Vector3 dolphinStart; //the new variable whihc we set in start
    public float rotateZ;
    public Vector3 sizeChange;
    private Vector3 newPosition;

    //Wont need this one now
    //private Vector3 initialCoor;
    
    void Start(){
        //boom we get the current starting pos and store it here as a vector3
        dolphinStart = dolphin.transform.position;
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
        //we can now use the dolphinStart to set the 3 values now
        dolphin.transform.position = new Vector3(dolphinStart.x, dolphinStart.y, dolphinStart.z);
        dolphin.transform.rotation = Quaternion.Euler(new Vector3(0f, rotateZ, 0f));
        dolphin.transform.localScale = new Vector3(1,1,1);
    }
}
