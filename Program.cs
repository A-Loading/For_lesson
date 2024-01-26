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
	public static void ShowArray(char [] array){
		for (int e=0; e<array.Length; e++ ){
			Console.Write($"[{array[e]}] ");
		}
	Console.WriteLine(";");
	}
	public static void ShowMesgTasks(int trash){//для повторяющихся сообщений
		switch (trash){
			case 1:
				Console.Write($"Введите строку:");
				// Console.WriteLine("");
			break;
			case 2:
				Console.WriteLine("вводится строка и положение слов реверсируется");
				 Console.WriteLine("");
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

public class tasks{
	static public void task1(){
		char[,] array = new char[,]{
                {'П','р','и','в','е','т'},
                {' ','м','и','р','.','√'}
            };
		string anser = "";
		foreach(char e in array){
			Console.Write($"[{e}]");
			anser += e;
		}
		Console.WriteLine("");
		Console.WriteLine(anser);
		Thread.Sleep(7000);//чтобы увидеть результат
	}
	static public void task2(){
		
		BaseTools.ShowMesgTasks(4);
 		BaseTools.ShowMesgTasks(1);
		string str = Console.ReadLine();
		char[] str_Rewrite = BaseTools.String_T_C(str);
		// Console.WriteLine(str);
		// BaseTools.ShowArray(str_Rewrite);
		
		for (int i=0;i<str.Length;i++){
			 int charID = str_Rewrite[i];//id of char in string
			 
			 // Console.WriteLine($"[{str_Rewrite[i]}][{charID}]- -[{charID>=1040}]&[{charID<=1071}]|[{65<=charID}]&[{charID<=90}]-");
			 if( ((charID>=1040) && (charID<=1071)) || ((65<=charID) && (charID<=90)) ){//A-Z А-Я
				
				str_Rewrite[i] = Convert.ToChar(charID+32);
				// Console.WriteLine($"{str_Rewrite[i]}[{charID+32}]");				
				 
			 }
			 // Thread.Sleep(1000);
		
		}
		// BaseTools.ShowArray(str_Rewrite);
/*
A-Z 65-90
-32-
a-z 97-122
 
А-Я 1040-1071
-32-
а-я 1072-1103
 
*/		
		str= BaseTools.CharArr_T_S(str_Rewrite);
		Console.WriteLine($"	-	-	-	-");
		Console.Write($"		");
		Console.WriteLine(str);
		Thread.Sleep(8000);
	
	}
	static public void task3(){
	
	BaseTools.ShowMesgTasks(3);
	BaseTools.ShowMesgTasks(1);
	string str = Console.ReadLine();
	Console.WriteLine(str);
	bool polyndrom = true;
	if (str.Length == 0){
		polyndrom = false;
	}
	else{
		for(int beg =0;beg<str.Length/2;beg++){
			if(str[beg] != str[str.Length-1-beg]){
				polyndrom = false;
			}
		}
	}
	
	
	if(polyndrom)
		{str = " подиндром";}
	else
		{str = " не подиндром";}
	Console.WriteLine(str);
	Thread.Sleep(5000);
	return;
	
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
		Console.WriteLine("Задачи представленны по коду 1-4");
		Console.WriteLine("Выход по коду 0");
		Console.Write("Введите код задания: ");
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