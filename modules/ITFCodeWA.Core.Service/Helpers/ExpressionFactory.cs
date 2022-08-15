using System.Linq.Expressions;

namespace ITFCodeWA.Core.Services.Helpers
{
    /// <summary>
    /// Expression Factory
    /// </summary>
    public static class ExpressionFactory
    {
        #region Public Methods 

        public static Expression<Func<T, bool>> Or<T>(Expression<Func<T, bool>> leftExp, Expression<Func<T, bool>> rightExp)
            => Combine(leftExp, rightExp, Expression.Or);

        public static Expression<Func<T, bool>> And<T>(Expression<Func<T, bool>> leftExp, Expression<Func<T, bool>> rightExp)
            => Combine(leftExp, rightExp, Expression.And);

        #endregion

        #region Private Methods 

        private static Expression<Func<T, bool>> Combine<T>(Expression<Func<T, bool>> leftExp, Expression<Func<T, bool>> rightExp,
            Func<Expression, Expression, BinaryExpression> combiner)
        {
            ArgumentValidator.ValidateNull((leftExp, nameof(leftExp)), (rightExp, nameof(rightExp)));

            var visitor = new ParameterUpdateVisitor(rightExp.Parameters.First(), leftExp.Parameters.First());
            rightExp = visitor.Visit(rightExp) as Expression<Func<T, bool>>;

            var binExp = combiner(leftExp.Body, rightExp.Body);
            return Expression.Lambda<Func<T, bool>>(binExp, rightExp.Parameters);
        }

        #endregion

        /// <summary>
        /// Additional helper class 
        /// </summary>
        private class ParameterUpdateVisitor : ExpressionVisitor
        {
            #region Private Fields 

            private readonly ParameterExpression _oldParameter;
            private readonly ParameterExpression _newParameter;

            #endregion

            #region Constructors 

            public ParameterUpdateVisitor(ParameterExpression oldParameter, ParameterExpression newParameter)
            {
                _oldParameter = oldParameter;
                _newParameter = newParameter;
            }

            #endregion

            #region Protected Override Methods 

            protected override Expression VisitParameter(ParameterExpression node)
            {
                return ReferenceEquals(node, _oldParameter) ? _newParameter : base.VisitParameter(node);
            }

            #endregion
        }
    }
}