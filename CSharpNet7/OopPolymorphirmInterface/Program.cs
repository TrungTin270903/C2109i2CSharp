
using OopPolymorphirmInterface;

SomeFile some=new SomeFile();
some.ReadFile();
some.WriteTextFile();
some.WriteBinaryFile(); 
//chỉ duy nhất ngôn ngữ c#
((IBinaryFile)some).ShowInfo();
//da ngon ngu 
(some as IBinaryFile).ShowInfo();
//=======
ManyFile many=new ManyFile();
many.WriteBinaryFile();
(many as IBinaryFile).ReadFile();
(many as IBinaryFile).ShowInfo();

many.WriteTextFile();
(many as ITextFile).ReadFile();

//=======
IBinaryFile bf =new SomeFile(); 
bf.ShowInfo();
bf.ReadFile();
bf.WriteBinaryFile();

bf=new ManyFile();
bf.ShowInfo();
bf.ReadFile();
bf.WriteBinaryFile();
