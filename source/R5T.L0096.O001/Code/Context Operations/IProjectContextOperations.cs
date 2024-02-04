using System;
using System.Threading.Tasks;

using R5T.L0095.T000;
using R5T.L0096.T000;
using R5T.T0221;
using R5T.T0241;


namespace R5T.L0096.O001
{
    [ContextOperationsMarker]
    public partial interface IProjectContextOperations : IContextOperationsMarker
    {
        public Func<TContext, Task> Add_ProjectToSolution<TContext>(
            // Should return a check that the solution contains the project, but omit for now. TODO
            )
            where TContext : IHasProjectFilePath, IHasSolutionFilePath
        {
            return context =>
            {
                // Ignore project GUID output.
                Instances.SolutionFileOperator.AddProject(
                    context.SolutionFilePath,
                    context.ProjectFilePath);

                return Task.CompletedTask;
            };
        }

        public Func<TContext, Task> Set_ProjectDirectoryPath<TContext>(
            out IsSet<IHasProjectFilePath> propertiesSet)
            where TContext : IWithProjectDirectoryPath, IHasSolutionFilePath, IHasProjectName
        {
            return context =>
            {
                context.ProjectDirectoryPath = Instances.ProjectPathsOperator.Get_ProjectDirectoryPath_FromSolutionFilePath(
                    context.SolutionFilePath,
                    context.ProjectName);

                return Task.CompletedTask;
            };
        }
    }
}
