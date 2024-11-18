using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nextpage : MonoBehaviour
{
    // �ݭn�ͦ�������w�s��
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;
    public GameObject object6;
    public GameObject object7;
    public GameObject object8;
    public GameObject object9;
    public GameObject object10;
    public GameObject object11;

    // UI���s�ޥ�
    public Button button_1;    // �Ĥ@���M�Ϋ��s
    public Button button_2;    // �ĤG���}�l���������s

    // ��e�������
    private int currentObjectIndex = 0;

    void Start()
    {
        if (button_1 != null)
        {
            button_1.onClick.AddListener(JumpToSecondObject);
        }

        if (button_2 != null)
        {
            button_2.onClick.AddListener(SpawnNextObject);
            button_2.gameObject.SetActive(false);
        }
    }

    void JumpToSecondObject()
    {
        // ���òĤ@�Ӫ���A��ܲĤG�Ӫ���
        object1.SetActive(false);
        object2.SetActive(true);

        // ��s����
        currentObjectIndex = 1;

        // ����button_1�A���button_2
        button_1.gameObject.SetActive(false);
        button_2.gameObject.SetActive(true);

        // ��ҤƲĤG�Ӫ���
        object2.transform.position = new Vector3(0, 1, 1);
        GameObject newObject = Instantiate(object2, Vector3.zero, Quaternion.identity);
        newObject.name = "Object_1";
    }

    void SpawnNextObject()
    {
        currentObjectIndex++;
        if (currentObjectIndex > 11)
        {
            button_2.gameObject.SetActive(false);
            return;
        }

        // �ھڷ�e���ޥͦ�����������
        GameObject prefabToSpawn = null;
        switch (currentObjectIndex)
        {
            case 2:
                prefabToSpawn = object3;
                object2.SetActive(false);
                object3.SetActive(true);
                break;
            case 3:
                prefabToSpawn = object4;
                object3.SetActive(false);
                object4.SetActive(true);
                break;
            case 4:
                prefabToSpawn = object5;
                object4.SetActive(false);
                object5.SetActive(true);
                break;
            case 5:
                prefabToSpawn = object6;
                object5.SetActive(false);
                object6.SetActive(true);
                break;
            case 6:
                prefabToSpawn = object7;
                object6.SetActive(false);
                object7.SetActive(true);
                break;
            case 7:
                prefabToSpawn = object8;
                object7.SetActive(false);
                object8.SetActive(true);
                break;
            case 8:
                prefabToSpawn = object9;
                object8.SetActive(false);
                object9.SetActive(true);
                break;
            case 9:
                prefabToSpawn = object10;
                object9.SetActive(false);
                object10.SetActive(true);
                break;
            case 10:
                prefabToSpawn = object11;
                object10.SetActive(false);
                object11.SetActive(true);
                button_2.gameObject.SetActive(false);
                break;
        }

        if (prefabToSpawn != null)
        {
            prefabToSpawn.transform.position = new Vector3(0, 1, 1);
            GameObject newObject = Instantiate(prefabToSpawn, Vector3.zero, Quaternion.identity);
            newObject.name = $"Object_{currentObjectIndex}";
        }
    }
}