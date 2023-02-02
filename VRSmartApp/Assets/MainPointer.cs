using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPointer : MonoBehaviour
{
    public Image loadingImg;
    public GameObject app7205;
    public GameObject app7206;
    public GameObject mainMenu;

    void Start()
    {
        Activefalse(mainMenu);
    }

    void Activefalse(GameObject gameObject)
    {
        mainMenu.SetActive(false);
        app7206.SetActive(false);
        app7205.SetActive(false);
        gameObject.SetActive(true);
    }

    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit, 500f))
        {
            if(hit.collider.CompareTag("App7205"))
            {
                loadingImg.fillAmount += 1.0f / 2 * Time.deltaTime;
                if(loadingImg.fillAmount == 1)
                {
                    Activefalse(app7205);
                }
            }
            if(hit.collider.CompareTag("App7206"))
            {
                loadingImg.fillAmount += 1.0f / 2 * Time.deltaTime;
                if(loadingImg.fillAmount == 1)
                {
                    Activefalse(app7206);
                }
            }
            if(hit.collider.CompareTag("Home"))
            {
                loadingImg.fillAmount += 1.0f / 2 * Time.deltaTime;
                if(loadingImg.fillAmount == 1)
                {
                    Activefalse(mainMenu);
                }
            }
        }
        else
        {
            loadingImg.fillAmount = 0;
        }
        
    }
}
