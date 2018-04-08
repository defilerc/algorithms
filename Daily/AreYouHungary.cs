using System;
using System.Collections.Generic;
using System.Linq;

namespace Daily
{
    public class AreYouHungaryAlgo
    {
        public string[] areYouHungary(string[] chefs, string[] food, int[][] values)
        {
            var chefFoods = new int[chefs.Length]; // food made by each chef

            for (var i = 0; i < chefFoods.Length; i++) {
                chefFoods[i] = -1;
            }

            var foodList = new List<string>(food);
            var f = 0;
            while (true) {
                int foodMax = 0, foodChef = 0, foodMaxCount = 0;

                for (var c = 0; c < chefs.Length; c++) {

                    if (chefFoods[c] > 0) {
                        continue; // skip chefs already assigned to food
                    }

                    if (values[c][f] > foodMax) {
                        foodChef = c;
                        foodMaxCount = 1;
                        foodMax = values[c][f];
                    }
                    else if (values[c][f] == foodMax) {
                        foodMaxCount++;
                    }
                }

                if (foodMax > 0 && foodMaxCount == 1) {
                    chefFoods[foodChef] = f; // also remove this chef
                    foodList.RemoveAt(f);
                }

                if (!foodList.Any()) {
                    break;
                }

                f = (f + 1) % foodList.Count;
            }

            var output = new List<string>();
            for (var i = 0; i < chefs.Length; i++) {
                if (chefFoods[i] >= 0) {
                    output.Add($"{chefs[i]} - {food[chefFoods[i]]}");
                } else if (chefFoods[i] == -1) {
                    output.Add($"{chefs[i]} - Nothing");
                }
            }

            return output.Count > 0 ? output.ToArray() : new[] {"Impossible"};
        }
    }
}
