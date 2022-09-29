public class App {
    public static void main(String[] args) throws Exception {
        int[] p1 = {7,1,5,3,6,4};
        int[] p2 = {7,6,4,3,1};
        int[] p3 = {1,4,1,4,3,1};
        int[] p4 = {2,1,2,0,1};

        System.out.println(Solution.maxProfit(p1));
        System.out.println(Solution.maxProfit(p2));
        System.out.println(Solution.maxProfit(p3));
        System.out.println(Solution.maxProfit(p4));
    }
}
