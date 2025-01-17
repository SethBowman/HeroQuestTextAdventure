using HeroQuestTextAdventureUI.Character;

namespace HeroQuestTextAdventureUI.GameFunctions;

public static class Game
{
    public static void RunGame()
    {
        UserInteraction.GameDialogue("Welcome to Hero Quest!\nLet's start off by getting your adventurer's name.");
        var hero = new Hero();
        hero.Name = UserInteraction.GetUserInput("Enter the name of your character:");
        hero.Health = StatGeneration.GenerateRandomHealth();
        hero.AttackDamage = StatGeneration.GenerateRandomHeroAttack();
        
        UserInteraction.GameDialogue($"Hello {hero.Name}, I see you're new around here.");
        UserInteraction.GameDialogue("Would you like to ask me something?");
        UserInteraction.PlayerInquiry(new string[] {"Who are you?", "What is this place?", "Goodbye"}, new string[] {"I am Captain of the Watch, protector of this village.", "This is the peaceful village of Arroyo, but danger lurks nearby.."});
        Thread.Sleep(2000);
        
        UserInteraction.GameDialogue("You sense a strange presence nearby..");
        Thread.Sleep(2000);

        var darkKnight = new Enemy();
        darkKnight.Name = "Dark Knight";
        darkKnight.Health = StatGeneration.GenerateRandomHealth();
        darkKnight.AttackDamage = StatGeneration.GenerateRandomEnemyAttack();
        
        Combat.HeroVsSingleEnemy(hero, darkKnight);
        
        UserInteraction.GameDialogue("You have survived! You are a hero!");
    }
}