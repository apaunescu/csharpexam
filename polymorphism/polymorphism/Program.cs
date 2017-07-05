using System;
using System.Collections.Generic;

namespace polymorphism
{

    interface hero
    {
        int strength();
        int agility();
        int intelligence();
        int kills();
        void newKill();

        string name
        {
            get;
        }
    }

    abstract class dotahero
    {
        private int _kills;
        private string _name;
        protected dotahero(string name)
        {
            _kills = 0;
            _name = name;
        }
        public int kills()
        {
            return _kills;
        }

        public void newKill()
        {
            _kills++;
        }

        public string name
        {
            get 
            {
                return _name;
            }
        }
    }

    class pudge : dotahero, hero
    {
        int fleshHeap = 1;
        public pudge() : base("butcher")
        {
            
        }
        public int strength()
        {
            return 10 + fleshHeap;
        }

		public int agility()
		{
			return 5;
		}

		public int intelligence()
		{
			return 1;
		}
    }

	class lina : dotahero, hero
	{
        public lina() : base("lina")
        {
            
        }

		public int strength()
		{
            return 3;
		}

		public int agility()
		{
            return 8;
		}

		public int intelligence()
		{
            return 12;
		}
	}


    class MainClass
    {
        public static void Main(string[] args)
        {
            List<hero> pool = new List<hero>();

            hero pudge = new pudge();
            hero lina = new lina();
            pudge.newKill();
            pudge.newKill();
            pool.Add(pudge);
            pool.Add(lina);
            pudge.newKill();
            pudge.newKill();

            foreach(var hero in pool)
            {
                Console.WriteLine(hero.name);
				Console.WriteLine(hero.kills());
            }

        }
    }
}
