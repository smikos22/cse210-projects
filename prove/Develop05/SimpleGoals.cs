public class SimpleGoals : Goals
{
    public SimpleGoals(string goalName, string description, int score): base(goalName, description, score)
    {

    }

    public void ShowGoal()
    {
        Console.WriteLine($"{_goalName}: {_description}");
        Console.WriteLine($"Worth {_score} points");
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
        Console.WriteLine($"{position}. [{mark}] {_goalName} ({_description})");
    }
    public override string ToCSVRecord()
    {
        return $"{base.ToCSVRecord()}";
    }

}