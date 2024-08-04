using System.Collections;

namespace task_adv_03
{
    internal class Program
    {
        //static int CountGreaterThanX(int[] arr, int x)
        //{
        //    int count = 0;
        //    foreach (int num in arr)
        //    {
        //        if (num > x)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        #region num2
        //static bool IsPalindrome(int[] arr)
        //{
        //    int left = 0;
        //    int right = arr.Length - 1;

        //    while (left < right)
        //    {
        //        if (arr[left] != arr[right])
        //        {
        //            return false;
        //        }
        //        left++;
        //        right--;
        //    }

        //    return true;
        //}
        #endregion


        #region num3
        //static void ReverseQueue(Queue<int> queue)
        //{
        //    Stack<int> stack = new Stack<int>();

        //    while (queue.Count > 0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }

        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }
        #endregion

        //static ArrayList RemoveOddNumbers(ArrayList numbers)
        //{
        //    ArrayList evenNumbers = new ArrayList();

        //    foreach (int number in numbers)
        //    {
        //        if (number % 2 == 0)
        //        {
        //            evenNumbers.Add(number);
        //        }
        //    }

        //    return evenNumbers;
        //}
        /// <summary>
        /// /////////////////////////////////////
        /// </summary>
        /// <param name="args"></param>

        //public static bool SubarraySumEqualsK(IList<int> nums, int k)
        //{
        //    int left = 0, right = 0, sum = 0;

        //    while (right < nums.Count)
        //    {
        //        sum += nums[right];

        //        if (sum == k)
        //            return true;

        //        while (sum > k && left <= right)
        //        {
        //            sum -= nums[left];
        //            left++;
        //        }

        //        right++;
        //    }

        //    return false;
        //}


        static void Main(string[] args)
        {
            #region num1
            //Console.WriteLine("Enter the size of the array:");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Console.WriteLine($"Enter {n} elements for the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter the number of queries:");
            //int q = int.Parse(Console.ReadLine());

            //for (int i = 0; i < q; i++)
            //{
            //    Console.WriteLine($"Enter query {i + 1}:");
            //    int x = int.Parse(Console.ReadLine());
            //    int count = CountGreaterThanX(arr, x);
            //    Console.WriteLine($"Numbers greater than {x}: {count}");
            //}
            #endregion

            #region num2
            //Console.WriteLine("Enter the size of the array:");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Console.WriteLine($"Enter {n} elements for the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //bool isPalindrome = IsPalindrome(arr);
            //if (isPalindrome)
            //{
            //    Console.WriteLine("Yes The array is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine("NO The array is not a palindrome.");
            //}
            #endregion

            #region num3
            //    Queue<int> queue = new Queue<int>();

            //    Console.WriteLine("Enter the number of elements in the queue:");
            //    int n = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Enter {n} elements for the queue:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        queue.Enqueue(int.Parse(Console.ReadLine()));
            //    }

            //    Console.WriteLine("Original queue:");
            //    PrintQueue(queue);

            //    ReverseQueue(queue);

            //    Console.WriteLine("Reversed queue:");
            //    PrintQueue(queue);




            //}


            //static void PrintQueue(Queue<int> queue)
            //{
            //    foreach (int item in queue)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region num4
            //    Console.WriteLine("Enter a string of parentheses:");
            //    string input = Console.ReadLine();

            //    bool isBalanced = IsBalanced(input);
            //    if (isBalanced)
            //    {
            //        Console.WriteLine("The string is balanced.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The string is not balanced.");
            //    }




            //}
            //static bool IsBalanced(string s)
            //{
            //    Stack<char> stack = new Stack<char>();

            //    foreach (char c in s)
            //    {
            //        if (c == '(' || c == '{' || c == '[')
            //        {
            //            stack.Push(c);
            //        }
            //        else if (c == ')' || c == '}' || c == ']')
            //        {
            //            if (stack.Count == 0)
            //            {
            //                return false;
            //            }

            //            char top = stack.Pop();
            //            if ((c == ')' && top != '(') ||
            //                (c == '}' && top != '{') ||
            //                (c == ']' && top != '['))
            //            {
            //                return false;
            //            }
            //        }
            //    }

            //    return stack.Count == 0;
            #endregion

            #region num5
            //    Console.WriteLine("Enter the size of the array:");
            //    int n = int.Parse(Console.ReadLine());

            //    int[] arr = new int[n];
            //    Console.WriteLine($"Enter {n} elements for the array:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        arr[i] = int.Parse(Console.ReadLine());
            //    }

            //    int[] uniqueArray = RemoveDuplicates(arr);

            //    Console.WriteLine("Array after removing duplicates:");
            //    foreach (int item in uniqueArray)
            //    {
            //        Console.Write(item + " ");
            //    }



            //}
            //static int[] RemoveDuplicates(int[] arr)
            //{
            //    HashSet<int> uniqueElements = new HashSet<int>();

            //    foreach (int item in arr)
            //    {
            //        uniqueElements.Add(item);
            //    }

            //    int[] result = new int[uniqueElements.Count];
            //    uniqueElements.CopyTo(result);

            //    return result;
            //}
            #endregion
            #region num6
            //ArrayList numbers = new ArrayList();

            //Console.WriteLine("Enter the number of elements in the ArrayList:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Enter {n} elements for the ArrayList:");
            //for (int i = 0; i < n; i++)
            //{
            //    numbers.Add(int.Parse(Console.ReadLine()));
            //}

            //ArrayList evenNumbers = RemoveOddNumbers(numbers);

            //Console.WriteLine("ArrayList after removing odd numbers:");
            //foreach (int number in evenNumbers)
            //{
            //    Console.Write(number + " ");
            //}
            #endregion

            #region num7
            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //Console.WriteLine("Elements in the queue:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion


            #region num8
            //Stack<int> stack = new Stack<int>();

            //Console.WriteLine("Enter the number of elements to push onto the stack:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Enter {n} elements to push onto the stack:");
            //for (int i = 0; i < n; i++)
            //{
            //    int element = int.Parse(Console.ReadLine());
            //    stack.Push(element);
            //}

            //Console.WriteLine("Enter the target element to search for:");
            //int target = int.Parse(Console.ReadLine());

            //SearchInStack(stack, target);
            #endregion

            #region num9
            //Console.WriteLine("Enter the size of the first array:");
            //int n1 = int.Parse(Console.ReadLine());
            //int[] array1 = new int[n1];
            //Console.WriteLine($"Enter {n1} elements for the first array:");
            //for (int i = 0; i < n1; i++)
            //{
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter the size of the second array:");
            //int n2 = int.Parse(Console.ReadLine());
            //int[] array2 = new int[n2];
            //Console.WriteLine($"Enter {n2} elements for the second array:");
            //for (int i = 0; i < n2; i++)
            //{
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] intersection = FindIntersection(array1, array2);

