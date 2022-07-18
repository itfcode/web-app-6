using System.Reflection;

namespace ITFCodeWA.BasisTests
{
    public abstract class BasisUnitTests
    {
        /// <summary>
        /// Gets Defined Types from Assemly 
        /// </summary>
        /// <param name="type">any type of needd assembly</param>
        /// <param name="namespace"> filter value for namespace</param>
        /// <returns>list of classes </returns>
        protected static IReadOnlyList<Type> GetAssemlyClasses(Type type, string @namespace)
            => type.Assembly.DefinedTypes
                .Where(x => x.Namespace!.StartsWith("ITFCodeWA.Models"))
                .Where(x => x.IsClass)
                .ToList();

        /// <summary>
        /// Gets public properties 
        /// </summary>
        /// <param name="type">type</param>
        /// <returns>list of properties</returns>
        protected static IReadOnlyList<PropertyInfo> GetPublicProperties(Type type)
            => type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(x => x.CanWrite && x.CanRead)
                .ToList();
    }
}