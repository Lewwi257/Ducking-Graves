using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSC : MonoBehaviour
{
    public Light FL;
    public float offset1;
    public GameObject Flashlight;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Flashlight.activeSelf == true)
            {
                Flashlight.SetActive(false);
                FL.enabled = false;
                PowerBar.Con = false;
            }
            else
            {
                Flashlight.SetActive(true);

            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (Flashlight.activeSelf == true)
            {
                if (FL.enabled == false)
                {
                    FL.enabled = true;
                    Debug.Log("������� ����ר� � ������ ��� ���� ����ר� ");
                    Debug.Log("power--");
                    PowerBar.Con = true;
                }
                else if (FL.enabled == true)
                {
                    FL.enabled = false;
                    Debug.Log("������� ����ר� � ������ ��� ���� �������� ");
                    Debug.Log("Power++");
                    PowerBar.Con = false;

                }
            }
            else
            {
                if (FL.enabled == false)
                {
                    FL.enabled = false;
                    Debug.Log("������� �������� � ���� ����");
                    Debug.Log("Power+");
                    PowerBar.Con = false;
                }
                else
                {
                    FL.enabled = false;
                    Debug.Log("������� �������� � ���� ����");
                    Debug.Log("Power+");
                    PowerBar.Con = false;
                }
            }
        }
        if (PowerBar.fill == 0)
        {
            FL.enabled = false;
            Debug.Log("NO MOWER");
            PowerBar.fill = 0.1F;
            Flashlight.SetActive(false);
            Flashlight.SetActive(true);
        }
    }
}
