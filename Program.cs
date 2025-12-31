// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Question no 01;
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 > number2) {
//     Console.WriteLine("first number is greater");
// } else if (number1 < number2) {
//     Console.WriteLine("2nd number is greater");
// } else if (number1 == number2) {
//     Console.WriteLine("Both are equal");
// } else {
//     Console.WriteLine("Oops something error.");
// }

// Question no 02:
// int age = Convert.ToInt32(Console.ReadLine());

// if(age < 13) {
//     Console.WriteLine("You are Child");
// } else if(age >= 13 && age <= 19) {
//     Console.WriteLine("You are Teenager");
// } else if(age > 19) {
//     Console.WriteLine("You are adult");
// } else {
//     Console.WriteLine("Oops something error");
// }

// Question no 3:
// for (int i = 1; i <= 10; i++) {
//     if (i == 5 || i == 6) {
//         continue;
//     } else {
//     Console.WriteLine(i);
//     }
// }

// Question no 04:
// for (int i = 1; i <= 10; i++) {
//     if (i == 6) {
//         break;
//     } else {
//         Console.WriteLine(i);
//     }
// }

// OOPs
// Question no 05:

class Student {
    public string s_name;
    public int s_roll_number;
    public double s_marks;

    public Student(string name, int roll_number, double marks) {
        s_name = name;
        s_roll_number = roll_number;
        s_marks = marks;
    }

    public void displayDetails() {
        Console.WriteLine("Name: " + s_name);
        Console.WriteLine("Roll Number: " + s_roll_number);
        Console.WriteLine("Marks: " + s_marks);
    }
}

class Program {
    static void Main(string[] args) {
        Student a = new Student("Shahnawaz", 3, 456);
        
        a.displayDetails();
    }
}
