using RosterManager;

internal class Team
{
    private string teamName;
    private List<Player> players;
    private static int playerCount;

    public Team(string teamName)
    {
        this.teamName = teamName;
        this.players = new List<Player>();
    }

    public void AddPlayer(Player player)
    {
        players.Add(player);
        playerCount++;
    }

    public void RemovePlayer(Player player)
    {
        players.Remove(player);
        playerCount--;
    }

    public string TeamName
    {
        get { return teamName; }
        set { teamName = value; }
    }

    public List<Player> Players
    {
        get { return players; }
        set { players = value; }
    }

    public static int PlayerCount
    {
        get { return playerCount; }
    }

    public void PrintPlayers()
    {
        foreach (var player in players)
        {
            Console.WriteLine($"{player.Name}, {player.Position}, {player.JerseyNumber}, {player.Age}");
        }
    }
}
