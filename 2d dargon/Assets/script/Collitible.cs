using UnityEngine;

public class Collitible : MonoBehaviour
{
    public GameObject own;
    private float spinSpeed = 150;

    private void Update()
    {
        own.transform.Rotate(new Vector3(0,spinSpeed,0)*Time.deltaTime);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(own);
        }
    }
}
