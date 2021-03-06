
using UnityEngine;

public class PlatformController : MonoBehaviour
{

	[SerializeField] private LayerMask _layerMask;

	private int _currentWayPointIndex = 0;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
			collision.gameObject.transform.SetParent(transform);
	}
	
	private void OnCollisionExit2D(Collision2D collision)
	{
		if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
			collision.gameObject.transform.SetParent(null);
	}
}
