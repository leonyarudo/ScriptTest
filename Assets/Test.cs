 using UnityEngine;
using System.Collections;

public class Boss {
	private int hp = 100;
	private int power = 25;
	private int mp = 53;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage) {
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}
	public void Magic (int MP){
		if (mp >= MP) {
			mp = mp - MP;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		}
			else{
			Debug.Log ("MPが足りないため魔法が使えない。");
			}
		}
}
public class Test : MonoBehaviour {

	void Start () {
		Boss lastboss = new Boss ();

		lastboss.Attack();
		lastboss.Defence(3);
		for(int b = 0; b < 11 ;b++)
		lastboss.Magic(7);
		/*
		int[] arrey = { 1, 2, 3, 4, 5 };
		for (int a = 0; a < arrey.Length; a++) {
			Debug.Log (arrey [a]);
		}
			for (int a = 0; a < arrey.Length; a++) {
			Debug.Log (arrey [arrey.Length - a - 1]);
		}
		*/
	}
	void Update () {

	}
}