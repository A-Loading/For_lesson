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
		foreach(int e in array){
			Console.Write($"{e} ");
		}
	}
	public static void ShowMesgTasks(int trash){//для повторяющихся сообщений
		switch (trash){
			case 1:
				Console.WriteLine("Введите число чтобы продолжить или q для выхода");
				Console.WriteLine("");
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
}
public class tasks{
	static public void task1(){
		BaseTools.ShowMesgTasks(1);// подсказка
		string S_num = Console.ReadLine();
		string memory="";//не хотел но пришлось иначе на другую сроку при вводе перекидывало
		while(S_num != "q"){
			int I_num;
			Console.Clear();// чтобы ввод не мешал
			if(int.TryParse(S_num, out I_num)){
				if(BaseTools.SumDigitsIsEven(I_num)){
					S_num = "q";//выход 
				}
				else
				{
					memory=$"{memory}[{S_num}] ";//не хотел но пришлось иначе на другую сроку при вводе перекидывало
					BaseTools.ShowMesgTasks(1);// подсказка для тех кто забудет
					Console.Write($"{memory} ");
					S_num = Console.ReadLine();
				}
			}
			else
			{	
				BaseTools.ShowMesgTasks(1);
				Console.Write($"--ERR1 введено {S_num}--");
				S_num = Console.ReadLine();
			}
		}
		Console.Clear();// чтобы ввод не мешал
		// BaseTools.ShowMesgTasks(1);
		Console.Write($"{memory}[STOP]");
		Thread.Sleep(3000);//чтобы увидеть результат
	}
	static public void task2(){
		int[] array = BaseTools.CreateRandomArray(5,100,999);
		BaseTools.ShowArray(array);
		int num = 0;
		for (int i=0;i<array.Length;i++){
			if(array[i]%2==0){
				num++;
			}
		}
		Console.WriteLine("");
		Console.WriteLine($"Количество чётных элементов масива = {num} элементов.");
		Thread.Sleep(7000);
	}
	static public void task3(){
		ReturnT3:
		Console.Write("Введите количество элементов масива :");
		string S_num = Console.ReadLine();
		Console.Clear();
		int I_num;
		
		if(int.TryParse(S_num, out I_num)){//проверка на буквы
		
			if(I_num<1 || I_num>8){//вне диапозона -1 или 9
				Console.WriteLine($"${S_num} :должна быть в диопазоне [1..8]");
				goto ReturnT3;//второй шанс
			}
			
			else{// ВСЕ условия соблюдены
				int[] array = BaseTools.CreateRandomArray(I_num,0,9);
				BaseTools.ShowArray(array);
				
				I_num = 0;//перезапись
				for (int i =0; i<array.Length;i++){
					I_num=(I_num*10)+array[i];
				}
				Console.Write($" => [{I_num}]");
				Thread.Sleep(7000);
				return;
			}
			
		}
		else{//проверка на буквы ПРОВАЛ
			Console.WriteLine($"${S_num} :не является целым числом.");
			goto ReturnT3;//второй шанс
		}
	}
	static public void task4(){
		
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