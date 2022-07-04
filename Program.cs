using System;

class simulacionjonathan
{

	static void Main(string[] args)
	{
		string am;
		int horas;
		int min;
		string pm;
		int seg;
		Console.Write(" Ingrese la cantidad de horas ");
		horas = int.Parse(Console.ReadLine());
		Console.Write(" Ingrese la cantidad de minutos ");
		min = int.Parse(Console.ReadLine());
		Console.Write(" Ingrese la cantidad de segundos ");
		seg = int.Parse(Console.ReadLine());
		Console.Write("Formato 24hs ");
		if (horas < 12)
		{
			Console.WriteLine(horas + ":" + min + ":" + seg + "am");
		}
		else
		{
			Console.WriteLine(horas + ":" + min + ":" + seg + "pm");
		}
	}

}




