package Player;

public class Player implements Comparable<Player> {
    private String name;
    private double points;

    public Player(String name, double points) {
        this.name = name;
        this.points = points;
    }

    // Getters
    public String getName() {
        return name;
    }

    public double getPoints() {
        return points;
    }

    // Setters
    public void setName(String name) {
        this.name = name;
    }

    public void setPoints(double points) {
        this.points = points;
    }

    //Override
    @Override
    public int compareTo(Player other) {
        return Double.compare(this.points, other.points);
    }
}
