using System;

namespace TEST02
{
    interface Repairable
    { }

    public class Unit
    {
        public int MAX_HP; //최대체력
        public int hitPoint;

        public Unit()
        {

        }
    }

    class GroundUnit : Unit
    {
        public GroundUnit(int hp)
        {
            this.MAX_HP = hp;
        }
    }
    class AirUnit : Unit
    {
        public AirUnit(int hp)
        {
            this.MAX_HP = hp;
        }
    }
    class Marine : GroundUnit
    {
        public Marine(int hp) : base(hp)
        {
            MAX_HP = 40;
            hitPoint = MAX_HP;
        }
    }

    class SCV : GroundUnit, Repairable
    {
        public SCV(int hp) : base(hp)
        {
            MAX_HP = 60;
            hitPoint = MAX_HP;
        }

        public void repair(Repairable r)
        {
            if (r is Unit) 
        {
                Unit u = (Unit)r;
                while (u.hitPoint != u.MAX_HP)
                {
                    /* Unit의 HP를 증가 */
                    u.hitPoint++;
                }
                Console.WriteLine(u.GetType().Name + "의 수리가 끝났습니다.");
            }
            else if (r is Marine)
            {
                Console.WriteLine("수리할 수 없는 Unit 입니다.");
            }
        }
    }
    class Tank : GroundUnit, Repairable
    {
        public Tank(int hp) : base(hp)
        {
            MAX_HP = 150;
            hitPoint = MAX_HP;
        }
    }
    class DropShip : AirUnit, Repairable
    {
        public DropShip(int hp) : base(hp)
        {
            MAX_HP = 125;
            hitPoint = MAX_HP;
        }
    }
    
    class RepairableTest
    {
        public static void Main(string[] args)
        {
            Tank t = new Tank(150);
            DropShip d = new DropShip(125);

            Marine m = new Marine(40);
            SCV s = new SCV(60);
           
            s.repair(t);       // SCV가 Tank를 수리하도록 한다. 
            s.repair(d);
            //s.repair(m);     //에러발생 : repair(Repairable) in SCV cannot be applied to (Marine) 
        }
    }
}
