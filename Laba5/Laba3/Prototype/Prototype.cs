namespace Laba2.Prototype
{
    public abstract class Prototype
    {
        public Prototype(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

        public abstract Prototype Clone();
    }

    internal class ConcretePrototype : Prototype
    {
        public ConcretePrototype(int id, string name) : base(id)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public override Prototype Clone()
        {
            return new ConcretePrototype(Id, Name);
        }
    }
}