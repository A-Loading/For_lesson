using System;
using System.Linq;

public class BaseTools {
	public static int [] CreateRandomArray(int size, int min, int max){
		int [] array = new int [size];
		for(int i = 0; i<size; i++){
			array[i] = new Random().Next(min, max+1);
		}
		return array;
	}
	public static void ShowArray(int [] array){
		foreach(int e in array){
			Console.Write($"{e} ");
		}
	}
	
}
public class tasks{
	static public void task1(){
		
	}
	static public void task2(){
		
	}
	static public void task3(){
		
	}
	static public void task4(){
		
	}
}
public class Menu {

	static int PlayMenu(){
		int n=0;
		Console.Clear();	
		Console.WriteLine("--MENU--");
		Console.WriteLine("Задачи представленны по коду 1-4");
		Console.WriteLine("Выход по коду 0");
		Console.WriteLine("Введите код задания: ");
        string str = Console.ReadLine();
        n = int.Parse(str);
		Console.Clear();
		return(n);
	}
	static void GO_to_task(int a){
		switch (a)
			{
            case 1:
                tasks.task1();break;
            case 2:
				tasks.task2();break;
            case 3:
				tasks.task3();break;
			case 4:
				tasks.task4();break;
			default:
                Console.WriteLine("--ВЫХОД НА 0--");
            break;
        }
	}
	static public void Main(string[] args) {
        int a;

        if (args.Length >= 1) {
			a = int.Parse(args[0]);
           
        } else {
			a = PlayMenu();
		}
		GO_to_task(a);
		if(a!=0){
			do{
				a = PlayMenu();
				GO_to_task(a);
			}while(a!=0);
		}
		Console.Clear();
		Console.WriteLine("Программа завершена");
    }
}