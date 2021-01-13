using System;

abstract class Builder
{
    public virtual void BuildPartA() { }
    public virtual void BuildPartB() { }
    public abstract Product GetResult();
}
