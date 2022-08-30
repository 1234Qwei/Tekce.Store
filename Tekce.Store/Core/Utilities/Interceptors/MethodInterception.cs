using Castle.DynamicProxy;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
                var result = invocation.ReturnValue as Task;
                result?.Wait();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }

            OnAfter(invocation);
        }

        protected virtual void OnBefore(IInvocation invocation)
        {
            if (!invocation.Method.Name.ToLower().Contains("create")) { return; }
            var parameters = invocation.Method.GetParameters();
            var createdBy = parameters.FirstOrDefault(x => x.Name == "CreatedBy");
            if (createdBy is null) { return; }
            parameters.SetValue(Guid.NewGuid(), createdBy.Position);

        }

        protected virtual void OnAfter(IInvocation invocation)
        {
        }

        protected virtual void OnException(IInvocation invocation, Exception e)
        {
        }

        protected virtual void OnSuccess(IInvocation invocation)
        {
        }
    }
}