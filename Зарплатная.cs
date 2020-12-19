using System;

namespace CCC
{
	class Зарплатная: Карта
	{
		public Зарплатная(string num, Платежные_системы type)
			:base(num, type)
		{
			Номер = num;
			Система = type;
		}
		
		public Зарплатная()
			:base()
		{
			Система = Платежные_системы.Visa;
		}
		
		public Платежные_системы Система;
		
		public override string Номер_пол
        {
			get { return base.Номер + "\n платежная система: " + Система.ToString();}
        } 
	}
}