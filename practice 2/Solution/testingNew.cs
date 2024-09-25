
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

        AdvancedStack x = new TestCase();
        x.push(10);
        x.push(20);
        x.push(5);
        x.push(30);
        Console.WriteLine("Max = " + x.getMax());
        Console.WriteLine("Min = " + x.getMin());

        AdvancedStack y = new TestCase();
        y.push(50);
        y.push(100);
        y.push(40);
        y.pop(); y.pop();
        Console.WriteLine("top = " + y.peek());

        AdvancedStack z = new TestCase();
        z.push(15);
        z.push(35);
        z.pop();
        z.push(5);
        z.push(25);
        Console.WriteLine("Max = " + z.getMax());
        Console.WriteLine("Min = " + z.getMin());

        AdvancedStack a = new TestCase();
        a.push(100);
        a.push(100);
        a.pop();
        a.pop();
        Console.WriteLine("result = " + a.getMax());
    }
}