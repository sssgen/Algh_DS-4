class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Student[] students = {
            new Student("Іваненко", "Іван", "3А", "Київ", "Київська"),
            new Student("Петренко", "Петро", "2Б", "Одеса", "Одеська"),
            new Student("Сидоренко", "Сидір", "3А", "Львів", "Львівська"),
            new Student("Коваленко", "Костянтин", "1В", "Харків", "Харківська"),
            new Student("Мельник", "Марія", "3Г", "Черкаси", "Черкаська")
        };

        Console.WriteLine("--- Масив до сортування ---");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Sorting.SelectionSort(students);

        Console.WriteLine("\n--- Масив після сортування (за областю та містом, в алфавітному порядку) ---");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
