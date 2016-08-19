using UnityEngine;
using System.Collections;

public class HealthBarScript : MonoBehaviour {

    public float inset = 40.0f;
    public float size = 138.0f;

    RectTransform thisRectTransform;
	void Start ()
    {
        thisRectTransform = gameObject.GetComponent<RectTransform>();
	}
	
	void Update ()
    {
        //gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, size);
        thisRectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, inset, size);
    }
}
