using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

    public float speed;
    public float yBuffer;
    public bool dragAndDrop;

   // public Renderer rend;

    void Start()
    {
        //rend = GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update ()
    {
        if(dragAndDrop)
            FollowMouse();
	}

    void FollowMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y);

        this.transform.up = direction;//small rotation
        this.transform.position = new Vector3(Mathf.Lerp(mousePosition.x, transform.position.x, Time.deltaTime * speed), Mathf.Lerp(mousePosition.y, transform.position.y, Time.deltaTime * speed) + yBuffer, transform.position.z);//smooth follow
    }

    private void OnMouseDrag()
    {
        //rend.material.color -= Color.white * Time.deltaTime;
        dragAndDrop = true;
    }

    void OnMouseUp()
    {
        // If your mouse hovers over the GameObject with the script attached, output this message
        dragAndDrop = false;
    }

}
