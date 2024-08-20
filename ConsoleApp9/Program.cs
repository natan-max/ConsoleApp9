public enum PlayerState
{
    Idle,
    Walking,
    Running,
    // Інші стани можна додавати тут
}

class Player
{
    // Словник для зберігання швидкості для кожного стану
    private Dictionary<PlayerState, double> stateSpeeds;

    private PlayerState state;
    public PlayerState State
    {
        get => state;
        set => state = value;  // Просто встановлює стан
    }

    public double Speed => stateSpeeds[state]; // Автоматично отримує швидкість із словника для поточного стану

    // Конструктор, який приймає словник швидкостей для кожного стану
    public Player(Dictionary<PlayerState, double> stateSpeeds, PlayerState initialState)
    {
        this.stateSpeeds = stateSpeeds;
        State = initialState;
    }
}
