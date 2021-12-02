import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Day2 {

    public static int solveDay2A() throws FileNotFoundException {

        int horizontal = 0;
        int depth = 0;

        File file = new File("Inputs/Day2.txt");
        Scanner scanner = new Scanner(file);

        while(scanner.hasNext()){
            String[] input = scanner.nextLine().split(" ");
            String direction = input[0];
            int amount = Integer.parseInt(input[1]);

            switch (direction){
                case "forward": horizontal += amount;
                break;
                case "down": depth += amount;
                break;
                case "up": depth -= amount;
                break;
            }
        }
        return horizontal*depth;
    }

    public static int solveDay2B() throws FileNotFoundException {

        int horizontal = 0;
        int depth = 0;
        int aim = 0;

        File file = new File("Inputs/Day2.txt");
        Scanner scanner = new Scanner(file);

        while(scanner.hasNext()){
            String[] input = scanner.nextLine().split(" ");
            String direction = input[0];
            int amount = Integer.parseInt(input[1]);

            switch (direction){
                case "forward": horizontal += amount;
                if(aim != 0){
                    depth += amount*aim;
                }
                    break;
                case "down": aim += amount;
                    break;
                case "up": aim -= amount;
                    break;
            }
        }
        return horizontal*depth;
    }
}
