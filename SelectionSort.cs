public static class Sorting
{
    public static void SelectionSort(Student[] students)
    {
        int n = students.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int index = i;
            for (int j = i + 1; j < n; j++)
            {
                if (string.Compare(students[j].Region, students[index].Region) < 0 ||
                    (students[j].Region == students[index].Region && string.Compare(students[j].City, students[index].City) < 0))
                {
                    index = j;
                }
            }
            var temp = students[i];
            students[i] = students[index];
            students[index] = temp;
        }
    }
}