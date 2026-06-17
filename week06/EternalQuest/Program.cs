// Creativity: I added a level system based on the user's score.
// The user receives different titles as they earn more points,
// such as New Adventurer, Beginner Hero, Disciple, Goal Master,
// and Eternal Champion.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}