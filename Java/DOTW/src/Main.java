import Player.Player;
import Team.Team;

public class Main {
    public static void main(String[] args) {
        Player[] team = Team.getTeam();

        double best = Team.bestScore(team);
        System.out.println("The best possible score for the team would be: " + best);
    }


}
