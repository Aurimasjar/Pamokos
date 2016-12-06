using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFights.model;

namespace CodeFights
{
    class MyFighter : IFighter
    {
        private readonly Random _random = new Random();
        public Move MakeNextMove(Move opponentsLastMove, int myLastScore, int opponentsLastScore)
        {
            var areas = new[] { Area.Belly, Area.Nose, Area.Groin, Area.Jaw, Area.Legs };
            Move move = new Move();
           if(opponentsLastMove == null)
            {
                return move.AddAttack(Area.Jaw).AddAttack(Area.Belly).AddDefence(Area.Nose);
            }
            else
            {

                if (opponentsLastMove.Attacks.Contains(Area.Nose))
                {
                    move.AddDefence(Area.Nose);
                }
                else
                {
                    var area = areas[_random.Next(5)];
                    if (_random.NextDouble() < 0.4)
                    {
                        move.AddDefence(area);
                    }
                    else
                    {
                        move.AddDefence(Area.Jaw);
                    }
                    //move.AddDefence(Area.Jaw);
                }

                if (!opponentsLastMove.Defences.Contains(Area.Nose))
                {
                    move.AddAttack(Area.Nose);
                }
                else
                {
                    move.AddAttack(Area.Jaw);
                }

                if (!opponentsLastMove.Defences.Contains(Area.Jaw))
                {
                    move.AddAttack(Area.Jaw);
                }
                else
                {
                    move.AddAttack(Area.Belly);
                }

                return move;
            }
        }
    }
}
