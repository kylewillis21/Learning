package Team;

import Player.*;

import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class Team {
    public static Player[] getTeam() {
        Scanner scanner = new Scanner(System.in);

        System.out.print("How many Quarterbacks on the team?: ");
        int numQbs = scanner.nextInt();

        System.out.print("How many Runningbacks on the team?: ");
        int numRbs = scanner.nextInt();

        System.out.print("How many Wide Receivers on the team?: ");
        int numWrs = scanner.nextInt();

        System.out.print("How many Tight Ends on the team?: ");
        int numTes = scanner.nextInt();

        System.out.print("How many Defenses on the team?: ");
        int numDef = scanner.nextInt();

        System.out.print("How many Kickers on the team?: ");
        int numKs = scanner.nextInt();

        Player[] team = new Player[numQbs + numRbs + numWrs + numTes + numDef + numKs];

        for (int i = 1; i <= numQbs; i++) {
            System.out.print("Enter how many points Quarterback #" + i + " had: ");
            double points = scanner.nextDouble();

            team[i - 1] = new Quarterback(points);
        }

        for (int i = 1; i <= numRbs; i++) {
            System.out.print("Enter how many points Runningback #" + i + " had: ");
            double points = scanner.nextDouble();

            team[numQbs + i - 1] = new Runningback(points);
        }

        for (int i = 1; i <= numWrs; i++) {
            System.out.print("Enter how many points Wide Receiver #" + i + " had: ");
            double points = scanner.nextDouble();

            team[numQbs + numRbs + i - 1] = new WideReceiver(points);
        }

        for (int i = 1; i <= numTes; i++) {
            System.out.print("Enter how many points Tight End #" + i + " had: ");
            double points = scanner.nextDouble();

            team[numQbs + numRbs + numWrs + i - 1] = new TightEnd(points);
        }

        for (int i = 1; i <= numDef; i++) {
            System.out.print("Enter how many points Defense #" + i + " had: ");
            double points = scanner.nextDouble();

            team[numQbs + numRbs + numWrs + numTes + i - 1] = new Defense(points);
        }

        for (int i = 1; i <= numKs; i++) {
            System.out.print("Enter how many points Kicker #" + i + " had: ");
            double points = scanner.nextDouble();

            team[numQbs + numRbs + numWrs + numTes + numDef + i - 1] = new Kicker(points);
        }

        return team;
    }

    public static double bestScore(Player[] team) {
        double qb = 0;
        double rb1 = 0;
        double rb2 = 0;
        double wr1 = 0;
        double wr2 = 0;
        double te = 0;
        double def = 0;
        double k = 0;
        double flex = 0;

        Arrays.sort(team, Collections.reverseOrder());

        // Need to start finding all the top players scores
        // Creating checks for what positions still need done
        boolean qbdone = false;
        boolean rb1done = false;
        boolean rb2done = false;
        boolean wr1done = false;
        boolean wr2done = false;
        boolean tedone = false;
        boolean flexdone = false;
        boolean defdone = false;
        boolean kdone = false;

        for (Player player : team) {
//            System.out.println(player.getClass());
            if (player.getClass() == Quarterback.class && !qbdone) {
                qb = player.getPoints();
                qbdone = true;
                System.out.println("QB: " + player.getPoints());
            }
            else if (player.getClass() == Runningback.class && !rb1done) {
                rb1 = player.getPoints();
                rb1done = true;
                System.out.println("RB1: " + player.getPoints());
            }
            else if (player.getClass() == Runningback.class && !rb2done) {
                rb2 = player.getPoints();
                rb2done = true;
                System.out.println("RB2: " + player.getPoints());
            }
            else if (player.getClass() == WideReceiver.class && !wr1done) {
                wr1 = player.getPoints();
                wr1done = true;
                System.out.println("WR1: " + player.getPoints());
            }
            else if (player.getClass() == WideReceiver.class && !wr2done) {
                wr2 = player.getPoints();
                wr2done = true;
                System.out.println("WR2: " + player.getPoints());
            }
            else if (player.getClass() == TightEnd.class && !tedone) {
                te = player.getPoints();
                tedone = true;
                System.out.println("TE: " + player.getPoints());
            }
            else if (player.getClass() == Defense.class && !defdone) {
                def = player.getPoints();
                defdone = true;
                System.out.println("DEF: " + player.getPoints());
            }
            else if (player.getClass() == Kicker.class && !kdone) {
                k = player.getPoints();
                kdone = true;
                System.out.println("K: " + player.getPoints());
            }
            else if (!flexdone && (player.getClass() == Runningback.class || player.getClass() == WideReceiver.class || player.getClass() == TightEnd.class)) {
                flex = player.getPoints();
                flexdone = true;
                System.out.println("FLEX: " + player.getPoints());
            }
        }



        return qb + rb1 + rb2 + wr1 + wr2 + te + def + k + flex;
    }
}
