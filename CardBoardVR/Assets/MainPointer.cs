using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPointer : MonoBehaviour
{
    public Image loadingImage;
    public GameObject boom;

    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit, 500f))
        {
            if(hit.collider.CompareTag("Box"))
            {
                loadingImage.fillAmount += 1.0f /2 * Time.deltaTime;
                if(loadingImage.fillAmount == 1)
                {
                    GameObject temp = Instantiate(boom, hit.collider.transform.position, transform.rotation);
                    Destroy(temp, 1f);
                    hit.collider.gameObject.SetActive(false);
                }
            }
        } 
        else
        {
            loadingImage.fillAmount = 0;
        }
    }
}
