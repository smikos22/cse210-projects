public abstract class Goals
{
    public int _score;
    protected string _goalName;
    protected string _description;
    protected bool _isComplete;


    public Goals(string goalName, string description, int score)
    {
        _goalName = goalName;
        _description = description;
        _score = score;
        _isComplete = false;
    }
    public abstract void DisplayGoal(int position);
    

    public virtual string ToCSVRecord()
    {

    return $"{_goalName}, {_description}, {_score}";
    }
}