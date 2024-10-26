using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> _scores;

    // Конструктор, який приймає список балів
    public HighScores(List<int> scores)
    {
        _scores = scores;
    }

    // Повертає всі бали
    public List<int> Scores()
    {
        return new List<int>(_scores);
    }

    // Повертає останній доданий бал
    public int Latest()
    {
        return _scores.Last();
    }

    // Повертає найвищий бал
    public int PersonalBest()
    {
        return _scores.Max();
    }

    // Повертає три найвищі бали у порядку спадання
    public List<int> PersonalTopThree()
    {
        return _scores.OrderByDescending(score => score).Take(3).ToList();
    }
}