// For creativity I added GetLevel() and DisplayScore() so that as users earn points, they can level up.
// Each level requires a certain number of cumulative points. It then displays the level whenever you show the score.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}