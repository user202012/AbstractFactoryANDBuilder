using System;


public class Client
{
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;


    public Client(AbstractFactory factory)
    {
        _abstractProductB = factory.CreateProductB();
        _abstractProductA = factory.CreateProductA();
    }

    public void Run(string input)
    {
        _abstractProductB.Hasher(input);
        _abstractProductA.Hasher(input);
    }
}