namespace EnumsTest
{
    using System;
    using System.Linq.Expressions;

    public class DelegateHelper
    {
        public static Expression<Func<TClass, TReturn>> GetPropertyAccessor<TClass, TReturn>(string propertyName)
        {
            ParameterExpression param =
            Expression.Parameter(typeof(TClass), "arg");

            MemberExpression member =
            Expression.Property(param, propertyName);

            LambdaExpression lambda =
                Expression.Lambda(typeof(Func<TClass, TReturn>), member, param);

            return (Expression<Func<TClass, TReturn>>)lambda;
        }
    }
}
