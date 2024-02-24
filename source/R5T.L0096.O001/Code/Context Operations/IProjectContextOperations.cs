using System;
using System.Threading.Tasks;

using R5T.L0091.T000;
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
            (IsSet<IHasProjectFilePath>, IsSet<IHasSolutionFilePath>) propertiesRequired,
            out IChecked<ISolutionHasProject> solutionHasProjectChecked)
            where TContext : IHasProjectFilePath, IHasSolutionFilePath
        {
            solutionHasProjectChecked = Checked.Check<ISolutionHasProject>();

            return context =>
            {
                // Ignore project GUID output.
                Instances.SolutionFileOperator.AddProject(
                    context.SolutionFilePath,
                    context.ProjectFilePath);

                return Task.CompletedTask;
            };
        }

        public Func<TContext, Task> Add_ProjectToSolution<TContext>(
            out IChecked<ISolutionHasProject> solutionHasProjectChecked)
            where TContext : IHasProjectFilePath, IHasSolutionFilePath
        {
            solutionHasProjectChecked = Checked.Check<ISolutionHasProject>();

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

        public Func<TContext, Task> Set_ProjectDirectoryPath<TContext>(
            (IsSet<IHasSolutionFilePath>, IsSet<IHasProjectName>) propertiesRequired,
            out IsSet<IHasProjectDirectoryPath> projectDirectoryPathSet)
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

        public Func<TProjectContext, TSolutionContext, Task> Set_ProjectDirectoryPath<TProjectContext, TSolutionContext>(
            IsSet<IHasProjectName> projectName_ProjectContextPropertiesRequired,
            IsSet<IHasSolutionDirectoryPath> solutionDirectoryPath_SolutionContextPropertiesRequired,
            out IsSet<IHasProjectDirectoryPath> projectDirectoryPathSet)
            where TProjectContext : IWithProjectDirectoryPath, IHasProjectName
            where TSolutionContext : IHasSolutionDirectoryPath
        {
            return (projectContext, solutionContext) =>
            {
                projectContext.ProjectDirectoryPath = Instances.ProjectPathsOperator.Get_ProjectDirectoryPath_FromSolutionDirectoryPath(
                    solutionContext.SolutionDirectoryPath,
                    projectContext.ProjectName);

                return Task.CompletedTask;
            };
        }
    }
}
