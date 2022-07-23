using ITFCodeWA.Core.Domain.Exceptions.Base;

namespace ITFCodeWA.Core.Domain.Exceptions
{
    public class EntityNotFoundException : RepositoryException
    {
        public EntityNotFoundException(object id, Type type) : base($"Entity '{type.Name}'(Id = {id}) not found") { }

        public EntityNotFoundException(object value, string paramName, Type type) : base($"Entity '{type.Name}'({paramName} = {value}) not found") { }

        public EntityNotFoundException(Type type) : base($"Entity '{type.Name}' not found for given condition") { }
    }
}