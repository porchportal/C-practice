
using Collections;
using Testing;

public class testingNew{
    public static void Main(){
        // ArrayCollection x = new ArrayCollection(3);
        // x.add(1); 
        // x.add(2); 
        // x.add(3); 
        // x.add(4);
        // Console.WriteLine("size = "+ x.size());
        // x.remove(1);
        // Console.WriteLine("size = " + x.size());

        // Collection y = new LinkedHeaderCollection();
        // y.add(1); y.add(7);y.add(6);y.add(2);y.add(3);y.add(4);y.add(9);
        // y.remove(1);
        // y.remove(4);

        // Collection z = new ArraySet(3);
        // z.add(1);

        ImplementedCode x = new TestCase();
        x.add(10);
        x.add(20);
        x.add(30);
        x.remove(20);
        int result = x.get(1);
        Console.WriteLine("result = " + result);

        ImplementedCode y = new TestCase();
        y.add(5);
        y.add(15);
        y.add(25);
        y.remove(15);
        Console.WriteLine("result = " + y.get(1));

        ImplementedCode z = new TestCase();
        z.add(100);
        z.add(200);
        z.add(300);
        z.add(400);
        z.remove(200);
        z.remove(400);
        Console.WriteLine("result = " + z.count());

        ImplementedCode a = new TestCase();
        a.add(1);
        a.add(2);
        a.add(3);
        a.add(4);
        a.remove(5);
        Console.WriteLine("result = " + a.count());
    }
}