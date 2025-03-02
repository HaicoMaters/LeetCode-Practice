public class Twitter {

    public class Tweet
    {
        public int tweetId {get; set;}
        public int date {get; set;}

        public Tweet(int _tweetId, int _date)
        {
            tweetId = _tweetId;
            date = _date;
        }
    }

    Dictionary<int, List<Tweet>> tweets {get; set;}
    Dictionary<int, HashSet<int>> following {get; set;} // Make so follower ids are unique (User, the who are following)
    // Implemented based on who a user is following rather than who follows a user for the specific problem requirements
    int nextDate {get; set;} // For recency without extra steps of using datetime

    public Twitter() {
       tweets = new Dictionary<int, List<Tweet>>();
       following = new Dictionary<int, HashSet<int>>();
       nextDate = 0;
    }
    
    public void PostTweet(int userId, int tweetId) {
        Tweet newTweet = new Tweet(tweetId, nextDate++); // Create the new tweet object

        // Check if previous tweets requiring new entry in dict
        if (tweets.ContainsKey(userId))
        {
            // Add new tweet to existing List
            tweets[userId].Add(newTweet);
        }
        else
        {
            // Create new entry in tweets array
            List<Tweet> list = new List<Tweet>();
            list.Add(newTweet);
            tweets.Add(userId, list);
        }
    }
    
    public IList<int> GetNewsFeed(int userId) 
    {
        List<int> newsFeed= new List<int>();

        // Use priority queue to get feed
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        // Fill prority queue with possible tweets
        if (following.ContainsKey(userId))
        {
            // Get possible tweets for each user that is followed
            var followees = following[userId];
            var followeeTweets = new List<Tweet>();

            foreach (var followee in followees)
            {
                if(tweets.ContainsKey(followee))
                {
                    // Get the 10 most recently added (10 tweets at the end) of the list
                    int n = tweets[followee].Count;
                    var possibleTweets = tweets[followee].GetRange(Math.Max(0, n - 10), Math.Min(10, n));
                    followeeTweets.AddRange(possibleTweets);
                }
            }

            // Add tweets to priority queue
            foreach (var tweet in followeeTweets)
            {
                pq.Enqueue(tweet.tweetId, tweet.date * - 1); // *-1 so we can use dequeue effectively
            }  
        }

        // Add users own tweets to feed
        if (tweets.ContainsKey(userId))
        {
            int n = tweets[userId].Count;
            var userTweets = tweets[userId].GetRange(Math.Max(0, n - 10), Math.Min(10, n));
            foreach (var tweet in userTweets)
            {
                pq.Enqueue(tweet.tweetId, tweet.date * - 1);
            }
        }

        // Add from queue to the feed
        while (pq.Count > 0 && newsFeed.Count < 10)
        {
            newsFeed.Add(pq.Dequeue());
        }

        return newsFeed;
    }
    
    public void Follow(int followerId, int followeeId) {
        if(followerId == followeeId) return; // Cannot follow self

        // Check if need new entry in dict
        if (following.ContainsKey(followerId))
        {
            // Add to following list
            following[followerId].Add(followeeId);
        }
        else
        {
            // Create new entry

            following.Add(followerId, new HashSet<int>(){followeeId});
        }
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if(following.ContainsKey(followerId))
        {
            following[followerId].Remove(followeeId);
        }
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */