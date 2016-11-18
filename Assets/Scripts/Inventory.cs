using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour 
{
    //the GUI canvas
    Canvas canvas;

    //the inventory panel
    GameObject inventory;

    //the object being dragged
    GameObject dragObject;
    GameObject dragParent;
    bool dragging = false;

	// Use this for initialization
	void Start () 
	{
        canvas = GameObject.Find("UI").GetComponent<Canvas>();
        inventory = GameObject.Find("Inventory");
        inventory.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	    if (Input.GetKeyDown(KeyCode.I))
        {
            inventory.SetActive(!inventory.activeSelf);
        }
        SelectObject();
        DragObject();
        ReleaseObject();
	}

    private void SelectObject()
    {
        if (Input.GetMouseButtonDown(0))
        {
            List<RaycastResult> results = GraphicRaycast();

            foreach (RaycastResult r in results)
            {
                if (r.gameObject.CompareTag("Item"))
                {
                    dragObject = r.gameObject;
                    dragParent = dragObject.transform.parent.gameObject;
                    dragObject.transform.SetParent(canvas.transform);
                    dragging = true;
                    return;
                }
            }
        }
    }
    
    private void DragObject()
    {
        //canvas should be in screen overlay mode!
        if(dragging)
        {
            dragObject.transform.position = Input.mousePosition;
        }
    }

    private void ReleaseObject()
    {
        if (dragging)
        {
            if(Input.GetMouseButtonUp(0))
            {
                dragging = false;

                dragObject.transform.SetParent(dragParent.transform);
                dragObject.transform.localPosition = new Vector3(0, 0, 0);

                List<RaycastResult> results = GraphicRaycast();

                foreach (RaycastResult r in results)
                {
                    if (r.gameObject.CompareTag("Slot"))
                    {
                        dragObject.transform.SetParent(r.gameObject.transform);
                        dragObject.transform.localPosition = new Vector3(0, 0, 0);
                    }
                }
            }
        }
    }

    private List<RaycastResult> GraphicRaycast()
    {
        List<RaycastResult> results = new List<RaycastResult>();
        PointerEventData data = new PointerEventData(null);

        data.position = Input.mousePosition;

        canvas.GetComponent<GraphicRaycaster>().Raycast(data, results);
        return results;
    }
}
/*
	"Don't let your dreams be dreams."
					- Shia LaBeouf
*/