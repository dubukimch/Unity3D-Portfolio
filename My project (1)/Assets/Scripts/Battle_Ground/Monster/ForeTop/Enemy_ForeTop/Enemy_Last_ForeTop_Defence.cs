using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Last_ForeTop_Defence : MonoBehaviour
{
    [SerializeField] private string towerName;
    [SerializeField] private float range;
    [SerializeField] private int damage;
    [SerializeField] private float rateOfAccuracy;
    [SerializeField] private float rateOfFire;
    private float currentRateOfFire; 
    [SerializeField] private float viewAngle;
    [SerializeField] private float spinSpeed;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform tf_TopGun;
    [SerializeField] private ParticleSystem particle_MuzzleFlash;
    [SerializeField] private GameObject go_HitEffect_Prefab;
    [SerializeField] private GameObject Destroy_Effect_prefab;



    private RaycastHit hitInfo;
    private Animator anim;
    private bool isFindTarget = false;
    private bool isAttack = false;

    private Transform tf_Target;

    public Slider ForeTop_Hp;
    float ForeTop_Hp_Value = 1f;

    Rigidbody rg;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rg = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        ForeTop_Status();

        Spin();
        SearchEnemy();
        LookTarget();
        Attack();
    }

    private void Spin()
    {
        if (!isFindTarget && !isAttack)
        {
            Quaternion _spin = Quaternion.Euler(0f, tf_TopGun.eulerAngles.y + (1f * spinSpeed * Time.deltaTime), 0f);
            tf_TopGun.rotation = _spin;
        }
    }

    private void SearchEnemy()
    {
        Collider[] _target = Physics.OverlapSphere(tf_TopGun.position, range, layerMask);

        for (int i = 0; i < _target.Length; i++)
        {
            Transform _targetTf = _target[i].transform;


            if (_targetTf.name == "Albino_Dragon" ||
                _targetTf.name == "Owr_Left_Minion(Clone)" ||
                _targetTf.name == "Player(Clone)" ||
                _targetTf.name == "Owr_Middle_Minion(Clone)" ||
                _targetTf.name == "Owr_Right_Minion(Clone)" ||
                _targetTf.name == "Owr_Right_Minion(Clone)" ||
                _targetTf.tag == "Our" ||
                _targetTf.name == "Albino_Dragon(Clone)")
            {
                Vector3 _direction = (_targetTf.position - tf_TopGun.position).normalized;
                float _angle = Vector3.Angle(_direction, tf_TopGun.forward);

                if (_angle < viewAngle * 0.5f)
                {
                    tf_Target = _targetTf;
                    isFindTarget = true;

                    if (_angle < 10f)
                        isAttack = true;
                    else
                        isAttack = false;

                    return;

                }
            }
        }
        tf_Target = null;
        isAttack = false;
        isFindTarget = false;


    }

    private void LookTarget()
    {
        if (isFindTarget)
        {
            Vector3 _direction = (tf_Target.position - tf_TopGun.position).normalized;
            Quaternion _lookRotation = Quaternion.LookRotation(_direction);
            Quaternion _rotation = Quaternion.Lerp(tf_TopGun.rotation, _lookRotation, 0.2f);
            tf_TopGun.rotation = _rotation;
        }
    }

    void Attack()
    {
        if (isAttack)
        {
            currentRateOfFire += Time.deltaTime;
            if (currentRateOfFire >= rateOfFire)
            {
                currentRateOfFire = 0;
                anim.SetTrigger("Fire");
                //theAudio.Play();
                particle_MuzzleFlash.Play();

                if (Physics.Raycast(tf_TopGun.position,
                                        tf_TopGun.forward + new Vector3(Random.Range(-1, 1f) * rateOfAccuracy, Random.Range(-1, 1f) * rateOfAccuracy, 0f),
                                        out hitInfo,
                                        range,
                                        layerMask))
                {
                    GameObject _HitEffect = Instantiate(go_HitEffect_Prefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                    Destroy(_HitEffect, 1f);

                    if (hitInfo.transform.name == "Player")
                    {
                        Debug.Log("플레이어 데미지 입었습니다.");
                    }
                    else if (hitInfo.transform.name == "Minion")
                    {
                        Debug.Log("미니언 데미지 입었습니다.");

                    }
                }

            }

        }
    }


    void ForeTop_Status()
    {
        ForeTop_Hp.value = ForeTop_Hp_Value;

        if (ForeTop_Hp_Value <= 0)
        {
            GameObject _Destroy_Effect = Instantiate(Destroy_Effect_prefab, transform.position, Quaternion.LookRotation(hitInfo.normal));
            Destroy(_Destroy_Effect, 1f);
            GameManager.Instance.Our_Game_Battle_Win = true;
            Destroy(gameObject);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Own_Attack"))
        {
            ForeTop_Hp_Value -= 5f * Time.deltaTime;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Player_Attack"))
        {
            ForeTop_Hp_Value -= 15f * Time.deltaTime;
        }

    }


}
