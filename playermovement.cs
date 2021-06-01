using UnityEngine;

public class playermovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Camera mainCamera;

    [SerializeField] private float xMargin = 2;

    [SerializeField] private float playerSpeed = 50;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main; 
    }

    private void Update()
    {
     int dirX = 0;
     transform.rotation = Quaternion.Euler(0, 0, 0);


        if (Application.isEditor)
        {
            if (Input.GetKey(KeyCode.D))
            {
                dirX = 3;
                transform.rotation = Quaternion.Euler(0, 0, -30);
            }

            else if(Input.GetKey(KeyCode.A))
            {
                dirX = -3;
                transform.rotation = Quaternion.Euler(0, 0, 30);

            }
        }

        
      if(Input.touches.Length > 0)
        {
            Vector3 touchPosition = Input.touches[0].position;
            touchPosition = mainCamera.ScreenToWorldPoint(touchPosition);

            if(touchPosition.x>0)
            {
                //go right
                dirX = 1;
            }
            else
            {
                //go left
                dirX = -1;
            }
        }
        rb.velocity = new Vector2(dirX * playerSpeed * Time.deltaTime, 0);
        float posX = transform.position.x;
        posX = Mathf.Clamp(posX, -xMargin, xMargin);
        transform.position = new Vector3(posX, transform.position.y, transform.position.x);
    }
}
