using ITFCodeWA.Core.Domain.Exceptions.Base;
using System.Text;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    /// <summary>
    /// Class Exception to handle an exception when entities have been not found by IDs
    /// </summary>
    public class EntitiesNotFoundException : RepositoryException
    {
        public EntitiesNotFoundException(IEnumerable<object> ids, Type type) : base(GetMessage(ids, type)) { }

        /// <summary>
        /// Helper method to create an exception message
        /// </summary>
        /// <param name="ids">sequence of IDs</param>
        /// <param name="type">Entity type</param>
        /// <returns>an exception message</returns>
        private static string GetMessage(IEnumerable<object> ids, Type type)
        {
            var sb = new StringBuilder();

            foreach (var id in ids)
                sb.AppendLine($"Entity '{type.Name}'(Id in {id}) not found");

            return sb.ToString();
        }

    }
}