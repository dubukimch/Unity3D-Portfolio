using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Manager : MonoBehaviour
{
    public static Item_Manager Instance;
    public GameObject Item_Box;
    public Transform Left_Item_Item_Pos;
    public Transform Right_Item_Item_Pos;
    public GameObject Hp_Poshion;
    public GameObject Mp_Poshion;
    public GameObject Exp_Poshion;
    int Random_Value = 0;
    public bool Left_Item_Box_Exist = true;
    public bool Right_Item_Box_Exist = true;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);

    }
    void Update()
    {
        if (Left_Item_Box_Exist == false)
        {
            StartCoroutine(LEft_Box_Instantiate_Wait());
            Item_Poshion(Left_Item_Item_Pos);
            Left_Item_Box_Exist = true;

        }

        if (Right_Item_Box_Exist == false)
        {
            StartCoroutine(Right_Box_Instantiate_Wait());
            Item_Poshion(Right_Item_Item_Pos);
            Right_Item_Box_Exist = true;

        }
    }
    IEnumerator LEft_Box_Instantiate_Wait()
    {
        yield return new WaitForSeconds(11f);
        Instantiate(Item_Box, Left_Item_Item_Pos.position, Quaternion.identity);
    }
    IEnumerator Right_Box_Instantiate_Wait()
    {
        yield return new WaitForSeconds(11f);
        Instantiate(Item_Box, Right_Item_Item_Pos.position, Quaternion.identity);
    }


    void Item_Poshion(Transform Pos)
    {
        Random_Value = Random.Range(1, 3);
        if (Random_Value == 1)
        {
            GameObject Item = Instantiate(Hp_Poshion, Pos.position, Quaternion.identity);
            Destroy(Item, 10f);
        }
        else if (Random_Value == 2)
        {
            GameObject Item = Instantiate(Mp_Poshion, Pos.position, Quaternion.identity);
            Destroy(Item, 10f);

        }
        else if (Random_Value == 3)
        {
            GameObject Item = Instantiate(Exp_Poshion, Pos.position, Quaternion.identity);
            Destroy(Item, 10f);
        }
    }

}
