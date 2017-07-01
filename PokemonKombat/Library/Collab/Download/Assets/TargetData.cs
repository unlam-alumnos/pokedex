using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
	public class TargetData : MonoBehaviour
	{

		public GameObject PokemonDescription;
	

		// Use this for initialization
		void Start()
		{
		}

		// Update is called once per frame
		void Update()
		{
			StateManager sm = TrackerManager.Instance.GetStateManager();
			IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

			foreach (TrackableBehaviour tb in tbs)
			{
				string name = tb.TrackableName;
				ImageTarget it = tb.Trackable as ImageTarget;
				Vector2 size = it.GetSize();

				Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

				// PokemonDescription.SetActive(true);

			}
		}

	}
}
