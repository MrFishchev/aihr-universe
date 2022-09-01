namespace Aihr_MilkyWay.Utils;

public static class AssemblyHelper 
{
    /// <summary>
    /// Finds instances of selected type in Assembly, creates them and casts to provided type T
    /// </summary>
    /// <param name="instanceType">Type of instances that you will find in Assembly</param>
    /// <typeparam name="T">Outgoing type to case created object</typeparam>
    /// <returns></returns>
    public static IEnumerable<T> InstantiateTypesInSameNamespaceAs<T>(Type instanceType)
    {
        static IEnumerable<Type> FindTypesInSameNamespaceAs(string? instanceNamespace, Type instancetype)
        {
            var results = instancetype.Assembly
                .GetTypes()
                .Where(tt => tt.Namespace == instanceNamespace);
            return results;
        }
        
        return FindTypesInSameNamespaceAs(instanceType.Namespace, instanceType)
            .Where(t => t.IsSubclassOf(typeof(T)))
            .Select(t => (T)Activator.CreateInstance(t)!);
    }
}