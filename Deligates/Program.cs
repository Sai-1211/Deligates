using Deligates;

Predefined_deligates obj3 = new Predefined_deligates();
obj3.Func_Deligate();
Console.ReadKey();

obj3.Action_deligate();
Console.ReadKey();

obj3.Predicate_Deligate();
Console.ReadKey();

MultiCast_deligates obj1 = new MultiCast_deligates();
obj1.MultiCast();
Console.ReadKey();

AnonymousClass obj = new AnonymousClass();
obj.SingleCast_Delegate();