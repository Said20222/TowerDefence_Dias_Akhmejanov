using UnityEngine;

public abstract class EnemyFactory
{
    public abstract IEnemy CreateWarrior();
    public abstract IEnemy CreateDragon();
    public abstract IEnemy CreateBoss();
}
