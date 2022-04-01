using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject dolphin;
    public Vector3 sizeChange;
    public float rotate;
    private float rotateStart;
    private Vector3 newPosition;
    private Vector3 dolphinStart;

    void Start(){
        dolphinStart = dolphin.transform.position;
        rotateStart = rotate;
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
        rotate = rotate - 1f;
        dolphin.transform.rotation = Quaternion.Euler(new Vector3(0f, rotate, 0f));
    }

    public void RotateLeft(){
        rotate = rotate + 1f;
        dolphin.transform.rotation = Quaternion.Euler(new Vector3(0f, rotate, 0f));
    }

    public void GrowUp(){
        dolphin.transform.localScale = dolphin.transform.localScale + sizeChange;
    }

    public void GrowDown(){
        dolphin.transform.localScale = dolphin.transform.localScale - sizeChange;
    }

    public void ResetValues(){
        dolphin.transform.position = new Vector3(dolphinStart.x, dolphinStart.y, dolphinStart.z);
        dolphin.transform.rotation = Quaternion.Euler(new Vector3(0f, rotateStart, 0f));
        dolphin.transform.localScale = new Vector3(1,1,1);
    }
}
