using System;

namespace Laba2.Prototype
{
    public abstract class Prototype 
    {
        public int Id { get; private set; }

        public Prototype(int id)
        {
            Id = id;
        }

        public abstract Prototype Clone();
    }

    class ConcretePrototype:Prototype
    {
        public string Name { get; private set; }

        public ConcretePrototype(int id,string name):base(id)
        {
            Name = name;
        }
        public override Prototype Clone()
        {
            return new ConcretePrototype(Id, Name);
        }
    }
    
    
}