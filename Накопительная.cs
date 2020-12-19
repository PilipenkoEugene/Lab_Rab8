using System;

namespace CCC
{
	class Накопительная: Карта
	{
		public Накопительная()
			:base()
		{
			Система = Платежные_системы.Visa;
		}
		
		public Накопительная(string num, Платежные_системы type)
			:base(num, type)
		{
			Номер = num;
			Система = type;
		}
		
		public Платежные_системы Система;
		
		public override string Номер_пол
        {
			get { return base.Номер + "\n платежная система: " + Система.ToString();}
        } 
	}
}
