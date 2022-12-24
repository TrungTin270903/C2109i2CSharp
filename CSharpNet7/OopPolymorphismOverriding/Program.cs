using OopPolymorphismOverriding;

Parent pa = new();
pa.Show();
pa.Display();   

Child1 c1 = new ();   
c1.Show();
c1.Display();   
//khoi tao doi tuong cua cha va goi pt cua con 
Parent p= new Child1();
p.Show();//show của cha chứ ko phải CỦA con
p.Display();
