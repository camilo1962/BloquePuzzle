using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Records : MonoBehaviour
{
    int recordClasico;
    public TMP_Text _recordClasico;
    int recordExtras;
    public TMP_Text _recordExtras;
    int recordBombas;
    public TMP_Text _recordBombas;
    int recordTiempo;
    public TMP_Text _recordTiempo;
    int recordHexagonos;
    public TMP_Text _recordHexagonos;
    int recordTotal;
    public TMP_Text _recordTotal;

    private void Start()
    {
        recordTotal = recordClasico + recordExtras + recordBombas + recordTiempo + recordHexagonos;
    }

    private void Update()
    {

        recordTotal = PlayerPrefs.GetInt("bestscore_" + GameMode.classic) + PlayerPrefs.GetInt("bestscore_" + GameMode.plus) + PlayerPrefs.GetInt("bestscore_" + GameMode.bomb) + PlayerPrefs.GetInt("bestscore_" + GameMode.timer) + PlayerPrefs.GetInt("bestscore_" + GameMode.hexa);
        _recordClasico.text = PlayerPrefs.GetInt("bestscore_" + GameMode.classic).ToString();
        _recordExtras.text = PlayerPrefs.GetInt("bestscore_" + GameMode.plus).ToString();
        _recordBombas.text = PlayerPrefs.GetInt("bestscore_" + GameMode.bomb).ToString();
        _recordTiempo.text = PlayerPrefs.GetInt("bestscore_" + GameMode.timer).ToString();
        _recordHexagonos.text = PlayerPrefs.GetInt("bestscore_" + GameMode.hexa).ToString();
        _recordTotal.text = recordTotal.ToString();
    }
}