            //Console.WriteLine("Intersection of the two arrays:");
            //foreach (int item in intersection)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region num10
            //Console.WriteLine("enter the target ");
            //var nums = new List<int> { 1, 5, 7, 3, 2, 5 };
            //int target ;
            //target=int.Parse(Console.ReadLine());

            //Console.WriteLine(SubarraySumEqualsK(nums, target));
            #endregion

        }
        //static void SearchInStack(Stack<int> stack, int target)
        //{
        //    Stack<int> tempStack = new Stack<int>(stack);
        //    int count = 0;
        //    bool found = false;

        //    while (tempStack.Count > 0)
        //    {
        //        int currentElement = tempStack.Pop();
        //        count++;

        //        if (currentElement == target)
        //        {
        //            found = true;
        //            break;
        //        }
        //    }

        //    if (found)
        //    {
        //        Console.WriteLine($"Target was found successfully and the count = {count}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Target was not found");
        //    }
        /////////////////////////////////////////////////////////////////////////////
        //}
        //static int[] FindIntersection(int[] array1, int[] array2)
        //{
        //    Dictionary<int, int> counts1 = new Dictionary<int, int>();
        //    Dictionary<int, int> counts2 = new Dictionary<int, int>();

        //    foreach (int num in array1)
        //    {
        //        if (counts1.ContainsKey(num))
        //        {
        //            counts1[num]++;
        //        }
        //        else
        //        {
        //            counts1[num] = 1;
        //        }
        //    }
        //    foreach (int num in array2)
        //    {
        //        if (counts2.ContainsKey(num))
        //        {
        //            counts2[num]++;
        //        }
        //        else
        //        {
        //            counts2[num] = 1;
        //        }
        //    }

        //    List<int> intersection = new List<int>();
        //    foreach (var kvp in counts1)
        //    {
        //        if (counts2.ContainsKey(kvp.Key))
        //        {
        //            int minCount = Math.Min(kvp.Value, counts2[kvp.Key]);
        //            for (int i = 0; i < minCount; i++)
        //            {
        //                intersection.Add(kvp.Key);
        //            }
        //        }
        //    }

        //    return intersection.ToArray();
        //}
    }
}
