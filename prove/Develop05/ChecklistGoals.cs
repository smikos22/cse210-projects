public class ChecklistGoals: Goals
{
    protected int _bonusScore;
    protected int _timesToDo;
    protected int _timesDone;
    public ChecklistGoals(string goalName, string description, int score, int bonusScore, int timesToDo, int timesDone): base(goalName, description, score, timesToDo == timesDone)
    {
        _bonusScore = bonusScore;
        _timesToDo = timesToDo;
        _timesDone = timesDone;
    }
    public override int GetBonusScore()
    {
        return _bonusScore;
    }
    public override void DisplayGoal(int position)
    {
        string mark;
        if (_isComplete == true)
        {
            mark = "X";
        }
        else
        {
            mark = " ";
        }

        Console.WriteLine($"{position}. [{mark}] {_goalName} ({_description}) -- Currently completed: {_timesDone}/{_timesToDo}");
    }
    public override string ToCSVRecord()
    {
        return $"ChecklistGoal:{base.ToCSVRecord()},{_bonusScore},{_timesToDo},{_timesDone}";
    }
    public override string GetGoalType()
    {
        return "ChecklistGoal";
    }
    public override void CompleteGoal()
    {
        _timesDone += 1;
        if (_timesDone == _timesToDo)
        {
            _isComplete = true;
        }
    }

}