class Program {
    static void Main(string[] args) {
        classA objA = new classA(3);
        classB objB = new classB(4);
        classC objC = new classC(5);
       
        Console.WriteLine(objB.age);


        Console.WriteLine(objA.PrintOut()); //classA PrintOut method called
        Console.WriteLine(objB.PrintOut());
        Console.WriteLine(objC.PrintOut());
    }
}


class classA { //PARENT
    public int age;
    public classA(int num)
    {
        Console.WriteLine("classA constructor called, num :" + num);
        age = num;
    }


    public virtual string PrintOut ()  {
        return ("classA PrintOut method called");
    }


}


class classB : classA //CHILD : PARENT
{
    public classB(int num):base(num)
    {
        Console.WriteLine("classB constructor called, num :" + num);
    }
    //Error because parent class does not have a default constructor
    /* public classB() {
        Console.WriteLine("classB constructor called without passing argument");
    } */
}


class classC : classA  //CHILD : PARENT
{
    public classC(int num):base(num)
    {
        Console.WriteLine("classC constructor called, num :" + num);
    }


    public override string PrintOut ()  {
        return ("classC PrintOut method called");
    }
}
