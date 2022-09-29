class Solution {
    public static int maxProfit(int[] prices) {
        int profit = 0;
        int minPrice = Integer.MAX_VALUE;
        int maxPrice = 0;

        for (int val : prices) {
            if (val < minPrice) {
                minPrice = val;
                maxPrice = 0;
            }
            else if (val > maxPrice){
                maxPrice = val;
            }
            int valDiff = maxPrice - minPrice;
            if (valDiff > profit) profit = valDiff;
        }

        return profit;
    }
}
