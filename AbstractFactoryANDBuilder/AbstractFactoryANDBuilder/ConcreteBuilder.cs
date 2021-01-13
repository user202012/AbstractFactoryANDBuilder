using System;

class ConcreteBuilder1 : Builder
{
    private readonly Product product = new Product();


    public override void BuildPartA()
    {
        product.XOR();
    }

    public override void BuildPartB()
    {
        product.HasherMD5();
    }

    public override Product GetResult()
    {
        return product;
    }
}


class ConcreteBuilder2 : Builder
{
    private readonly Product product = new Product();


    public override void BuildPartA()
    {
        product.XOR();
    }

    public override void BuildPartB()
    {
        product.HasherSHA256();
    }

    public override Product GetResult()
    {
        return product;
    }
}
