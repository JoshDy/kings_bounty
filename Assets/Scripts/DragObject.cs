using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))] //Determines that the objects that will be dragged will have to have a certain type of collider

public class DragObject : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown() //When a specific object is clicked on, the player will be able to drag it
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag() //When a specific object is dragged with the mouse and released, it will stay in the position it was released in
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}
