using System;

namespace week9{

    class Program{

        static void Main(string[] args){
            var setOfDie2 = Dice.GroupBy(die => die.Value)
                                .Select(die => {
                return new {
                    Value = die.Key,
                    Count = die.Count(),
                    Score = die.Key * die.Count()
                };
            }).OrderBy(Die => Die.Value);
            
        }



    }





}
