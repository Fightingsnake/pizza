using pizza;

KleinePizza kp  = new KleinePizza();
Console.WriteLine(kp.GetPrice());
Console.WriteLine(kp.Description());

MittlerePizza mp = new MittlerePizza();
Console.WriteLine(mp.GetPrice());
Console.WriteLine(mp.Description());

GrossePizza gp  = new GrossePizza();
Console.WriteLine(gp.GetPrice());
Console.WriteLine(gp.Description());

kp = new Thunfisch(kp);