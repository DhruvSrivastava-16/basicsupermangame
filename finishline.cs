
using UnityEngine;

public class finishline : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Entity"))
        {
            Destroy(collision.gameObject);
        }
    }
}
