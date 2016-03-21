using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour 
{
	public GameObject enemy;
	GameObject[] spawnPoints;
	public GameObject Boss;
	public int EnemiesToKillForBoss = 3;
	public float waveInterval;
	int enemiesToSpawn = 1;
	float nextWave;
	
	
	bool didSpawnBoss;
	
	// Use this for initialization
	void Start () 
	{
		spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(didSpawnBoss)
		{
			return;
		}
		
		if(Enemy.EnemiesKilled >= EnemiesToKillForBoss)
		{
			Instantiate(Boss, Boss.transform.position, Boss.transform.rotation);
			didSpawnBoss = true;
		}
		
		if(Time.time > nextWave)
		{
			SpawnWave();
			
			nextWave = Time.time + waveInterval;
		}
	}
	
	void SpawnWave()
	{
		for (int i = 0; i < enemiesToSpawn; i++) 
		{
			if(i > spawnPoints.Length - 1)
			{
				break;
			}
			
			GameObject clone = (GameObject)Instantiate(enemy, spawnPoints[i].transform.position, enemy.transform.rotation);
			clone.name = enemy.name;
		}
		
		enemiesToSpawn++;
	}
	
	void SpawnEnemy()
	{
		Vector3 SpawnPos = spawnPoints[Random.Range(0,spawnPoints.Length)].transform.position;
		GameObject clone = (GameObject)Instantiate(enemy, SpawnPos, enemy.transform.rotation);
		clone.name = enemy.name;
	}
}
