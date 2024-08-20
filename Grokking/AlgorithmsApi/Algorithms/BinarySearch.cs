namespace AlgorithmsApi.Algorithms;

public class BinarySearch
{
    //  my_list = [1, 3, 5, 7, 9]
    public int Execute(int[] lst, int item)
    {
        //low and high Keep trace which part of list you'll search in
        int low = 0;
        int high = lst.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = lst[mid];
            if (guess == item)
            {
                return mid;
            }
            else if (guess > item)
            {
                high = mid - 1;

            }
            else
            {
                low = mid + 1;
            }

        }
        return -1;
    }

}
