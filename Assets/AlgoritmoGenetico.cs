using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgoritmoGenetico : MonoBehaviour
{

	public int Semente;

	public GameObject[] Populacao, PopulacaoDecendente;

	void geraPopulacao ()
	{
		individuo.Cromossomo = 10;
		Populacao = new GameObject[Semente];
	}

	void mutacao (individuo Individuo)
	{
		

	}

	void crossover (individuo Pai, individuo Mae)
	{
		individuo Filho = new individuo ();

		//TODO
		//Realizar o cruzamento:


		//return Filho;
	}

	double fitness ()
	{

		return 0;
	}

	// Use this for initialization
	void Start ()
	{
		this.Semente = Random.Range (5, 10);

		this.geraPopulacao ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
