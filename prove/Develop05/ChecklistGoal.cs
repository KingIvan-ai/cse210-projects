public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _requiredAmount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int requiredAmount, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _requiredAmount = requiredAmount;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int requiredAmount, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _requiredAmount = requiredAmount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _requiredAmount)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _requiredAmount;
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_name} ({_description}) -- Completed {_amountCompleted}/{_requiredAmount} times";
        }
        else
        {
            return $"[ ] {_name} ({_description}) -- Completed {_amountCompleted}/{_requiredAmount} times";
        }
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_requiredAmount}|{_bonus}|{_amountCompleted}";
    }
}