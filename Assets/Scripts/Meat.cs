using UnityEngine;
using System.Collections;

public class Meat : Item
{
    Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    public override void Use()
    {
        base.Use();
        player.ModifyHunger(-50.0f);
        Destroy(gameObject);
    }
}
/*
	"Don't let your dreams be dreams."
					- Shia LaBeouf
*/