using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum BlockColorName
{
	ROJO,
	VERDE,
	AZUL,
	PURPLE,
	AMARILLO,
	NARANJA,
	BROWN,
	LIMA,
	MAGENTA,
	OLIVA,
	ROSA,
	VERDEAZULADO,
	TERRACOTA,
	TURQUESA,
	VERDEAGUA,
	BEIGE,
	CREMA,
	CARMESI,
	DORADO,
    BRONCE,
    MANDARINA,
	CIRUELA,
	VERDESECO,
	SCARLET,
	SILVER,
	SKYBLUE,
	MUSTARD,
	NAVYBLUE,
	OCHRE,
	MOSS,
	MAUVE,
	MAROOM,
	LILAC,
	LEMONADE,
	LAVENDER,
	KELLYGREEN,
	GREY,
	INDIGO,
	JETBACK,
	EMERALD,
	BLUSH,
	CHARTREUSE,
	AMBER,
	AGUAMARINA,
	CRUDO,
	CHESTNUT,
	CORAL,
    VERDEMAR,
	FUCHSIA,
    BOSQUE,
    MENTA
}

public class GameBlockColors : MonoBehaviour 
{
	public List <colorData> DarkThemeBlockColorData  = new List<colorData>();
	public List <colorData> LightThemeBlockColorData  = new List<colorData>();


	public static GameBlockColors instance;

	void Awake()
	{
		if (instance == null) {
			instance = this;
			return;
		}
		Destroy (gameObject);
	}
}

[System.Serializable]
public class colorData
{
	public BlockColorName blockColorName;
	public Color color;
}
