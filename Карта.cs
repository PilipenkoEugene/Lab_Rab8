using System;

namespace CCC
{
    class Карта
    {
    	public string Номер;
        public Платежные_системы Тип;
        public Карта()
        {
        	Номер = "9999 9999 9999 9999";
        	Тип = Платежные_системы.Non;
        }
        
        public Карта(string num, Платежные_системы type)
        {
        	Номер = num;
        	Тип = type;
        }

        
        
        public virtual string Номер_пол
        {
        	get { return Номер + " " + Тип;}
        }       
    }
}
