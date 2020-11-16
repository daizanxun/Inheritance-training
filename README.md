# Inheritance-training

This is a simple text game.
There are fighters and weapons. there are different types of Fighter and weapon.
Fighters have basic attack and skill attack. skill attack is calculated by (basic attach)*multiplier and it has cooldown time
Weapon has min and max attack.
Fighters will enter battle with weapon and take turns to attack each other. When either of the fighter's Hp reach to zero or less, the other fighter is the winner.

Task 1:
Write 1 unitest of BattleEngine.Battle method.

Task 2:
Add Interfaces to the classes to declare expected methods and properties

Task 3
Write 1 unittest of battleEngine.Battle method after you have something like public IFighter Battle(IFighter f1, IFighter f2)

Task 4:
move common actions or definitions to base class if it makes sense.

change whatever you like to the classes
for example, 
you may want to change the constructor of fighter class, to take Skill and Weaspon as parameters
you may want to make factories to initialize skills, fighters, weapons.

have fun.

