public class SinglePlayerService : InterfaceScoreService
{
    private int _score = 0;

    public void AddScore(string player, int points)
    {
        _score += points;
        Console.WriteLine($"{player} ganhou {points} pontos. Pontuação total: {_score}");
    }

    public void DisplayScores()
    {
        Console.WriteLine($"Pontuação total: {_score}");
    }
}
