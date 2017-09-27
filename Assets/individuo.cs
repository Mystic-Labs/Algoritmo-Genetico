using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class individuo : MonoBehaviour
{
	public static int Cromossomo = 10;
	//public GameObject Modelo;
	public int vagas;
	public Gene[] CadeiaGenes;
	public GameObject Self;
	public Gene raiz;

	public individuo ()
	{
		//Self = new GameObject ();
		//DECLARO A QUANTIDADE DE GENES
		this.CadeiaGenes = new Gene[Cromossomo];
		vagas = Cromossomo - 1;
		inicializaRaiz ();

		inicializaCadeia ();

		//familia (raiz);
	}

	private void inicializaRaiz ()
	{
		this.CadeiaGenes [0] = new Gene (this);
		raiz = CadeiaGenes [0];
	}

	private void inicializaCadeia ()
	{
		for (int i = 1; i < Cromossomo; i++) {
			CadeiaGenes [i] = new Gene ();
		}

	}
	// Use this for initialization
	void Start ()
	{
		Transform self = GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void familia (Gene x)
	{
		if (vagas > 0) {

			int num = Random.Range (1, 3);//numero aleatorio de quantidade filhos cadidatos(1-3)
			num = (num > vagas) ? vagas : num;
			int filhoCandidato;
			int[] filhos = new int[num];// vetor que guarda a posição dos filhos candidatos ,que estão na cadeia de genes
			for (int i = 0; i < filhos.Length; i++) {//para cada um dos filhos candidatos
				filhos [i] = Random.Range (0, Cromossomo);//
				filhoCandidato = filhos [i];
				if (CadeiaGenes [filhoCandidato].Pai == null && CadeiaGenes [filhoCandidato] != raiz) {
					x.filhos.Add (CadeiaGenes [filhoCandidato]);
					CadeiaGenes [filhoCandidato].Pai = x;
					vagas--;
				} else {
					i--;
					continue;
				}
			}
			foreach (var filho in filhos) {
				familia (CadeiaGenes [filho]);
			}
		}

	}
}
