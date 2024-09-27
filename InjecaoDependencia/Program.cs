using System;

class Program
{
    static void Main(string[] args)
    {
        
        InterfaceScoreService scoreService = new SinglePlayerService();
        var scoreManager = new ScoreManager(scoreService);

        // Adiciona pontos para o jogador
        scoreManager.AddPoints("Player1", 10);
        scoreManager.AddPoints("Player1", 20);
        scoreManager.ShowScores();
    }
}
