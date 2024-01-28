using System;
using System.Linq;
using System.Threading;//sleep

public class BaseTools {
	public static int [] CreateRandomArray(int size, int min, int max){
		int [] array = new int [size];
		for(int i = 0; i<size; i++){
			array[i] = new Random().Next(min, max+1);
		}
		return array;
	}
	public static void ShowArray(int [] array){
		for (int e=0; e<array.Length; e++ ){
			Console.Write($"[{array[e]}] ");
		}
	Console.WriteLine(";");
	}
	public static void ShowMesgTasks(int trash){//для повторяющихся сообщений
		switch (trash){
			case 1:
				Console.WriteLine($"Вводится 2 числа и выводятся все натуральные числа в промежутке");
				// Console.WriteLine("");
			break;
			case 2:
				Console.WriteLine("Вводится 2 числа и проводятся через функцию Аккермана");
				 Console.WriteLine("	┌	n+1		m=0;");
				 Console.WriteLine("a(m,n)=	┤	A(m-1,1)	m>0,n=0;");
				 Console.WriteLine("	└	A(m-1,A(m,n-1))	m>0,n>0.");
				 Console.Write("Введите m:");
			break;
			case 3:
				Console.WriteLine("вводится строка и проверяется является ли слово полиндромом");
				 Console.WriteLine("как пример полиндрома: 'шалаш','дед','радар' ");
			break;
			case 4:
				Console.WriteLine("вводится строка и заглавные преобразуются в строчные");
				 Console.WriteLine("как пример: 'ШаЛаш1' => 'шалаш1'");
			break;
		}
	}
	public static bool SumDigitsIsEven(int num){//СУМ ЦИФР ЧЁТНА?
		bool even = false;//Defolt
		num=Math.Abs(num);//[-num]
		
		int sum=0; //n+u+m
		
			while((num/10)>0){//n u
				sum+=num%10;
				num/=10; 
			}
			
			sum+=num; //n+u += m
			
			if (sum%2==0){
				even=true; //EVEN!
			}
		
		return(even);
	}
	public static char [] String_T_C(string INpt){
		char[] Out =new char[INpt.Length];
		for(int i=0;i<INpt.Length;i++){
		Out[i]=INpt[i];	
		}
		return(Out);
	}
	public static string CharArr_T_S(char [] INpt){
		string Out = "";
		foreach(char e in INpt){
			Out += e;
		}
		return(Out);
	}
}

public class Recursion {
	public static void ShowNaturalNumbers(int m, int n){
		if (m==n){
			return;
		}
		
		Console.Write($"{m} ");
		ShowNaturalNumbers(m+1,n);
	}
	public static int Ackerman(int m, int n){
		if (m == 0){
			return n + 1;
		}
		
		else if (n == 0){
			return Ackerman(m - 1, 1);
		}
		
		else{
			return Ackerman(m - 1, Ackerman(m, n - 1));
		}
	}
	public static void ShowArray(int [] array,int i=0){
		if(i>=array.Length){
			return;
		}
		// Console.Write($"[{array[i]}][{i}][{i>=array.Length}]");
		ShowArray(array,i+1);
		Console.Write($"[{array[i]}] ");
	}
}

public class tasks{
	static public void task1(){
 		BaseTools.ShowMesgTasks(1);
		
		Console.WriteLine("Введите 1 число:");
		int num1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Введите 2 число:");
		int num2 = int.Parse(Console.ReadLine());
		
		int memory =0;
		
		if (num1>num2){
			memory=num1;
			num1=num2;
			num2=memory;
		}
		num1++;
		Recursion.ShowNaturalNumbers(num1,num2);
		
		Thread.Sleep(7000);//чтобы увидеть результат
	}
	static public void task2(){
		
 		BaseTools.ShowMesgTasks(2);
		int m = int.Parse(Console.ReadLine());
		
		Console.Write("Введите n:");
		int n = int.Parse(Console.ReadLine());
		
		if(m<0 || n<0){
			Console.WriteLine("ERR: Переменные не положительны");
		}
		else{
			m = Recursion.Ackerman(m,n);
			Console.WriteLine($"A(m,n) = {m}");
		}
		
		Thread.Sleep(8000);
	
	}
	static public void task3(){
	int[] array = BaseTools.CreateRandomArray(10,0,9);
	BaseTools.ShowArray(array);//вывод
	Thread.Sleep(1000);
	Recursion.ShowArray(array);//вывод рекурсия
	Thread.Sleep(10000);

	}
	static public void task4(){

	BaseTools.ShowMesgTasks(2);
	BaseTools.ShowMesgTasks(1);
	string str = Console.ReadLine();
	if(str.Length>1){
		string str_Rewrite = "";
		
		int back = str.Length-1;//реверс по строке
		
		for (int i=0;i<str.Length;i++){
			if(char.IsLetter(str[i])){
				while(i+1<str.Length && char.IsLetter(str[i+1])){i++;}//пропуск слова
					while(back >= 0 && !char.IsLetter(str[back])){back --;}//в реверсивном пропуск 12!"№
					while(back >= 0 && char.IsLetter(str[back])){back --;}//в реверсивном пропуск слова
				int forward = back + 1 ;// меняем движ, по направлению, в реверсивном   
					while( forward<str.Length && char.IsLetter(str[forward]) ){//в реверсивном пишет слово
						str_Rewrite += str[forward];
						forward++;
					}
			}
			else{
				str_Rewrite +=str[i];
			}
			
			// Console.WriteLine($"[{i}]{str[i]}");// что ?
		}
		
		
		str=str_Rewrite;
	}
	Console.WriteLine(str);		
	Thread.Sleep(8000);
	}
}
public class Menu {

	static int PlayMenu(){
		int n=0;
		Console.Clear();	
		Console.WriteLine("--MENU--");
		Console.WriteLine("Задачи представленны по коду 1-3");
		Console.WriteLine("Выход по коду 0");
		Console.Write("Введите код задания: ");
		string str ="";
        str = Console.ReadLine();
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