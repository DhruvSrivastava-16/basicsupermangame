using UnityEngine;

public class logocollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Entity"))
        {
            switch (collision.GetComponent<entitytype>().entityType)
            {
                case entitytype.EntityTypes.logo:
                    //addscore
                 Destroy(collision.gameObject);
                    break;


                case entitytype.EntityTypes.nuc:
                    //lose
                    Debug.Log("You lost!");
                    break;
            }
        }
    }

}