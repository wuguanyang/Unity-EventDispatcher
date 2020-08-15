/*
CreateBy:     wgy
CreateTime:   2020/08/13 15:53:06
Description:  单例模板
*/

using System;
using System.Reflection;

public abstract class Singleton<T> where T : class {

    protected static T instance;
    public static T Instance {
        get {
            if (instance == null) {
                // 先获取所有非public的构造方法
                ConstructorInfo[] ctors = typeof(T).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
                // 从ctors中获取无参的构造方法
                ConstructorInfo ctor = Array.Find(ctors, c => c.GetParameters().Length == 0);
                if (ctor == null)
                    throw new Exception("Non-public ctor() not found!");
                // 调用构造方法
                instance = ctor.Invoke(null) as T;
            }
            return instance;
        }
    }
    protected Singleton() {

    }
}
/*
 如果代码块只有一句就可以使用=>
 * c => c.GetParameters().Length == 0
 * T是委托/匿名函数/lamda的值类型,相当于
 * Foo(T c)
 * {
 *  return c.GetParameters().Length == 0
 * }
 
 */

   
