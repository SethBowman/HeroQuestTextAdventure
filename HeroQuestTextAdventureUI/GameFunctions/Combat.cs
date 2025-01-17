using HeroQuestTextAdventureUI.Character;

namespace HeroQuestTextAdventureUI.GameFunctions;

public static class Combat
{
    public static void HeroVsSingleEnemy(Hero hero, Enemy enemy)
    {
        while (hero.Health > 0 && enemy.Health > 0)
        {
            UserInteraction.GameDialogue($"\n{hero.Name} (Health: {hero.Health}, Attack: {hero.AttackDamage}) vs {enemy.Name} (Health: {enemy.Health}, Attack: {enemy.AttackDamage})");
            Thread.Sleep(5000);
            
            UserInteraction.GameDialogue($"\n{hero.Name} attacks {enemy.Name}");
            enemy.TakeDamage(hero.Attack());
            UserInteraction.GameDialogue($"{enemy.Name} has {enemy.Health} health remaining.");
            Thread.Sleep(5000);

            if (enemy.Health <= 0)
            {
                UserInteraction.GameDialogue($"{enemy.Name} has been defeated!");
                Thread.Sleep(5000);
                break;
            }
            
            UserInteraction.GameDialogue($"\n{enemy.Name} attacks {hero.Name}");
            hero.TakeDamage(enemy.Attack());
            UserInteraction.GameDialogue($"{hero.Name} has {hero.Health} health remaining.");
            Thread.Sleep(5000);

            if (hero.Health <= 0)
            {
                UserInteraction.GameDialogue($"{hero.Name} has been defeated!");
                Thread.Sleep(5000);
                break;
            }
        }
    }
}