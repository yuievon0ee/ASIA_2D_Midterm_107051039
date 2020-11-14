using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject final;
    public Text textCount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "終點" )
        {
            final.SetActive(true);
        }
        if (collision.tag == "櫻桃")
        {
            Destroy(collision.gameObject);
            count++;
            textCount.text = "X" + count;
        }
    }
}


