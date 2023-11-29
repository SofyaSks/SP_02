using System.Reflection;
using static System.Console;

//Type type = typeof(string);

/*WriteLine(type);

MethodInfo[] methodInfos = type.GetMethods();

foreach (MethodInfo item in methodInfos)
{
    WriteLine(item);
}*/


//WriteLine("***************************************");

/*FieldInfo[] infoFill = type.GetFields();*/

/*FieldInfo[] infoFill = type.GetFields(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static);

foreach (FieldInfo field in infoFill)
    //WriteLine(field);

    if (field.Name == "_firstChar")
    {
        string hello = "Hello";
        field.SetValue(hello, 'h');
        char c = (char)field.GetValue("Hello");
        WriteLine(c);
    }*/


/*Assembly assembly = Assembly.LoadFrom("reflection.dll");
Module module = assembly.GetModule("reflection.dll");

foreach (Type type in module.GetTypes())
{
    WriteLine(type);
}*/
