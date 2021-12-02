import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class Day1 {

    public static int solveDay1A() throws FileNotFoundException {
        File file = new File("Inputs/Day1.txt");
        Scanner scanner = new Scanner(file);

        int previousNum = Integer.parseInt(scanner.nextLine());
        int increases = 0;

        while(scanner.hasNext()){

            int currentNum = Integer.parseInt(scanner.nextLine());

            if( currentNum > previousNum){
                increases++;
            }
            previousNum = currentNum;
        }
        return increases;
    }

    public static int solveDay1B() throws FileNotFoundException {
        File file = new File("Inputs/Day1.txt");
        Scanner scanner = new Scanner(file);

        int increases = 0;
        ArrayList<Integer> numbers = new ArrayList<>();

        //init
        numbers.add(Integer.parseInt(scanner.nextLine()));
        numbers.add(Integer.parseInt(scanner.nextLine()));
        numbers.add(Integer.parseInt(scanner.nextLine()));

        int previousSum = numbers.get(0) + numbers.get(1) + numbers.get(2);

        while(scanner.hasNext()){

            numbers.remove(0);
            numbers.add(Integer.parseInt(scanner.nextLine()));

            int currentSum = numbers.get(0) + numbers.get(1) + numbers.get(2);

            if( currentSum > previousSum){
                increases++;
            }
            previousSum = currentSum;
        }
        return increases;
    }
}
