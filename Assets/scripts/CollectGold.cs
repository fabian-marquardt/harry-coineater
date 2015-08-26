using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectGold : MonoBehaviour {

	int goldBagsCollected = 0;

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "gold")
		{
			goldBagsCollected++;
			Destroy(col.gameObject);
			//GameObject.Find("GoldText").GetComponent<Text>().text = goldBagsCollected + " gold bags collected";
		}
	}
}
