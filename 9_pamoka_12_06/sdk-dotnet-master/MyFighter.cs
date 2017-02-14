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
        List<Move> oppMoves = new List<Move>();
        int[] ataks;
        int[] defens;
        public Move MakeNextMove(Move opponentsLastMove, int myLastScore, int opponentsLastScore)
        {
            var areas = new[] { Area.Belly, Area.Nose, Area.Groin, Area.Jaw, Area.Legs };
            Move move = new Move();
            double random1 = new Random().NextDouble();
            double random2 = new Random().NextDouble();
            double random3 = new Random().NextDouble();
            if (opponentsLastMove == null)
            {
                return move.AddAttack(Area.Jaw).AddAttack(Area.Belly).AddDefence(Area.Nose);
            }
            else
            {
                oppMoves.Add(opponentsLastMove);

                /*ataks[0] = oppMoves.SelectMany(lst => lst.Attacks).Count(a => a == Area.Nose);
                ataks[1] = oppMoves.SelectMany(lst => lst.Attacks).Count(a => a == Area.Jaw);
                ataks[2] = oppMoves.SelectMany(lst => lst.Attacks).Count(a => a == Area.Belly);
                ataks[3] = oppMoves.SelectMany(lst => lst.Attacks).Count(a => a == Area.Groin);
                ataks[4] = oppMoves.SelectMany(lst => lst.Attacks).Count(a => a == Area.Legs);

                defens[0] = oppMoves.SelectMany(lst => lst.Defences).Count(a => a == Area.Nose);
                defens[1] = oppMoves.SelectMany(lst => lst.Defences).Count(a => a == Area.Jaw);
                defens[2] = oppMoves.SelectMany(lst => lst.Defences).Count(a => a == Area.Belly);
                defens[3] = oppMoves.SelectMany(lst => lst.Defences).Count(a => a == Area.Groin);
                defens[4] = oppMoves.SelectMany(lst => lst.Defences).Count(a => a == Area.Legs);*/


                if(opponentsLastMove.Attacks.Contains(Area.Jaw) && (random1 > 0.3))
                {
                    move.AddDefence(Area.Jaw);
                }       
                else if(opponentsLastMove.Attacks.Contains(Area.Belly) && (random1 > 0.6))
                {
                    move.AddDefence(Area.Belly);
                }
                else if (opponentsLastMove.Attacks.Contains(Area.Belly) && (random1 > 0.9))
                {
                    move.AddDefence(Area.Groin);
                }
                else
                {
                    move.AddDefence(Area.Nose);
                }

                if(opponentsLastMove.Defences.Contains(Area.Nose) && (random2 < 0.8))
                {
                    if (opponentsLastMove.Defences.Contains(Area.Jaw) && (random2 < 0.8))
                    {
                        move.AddAttack(Area.Belly);
                    }
                    else
                    {
                        move.AddAttack(Area.Jaw);
                    }
                }
                else
                {
                    move.AddAttack(Area.Nose);
                }

                if (opponentsLastMove.Defences.Contains(Area.Nose) && (random3 < 0.3))
                {
                    if (opponentsLastMove.Defences.Contains(Area.Jaw) && (random3 < 0.3))
                    {
                        if(opponentsLastMove.Defences.Contains(Area.Belly) && (random3 < 0.3))
                        {
                            move.AddAttack(Area.Groin);
                        }
                        else
                        {
                            move.AddAttack(Area.Belly);
                        }
                    }
                    else
                    {
                        move.AddAttack(Area.Jaw);
                    }
                }
                else
                {
                    move.AddAttack(Area.Nose);
                }
                return move;
            }
           

           
           /*if(opponentsLastMove == null)
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
                    if (_random.NextDouble() < 0.2)
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
            }*/
        }
    }
}
