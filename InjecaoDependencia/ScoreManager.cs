public class ScoreManager
{
    private readonly InterfaceScoreService _scoreService;

    public ScoreManager(InterfaceScoreService scoreService)
    {
        _scoreService = scoreService;
    }

    public void AddPoints(string player, int points)
    {
        _scoreService.AddScore(player, points);
    }

    public void ShowScores()
    {
        _scoreService.DisplayScores();
    }
}
