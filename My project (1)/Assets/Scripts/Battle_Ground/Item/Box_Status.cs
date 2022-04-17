using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box_Status : MonoBehaviour
{
    public Slider Box_Hp;

    Transform Left_Item_Box_Pos;
    Transform Right_Item_Box_Pos;

    Animator animator;
    float Random_Value = 0;
    
    void Start()
    {
            transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);

        animator = GetComponent<Animator>();
        Left_Item_Box_Pos = GameObject.Find("Left_Item_Box_Instatiate_Pos").transform;
        Right_Item_Box_Pos = GameObject.Find("Left_Item_Box_Instatiate_Pos").transform;

    }

    void Update()
    {
        if(Box_Hp.value <=0)
        {
            Destroy(gameObject, 1f);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);

            animator.SetBool("Crash", true);
          
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Own_Attack")||
           other.gameObject.layer == LayerMask.NameToLayer("Enemy_Attack"))
        {
            Box_Hp.value -= 6f * Time.deltaTime;
        }
    }
   
    private void OnDestroy()
    {

        if (gameObject.name == "Item_Box_Left" || gameObject.name == "Item_Box_Left(Clone)")
            Item_Manager.Instance.Left_Item_Box_Exist = false;
        if (gameObject.name == "Item_Box_Right" || gameObject.name == "Item_Box_Right(Clone)")
            Item_Manager.Instance.Right_Item_Box_Exist = false;
    }
}
