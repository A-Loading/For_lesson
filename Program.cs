using System;
class lesson2_home
{ 
	static void Main()
		{
/*//задача 1
			int num = 161;// принимаемое число
			Console.WriteLine($"-{num}-");//debag
			if ((num%7 == 0)&&(num%23 ==0))
				{Console.WriteLine("Да");}
			else
				{Console.WriteLine("Нет");}
*/ //------------------------------------|
/* //задача 2			
			int x = 2;// принимаемое число x
			int y = 1;// принимаемое число y
			Console.WriteLine($"x-{x}-y-{y}-");//debag
			if ((x==0)||(y==0)){
			Console.WriteLine("Err X|Y == 0");
			return;
			}
			string s;
			if(x>0){
				if(y>0){s="1";}
				else{s="4";}
			}
			else{
				if(y>0){s="2";}
				else{s="3";}
			}
			Console.WriteLine(s);
		
*/ //------------------------------------|
/* //задача 3
			int num = 55;// принимаемое число
			Console.WriteLine($"-{num}-");//debag
			if ((num<10)||(num>99)){
			Console.WriteLine("Err ≠[10..99] ");
			return;
			}
			int max = num%10;
			num /= 10;
			if (max<num)
				{max=num;}
			Console.WriteLine($"{max}");
*/ //------------------------------------|	
//задача 4	
			int num =-987654321;// принимаемое число
			Console.WriteLine($"-{num}-");//debag
			num=Math.Abs(num);
			string s =$"{num%10}";
			do{
				num /=10;
				s = $"{num%10},{s}";
			}while((num/10) > 0);
			Console.WriteLine(s);
//------------------------------------|	
		}
}