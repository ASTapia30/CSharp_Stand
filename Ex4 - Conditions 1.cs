/*EXERCISE 4
Instructions
In this exercise, you'll be implementing the quest logic for a new RPG game a friend is developing.

The game's main character is Annalyn, a brave girl with a fierce and loyal pet dog. Unfortunately, 
disaster strikes, as her best friend was kidnapped while searching for berries in the forest.

Annalyn will try to find and free her best friend, optionally taking her dog with her on this quest.

After some time spent following her best friend's trail, she finds the camp in which her best friend is 
imprisoned. It turns out there are two kidnappers: a mighty knight and a cunning archer.

Having found the kidnappers, Annalyn considers which of the following actions she can engage in:

Fast attack:    a fast attack can be made if the knight is sleeping, as it takes time for him to get his 
                armor on, so he will be vulnerable.

Spy:            the group can be spied upon if at least one of them is awake. Otherwise, spying is a waste 
                of time.

Signal prisoner: the prisoner can be signalled using bird sounds if the prisoner is awake and the archer 
                is sleeping, as archers are trained in bird signaling so they could intercept the message.

Free prisoner:  if the prisoner is awake and the other two characters are sleeping, a sneaky entry into
                the camp can free the prisoner. This won't work if the prisoner is sleeping, as the prisoner 
                will be startled by the sudden appearance of her friend and the knight and archer will be 
                awoken. The prisoner can also be freed if the archer is sleeping and Annalyn has her pet 
                dog with her, as the knight will be scared by the dog and will withdraw, and the archer 
                can't equip his bow fast enough to prevent the prisoner from being freed.

You have four tasks: to implement the logic for determining if the above actions are available based on 
the state of the three characters found in the forest and whether Annalyn's pet dog is present or not.

-->Task 1
    Check if a fast attack can be made

    Implement the (static) QuestLogic.CanFastAttack() method that takes a boolean value that indicates 
    if the knight is awake. This method returns true if a fast attack can be made based on the state of 
    the knight. Otherwise, returns false:

    var knightIsAwake = true;
    QuestLogic.CanFastAttack(knightIsAwake);
    // => false

-->Task 2
    Check if the group can be spied upon

    Implement the (static) QuestLogic.CanSpy() method that takes three boolean values, indicating if the 
    knight, archer and the prisoner, respectively, are awake. The method returns true if the group can be 
    spied upon, based on the state of the three characters. Otherwise, returns false:

    var knightIsAwake = false;
    var archerIsAwake = true;
    var prisonerIsAwake = false;
    QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
    // => true

-->Task 3
    Check if the prisoner can be signalled

    Implement the (static) QuestLogic.CanSignalPrisoner() method that takes two boolean values, 
    indicating if the archer and the prisoner, respectively, are awake. The method returns true if 
    the prisoner can be signalled, based on the state of the two characters. Otherwise, returns false:

    var archerIsAwake = false;
    var prisonerIsAwake = true;
    QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);
    // => true

-->Task 4
    Check if the prisoner can be freed
    
    Implement the (static) QuestLogic.CanFreePrisoner() method that takes four boolean values. 
    The first three parameters indicate if the knight, archer and the prisoner, respectively, are awake. 
    The last parameter indicates if Annalyn's pet dog is present. The method returns true if the prisoner 
    can be freed based on the state of the three characters and Annalyn's pet dog presence. Otherwise, 
    it returns false:

    var knightIsAwake = false;
    var archerIsAwake = true;
    var prisonerIsAwake = false;
    var petDogIsPresent = false;
    QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);
    // => false
**/




using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake == false){
            return true;
        }
        else{
            return false;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true){
            return true;
        }
        else{
            return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (archerIsAwake == false && prisonerIsAwake == true){
            return true;
        }
        else{
            return false;
        }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (prisonerIsAwake == true && knightIsAwake == false && archerIsAwake == false){
            return true;
        }
        else if (archerIsAwake == false && petDogIsPresent == true){
            return true;
        }
        else{
            return false;
        }
    }
}