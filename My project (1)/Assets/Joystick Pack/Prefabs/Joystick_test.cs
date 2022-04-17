using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Joystick_test : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static Joystick_test Instance;


    [SerializeField]
    private RectTransform lever;
    private RectTransform rectTransform;
    [SerializeField, Range(10, 150)]
    private float leverRange;

    private Vector2 inputDirection;
    public bool isInput = false;

    //[SerializeField]
    public PlayerMove UnityChan_controller;
    public Player_PBRCharacter PBRCharacter_controller;
    public Player_RobotKyle RobotKyle_controller;
    public Player_Satomi Satomi_controller;
    public Player_Arisa Arisa_controller;
    public Player_SapphiArtchan SopphiArt_controller;


    

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        ControlJoysticklever(eventData);
        isInput = true;
    }

        
    public void OnDrag(PointerEventData eventData)
    {
        ControlJoysticklever(eventData);

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lever.anchoredPosition = Vector2.zero;
        isInput = false;
        if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_UnityChan(Clone)")
            UnityChan_controller.Move(Vector2.zero);
        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_PBRCharacter(Clone)")
            PBRCharacter_controller.Move(Vector2.zero);
        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_RobotKyle(Clone)")
            RobotKyle_controller.Move(Vector2.zero);
        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Satomi(Clone)")
            Satomi_controller.Move(Vector2.zero);
        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Arisa(Clone)")
            Arisa_controller.Move(Vector2.zero);
        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_SopphiArt(Clone)")
            SopphiArt_controller.Move(Vector2.zero);
      
    }

    private void ControlJoysticklever(PointerEventData eventData)
    {
        var inputPos = eventData.position - rectTransform.anchoredPosition;
        var inputVector = inputPos.magnitude < leverRange ? inputPos : inputPos.normalized * leverRange;
        lever.anchoredPosition = inputVector;
        inputDirection = inputVector / leverRange;
    }
    public void InputControlVector()
    {
        try
        {
            if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_UnityChan(Clone)")
            {
                UnityChan_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<PlayerMove>();
                UnityChan_controller.Move(inputDirection);

            }
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_PBRCharacter(Clone)")
            {
                PBRCharacter_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_PBRCharacter>();
                PBRCharacter_controller.Move(inputDirection);
            }
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_RobotKyle(Clone)")
            {
                RobotKyle_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_RobotKyle>();
                RobotKyle_controller.Move(inputDirection);
            }
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Satomi(Clone)")
            {
                Satomi_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_Satomi>();
                Satomi_controller.Move(inputDirection);
            }
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Arisa(Clone)")
            {
                Arisa_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_Arisa>();
                Arisa_controller.Move(inputDirection);
            }
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_SopphiArt(Clone)")
            {
                SopphiArt_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_SapphiArtchan>();
                SopphiArt_controller.Move(inputDirection);
            }

          
        }
        catch (NullReferenceExcelltion Ex)
        {
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            if(GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_UnityChan(Clone)")
                UnityChan_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<PlayerMove>();
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_PBRCharacter(Clone)")
                PBRCharacter_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_PBRCharacter>();
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_RobotKyle(Clone)")
                RobotKyle_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_RobotKyle>();
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Satomi(Clone)")
                Satomi_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_Satomi>();
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Arisa(Clone)")
                Arisa_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_Arisa>();
            //else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_GamblerCat(Clone)")
            //    Arisa_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_GamblerCat>();
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_SopphiArt(Clone)")
                SopphiArt_controller = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).GetComponent<Player_SapphiArtchan>();

        }
        catch (NullReferenceExcelltion Ex)
        {

        }

        if (isInput && Enemy_Player_UI_Manager.Instance.Our_Player_Hp > 0)
        {
            InputControlVector();
        }
    }
}
