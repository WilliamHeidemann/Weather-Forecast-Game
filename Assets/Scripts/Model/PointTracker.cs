using TMPro;
using UtilityToolkit.Runtime;

namespace Model
{
    public class PointTracker
    {
        private readonly Observable<int> _points;
        private readonly TextMeshProUGUI _scoreText;
        
        public PointTracker(TextMeshProUGUI scoreText)
        {
            _scoreText = scoreText;
            _points = new Observable<int>();
            _points.OnValueChanged += UpdateScoreText;
        }

        private void UpdateScoreText(int points)
        {
            _scoreText.text = $"Points [ {points.ToString()} ]";
        }

        public void AddPoints(int points)
        {
            _points.Value += points;
            StaticValues.PointsAwarded = points;
        }

        public void UpdatePoints()
        {
            StaticValues.Points += _points.Value;
        }
    }
}