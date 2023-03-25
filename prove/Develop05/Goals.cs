public abstract class Goals
{
    protected int _score;
    protected string _goalName;
    protected string _description;
    protected bool _isComplete;


    public Goals(string goalName, string description, int score, bool isComplete)
    {
        _goalName = goalName;
        _description = description;
        _score = score;
        _isComplete = isComplete;
    }
    public abstract void DisplayGoal(int position);
    public abstract string GetGoalType();
    public abstract void CompleteGoal();
    public abstract int GetBonusScore();
    public virtual string ToCSVRecord()
    {

        return $"{_goalName},{_description},{_score}";
    }
    public virtual int GetScore()
    {
        return _score;
    }
    public virtual string GetGoalName()
    {
        return _goalName;
    }
    public virtual bool GetisComplete()
    {
        return _isComplete;
    }
}