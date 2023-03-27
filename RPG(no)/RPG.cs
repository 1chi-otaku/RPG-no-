using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_no_
{
    abstract class Hero
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int speed { get; set; }
        public int health { get; set; }
        public int defence { get; set; }

        public Hero(string name, int attack, int speed, int health, int defence)
        {
            this.name = name;
            this.attack = attack;
            this.speed = speed;
            this.health = health;
            this.defence = defence;
        }
        public Hero() { }
        public Hero(string name) { }
        public  override string ToString()
        {
            return "Name - " + name + "\nAttack - " + attack + "\nSpeed - " + speed + "\nHealth - " + health + "\nDefence - " + defence;
        }
    }

    class Human : Hero
    {
        public Human(string name, int attack, int speed, int health, int defence) : base(name, attack, speed, health, defence)
        {
        }
        public Human(string name):this()
        {
            this.name = name;
        }
        public Human()
        {
            name = string.Empty;
            attack = 20;
            speed = 20;
            health = 150;
            defence = 0;
        }

    }

    class Elf: Hero
    {
        public Elf(string name, int attack, int speed, int health, int defence) : base(name, attack, speed, health, defence)
        {
        }
        public Elf()
        {
            name = string.Empty;
            attack = 15;
            speed = 30;
            health = 100;
            defence = 0;
        }
    }

    abstract class HeroDecorator:Hero
    {
        protected Hero hero { get; set; }
        public HeroDecorator(string name, int attack, int speed, int health, int defence,Hero hero)
        {
            this.name = name;
            this.attack = attack;
            this.speed = speed;
            this.health = health;
            this.defence = defence;
        }
        }

    class Warrior : HeroDecorator
    {
        public Warrior(Hero hero):base((hero.name + " + Warrior"), hero.attack+20, hero.speed + 10, hero.health + 150, hero.defence, hero) { }
    }
    class SwordMan : HeroDecorator
    {
        public SwordMan(Hero hero) : base((hero.name + " + Sword Class"), hero.attack + 40, hero.speed - 10, hero.health + 50, hero.defence+40, hero) { }
    }

    class Archer : HeroDecorator
    {
        public Archer(Hero hero) : base((hero.name + " + Archer"), hero.attack + 20, hero.speed + 20, hero.health + 50, hero.defence + 10, hero) { }
    }

    class Rider : HeroDecorator
    {
        public Rider(Hero hero) : base((hero.name + " + Rider"), hero.attack - 20, hero.speed + 40, hero.health +200, hero.defence + 100, hero) { }
    }
    class Elf_Warrior : HeroDecorator
    {
        public Elf_Warrior(Hero hero) : base((hero.name + " + Elf Warrior"), hero.attack + 20, hero.speed - 10, hero.health + 100, hero.defence + 20, hero) { }
    }
    class Elf_Magician : HeroDecorator
    {
        public Elf_Magician(Hero hero) : base((hero.name + " + Elf Magician"), hero.attack + 10, hero.speed + 10, hero.health + 50, hero.defence + 10, hero) { }
    }
    class Crossbowman : HeroDecorator
    {
        public Crossbowman(Hero hero) : base((hero.name + " + Crossbowman"), hero.attack + 20, hero.speed + 10, hero.health + 50, hero.defence + 70, hero) { }
    }
    class Dark_Mag : HeroDecorator
    {
        public Dark_Mag(Hero hero) : base((hero.name + " + Dark Mag"), hero.attack + 50, hero.speed + 30, hero.health + 100, hero.defence + 30, hero) { }
    }
}

