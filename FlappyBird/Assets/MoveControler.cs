using UnityEngine

public class MoveControler : MonoBehaviour
{
    public float speed;
    public float spawnPositionX;
    public float despawnPositionX;

    void Start()
    {
        
    }

    void Update()
    {
        
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);

        if (transform.position.x <= despawnPositionX)
        {
            transform.position = new Vector3(spawnPositionX, transform.position.y, transform.position.z);
        }
    }
}
// transform.position.y