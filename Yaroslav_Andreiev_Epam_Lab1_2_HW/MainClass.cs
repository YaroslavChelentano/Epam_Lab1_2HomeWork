using System;
using System.Collections.Generic;
using lab1task1;
using lab1task2;
using lab1task3;
using lab1task4;
using lab1task5;
using lab2task1;
using lab2task2;
using lab2task3;
using lab2task4;
using lab3task1_2;
using lab3task3;
namespace Lab1_2_NET_Epam
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Menu menu = new Menu();
            menu.ChooseAction();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    menu.ChooseLab();
                    int choiceLab = int.Parse(Console.ReadLine());
                    if (choiceLab == 1)
                    {
                        Console.WriteLine("Enter points:");
                        Console.Write("LeftTopX: ");
                        double leftTopX = double.Parse(Console.ReadLine());
                        Console.Write("LeftTopY: ");
                        double leftTopY = double.Parse(Console.ReadLine());
                        Console.Write("RightDownX: ");
                        double rightDownX = double.Parse(Console.ReadLine());
                        Console.Write("RightDownY: ");
                        double rightDownY = double.Parse(Console.ReadLine());

                        // Lab#1Task1
                        Console.WriteLine("Task 1: ");
                        Rectangle myRectangle1 = new Rectangle(leftTopX, leftTopY, rightDownX, rightDownY);
                        Console.WriteLine(myRectangle1.square());
                        Console.WriteLine(myRectangle1.perimeter());
                        // Lab#1Task2
                        Console.WriteLine("Task 2: ");
                        Rectangle_Auto_Implemented myRectangleAuto1 = new
                        Rectangle_Auto_Implemented();
                        myRectangleAuto1.leftTopX = leftTopX;
                        myRectangleAuto1.leftTopY = leftTopY;
                        myRectangleAuto1.rightDownX = rightDownX;
                        myRectangleAuto1.rightDownY = rightDownY;

                        Console.WriteLine(myRectangleAuto1.GetPerimeter);
                        Console.WriteLine(myRectangleAuto1.GetSquare);

                        //  Lab#1Task3
                        Console.Write("Enter radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("Task 3: ");
                        Circle myCircle1 = new Circle();
                        Console.WriteLine(myCircle1.length(radius));
                        Console.WriteLine(myCircle1.square(radius));
                        Console.WriteLine("Task 4: ");
                        //  Lab#1Task4
                        Console.WriteLine(StatRectangle.perimeter(leftTopX, leftTopY, rightDownX, rightDownY));
                        Console.WriteLine(StatRectangle.square(leftTopX, leftTopY, rightDownX, rightDownY));
                        Console.WriteLine(StatCircle.length(radius));
                        Console.WriteLine(StatCircle.square(radius));
                        //  Lab#1Task5
                        Console.WriteLine("Task 5: ");
                        Console.Write("Num1RealPart: ");
                        double real1 = double.Parse(Console.ReadLine());
                        Console.Write("Num1ImagPart: ");
                        double imag1 = double.Parse(Console.ReadLine());
                        Console.Write("Num2RealPart: ");
                        double real2 = double.Parse(Console.ReadLine());
                        Console.Write("Num2ImagPart: ");
                        double imag2 = double.Parse(Console.ReadLine());

                        ComplexNumber numfirst = new ComplexNumber(real1, imag1);
                        ComplexNumber numsecond = new ComplexNumber(real2, imag2);
                        Console.WriteLine(numfirst * numsecond);
                        Console.WriteLine(numfirst / numsecond);
                    }
                    if (choiceLab == 2)
                    {
                        Console.WriteLine("Task 1: ");
                        RectangleFigure rect1 = new RectangleFigure();
                        rect1.Draw();
                        SquareFigure square1 = new SquareFigure();
                        square1.Draw();
                        Console.WriteLine("Task 2: ");
                        Console.WriteLine("Look my code");
                        RectangleReadOnly rectangleRead1 = new RectangleReadOnly(2, 3);
                        SquareReadOnly squareRead1 = new SquareReadOnly(2, 3);
                        Console.WriteLine("Task 3: ");
                        FigureVirtual figure1 = new FigureVirtual(2, 3);
                        figure1.Draw();
                        FigureVirtual newfigureone = new RectangleVirtual(2, 3);
                        newfigureone.Draw();
                        FigureVirtual newfiguresecond = new SquareVirtual(2, 3);
                        newfiguresecond.Draw();
                        Console.WriteLine("Task 4: ");
                        FigureDraw figuretoDraw1 = new FigureDraw(2, 3);
                        RectangleDraw rectangleDraw1 = new RectangleDraw(2, 3);
                        figuretoDraw1.DrawAll(figuretoDraw1, rectangleDraw1);
                    }
                    if (choiceLab == 3)
                    {
                        //   Lab#3Task1
                        Console.WriteLine("\t Lab 3: ");
                        Console.WriteLine("Task 1: ");
                        List<Person> newList1 = new List<Person>();
                        CreateDisplayPerson create1 = new CreateDisplayPerson(newList1);
                        create1.CreateSomePerson();
                        create1.DisplayPerson();
                        //   Lab#3Task2 
                        Console.WriteLine("Task 2: ");
                        AddRangePerson add1 = new AddRangePerson(newList1);
                        add1.AddTwoPerson();
                        add1.DisplayPhoneNumbers();
                        //   Lab#3Task3
                        Console.WriteLine("Task 3: ");
                        RandomList randomList1= new RandomList();
                        Console.Write("Enter number of Page: ");
                        string numberPage1 = Console.ReadLine();
                        int number1;
                        bool success1 = Int32.TryParse(numberPage1, out number1);
                        if (success1)
                        {
                            number1 = Int32.Parse(numberPage1);
                            randomList1.DisplayPage(number1);
                        }
                        else
                        {
                            Console.WriteLine("Please enter number as digit");
                            break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("\tLab 1: ");
                    // Lab#1Task1
                    Console.WriteLine("Task 1: ");
                    Rectangle myRectangle = new Rectangle(2, 3, 3, 1);
                    Console.WriteLine(myRectangle.square());
                    Console.WriteLine(myRectangle.perimeter());
                    // Lab#1Task2
                    Console.WriteLine("Task 2: ");
                    Rectangle_Auto_Implemented myRectangleAuto = new
                    Rectangle_Auto_Implemented();
                    myRectangleAuto.leftTopX = 2;
                    myRectangleAuto.leftTopY = 3;
                    myRectangleAuto.rightDownX = 3;
                    myRectangleAuto.rightDownY = 1;

                    Console.WriteLine(myRectangleAuto.GetPerimeter);
                    Console.WriteLine(myRectangleAuto.GetSquare);

                    //  Lab#1Task3
                    Console.WriteLine("Task 3: ");
                    Circle myCircle = new Circle();
                    Console.WriteLine(myCircle.length(2));
                    Console.WriteLine(myCircle.square(3));
                    //  Lab#1Task4
                    Console.WriteLine("Task 4: ");
                    Console.WriteLine(StatRectangle.perimeter(2, 3, 3, 1));
                    Console.WriteLine(StatRectangle.square(2, 3, 3, 1));
                    Console.WriteLine(StatCircle.length(2));
                    Console.WriteLine(StatCircle.square(3));
                    //  Lab#1Task5
                    Console.WriteLine("Task 5: ");
                    ComplexNumber num1 = new ComplexNumber(1, 1);
                    ComplexNumber num2 = new ComplexNumber(1, 3);
                    Console.WriteLine(num1 * num2);
                    Console.WriteLine(num1 / num2);
                    Console.WriteLine("\t Lab 2: ");
                    //  Lab#2Task1
                    Console.WriteLine("Task 1: ");
                    RectangleFigure rect = new RectangleFigure();
                    rect.Draw();
                    SquareFigure square = new SquareFigure();
                    square.Draw();
                    //  Lab#2Task2
                    Console.WriteLine("Task 2: ");
                    Console.WriteLine("Look my code");
                    RectangleReadOnly rectangleRead = new RectangleReadOnly(2, 3);
                    SquareReadOnly squareRead = new SquareReadOnly(2, 3);
                    //  Lab#2Task3
                    Console.WriteLine("Task 3: ");
                    FigureVirtual figure = new FigureVirtual(2, 3);
                    figure.Draw();
                    FigureVirtual newfigure1 = new RectangleVirtual(2, 3);
                    newfigure1.Draw();
                    FigureVirtual newfigure2 = new SquareVirtual(2, 3);
                    newfigure2.Draw();
                    //   Lab#2Task4
                    Console.WriteLine("Task 4: ");
                    FigureDraw figuretoDraw = new FigureDraw(2, 3);
                    RectangleDraw rectangleDraw = new RectangleDraw(2, 3);
                    figuretoDraw.DrawAll(figuretoDraw, rectangleDraw);
                    //   Lab#3Task1
                    Console.WriteLine("\t Lab 3: ");
                    Console.WriteLine("Task 1: ");
                    List<Person> newList = new List<Person>();
                    CreateDisplayPerson create = new CreateDisplayPerson(newList);
                    create.CreateSomePerson();
                    create.DisplayPerson();
                    //   Lab#3Task2 
                    Console.WriteLine("Task 2: ");
                    AddRangePerson add = new AddRangePerson(newList);
                    add.AddTwoPerson();
                    add.DisplayPhoneNumbers();
                    //   Lab#3Task3
                    Console.WriteLine("Task 3: ");
                    RandomList randomList = new RandomList();
                    Console.Write("Enter number of Page: ");
                    string numberPage = Console.ReadLine();
                    int number;
                    bool success = Int32.TryParse(numberPage, out number);
                    if (success)
                    {
                        number = Int32.Parse(numberPage);
                        randomList.DisplayPage(number);
                    }
                    else
                    {
                        Console.WriteLine("Please enter number as digit");
                        break;
                    }
                    break;
                    
                default:
                    Console.WriteLine("Choose 1 or 2 variant");
                    break;
            }
        }
    }
}
