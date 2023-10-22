package Player;

public class Player implements Comparable<Player> {
    private double points = 0;

    public Player(double points) {
        this.points = points;
    }

    // Getters
    public double getPoints() {
        return points;
    }

    // Setters
    public void setPoints(double points) {
        this.points = points;
    }

    //Override
    @Override
    public int compareTo(Player other) {
        return Double.compare(this.points, other.points);
    }
}
