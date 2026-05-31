using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _cslt.session_06.exercise_7
{
    internal class baitapmangmotchieu
    {
        // 1.Nhap va xuat mang
        static void Main1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        // 2.Tinh tong va trung binh cong
        static void Main2()
        {
            int n = int.Parse(Console.ReadLine());
            double[] a = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            double sum = 0;
            foreach (double x in a)
            {
                sum += x;
            }
            double avg = sum / n;
            Console.WriteLine($"{sum:F2} {avg:F2}");
        }
        // 3. Tim gia tri lon nhat va nho nhat
        static void Main3()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int max = a[0];
            int min = a[0];
            foreach (int x in a)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
            Console.WriteLine($"{max} {min}");
        }
        // 4. Dem so chan va so le
        static void Main4()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int even = 0;
            int odd = 0;
            foreach (int x in a)
            {
                if (x % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine($"{even} {odd}");
        }
        // 5. Tim kiem mot so trong mang
        static void Main5()
        {
            string[] firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int x = int.Parse(firstLine[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int position = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    position = i;
                    break;
                }
            }
            Console.WriteLine(position);
        }
        // 6. Dao ngươc mang
        static void Main6()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int left = 0;
            int right = n - 1;
            while (left < right)
            {
                int temp = a[left];
                a[left] = a[right];
                a[right] = temp;
                left++;
                right--;
            }
            foreach (int x in a)
            {
                Console.Write(x + " ");
            }
        }
        // 7. Kiem tra mang doi xung
        static void Main7()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool isPalindrome = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (a[i] != a[n - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            Console.WriteLine(isPalindrome ? "YES" : "NO");
        }
        // 8. Liet ke cac so nguyen to trong mang
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main8()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool found = false;
            foreach (int x in a)
            {
                if (IsPrime(x))
                {
                    Console.Write(x + " ");
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("EMPTY");
        }
        // 9. Tach mang Chan-Le
        static void Main9()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int x in a)
            {
                if (x % 2 == 0)
                    Console.Write(x + " ");
            }
            Console.WriteLine();
            foreach (int x in a)
            {
                if (x % 2 != 0)
                    Console.Write(x + " ");
            }
        }
        // 10. Sap xep mang tang dan và giam dan
        static void Main10()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(a);
            foreach (int x in a)
                Console.Write(x + " ");
            Console.WriteLine();
            Array.Reverse(a);
            foreach (int x in a)
                Console.Write(x + " ");
        }
        // 11. Chen mot phan vao mang da sap xep
        static void Main11()
        {
            string[] first = Console.ReadLine().Split();
            int n = int.Parse(first[0]);
            int x = int.Parse(first[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = new int[n + 1];
            int i = 0, j = 0;
            while (i < n && a[i] < x)
            {
                b[j++] = a[i++];
            }
            b[j++] = x;
            while (i < n)
            {
                b[j++] = a[i++];
            }
            foreach (int value in b)
                Console.Write(value + " ");
        }
        // 12. Xoa mot phan tu tai vi tri k
        static void Main12()
        {
            string[] first = Console.ReadLine().Split();
            int n = int.Parse(first[0]);
            int k = int.Parse(first[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < n; i++)
            {
                if (i != k)
                    Console.Write(a[i] + " ");
            }
        }
        // 13. Dem tan sut xuat hien cua cac phan tu
        static void Main13()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int x in a)
            {
                if (freq.ContainsKey(x))
                    freq[x]++;
                else
                    freq[x] = 1;
            }
            HashSet<int> printed = new HashSet<int>();
            foreach (int x in a)
            {
                if (!printed.Contains(x))
                {
                    Console.WriteLine($"{x}: {freq[x]}");
                    printed.Add(x);
                }
            }
        }
        // 14. Tim phan tu xuat hien nhieu nhat
        static void Main14()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int x in a)
            {
                if (freq.ContainsKey(x))
                    freq[x]++;
                else
                    freq[x] = 1;
            }
            int result = a[0];
            int maxFreq = freq[result];
            foreach (var item in freq)
            {
                if (item.Value > maxFreq)
                {
                    maxFreq = item.Value;
                    result = item.Key;
                }
                else if (item.Value == maxFreq && item.Key < result)
                {
                    result = item.Key;
                }
            }
            Console.WriteLine(result);
        }
        // 15. Tron hai mang da sap xep
        static void Main15()
        {
            string[] nm = Console.ReadLine().Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] C = new int[n + m];
            int i = 0, j = 0, k = 0;
            while (i < n && j < m)
            {
                if (A[i] <= B[j])
                    C[k++] = A[i++];
                else
                    C[k++] = B[j++];
            }
            while (i < n)
                C[k++] = A[i++];

            while (j < m)
                C[k++] = B[j++];

            foreach (int x in C)
                Console.Write(x + " ");
        }
        // 16. Tim day con lien tiep dai nhat co cac phan tu tang dan
        static void Main16()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int currentLen = 1;
            int maxLen = 1;
            for (int i = 1; i < n; i++)
            {
                if (a[i] > a[i - 1])
                    currentLen++;
                else
                    currentLen = 1;
                maxLen = Math.Max(maxLen, currentLen);
            }
            Console.WriteLine(maxLen);
        }
        // 17. Tinh tong lon nhat cua day con lien tiep (Thuat toan Kadane)
        static void Main17()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int currentSum = a[0];
            int maxSum = a[0];
            for (int i = 1; i < n; i++)
            {
                currentSum = Math.Max(a[i], currentSum + a[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            Console.WriteLine(maxSum);
        }
        // 18. Tim cap so co tong bang X
        static void Main18()
        {
            string[] first = Console.ReadLine().Split();
            int n = int.Parse(first[0]);
            int X = int.Parse(first[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int need = X - a[i];
                if (map.ContainsKey(need))
                {
                    Console.WriteLine("YES");
                    Console.WriteLine($"{map[need]} {i}");
                    return;
                }
                if (!map.ContainsKey(a[i]))
                    map[a[i]] = i;
            }
            Console.WriteLine("NO");
        }
        // 19. Dich chuyen mang xoay vong k phan tu
        static void Reverse(int[] a, int left, int right)
        {
            while (left < right)
            {
                int temp = a[left];
                a[left] = a[right];
                a[right] = temp;
                left++;
                right--;
            }
        }
        static void Main19()
        {
            string[] first = Console.ReadLine().Split();
            int n = int.Parse(first[0]);
            int k = int.Parse(first[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            k %= n;
            Reverse(a, 0, n - 1);
            Reverse(a, 0, k - 1);
            Reverse(a, k, n - 1);
            foreach (int x in a)
                Console.Write(x + " ");
        }
        // 20. Tim so con thieu nho nhat (Ky luat mang)
        static void Main20()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool[] mark = new bool[n + 2];
            foreach (int x in a)
            {
                if (x >= 1 && x <= n)
                    mark[x] = true;
            }
            for (int i = 1; i <= n + 1; i++)
            {
                if (!mark[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
    internal class baitapmanghaichieu
    {
        // 21. Nhap va xuat ma tran
        static void Main21()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(row[j]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // 22. Tinh tong cac phan tu tren tung dong/tung cot
        static void Main22()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(row[j]);
                }
            }
            // Tong tung dong
            for (int i = 0; i < m; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                    sum += a[i, j];

                Console.Write(sum + " ");
            }
            Console.WriteLine();

            // Tong tung cot
            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int i = 0; i < m; i++)
                    sum += a[i, j];
                Console.Write(sum + " ");
            }
        }
        // 23. Tim phan tu lon nhat va vi tri cua no
        static void Main23()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(row[j]);
                }
            }
            int max = a[0, 0];
            int rowPos = 0;
            int colPos = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        rowPos = i;
                        colPos = j;
                    }
                }
            }
            Console.WriteLine($"Max_Value {max} tai hang {rowPos}, cot {colPos}");
        }
        // 24. Liet ke cac phan tu tren duong cheo chinh (Matran vuong)
        static void Main24()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(row[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i, i] + " ");
            }
        }
        // 25. Tinh tong duong cheo phu cua ma tran vuong
        static void Main25()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(row[j]);
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i, n - 1 - i];
            }
            Console.WriteLine(sum);
        }
        // 26. Tim kiem mot so X trong ma tran
        static void Main26()
        {
            string[] first = Console.ReadLine().Split();
            int m = int.Parse(first[0]);
            int n = int.Parse(first[1]);
            int x = int.Parse(first[2]);
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(row[j]);
                }
            }
            bool found = false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == x)
                    {
                        Console.WriteLine($"({i},{j})");
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("NOT FOUND");
            }
        }
        // 27. Dem so luong so am tren bien ma tran
        static void Main27()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(row[j]);
                }
            }
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool isBorder =
                        i == 0 || i == m - 1 ||
                        j == 0 || j == n - 1;
                    if (isBorder && a[i, j] < 0)
                        count++;
                }
            }
            Console.WriteLine(count);
        }
        // 28. Cong hai ma tan cung kich thuoc
        static void Main28()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] A = new int[m, n];
            int[,] B = new int[m, n];
            int[,] C = new int[m, n];
            // Nhap A
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    A[i, j] = int.Parse(row[j]);
            }
            // Nhap B
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    B[i, j] = int.Parse(row[j]);
            }
            // C = A + B
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // 29. Tim ma tran chuyen vi
        static void Main29()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] A = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(row[j]);
                }
            }
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // 30. Kiem tra ma tran doi xung qua duong cheo chinh
        static void Main30()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(row[j]);
                }
            }
            bool symmetric = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i, j] != A[j, i])
                    {
                        symmetric = false;
                        break;
                    }
                }
            }
            Console.WriteLine(symmetric ? "YES" : "NO");
        }
        // 31. Sap xep cac phan tu tren tung dong tang dan
        static void Main31()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] A = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(row[j]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                int[] temp = new int[n];
                for (int j = 0; j < n; j++)
                    temp[j] = A[i, j];
                Array.Sort(temp);
                for (int j = 0; j < n; j++)
                    A[i, j] = temp[j];
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(A[i, j] + " ");
                Console.WriteLine();
            }
        }
        // 32. Doi cho hai dong cua ma tran
        static void Main32()
        {
            string[] first = Console.ReadLine().Split();
            int m = int.Parse(first[0]);
            int n = int.Parse(first[1]);
            string[] rows = Console.ReadLine().Split();
            int r1 = int.Parse(rows[0]);
            int r2 = int.Parse(rows[1]);
            int[,] A = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    A[i, j] = int.Parse(row[j]);
            }
            for (int j = 0; j < n; j++)
            {
                int temp = A[r1, j];
                A[r1, j] = A[r2, j];
                A[r2, j] = temp;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(A[i, j] + " ");
                Console.WriteLine();
            }
        }
        // 33. Kiem tra ma tran tam giac tren
        static void Main33()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    A[i, j] = int.Parse(row[j]);
            }
            bool upperTriangular = true;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (A[i, j] != 0)
                    {
                        upperTriangular = false;
                        break;
                    }
                }
            }
            Console.WriteLine(upperTriangular ? "YES" : "NO");
        }
        // 34. Tim dong co tong phan tu lon nhat
        static void Main34()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] A = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    A[i, j] = int.Parse(row[j]);
            }
            int maxRow = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                    sum += A[i, j];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = i;
                }
            }
            Console.WriteLine($"Row {maxRow}: {maxSum}");
        }
        // 35. Nhan hai ma tran
        static void Main35()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int p = int.Parse(input[2]);
            int[,] A = new int[m, n];
            int[,] B = new int[n, p];
            int[,] C = new int[m, p];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    A[i, j] = int.Parse(row[j]);
            }
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < p; j++)
                    B[i, j] = int.Parse(row[j]);
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // 36. In ma tran theo dang xoan oc (Spiral Matrix)
        static void Main36()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] A = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    A[i, j] = int.Parse(row[j]);
            }
            int top = 0, bottom = m - 1;
            int left = 0, right = n - 1;
            while (top <= bottom && left <= right)
            {
                for (int j = left; j <= right; j++)
                    Console.Write(A[top, j] + " ");
                top++;
                for (int i = top; i <= bottom; i++)
                    Console.Write(A[i, right] + " ");
                right--;
                if (top <= bottom)
                {
                    for (int j = right; j >= left; j--)
                        Console.Write(A[bottom, j] + " ");
                    bottom--;
                }
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                        Console.Write(A[i, left] + " ");
                    left++;
                }
            }
        }
        // 37. Tao ma tran xoan oc bac X
        static void Main37()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[n, n];
            int top = 0, bottom = n - 1;
            int left = 0, right = n - 1;
            int value = 1;
            while (top <= bottom && left <= right)
            {
                for (int j = left; j <= right; j++)
                    A[top, j] = value++;
                top++;
                for (int i = top; i <= bottom; i++)
                    A[i, right] = value++;
                right--;
                for (int j = right; j >= left && top <= bottom; j--)
                    A[bottom, j] = value++;
                bottom--;
                for (int i = bottom; i >= top && left <= right; i--)
                    A[i, left] = value++;
                left++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(A[i, j] + "\t");
                Console.WriteLine();
            }
        }
        // 38. Xoay ma tran vuong 90 do theo chieu kim dong ho
        static void Main38()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    A[i, j] = int.Parse(row[j]);
            }
            // Chuyen vi
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int temp = A[i, j];
                    A[i, j] = A[j, i];
                    A[j, i] = temp;
                }
            }
            // Dao tung dong
            for (int i = 0; i < n; i++)
            {
                int left = 0;
                int right = n - 1;
                while (left < right)
                {
                    int temp = A[i, left];
                    A[i, left] = A[i, right];
                    A[i, right] = temp;
                    left++;
                    right--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(A[i, j] + " ");
                Console.WriteLine();
            }
        }
        // 39. Tim ma tran con vuong co tong lon nhat (Kich thuoc k x k)
        static void Main39()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int k = int.Parse(input[2]);
            int[,] A = new int[m + 1, n + 1];
            int[,] prefix = new int[m + 1, n + 1];
            for (int i = 1; i <= m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 1; j <= n; j++)
                {
                    A[i, j] = int.Parse(row[j - 1]);
                    prefix[i, j] =
                        prefix[i - 1, j]
                        + prefix[i, j - 1]
                        - prefix[i - 1, j - 1]
                        + A[i, j];
                }
            }
            int maxSum = int.MinValue;
            for (int i = k; i <= m; i++)
            {
                for (int j = k; j <= n; j++)
                {
                    int sum =
                        prefix[i, j]
                        - prefix[i - k, j]
                        - prefix[i, j - k]
                        + prefix[i - k, j - k];

                    maxSum = Math.Max(maxSum, sum);
                }
            }
            Console.WriteLine(maxSum);
        }
        // 40. Diem yen ngua cua ma tran
        static void Main40()
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] A = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    A[i, j] = int.Parse(row[j]);
            }
            bool found = false;
            for (int i = 0; i < m; i++)
            {
                int minValue = A[i, 0];
                for (int j = 1; j < n; j++)
                {
                    if (A[i, j] < minValue)
                        minValue = A[i, j];
                }
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] != minValue)
                        continue;
                    bool largestInColumn = true;
                    for (int r = 0; r < m; r++)
                    {
                        if (A[r, j] > A[i, j])
                        {
                            largestInColumn = false;
                            break;
                        }
                    }
                    if (largestInColumn)
                    {
                        Console.WriteLine($"{A[i, j]} tại ({i}, {j})");
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("NONE");
            }
        }
    }
}