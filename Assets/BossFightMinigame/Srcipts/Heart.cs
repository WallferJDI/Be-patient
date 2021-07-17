using UnityEngine;

public class Heart : MonoBehaviour
{

    [SerializeField] private GameObject game;
    [SerializeField] private GameObject lose;

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            Destroy(gameObject);
            
        }
    }

}
