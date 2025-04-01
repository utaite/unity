using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public Color touchColor;

    private Color originalColor;
    private Renderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    void Update()
    {
        
    }

    public bool IsOveraped()
    {
        return myRenderer.material.color == touchColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            myRenderer.material.color = touchColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            myRenderer.material.color = originalColor;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            myRenderer.material.color = touchColor;
        }
    }
}
