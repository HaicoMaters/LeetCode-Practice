// Last updated: 17/09/2025, 12:03:36
public class Food{
    public string name;
    public string cuisine;
    public int rating;

    public Food(string Name, string Cuisine, int Rating)
    {
        name = Name;
        cuisine = Cuisine;
        rating = Rating;
    }
}

public class FoodComparer : IComparer<Food>{
    public int Compare(Food a, Food b)
    {
        if (a.rating != b.rating)
        {
            return b.rating.CompareTo(a.rating);
        }
        return a.name.CompareTo(b.name);
    }
}

public class FoodRatings {
    Dictionary<string, Food> nameToFood;
    Dictionary<string, SortedSet<Food>> cuisineToFoods;

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) {
        nameToFood = new Dictionary<string, Food>();
        cuisineToFoods = new Dictionary<String, SortedSet<Food>>();

        for (int i = 0; i < foods.Length; i++)
        {
            Food f = new Food(foods[i], cuisines[i], ratings[i]);
            nameToFood[foods[i]] = f;

            if (!cuisineToFoods.ContainsKey(cuisines[i]))
            {
                cuisineToFoods[cuisines[i]] = new SortedSet<Food>(new FoodComparer());
            }
            cuisineToFoods[cuisines[i]].Add(f);
        }
    }
    
    public void ChangeRating(string food, int newRating) {
        Food f = nameToFood[food];
        var set = cuisineToFoods[f.cuisine];
        set.Remove(f);
        f.rating = newRating;
        set.Add(f);
    }
    
    public string HighestRated(string cuisine) {
        return cuisineToFoods[cuisine].Min.name;
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */