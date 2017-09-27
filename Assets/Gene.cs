using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gene : MonoBehaviour
{

	public GameObject Modelo;

	public ArrayList filhos;

	public Gene Pai;

	public Gene (Gene Pai)
	{
		this.Pai = Pai;
		filhos = new ArrayList ();
	}

	public void Start ()
	{
		instanciaModelo ();
		filhos = new ArrayList ();
	}

	public GameObject procuraModelo ()
	{
		return (GameObject)Resources.Load ("modelos/capsula", typeof(GameObject));
	}

	public Gene ()
	{
		
		filhos = new ArrayList ();
	}

	public Gene (individuo Individuo)
	{
		
	}

	public void adicionaFilho (Gene novoFilho)
	{
		filhos.Add (novoFilho);
	}

	private void instanciaModelo ()
	{
		this.Modelo = GameObject.Instantiate (Modelo, Pai.Modelo.transform);
	}



}
