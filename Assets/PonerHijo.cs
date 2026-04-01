using UnityEngine;

public class PonerHijo : MonoBehaviour
{
    public GameObject parent;

    public GameObject hijo;

    public bool ponerHijo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        

    }

    void OnGUI()
    {
       if (ponerHijo)
        {
            hijo.gameObject.transform.parent = parent.transform;
        }
        else
        {
            hijo.gameObject.transform.parent = null;
        } 
    }
}
