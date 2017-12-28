using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class GroupingDishesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new GroupingDishes();

            string[][] dishes = {
                new[] {"Salad", "Tomato", "Cucumber", "Salad", "Sauce"},
                new[] {"Pizza", "Tomato", "Sausage", "Sauce", "Dough"},
                new[] {"Quesadilla", "Chicken", "Cheese", "Sauce"},
                new[] {"Sandwich", "Salad", "Bread", "Tomato", "Cheese"}
            };

            var result = algo.groupingDishes(dishes);

            string[][] dishes1 = {
                new[] {"Cake", "Chocolate", "Biscuit", "Cream"},
                new[] {"Pavlova", "Strawberry", "Cream"},
                new[] {"Kormos", "Chocolate"},
                new[] {"Amethstos", "Karavopano", "Chocolate"},
                new[] {"Delphini", "Cream", "Biscuit"},
                new[] {"Delphini1", "Cream", "Biscuit"},
                new[] {"Delphini2", "Cream", "Biscuit"}
            };

            result = algo.groupingDishes(dishes1);
        }
    }
}
