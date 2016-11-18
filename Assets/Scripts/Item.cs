using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour 
{
    private int count = 1;

    public virtual void Use()
    {
        Debug.Log("Item used!");
    }

    public int GetCount()
    {
        return count;
    }
}

/*
	"Don't let your dreams be dreams."
					- Shia LaBeouf
*/