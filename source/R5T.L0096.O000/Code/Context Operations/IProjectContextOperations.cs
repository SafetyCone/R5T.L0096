using System;
using System.Threading.Tasks;

using R5T.T0221;
using R5T.T0241;

using R5T.L0096.T000;


namespace R5T.L0096.O000
{
    [ContextOperationsMarker]
    public partial interface IProjectContextOperations : IContextOperationsMarker
    {
        public Func<TContext, Task> Set_NamespaceName<TContext>(
            out IsSet<IHasNamespaceName> namespaceNameSet)
            where TContext : IWithNamespaceName, IHasProjectName
        {
            return context =>
            {
                context.NamespaceName = Instances.ProjectNamespacesOperator.Get_DefaultNamespaceName_FromProjectName(
                    context.ProjectName);

                return Task.CompletedTask;
            };
        }

        public Func<TContext, Task> Set_ProjectFilePath<TContext>(
            out IsSet<IHasProjectFilePath> propertiesSet)
            where TContext : IWithProjectFilePath, IHasProjectDirectoryPath, IHasProjectName
        {
            return context =>
            {
                context.ProjectFilePath = Instances.ProjectPathsOperator.Get_ProjectFilePath(
                    context.ProjectDirectoryPath,
                    context.ProjectName);

                return Task.CompletedTask;
            };
        }
    }
}
