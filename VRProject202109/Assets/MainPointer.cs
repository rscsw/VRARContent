using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPointer : MonoBehaviour
{
    public Image loadingImg;
    public int loadingTime;
    public GameObject menu;
    public GameObject deathChest;

    private Animator anim;

    void Start()
    {
        menu.SetActive(false);
        anim = deathChest.GetComponent<Animator>();
    }

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 500f))
        {
            if(hit.collider.CompareTag("Chest")) 
            {
                MoveController.is_Stopped = true;
                menu.SetActive(true);
            }
            else 
            {
                MoveController.is_Stopped = false;
                menu.SetActive(false);
            }

            if(hit.collider.CompareTag("YES") || hit.collider.CompareTag("NO"))
            {
                menu.SetActive(true);
                MoveController.is_Stopped = true;
                loadingImg.fillAmount += 1.0f / loadingTime * Time.deltaTime;
                if(loadingImg.fillAmount == 1)
                {
                    if(hit.collider.CompareTag("YES")) anim.SetBool("IsOpen", true);
                    if(hit.collider.CompareTag("NO")) anim.SetBool("IsOpen", false);
                }
            }
            else
            {
                loadingImg.fillAmount = 0;
            }
        }
        else
        {
            loadingImg.fillAmount = 0;
        }
    }
}
