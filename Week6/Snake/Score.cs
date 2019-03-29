namespace Snake
{
    public class Score
    {
        public int score;
        Worm worm;
        Food food;

        public Score()
        {
            score = 0;
            worm = new Worm('0');
            food = new Food('F');
        }

        public int GetScore()
        {
            if (worm.CheckIntersection(food.body[0]))
            {
                score += 10;
            }
            return score;
        }
    }
}
