#region Task
//int[] numbers = { 1, 2, 3, 4 };

//int[] array = new int[10];

//Array.Resize(ref numbers, numbers.Length + 1);

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//Resize(ref numbers, numbers.Length + 1);

//void Resize(ref int[] arr, int newSize)
//{
//    int[] newArr = new int[newSize]; // newArr.Length = 5 [0,0,0,0,0]

//    int length = arr.Length < newSize ? arr.Length : newSize; // arr.Length = 4, newSize = 5 ; length = 4

//    for (int i = 0; i < length; i++)
//    {
//        newArr[i] = arr[i]; /*
//                             1 - newArr[0] = arr[0] newArr[0] = 1 [1,0,0,0,0]
//                             2 - newArr[1] = arr[1] newArr[1] = 2 [1,2,0,0,0]
//                             3 - newArr[2] = arr[2] newArr[2] = 3 [1,2,3,0,0]
//                             4 - newArr[3] = arr[3] newArr[3] = 4 [1,2,3,4,0]

//                             */
//    }

//    arr = newArr; //arr = [1,2,3,4] -> arr = [1,2,3,4,0]
//}

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
#endregion

//string name = "Nicat";
//string surname = "Heyderov";
//int age = 18;

//string name1 = "Musa";
//string surname1 = "Mahmudov";
//int age1 = 19;
//var stu1 = new
//{
//    name = "Nicat",
//    surname = "Heyderov",
//    age = 18
//};

//var stu2 = new
//{
//    name = "Musa",
//    surname = "Mahmudov",
//    age = 19,
//};

//Console.WriteLine($"{stu1.name} {stu1.surname} {stu1.age}");
//Console.WriteLine($"{stu2.name} {stu2.surname} {stu2.age}");


using Class;

//Student stu1 = new Student();
//stu1.name = "Nicat";
//stu1.surname = "Heyderov";
//stu1.age = 18;

//Student stu2 = new Student()
//{
//    name = "Leman",
//    surname = "Cananova",
//    age = 18
//};

//stu2.age = 19;

//stu1.Print();
//stu2.Print();

Student student = new("Kenan", "Elekberov", 20);
Console.WriteLine(student.name);
Console.WriteLine(student.surname);
Console.WriteLine(student.age);
