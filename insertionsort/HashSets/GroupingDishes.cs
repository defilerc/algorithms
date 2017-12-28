using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo
{
    public class GroupingDishes
    {
        public string[][] groupingDishes(string[][] dishes) {

            var ingredients = new SortedDictionary<string, List<string>>(StringComparer.Ordinal);
    
            for (var i = 0; i < dishes.Length; i++) {
                for (var j = 1; j < dishes[i].Length; j++) {
                    var ingredient = dishes[i][j];
                    var dish = dishes[i][0];

                    if (!ingredients.ContainsKey(ingredient)) {
                        ingredients[ingredient] = new List<string>();
                    }

                    ingredients[ingredient].Add(dish);
                }
            }
    
            var output = new List<string[]>();
    
            foreach (var ingredient in ingredients) {
                if (ingredient.Value.Count < 2) {
                    continue;
                }

                var outputrow = new List<string> {ingredient.Key};
                outputrow.AddRange(ingredient.Value.OrderBy(i => i));
        
                output.Add(outputrow.ToArray());
            }
    
            return output.ToArray();
        }

    }
}
