namespace HeroQuestTextAdventureUI.GameFunctions;

public static class StatGeneration
{
    public static int GenerateRandomHealth()
    {
        return Random.Shared.Next(75, 101);
    }

    public static int GenerateRandomHeroAttack()
    {
        return Random.Shared.Next(20, 36);
    }

    public static int GenerateRandomEnemyAttack()
    {
        return Random.Shared.Next(5, 16);
    }
}