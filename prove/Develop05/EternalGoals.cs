public class EternalGoals : Goals
{
    public EternalGoals(string goalName, string description, int score): base(goalName, description, score, false)
    {

    }
    public override int GetBonusScore()
    {
    return 0;
    }

    public override void DisplayGoal(int position)
    {
        Console.WriteLine($"{position}. [] {_goalName} ({_description})");
    }
    public override string ToCSVRecord()
    {
        return $"EternalGoal:{base.ToCSVRecord()},{_isComplete}";
    }
    public override string GetGoalType()
    {
        return "EternalGoal";
    }
    public override void CompleteGoal()
    {
        _isComplete = false;
    }

}